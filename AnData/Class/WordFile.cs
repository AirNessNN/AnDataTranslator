using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using NPOI.XWPF.UserModel;
using NPOI.OpenXmlFormats.Spreadsheet;
using System.Diagnostics;
using System.Collections;
using Spire.Doc;

namespace AnData.Class {

	/// <summary>
	/// Word文档操作类，实现Word读取，内容提取
	/// </summary>
	public class WordFile : DataFile {
		#region 常量

		#endregion


		#region 属性


		#endregion



		#region 成员变量
		/// <summary>
		/// 对应的文件流
		/// </summary>
		private FileStream fs = null;

		/// <summary>
		/// 文档实例
		/// </summary>
		private XWPFDocument document = null;


		private List<XWPFRun> list = null;
		#endregion







		/// <summary>
		/// 获取所有文本元素
		/// </summary>
		/// <returns></returns>
		public List<XWPFRun> GetAllRunText () {
			if (!Loaded)
				return null;
			return list;
		}

		/// <summary>
		/// 返回该文档内所有标记元素
		/// </summary>
		/// <param name="mark"></param>
		/// <returns></returns>
		public List<XWPFRun> GetRunText(string mark ) {

			List<XWPFRun> tmp = new List<XWPFRun>( );

			if (list == null)
				return null;

			foreach(var run in list) {
				string text = run.ToString( );
				Debug.WriteLine("获取到的Run文本：" + run.ToString( ) + " 是否包含Mark：" + (text.Contains(mark)));
				if (text.Contains(mark)) 
					tmp.Add(run);
			}

			return tmp;
		}

		/// <summary>
		/// 替换本工作表中所有Mark 
		/// </summary>
		/// <param name="mark">标记</param>
		/// <param name="values">要替换的数据</param>
		/// <returns></returns>
		public int ReplaceMark(string mark ,Queue<object> values) {
			if (!Loaded)
				return 0;

			int count = 0;//替换的数量

			List<XWPFRun> tmpArr = GetRunText(mark);//获取标记元素数组 
			Debug.WriteLine("找到的标记数量：" + tmpArr.Count);

			if (tmpArr == null)
				return 0;

			/*
			 * 传进去的values数量大于标记数量,，
			 * 代表还有数据没有填充进去，
			 * 只能留给用户进行确认后的操作。
			 * 
			 * 而当标记数量多于数值数量时则可以继续，
			 * 因为所有数值可以得到填充。
			 */
			if (values.Count > tmpArr.Count)
				return 0;

			int listIndex = 0;//Run文本下标
			//替换数值
			while (true) {
				if (listIndex > tmpArr.Count - 1)
					break;
				string run = tmpArr[listIndex].ToString( );//run文本
				try {
					//循环替换字符串
					for (int i = 0; i < Util.GetMarkCount(run, Program.Mark); i++) {
						run = Util.ReplaceString(run, (string)values.Dequeue( ), Program.Mark);
						count++;
					}
					tmpArr[listIndex++].SetText(run);
				} catch {
					break;
				}
			}
			return count;
		}






		/// <summary>
		/// 打开一个Word文档
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public override bool ReadFile ( string path ) {
			if (path == "")
				return false;
			if (!File.Exists(path))
				return false;

			//判断文档类型
			if (path.IndexOf(".docx") < 1)
				return false;

			try {
				fs = new FileStream(path, FileMode.Open, FileAccess.Read);
				FilePath = path;

				document = new XWPFDocument(fs);

				list = new List<XWPFRun>( );

				if (document == null)
					return false;

				//提取run文本
				foreach(var para in document.Paragraphs) {
					string text = para.ParagraphText;

					var runs = para.Runs;

					for (int i = 0; i < runs.Count; i++) {
						var run = runs[i];
						text = run.ToString( );
						list.Add(run);
						Debug.Write(text + ",");
					}
					Debug.WriteLine("");
				}
			} catch(Exception ex) {
				Debug.WriteLine(ex.ToString( ));
				fs = null;
				return false;
			}

			//加载完成
			Close( );
			IsLoaded = true;
			return true;
		}

		/// <summary>
		/// 将内存中的Document写入内存，直接覆盖原文件
		/// </summary>
		/// <returns></returns>
		public override bool WriteFile () {
			return WriteFile(FilePath);
		}

		/// <summary>
		/// 将内存中的Document写入内存
		/// </summary>
		/// <param name="path">写入目标路径</param>
		/// <returns></returns>
		public override bool WriteFile ( string path ) {
			if (path == null)
				return false;
			if (fs != null)
				fs.Close( );

			try {
				MemoryStream ms = new MemoryStream( );//内存Steam
				fs = new FileStream(path, FileMode.Create, FileAccess.Write);//FileSteam写入模式
				document.Write(ms);//写入内存流
				ms.Flush( );//刷新缓冲
				byte[] data = ms.ToArray( );//将流转为字节码
				fs.Write(data, 0, data.Length);//写入文件
				fs.Flush( );//刷新缓冲
				Close( );//关闭
			}catch(Exception ex) {
				fs = null;
				Debug.WriteLine(ex.ToString( ));
				return false;
			}
			return true;
		}

		/// <summary>
		/// 关闭并释放Steam
		/// </summary>
		public override void Close () {
			if (!Loaded)
				return;
			if (fs == null)
				return;

			fs.Close( );
		}
	}
}
