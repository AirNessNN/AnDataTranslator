using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnData.Class;
using System.IO;

namespace AnData.Component {
	public partial class GuideWindow : Form {

		#region 属性
		/// <summary>
		/// 获取或设置标题
		/// </summary>
		public string Title {
			get { return labTitle.Text; }
			set { labTitle.Text = value; }
		}

		/// <summary>
		/// Excel转换任务
		/// </summary>
		private ExcelToWordTask Task { get; set; }

		/// <summary>
		/// 文件实例
		/// </summary>
		private ExcelFile Excel { get; set; }

		/// <summary>
		/// ExcelFile读取的Table
		/// </summary>
		private DataTable ExcelTable { get; set; }

		/// <summary>
		/// Word标记数量
		/// </summary>
		private int MarkCount {
			get {
				return wd.MarkCount;
			}
			set {
				labMarkCount.Text = value + "个";
			}
		}

		/// <summary>
		/// Excel行数据数量
		/// </summary>
		private int ValueCount { get; set; }

		#endregion





		#region 字段
		/// <summary>
		/// 标题集合
		/// </summary>
		private string[] titles = { "欢迎使用An任务向导", "设置Excel文件", "设置Word模板文件", "设置输出选项","任务设置完成！" };


		private ExcelWindow excelWindow = null;

		private WordFile wd = null;

		public delegate void Callback ( ExcelToWordTask task );
		/// <summary>
		/// 任务回调：当完成创建时点击完成，就会回调
		/// </summary>
		public Callback TaskCallback { get; set; }
		#endregion





		public GuideWindow () {
			InitializeComponent( );

			//设置标题
			Title = titles[0];

			Task = new ExcelToWordTask( );

			Excel = new ExcelFile( );

			wd = new WordFile( );

		}



		/// <summary>
		/// 读取Excel文件
		/// </summary>
		/// <param name="path"></param>
		private void ReadExcel (string path) {
			bool b = Excel.ReadFile(path);
			if (b) {
				ExcelTable = Excel.GetDataTable(Excel.GetSheetName( )[0], 0, 0);
			} else {
				labExcelInfo.Text = "数据无法读取";
			}
			//取后缀名
			string[] type = new FileInfo(path).FullName.Split('.');
			labExcelType.Text = type[type.Length - 1];
			//获取DT信息
			GetDataTableInfo( );
		} 


		/// <summary>
		/// 获取DataTable信息
		/// </summary>
		private void GetDataTableInfo () {
			if (ExcelTable != null) {
				labExcelInfo.Text = ExcelTable.Rows.Count + "行，" + ExcelTable.Columns.Count + "列。";
			}else {
				labExcelInfo.Text = "无法读取";
			}
		}






		public void FinishExcelWindow(DataTable dt ) {
			ExcelTable = dt;
			GetDataTableInfo( );
		}




