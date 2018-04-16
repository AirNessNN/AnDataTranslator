using AnData.Interface;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace AnData.Class {
	/// <summary>
	/// Excel转Word任务类
	/// </summary>
	class ExcelToWordTask {

		#region 字段
		private bool isLoaded = false;

		private int fileNameValueIndex = -1;

		public delegate void TaskListener ( int index, int count, int failCount );

		/// <summary>
		/// 监听器
		/// </summary>
		public TaskListener Listener;
		

		#endregion


		#region 属性

		/// <summary>
		/// 获取或设置目标文件夹
		/// </summary>
		public string TargetPath { get; set; }

		/// <summary>
		/// 获取或设置模板路径
		/// </summary>
		public string ModelPath { get; set; }

		/// <summary>
		/// 获取或设置元数据
		/// </summary>
		public List<QueueData> SourceData { get; set; }

		/// <summary>
		/// 获取任务加载状态
		/// </summary>
		public bool Loaded {
			get {
				return isLoaded;
			}
		}

		/// <summary>
		/// 获取任务是否运行
		/// </summary>
		public bool TaskRunning { get; private set; }
		#endregion


		#region 构造
		/// <summary>
		/// 构造一个空任务
		/// </summary>
		public ExcelToWordTask () {
		}

		/// <summary>
		/// 实例一个传人目标路径和数据源的任务
		/// </summary>
		/// <param name="targetPath">目标路径：必须是文件夹路径</param>
		/// <param name="modelPath">模板路径：必须是文件路径</param>
		/// <param name="grid">数据源</param>
		public ExcelToWordTask(string targetPath, string modelPath,List<QueueData> data ) {

			if (!Directory.Exists(targetPath))
				return;

			if (!File.Exists(modelPath))
				return;

			if (data == null)
				return;

			//设置
			ModelPath = modelPath;
			TargetPath = targetPath;
			SourceData = data;
			//完成加载
			isLoaded = true;
		}
		#endregion


		///<summary>
		///ExcelToWordTask还没测试
		///
		/// Util类一些转换方法没写完
		/// 名字的Word名字根据数据值填充还没写，应该要写Util的操作方法
		/// DataTable转换成List<QueueData>
		/// 读取DataGrid
		/// 重建DataGrid中的DataTable
		/// 写一个DataGrid的操作类窗口，封装对DataGrid中数据的筛选和重建
		/// </summary>




		#region 方法
		/// <summary>
		/// 设置一列数据为输出名称
		/// </summary>
		/// <param name="index">列的索引号：下标从0开始</param>
		public void SetFileNameAtColumn(int index ) {
			fileNameValueIndex = index;
		}

		/// <summary>
		/// 重置
		/// </summary>
		public void Dispose () {
			SourceData = null;
			isLoaded = false;
			TargetPath = "";
			ModelPath = "";
			fileNameValueIndex = -1;
		}

		
		/// <summary>
		/// 异步启动线程
		/// </summary>
		public void Start () {
			if (!Directory.Exists(TargetPath))
				throw new Exception("目标路径不明确！");

			if (!File.Exists(ModelPath))
				throw new Exception("模板未找到");

			if (SourceData == null)
				throw new Exception("没有元数据");

			if (TaskRunning)
				return;

			TaskRunning = true;
			//启动线程
			new Thread(() => {
				var failCount = 0;

				foreach (var queue in SourceData) {
					
					
					WordFile word = new WordFile( );
					Debug.WriteLine("建立WordFile");

					bool flag = word.ReadFile(ModelPath); //判断是否读取失败
					int num = 0;
					//替换
					if (flag) 
						num=word.ReplaceMark("%m", queue.GetQueue());
					
					//写入文件
					bool writeFlag= word.WriteFile(@TargetPath + "/" + queue.Name + ".docx");
					if (!writeFlag || !flag || num == 0) 
						failCount++;

					//通知监听器
					Debug.WriteLine("Debug：位置" +( SourceData.IndexOf(queue)+1) + " 全部数量：" + SourceData.Count + " 失败个数：" + failCount);
					Listener(SourceData.IndexOf(queue) + 1, SourceData.Count, failCount);
				}

				//任务结束
				TaskRunning = false;
			}).Start( );


		}



		/// <summary>
		/// 停止任务
		/// </summary>
		public void Stop () {
			throw new NotImplementedException( );
		}



		
		#endregion
	}
}
