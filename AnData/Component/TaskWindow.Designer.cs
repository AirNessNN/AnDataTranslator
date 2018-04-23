namespace AnData.Component {
	partial class TaskWindow {
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskWindow));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.listBox = new System.Windows.Forms.ListBox();
			this.listMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.DeleteItem = new System.Windows.Forms.ToolStripMenuItem();
			this.InfoItem = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnDelete = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnAdd = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnStart = new System.Windows.Forms.Button();
			this.progressBar = new System.Windows.Forms.ProgressBar();
			this.tbInfo = new System.Windows.Forms.RichTextBox();
			this.tableLayoutPanel1.SuspendLayout();
			this.listMenu.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.listBox, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(715, 533);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// listBox
			// 
			this.listBox.ContextMenuStrip = this.listMenu;
			this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.listBox.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.listBox.FormattingEnabled = true;
			this.listBox.ItemHeight = 22;
			this.listBox.Location = new System.Drawing.Point(3, 3);
			this.listBox.Name = "listBox";
			this.listBox.Size = new System.Drawing.Size(351, 527);
			this.listBox.TabIndex = 0;
			this.listBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ListBoxGroupRange_DrawItem);
			this.listBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.ListBoxGroupRange_MeasureItem);
			this.listBox.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.listBox_ControlAdded);
			this.listBox.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.listBox_ControlRemoved);
			// 
			// listMenu
			// 
			this.listMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DeleteItem,
            this.InfoItem});
			this.listMenu.Name = "listMenu";
			this.listMenu.Size = new System.Drawing.Size(125, 48);
			// 
			// DeleteItem
			// 
			this.DeleteItem.Name = "DeleteItem";
			this.DeleteItem.Size = new System.Drawing.Size(124, 22);
			this.DeleteItem.Text = "详细信息";
			this.DeleteItem.Click += new System.EventHandler(this.InfoItem_Click);
			// 
			// InfoItem
			// 
			this.InfoItem.Name = "InfoItem";
			this.InfoItem.Size = new System.Drawing.Size(124, 22);
			this.InfoItem.Text = "删除该项";
			this.InfoItem.Click += new System.EventHandler(this.DeleteItem_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.progressBar, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.tbInfo, 0, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tableLayoutPanel2.Location = new System.Drawing.Point(360, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 4;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(352, 527);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.btnDelete);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.btnClear);
			this.groupBox1.Controls.Add(this.btnAdd);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(346, 110);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "任务添加";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(87, 83);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 17);
			this.label3.TabIndex = 5;
			this.label3.Text = "删除所选任务。";
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(6, 78);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "删除";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(87, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(152, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "清空任务列表中所有任务。";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(87, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(248, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "创建一个任务向导，添加任务到任务列表中。";
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(6, 49);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(75, 23);
			this.btnClear.TabIndex = 1;
			this.btnClear.Text = "清空";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(6, 20);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 0;
			this.btnAdd.Text = "添加";
			this.btnAdd.UseVisualStyleBackColor = true;
			this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnStop);
			this.groupBox2.Controls.Add(this.btnStart);
			this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox2.Location = new System.Drawing.Point(3, 446);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(346, 58);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "任务操作";
			// 
			// btnStop
			// 
			this.btnStop.Enabled = false;
			this.btnStop.FlatAppearance.BorderColor = System.Drawing.Color.Red;
			this.btnStop.FlatAppearance.BorderSize = 2;
			this.btnStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.btnStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnStop.Location = new System.Drawing.Point(6, 20);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(77, 29);
			this.btnStop.TabIndex = 1;
			this.btnStop.Text = "中止";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnStart
			// 
			this.btnStart.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.btnStart.Enabled = false;
			this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
			this.btnStart.FlatAppearance.BorderSize = 2;
			this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
			this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.btnStart.Location = new System.Drawing.Point(89, 20);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(251, 29);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "开始";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// progressBar
			// 
			this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.progressBar.Location = new System.Drawing.Point(3, 510);
			this.progressBar.Name = "progressBar";
			this.progressBar.Size = new System.Drawing.Size(346, 14);
			this.progressBar.TabIndex = 4;
			// 
			// tbInfo
			// 
			this.tbInfo.BackColor = System.Drawing.SystemColors.Control;
			this.tbInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbInfo.Cursor = System.Windows.Forms.Cursors.Arrow;
			this.tbInfo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbInfo.Location = new System.Drawing.Point(3, 119);
			this.tbInfo.Name = "tbInfo";
			this.tbInfo.ReadOnly = true;
			this.tbInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.tbInfo.Size = new System.Drawing.Size(346, 321);
			this.tbInfo.TabIndex = 5;
			this.tbInfo.Text = "";
			// 
			// TaskWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(715, 533);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(731, 572);
			this.MinimumSize = new System.Drawing.Size(731, 572);
			this.Name = "TaskWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "创建任务";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.listMenu.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.ListBox listBox;
		private System.Windows.Forms.ContextMenuStrip listMenu;
		private System.Windows.Forms.ToolStripMenuItem DeleteItem;
		private System.Windows.Forms.ToolStripMenuItem InfoItem;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.ProgressBar progressBar;
		private System.Windows.Forms.RichTextBox tbInfo;
	}
}