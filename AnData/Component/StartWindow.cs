using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AnData.Class;

namespace AnData.Component {
	public partial class StartWindow : Form {


		private GuideWindow guideWindow = null;

		/// <summary>
		/// 任务报告窗口
		/// </summary>
		private TaskDialog dialog = null;

		/// <summary>
		/// 任务输出文件夹
		/// </summary>
		private string TaskOutDirectory = "";

		/// <summary>
		/// 数据库导出窗口
		/// </summary>
		private DbfWindow dbfwindow = null;

		public TaskDialog bugReport { get; set; }





		public StartWindow () {
			InitializeComponent( );
			bugReport = new TaskDialog( );
		}


		public void Report(string value ) {
			bugReport.Info = value;
		}


		//任务Task
		public void TaskCallbcak(ExcelToWordTask task ) {
			task.Listener = InfoCallback;
			task.Callback = FinishCallback;
			TaskOutDirectory = task.TargetPath;

			dialog = new TaskDialog( );
			dialog.Title = task.TaskName;
			dialog.Show( );
			task.Start( );
		}

		//完成回调
		public void FinishCallback(bool flag ) {
			dialog.SetCursor(true);
			dialog.Title = "完成任务!";
			DialogResult r= MessageBox.Show("任务完成，是否打开输出路径？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (r == DialogResult.Yes) {
				if (TaskOutDirectory != "") {
					System.Diagnostics.Process.Start(TaskOutDirectory);
				}
			}
			TaskOutDirectory = "";
		}

		//信息回调
		public void InfoCallback(int index,int count,int failCount ) {
			dialog.Info = "正在处理第" + (index) + "个 ，全部数量：" + count + " 个，失败个数：" + failCount+"个。";
		}





		private void btnExit_Click ( object sender, EventArgs e ) {
			Environment.Exit(0);
		}

		private void BtnHelp_Click ( object sender, EventArgs e ) {
			HelpWindow hp = new HelpWindow( );
			hp.ShowDialog( );
		}

		private void btnAbout_Click ( object sender, EventArgs e ) {
			AboutWindow ab = new AboutWindow( );
			ab.ShowDialog( );
		}

		private void btnTask_Click ( object sender, EventArgs e ) {
			TaskWindow t = new TaskWindow( );
			t.ShowDialog( );
		}

		private void btnExcelToWord_Click ( object sender, EventArgs e ) {
			if (guideWindow!=null&& guideWindow.Visible) {
				guideWindow.Focus( );
				return;
			}
			guideWindow = new GuideWindow( );
			guideWindow.TaskCallback = this.TaskCallbcak;
			guideWindow.Show( );
		}

		private void btnDbToExcel_Click ( object sender, EventArgs e ) {
			dbfwindow = new DbfWindow( );
			dbfwindow.ShowDialog( );
		}

		private void btnBugReport_Click ( object sender, EventArgs e ) {
			bugReport.Title = "任务日志";
			bugReport.Show( );
		}
	}
}
