using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AnData.Class;
using System.Threading;

namespace AnData.Component {
	public partial class TaskWindow : Form {

		/// <summary>
		/// 任务列表
		/// </summary>
		private List<ExcelToWordTask> Task { get; set; }

		private bool stopFlag = false;

		private string InfoTB { set {
				tbInfo.Text += value + "\r\n";
				tbInfo.SelectionStart = tbInfo.TextLength;
				tbInfo.ScrollToCaret( );
			} }

		private GuideWindow guidwindow = null;


		/// <summary>
		/// 初始化
		/// </summary>
		private void Initialize () {
			Task = new List<ExcelToWordTask>( );
		}

		public TaskWindow () {
			InitializeComponent( );
			Initialize( );
		}



		#region 回调
		/// <summary>
		/// 向导窗口的回调
		/// </summary>
		/// <param name="task"></param>
		void TaskCallback(ExcelToWordTask task ) {
			if (task == null)
				return;
			Task.Add(task);
			listBox.Items.Add(task.TaskName);
		}


		void FinishCallback(bool flag ) {

		}


		void StateCallback(int index,int count,int failCount ) {
			InfoTB = "正在处理第" + index + "个 ，全部数量：" + count + " 个，失败个数：" + failCount + "个。";
		}
		#endregion




		#region List事件
		//自绘Item，使其视觉效果更好  
		private void ListBoxGroupRange_DrawItem ( object sender, DrawItemEventArgs e ) {
			e.Graphics.FillRectangle(new SolidBrush(e.BackColor), e.Bounds);
			if (e.Index >= 0) {
				StringFormat sStringFormat = new StringFormat( );
				sStringFormat.LineAlignment = StringAlignment.Center;
				e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString( ), e.Font, new SolidBrush(e.ForeColor), e.Bounds, sStringFormat);
			}
			e.DrawFocusRectangle( );
		}

		private void ListBoxGroupRange_MeasureItem ( object sender, MeasureItemEventArgs e ) {
			e.ItemHeight = e.ItemHeight + 12;
		}
		#endregion 



		#region 菜单事件
		private bool IsListSelected () {
			if (listBox.SelectedIndex == -1)
				MessageBox.Show("未选择项目", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			return listBox.SelectedIndex != -1;
		}
		//删除项目
		private void DeleteItem_Click ( object sender, EventArgs e ) {
			if (!IsListSelected( ))
				return;
			listBox.Items.RemoveAt(listBox.SelectedIndex);
			Task.RemoveAt(listBox.SelectedIndex);

			if (Task.Count == 0)
				btnStart.Enabled = false;
		}

		private void InfoItem_Click ( object sender, EventArgs e ) {
			if (!IsListSelected( ))
				return;
			//打开详细窗口
		}
		#endregion
		//删除项目
		private void btnDelete_Click ( object sender, EventArgs e ) {
			if (!IsListSelected( ))
				return;
			listBox.Items.RemoveAt(listBox.SelectedIndex);
			Task.RemoveAt(listBox.SelectedIndex);

			if (Task.Count == 0)
				btnStart.Enabled = false;
		}

		private void btnClear_Click ( object sender, EventArgs e ) {
			listBox.Items.Clear( );
			Task.Clear( );
			btnStart.Enabled = false;
		}

		private void btnAdd_Click ( object sender, EventArgs e ) {
			guidwindow = new GuideWindow( );
			guidwindow.TaskCallback = TaskCallback;
			guidwindow.ShowDialog( );
			btnStart.Enabled = true;
		}

		private void btnStart_Click ( object sender, EventArgs e ) {
			if (Task.Count == 0)
				return;

			btnAdd.Enabled = false;
			btnClear.Enabled = false;
			btnDelete.Enabled = false;
			btnStart.Enabled = false;
			btnStop.Enabled = true;
			listBox.Enabled = false;
			btnStart.Cursor = Cursors.WaitCursor;


			int index = 1;

			progressBar.Maximum = Task.Count;


			foreach(ExcelToWordTask task in Task) {
				if (stopFlag) {
					InfoTB = "任务终止！";
					btnStart.Cursor = Cursors.Arrow;
					btnStop.Enabled = false;
					btnStart.Enabled = true;
					btnClear.Enabled = true;
					btnAdd.Enabled = true;
					btnDelete.Enabled = true;
					listBox.Enabled = true;
					return;
				}
					
				InfoTB = task.TaskName + "开始转换。";

				task.Listener = StateCallback;//设置回调

				task.Start(true );
				progressBar.Value = index++;
				InfoTB = task.TaskName+"转换完成。";

			}
			//结束之后的判断
			MessageBox.Show("所有任务都已经完成！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
			//清空任务
			Task.Clear( );
			listBox.Items.Clear( );

			btnStop.Enabled = false;
			btnStart.Enabled = false;
			btnClear.Enabled = true;
			btnAdd.Enabled = true;
			btnDelete.Enabled = true;
			listBox.Enabled = true;
			btnStart.Cursor = Cursors.Arrow;
		}

		private void btnStop_Click ( object sender, EventArgs e ) {
			btnStop.Enabled = false;
			btnStart.Enabled = true;
			btnClear.Enabled = true;
			btnAdd.Enabled = true;
			btnDelete.Enabled = true;
			listBox.Enabled = true;

			new Thread(() => {
				stopFlag = true;
			}).Start( );
		}

		private void listBox_ControlAdded ( object sender, ControlEventArgs e ) {
			btnStart.Enabled = true;
		}

		private void listBox_ControlRemoved ( object sender, ControlEventArgs e ) {
			if (listBox.Items.Count == 0) {
				btnStart.Enabled = false;
			}
		}
	}
}
