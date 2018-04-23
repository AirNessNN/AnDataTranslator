using AnData.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AnData {
	static class Program {

		public static string Mark { get; set; }
		public static string XLSX = "EXCEL 2007以上 文件(*.xlsx)|*.xlsx";
		public static string XLS = "EXCEL 2003文件(*.xls)|*.xls";
		public static string DOCX = "Word2007以上文件(*.docx)|*.docx";
		public static string DBF = "DBF数据表文件(*.dbf)|*.dbf";
		private static StartWindow st = null;

		public static double Version { get; set; }

		/// <summary>
		/// 报告文件
		/// </summary>
		/// <param name="info"></param>
		public static void PutMessage(string info ) {
			//st.Report(info);
		}
		

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main () {
			Mark = "%m";
			Version = 1.1;
			Application.EnableVisualStyles( );
			Application.SetCompatibleTextRenderingDefault(false);
			st = new StartWindow( );
			Application.Run(st);
		}
	}
}
