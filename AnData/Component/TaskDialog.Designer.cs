namespace AnData.Component {
	partial class TaskDialog {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose ( bool disposing ) {
			if (disposing && (components != null)) {
				components.Dispose( );
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent () {
			this.labTitle = new System.Windows.Forms.Label();
			this.tbInfo = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// labTitle
			// 
			this.labTitle.AutoSize = true;
			this.labTitle.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labTitle.Location = new System.Drawing.Point(14, 13);
			this.labTitle.Name = "labTitle";
			this.labTitle.Size = new System.Drawing.Size(93, 20);
			this.labTitle.TabIndex = 0;
			this.labTitle.Text = "正在执行任务";
			// 
			// tbInfo
			// 
			this.tbInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbInfo.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.tbInfo.Location = new System.Drawing.Point(18, 36);
			this.tbInfo.Name = "tbInfo";
			this.tbInfo.ReadOnly = true;
			this.tbInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.tbInfo.Size = new System.Drawing.Size(562, 167);
			this.tbInfo.TabIndex = 1;
			this.tbInfo.Text = "";
			// 
			// TaskDialog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(592, 215);
			this.Controls.Add(this.tbInfo);
			this.Controls.Add(this.labTitle);
			this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
			this.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "TaskDialog";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.Text = "任务报告";
			this.TopMost = true;
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labTitle;
		private System.Windows.Forms.RichTextBox tbInfo;
	}
}