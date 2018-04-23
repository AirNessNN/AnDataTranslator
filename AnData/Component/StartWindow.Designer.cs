namespace AnData.Component {
	partial class StartWindow {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartWindow));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnDbToExcel = new System.Windows.Forms.Button();
			this.btnTask = new System.Windows.Forms.Button();
			this.btnExcelToWord = new System.Windows.Forms.Button();
			this.BtnHelp = new System.Windows.Forms.Button();
			this.btnExit = new System.Windows.Forms.Button();
			this.btnAbout = new System.Windows.Forms.Button();
			this.btnBugReport = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(840, 698);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.btnDbToExcel, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.btnTask, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnExcelToWord, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.BtnHelp, 0, 6);
			this.tableLayoutPanel2.Controls.Add(this.btnExit, 0, 7);
			this.tableLayoutPanel2.Controls.Add(this.btnAbout, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.btnBugReport, 0, 3);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 4);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 8;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(134, 690);
			this.tableLayoutPanel2.TabIndex = 0;
			// 
			// btnDbToExcel
			// 
			this.btnDbToExcel.Location = new System.Drawing.Point(3, 88);
			this.btnDbToExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnDbToExcel.Name = "btnDbToExcel";
			this.btnDbToExcel.Size = new System.Drawing.Size(126, 33);
			this.btnDbToExcel.TabIndex = 1;
			this.btnDbToExcel.Text = "DBF转Excel";
			this.btnDbToExcel.UseVisualStyleBackColor = true;
			this.btnDbToExcel.Click += new System.EventHandler(this.btnDbToExcel_Click);
			// 
			// btnTask
			// 
			this.btnTask.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnTask.Location = new System.Drawing.Point(3, 4);
			this.btnTask.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnTask.Name = "btnTask";
			this.btnTask.Size = new System.Drawing.Size(128, 34);
			this.btnTask.TabIndex = 0;
			this.btnTask.Text = "批量Excel任务";
			this.btnTask.UseVisualStyleBackColor = true;
			this.btnTask.Click += new System.EventHandler(this.btnTask_Click);
			// 
			// btnExcelToWord
			// 
			this.btnExcelToWord.Location = new System.Drawing.Point(3, 46);
			this.btnExcelToWord.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnExcelToWord.Name = "btnExcelToWord";
			this.btnExcelToWord.Size = new System.Drawing.Size(126, 33);
			this.btnExcelToWord.TabIndex = 1;
			this.btnExcelToWord.Text = "Excel转Word";
			this.btnExcelToWord.UseVisualStyleBackColor = true;
			this.btnExcelToWord.Click += new System.EventHandler(this.btnExcelToWord_Click);
			// 
			// BtnHelp
			// 
			this.BtnHelp.Location = new System.Drawing.Point(3, 610);
			this.BtnHelp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.BtnHelp.Name = "BtnHelp";
			this.BtnHelp.Size = new System.Drawing.Size(126, 33);
			this.BtnHelp.TabIndex = 2;
			this.BtnHelp.Text = "帮助";
			this.BtnHelp.UseVisualStyleBackColor = true;
			this.BtnHelp.Click += new System.EventHandler(this.BtnHelp_Click);
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(3, 652);
			this.btnExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(126, 33);
			this.btnExit.TabIndex = 3;
			this.btnExit.Text = "退出";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// btnAbout
			// 
			this.btnAbout.Location = new System.Drawing.Point(3, 568);
			this.btnAbout.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(126, 34);
			this.btnAbout.TabIndex = 4;
			this.btnAbout.Text = "关于(1.1)";
			this.btnAbout.UseVisualStyleBackColor = true;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// btnBugReport
			// 
			this.btnBugReport.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnBugReport.Enabled = false;
			this.btnBugReport.Location = new System.Drawing.Point(3, 129);
			this.btnBugReport.Name = "btnBugReport";
			this.btnBugReport.Size = new System.Drawing.Size(128, 36);
			this.btnBugReport.TabIndex = 5;
			this.btnBugReport.Text = "错误报告";
			this.btnBugReport.UseVisualStyleBackColor = true;
			this.btnBugReport.Click += new System.EventHandler(this.btnBugReport_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(143, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(694, 692);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// StartWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.BackgroundImage = global::AnData.Properties.Resources.picbg;
			this.ClientSize = new System.Drawing.Size(840, 698);
			this.Controls.Add(this.tableLayoutPanel1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(856, 737);
			this.MinimumSize = new System.Drawing.Size(856, 737);
			this.Name = "StartWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "An数据转换助手";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button btnDbToExcel;
		private System.Windows.Forms.Button btnTask;
		private System.Windows.Forms.Button btnExcelToWord;
		private System.Windows.Forms.Button BtnHelp;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnAbout;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button btnBugReport;
	}
}