		#region 监听事件
		//完成按钮
		private void btnFinish_Click ( object sender, EventArgs e ) {
			Task.TargetPath = tbDirectory.Text;
			Task.ModelPath = tbWordFilePath.Text;

			//为什么不直接读取，因为，在用户看来经过下一步已经是确定了所选的表单了，或者经过了筛选，所以读取储存好的数据
			//设置文件名
			List<QueueData> list = Util.DataTableToQueueData(ExcelTable);
			if (rdExcelColumnName.Checked) {
				int index = cbExcelColumnName.SelectedIndex;
				list = Util.SetQueueDatasNameFrom(index, list);
			}
			if (rdUserName.Checked) {
				for(int i = 0; i < list.Count; i++) {
					list[i].Name = tbFileName.Text+"_" + i;
				}
			}

			Task.SourceData = list;

			Task.TaskName = new FileInfo(tbExcelPath.Text).Name;

			//回调
			TaskCallback?.Invoke(Task);
			this.Close( );
		}
		//下一个
		private void btnNext_Click ( object sender, EventArgs e ) {
			//页面的索引号
			int tabIndex = tabControl.SelectedIndex;
			//单页判断
			if (tabIndex == 1) {
				if (!btnExcelFiltarte.Enabled) {
					MessageBox.Show("无效文件，请重新选择", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
			}
			if (tabIndex == 2) {
				if (!btnWordFileRead.Enabled) {
					MessageBox.Show("无效文件，请重新选择", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				if (tbMark.Text == "") {
					MessageBox.Show("未设置标记", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				//对第三页的加载
				if (rdExcelColumnName.Checked) {
					if (ExcelTable != null) {
						string[] name = new string[ExcelTable.Columns.Count];
						for (int i = 0; i < name.Length; i++) {
							name[i] = ExcelTable.Columns[i].ColumnName;
						}
						cbExcelColumnName.DataSource = name;
					} else {
						rdUserName.Checked = true;
					}
				}
			}
			if (tabIndex == 3) {
				if (!Directory.Exists(tbDirectory.Text)) {
					MessageBox.Show("无效路径，请重新选择", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}
				if (rdExcelColumnName.Checked) {
					if (cbExcelColumnName.SelectedIndex < 0) {
						MessageBox.Show("选择的命名不存在，请重新选择", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
						return;
					}
				}
			}
			/*
			 * 以上进行的操作是在点击下一步响应之前做判断和操作，
			 * 是否符合标准进入到下一步，如果不符合，则不执行下面的切换页面
			 */
			btnPrevious.Enabled = true;
			tabControl.SelectedIndex++;
			Title = titles[tabControl.SelectedIndex];
			if (tabControl.SelectedIndex == tabControl.TabCount - 1) {
				btnNext.Enabled = false;
				btnFinish.Enabled = true;
			}
		}
		//上一个
		private void btnPrevious_Click ( object sender, EventArgs e ) {
			btnFinish.Enabled = false;
			btnNext.Enabled = true;
			tabControl.SelectedIndex--;
			Title = titles[tabControl.SelectedIndex];
			if (tabControl.SelectedIndex == 0)
				btnPrevious.Enabled = false;
		}
		//取消
		private void btnCancel_Click ( object sender, EventArgs e ) {
			DialogResult r = MessageBox.Show("确认取消吗？", "取消提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if(r==DialogResult.Yes)
				this.Close( );
		}


		//选择Excel文件
		private void btnSelectFile_Click ( object sender, EventArgs e ) {
			OpenFileDialog fd = new OpenFileDialog( );
			fd.Multiselect = false;
			fd.Filter = Program.XLSX + "|" + Program.XLS;
			if (fd.ShowDialog( ) == DialogResult.OK) {
				//设置文本框
				tbExcelPath.Text = fd.FileName;
				btnExcelFiltarte.Enabled = true;
				//设置后缀
				string[] type = new FileInfo(fd.FileName).FullName.Split('.');
				labExcelType.Text = type[type.Length - 1];
			}
		}
		//读取Excel
		private void btnReadExcel_Click ( object sender, EventArgs e ) {
			if (tbExcelPath.Text == "") {
				MessageBox.Show("先选择或填写路径。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			ReadExcel(tbExcelPath.Text);
		}
		//Excel筛选
		private void btnExcelFiltarte_Click ( object sender, EventArgs e ) {
			if (excelWindow != null) {
				if (excelWindow.FileName == tbExcelPath.Text&&excelWindow.Visible) {
					excelWindow.Focus( );
					return;
				}else {
					excelWindow.Close( );
				}
			}
			excelWindow = new ExcelWindow(tbExcelPath.Text);
			excelWindow.callback = FinishExcelWindow;
			excelWindow.ShowDialog( );
		}
		//Excel文件路径发生改变
		private void tbExcelPath_TextChanged ( object sender, EventArgs e ) {
			try {
				if (File.Exists(tbExcelPath.Text)) {
					btnExcelFiltarte.Enabled = true;
					btnReadExcel.Enabled = true;
				} else {
					btnExcelFiltarte.Enabled = false;
					btnReadExcel.Enabled = false;
				}
			} catch {
				btnExcelFiltarte.Enabled = false;
				btnReadExcel.Enabled = false;
			}
		}



		//Word文件选择
		private void btnWordFileSelection_Click ( object sender, EventArgs e ) {
			OpenFileDialog fd = new OpenFileDialog( );
			fd.Multiselect = false;
			fd.Filter = Program.DOCX;
			if (fd.ShowDialog( ) == DialogResult.OK) {
				//设置文本框
				tbWordFilePath.Text = fd.FileName;
			}
		}
		//Word路径发生改变
		private void tbWordFilePath_TextChanged ( object sender, EventArgs e ) {
			try {
				if (File.Exists(tbWordFilePath.Text)) {
					btnWordFileRead.Enabled = true;
					btnEditModel.Enabled = true;
				} else {
					btnWordFileRead.Enabled = false;
					btnEditModel.Enabled = false;
				}
			} catch {
				btnWordFileRead.Enabled = false;
				btnEditModel.Enabled = false;
			}
		}
		//读Word文件
		private void btnWordFileRead_Click ( object sender, EventArgs e ) {
			if (tbMark.Text == ""||tbMark.Text==null) {
				MessageBox.Show("未设置标记，请先设置标记", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			wd.ReadFile(tbWordFilePath.Text);
			MarkCount = wd.MarkCount;
			if (ExcelTable != null) {
				if (ExcelTable.Columns.Count != MarkCount) {
					DialogResult r= MessageBox.Show("当前数据源的列数为：" + ExcelTable.Columns.Count + "，当前找到的标记数量："+MarkCount+"，与找到的标记不吻合，是否要重新筛选Excel表格数据？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (r == DialogResult.Yes) {
						excelWindow.ShowDialog( );
					}
				}
					
			}
		}
		//编辑Word模板
		private void btnEditModel_Click ( object sender, EventArgs e ) {
			Process.Start(tbWordFilePath.Text);
		}
		//模板标记改变
		private void tbMark_TextChanged ( object sender, EventArgs e ) {
			wd.Mark = tbMark.Text;
		}


		//路径选择
		private void btnWordDirectorySelection_Click ( object sender, EventArgs e ) {
			FolderBrowserDialog fd = new FolderBrowserDialog( );
			if (fd.ShowDialog( ) == DialogResult.OK) {
				tbDirectory.Text = fd.SelectedPath;
			}
		}

		private void radioButton1_CheckedChanged ( object sender, EventArgs e ) {
			if (!rdExcelColumnName.Checked)
				return;
			tbFileName.Visible = false;
			cbExcelColumnName.Visible = true;
			tst1.Visible = true;
			tst2.Visible = false;
		}

		private void radioButton2_CheckedChanged ( object sender, EventArgs e ) {
			if (!rdUserName.Checked)
				return;
			tbFileName.Visible = true;
			cbExcelColumnName.Visible = false;
			tst1.Visible = false;
			tst2.Visible = true;
		}


		#endregion

		
	}
}
