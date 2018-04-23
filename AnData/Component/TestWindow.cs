using AnData.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace AnData.Component {
	public partial class TestWindow : Form {

		ExcelFile excel = new ExcelFile( );
		DataTable dt = new DataTable( );
		DatabaseFile df = null;

		public TestWindow () {
			InitializeComponent( );
		}

		private void PrintTable(DataTable dt ) {
			if (null == dt)
				return;

			for(int i = 0; i < dt.Rows.Count; i++) {
				for(int j = 0; j < dt.Columns.Count; j++) {
					Debug.Write(dt.Rows[i][j].ToString( ) + " ");
				}
				Debug.WriteLine("");
			}
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

		private void button4_Click ( object sender, EventArgs e ) {
			bool b=excel.FillData((DataTable)dataGridView1.DataSource, "Sheet1", "测试标题");
			debug("填充测试：" + b);
		}

		private void button5_Click ( object sender, EventArgs e ) {
			OpenFileDialog fd = new OpenFileDialog( );
			fd.Filter = Program.DBF;
			if (fd.ShowDialog( ) == DialogResult.OK) {
				df = new DatabaseFile(fd.FileName);
			}
		}

		private void button6_Click ( object sender, EventArgs e ) {
			if (df != null) {
				df.TestConnection( );
				dataGridView1.DataSource = df.GetDbfData("表1");
			}
		}

		private void button7_Click ( object sender, EventArgs e ) {
			Point p = button11.Location;
			p.Y -= 5;
			button11.Location = p;
		}

		private void button9_Click ( object sender, EventArgs e ) {
			Point p = button11.Location;
			p.X -= 5;
			button11.Location = p;
		}

		private void button8_Click ( object sender, EventArgs e ) {
			Point p = button11.Location;
			p.Y += 5;
			button11.Location = p;
		}

		private void button10_Click ( object sender, EventArgs e ) {
			Point p = button11.Location;
			p.X += 5;
			button11.Location = p;
		}

		private void button11_Click ( object sender, EventArgs e ) {
			for(int i = 0; i <= 100; i++) {
				progressBar1.Value = i;
				Thread.Sleep(100);
			}
		}
	}
}
