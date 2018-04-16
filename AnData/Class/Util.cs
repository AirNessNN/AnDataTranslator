using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AnData.Class {
	/// <summary>
	/// 该程序的工具类
	/// </summary>
	class Util {

		/// <summary>
		/// DataTab转换成Queue列队
		/// </summary>
		/// <returns></returns>
		public static List<QueueData> DataTableToQueueData (DataTable dataTable) {
			if (dataTable == null)
				return null;

			List<QueueData> tmpList = new List<QueueData>( );
			//外层循环列
			for(int i = 0; i < dataTable.Rows.Count; i++) {
				QueueData qd = new QueueData( );
				bool nullFlag = true;
				//内层循环行
				for(int j = 0; j < dataTable.Columns.Count; j++) {
					string str= dataTable.Rows[i][j].ToString( );//数值
					qd.Pull(str);//先添加
					if (str != "")//判空，如果一行中有一条数据不是空的，那整行就应该添加到List中
						nullFlag = false;
				}
				if (nullFlag)//是否舍弃
					continue;
				tmpList.Add(qd);
			}
			return tmpList;
		}


		/// <summary>
		/// 设置QueueData的名字
		/// </summary>
		/// <param name="index"></param>
		public static List<QueueData> SetQueueDatasNameFrom (int index,List<QueueData> datas) {
			if (datas == null)
				return null;

			foreach (QueueData qd in datas) {
				qd.Name = (string)qd.Get(index);
			}
			return datas;
		}

		/// <summary>
		/// 替换掉源字符串中第一个标记，
		/// 如果未找到则返回源字符串
		/// </summary>
		/// <param name="origin">源字符串</param>
		/// <param name="value">替换的内容</param>
		/// <param name="mark">标记</param>
		/// <returns></returns>
		public static string ReplaceString(string origin,string value,string mark ) {

			int index = origin.IndexOf(mark);//第一个标记的位置
			if (index < 0)
				return origin;

			char[] c1 = origin.ToCharArray(0, index);//标志之前的字符串
			char[] c2 = null;//标志之后的字符串

			if(!((mark.Length+index)==origin.Length))
				c2 = origin.ToCharArray(index + mark.Length, origin.Length-index-mark.Length);

			string s1 = new String(c1);
			string s2 = value;
			if (c2 == null)
				return s1 + s2;
			return s1 + s2 +new String(c2);
		}

		/// <summary>
		/// 查找给定字符串的标记，并返回在字符串中出现的次数
		/// </summary>
		/// <param name="origin">源字符串</param>
		/// <param name="mark">标记</param>
		/// <returns></returns>
		public static int GetMarkCount(string origin,string mark ) {
			if (origin == "")
				return 0;
			if (mark == "")
				return 0;

			char[] c1 = origin.ToCharArray( );//原始字符串
			char[] c2 = mark.ToCharArray( );
			int count = 0;//mark数量
			int c2Index = 0;//C2下标

			for (int i = 0; i < c1.Length; i++) {
				if (c1[i] == c2[c2Index]) {
					c2Index++;
					if (c2Index > c2.Length - 1) {
						count++;
						c2Index = 0;
					}
				} else {
					c2Index = 0;
				}
			}
			return count;
		}

	}
}
