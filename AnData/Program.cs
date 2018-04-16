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

		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main () {
			Mark = "%m";
			Application.EnableVisualStyles( );
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new TestWindow());
		}
	}
}
