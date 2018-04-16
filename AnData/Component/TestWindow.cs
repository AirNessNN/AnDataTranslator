using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnData.Component {
	public partial class TestWindow : Form {

		ExcelFile excel = new ExcelFile( );
		DataTable dt = new DataTable( );

		public TestWindow () {
			InitializeComponent( );


			DataColumn dc1 = new DataColumn("哈哈");
			DataColumn dc2 = new DataColumn("嘻嘻");
			DataColumn dc3 = new DataColumn("嘿嘿");
			dt.Columns.Add(dc1);
			dt.Columns.Add(dc2);
			dt.Columns.Add(dc3);

			DataRow dr1 = dt.NewRow( );
			DataRow dr2 = dt.NewRow( );
			DataRow dr3 = dt.NewRow( );
			dr1[0] = "小";
			dr1[1] = "云";
			dr1[2] = "云";

			dr2[0] = "大";
			dr2[1] = "nei";
			dr2[2] = "nei";

			dr3[0] = "臭";
			dr3[1] = "jio";
			dr3[2] = "jio";

			dt.Rows.Add(dr1);
			dt.Rows.Add(dr2);
			dt.Rows.Add(dr3);

			dataGridView1.DataSource = dt;
		}

		//创建
		private void button2_Click ( object sender, EventArgs e ) {
			FolderBrowserDialog bd = new FolderBrowserDialog( );
			if (bd.ShowDialog( ) == DialogResult.OK) {
				bool b=excel.CreateWorkbook(bd.SelectedPath + "\\" + textBox1.Text + ".xlsx");
				debug("创建文件：" + b);
			}
		}

		//选择
		private void button1_Click ( object sender, EventArgs e ) {
			OpenFileDialog fd = new OpenFileDialog( );
			fd.Filter = Program.XLSX;
			if (fd.ShowDialog( ) == DialogResult.OK) {
				bool b=excel.ReadFile(fd.FileName);
				debug("读取文件："+b);

				comboBox1.DataSource = excel.GetSheetName( );
			}
		}




		public void debug(object name ) {
			Debug.WriteLine(name);
		}

		//替换表名
		private void button3_Click ( object sender, EventArgs e ) {
			bool b=excel.ReplaceSheetName(comboBox1.SelectedItem.ToString(), textBox2.Text);
			debug("替换表名：" + b);
		}
	}
}
