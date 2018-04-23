using AnData.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnData.Component {
	public partial class DbfWindow : Form {

		#region 属性
		/// <summary>
		/// 获取或设置表名，同时设置在标题上
		/// </summary>
		public string TableName {
			get {
				return labDBFName.Text;
			}
			set {
				labDBFName.Text = value;
				this.Text = "编辑DBF数据表：" + value;
			}
		}

		/// <summary>
		/// 获取或设置读取到的表，并显示在程序中
		/// </summary>
		public DataTable DBFTable { get; set; }


		/// <summary>
		/// 获取DBF实例
		/// </summary>
		public DatabaseFile DBF { get; private set; }


		private bool readFlag = false;


		#endregion

		public DbfWindow () {
			InitializeComponent( );

			openFileDialog.Filter = Program.DBF;
			openFileDialog.Multiselect = false;

		}

		/// <summary>
		/// 删除行
		/// </summary>
		private void DeleteRow () {
			if (dataGridView.SelectedCells.Count > 0) {
				try {
					DBFTable.Rows.RemoveAt(dataGridView.CurrentRow.Index);
				}catch(Exception ex) {
					MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
		}

		/// <summary>
		/// 删除列
		/// </summary>
		private void DeleteColumn () {
			if (dataGridView.SelectedCells.Count > 0) {
				try {
					DBFTable.Columns.RemoveAt(dataGridView.SelectedCells[0].ColumnIndex);
				}catch(Exception ex) {
					MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			}
		}


		/// <summary>
		/// 删除按键按下
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void dataGridView_KeyDown ( object sender, KeyEventArgs e ) {
			if (dataGridView.SelectedCells.Count < 1)
				return;
			if (e.KeyCode == Keys.Delete) {
				DialogResult r= MessageDialog.ShowMessageDialog( );
				if (r == DialogResult.Yes) {
					DeleteColumn( );
				} else {
					DeleteRow( );
				}
			}
		}

		/// <summary>
		/// 删除行按钮
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDeleteRow_Click ( object sender, EventArgs e ) {
			DeleteRow( );
		}

		/// <summary>
		/// 删除列按钮
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnDeleteColumn_Click ( object sender, EventArgs e ) {
			DeleteColumn( );
		}
		
		/// <summary>
		/// 选择文件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnSelectFile_Click ( object sender, EventArgs e ) {
			if (openFileDialog.ShowDialog( ) == DialogResult.OK) {
				DBF = new DatabaseFile(openFileDialog.FileName);
				TableName = new FileInfo(openFileDialog.FileName).Name.Split('.')[0];//设置表名
			}
		}

		/// <summary>
		/// 完成
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void Finish_Click ( object sender, EventArgs e ) {
			if (!readFlag) {
				MessageBox.Show("请选择数据表文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}

			saveFileDialog.Filter = "Excel 工作簿（*.xlsx）|*.xlsx";
			saveFileDialog.CheckPathExists = true;
			saveFileDialog.CheckFileExists = false;
			saveFileDialog.FileName = "Out.xlsx";
			if (saveFileDialog.ShowDialog( ) == DialogResult.OK) {

				ExcelFile excel = new ExcelFile( );
				excel = new ExcelFile( );
				bool b=excel.CreateWorkbook(saveFileDialog.FileName);
				if (!b) {
					MessageBox.Show("文件未写入成功，请确保该目录有权限写入或获取管理员权限后重试。" , "错误" , MessageBoxButtons.OK , MessageBoxIcon.Error);
					return;
				}
				//填充
				excel.FillData(DBFTable, "Sheet1", tbExcelTitle.Text == "" ? TableName : tbExcelTitle.Text);
				var r=MessageBox.Show("完成了！是否检查文件？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
				if (r == DialogResult.Yes) {
					Process.Start(saveFileDialog.FileName);
				}
				Close( );
			}
		}

		/// <summary>
		/// 读取
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btnRead_Click ( object sender, EventArgs e ) {
			if (DBF == null) {
				MessageBox.Show("还没有选择文件", "提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				return;
			}
			DataTable dt = null;
			try {
				if (tbSheetName.Text != "")
					dt = DBF.GetDbfData(tbSheetName.Text);
				else
					dt = DBF.GetDbfData(TableName);
			}catch(Exception ex) {
				MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			dataGridView.DataSource = dt;
			DBFTable = dt;
			readFlag = true;
		}

		/// <summary>
		/// 删除列菜单项
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void deleteColumnMenu_Click ( object sender, EventArgs e ) {
			DeleteColumn( );
		}

		/// <summary>
		/// 删除行菜单项
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void deleteRowMenu_Click ( object sender, EventArgs e ) {
			DeleteRow( );
		}
	}
}