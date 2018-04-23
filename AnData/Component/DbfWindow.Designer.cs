namespace AnData.Component {
	partial class DbfWindow {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DbfWindow));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.deleteColumnMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.deleteRowMenu = new System.Windows.Forms.ToolStripMenuItem();
			this.labDBFName = new System.Windows.Forms.Label();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnFInish = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.btnSelectFile = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tbExcelTitle = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.btnDeleteRow = new System.Windows.Forms.Button();
			this.btnDeleteColumn = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.tbSheetName = new System.Windows.Forms.TextBox();
			this.btnRead = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.contextMenuStrip.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175F));
			this.tableLayoutPanel1.Controls.Add(this.dataGridView, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.labDBFName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(784, 631);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// dataGridView
			// 
			this.dataGridView.AllowUserToOrderColumns = true;
			this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.ContextMenuStrip = this.contextMenuStrip;
			this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView.Location = new System.Drawing.Point(3, 33);
			this.dataGridView.MultiSelect = false;
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.ReadOnly = true;
			this.dataGridView.RowTemplate.Height = 23;
			this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridView.Size = new System.Drawing.Size(603, 595);
			this.dataGridView.TabIndex = 0;
			this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDown);
			// 
			// contextMenuStrip
			// 
			this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteColumnMenu,
            this.deleteRowMenu});
			this.contextMenuStrip.Name = "contextMenuStrip";
			this.contextMenuStrip.Size = new System.Drawing.Size(113, 48);
			// 
			// deleteColumnMenu
			// 
			this.deleteColumnMenu.Name = "deleteColumnMenu";
			this.deleteColumnMenu.Size = new System.Drawing.Size(112, 22);
			this.deleteColumnMenu.Text = "删除列";
			this.deleteColumnMenu.Click += new System.EventHandler(this.deleteColumnMenu_Click);
			// 
			// deleteRowMenu
			// 
			this.deleteRowMenu.Name = "deleteRowMenu";
			this.deleteRowMenu.Size = new System.Drawing.Size(112, 22);
			this.deleteRowMenu.Text = "删除行";
			this.deleteRowMenu.Click += new System.EventHandler(this.deleteRowMenu_Click);
			// 
			// labDBFName
			// 
			this.labDBFName.AutoSize = true;
			this.labDBFName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labDBFName.Font = new System.Drawing.Font("微软雅黑", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labDBFName.ForeColor = System.Drawing.SystemColors.Highlight;
			this.labDBFName.Location = new System.Drawing.Point(3, 0);
			this.labDBFName.Name = "labDBFName";
			this.labDBFName.Size = new System.Drawing.Size(603, 30);
			this.labDBFName.TabIndex = 1;
			this.labDBFName.Text = "标题";
			this.labDBFName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.btnFInish, 0, 15);
			this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnSelectFile, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 11);
			this.tableLayoutPanel2.Controls.Add(this.tbExcelTitle, 0, 12);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 6);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 7);
			this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.tbSheetName, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.btnRead, 0, 4);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(612, 33);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 16;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 132F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 242F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(169, 595);
			this.tableLayoutPanel2.TabIndex = 2;
			// 
			// btnFInish
			// 
			this.btnFInish.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnFInish.Location = new System.Drawing.Point(3, 562);
			this.btnFInish.Name = "btnFInish";
			this.btnFInish.Size = new System.Drawing.Size(163, 30);
			this.btnFInish.TabIndex = 0;
			this.btnFInish.Text = "导出";
			this.btnFInish.UseVisualStyleBackColor = true;
			this.btnFInish.Click += new System.EventHandler(this.Finish_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "选择数据表";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnSelectFile
			// 
			this.btnSelectFile.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnSelectFile.Location = new System.Drawing.Point(3, 23);
			this.btnSelectFile.Name = "btnSelectFile";
			this.btnSelectFile.Size = new System.Drawing.Size(163, 24);
			this.btnSelectFile.TabIndex = 2;
			this.btnSelectFile.Text = "选择文件";
			this.btnSelectFile.UseVisualStyleBackColor = true;
			this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 270);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(163, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "设置导出到Excel的标题";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbExcelTitle
			// 
			this.tbExcelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbExcelTitle.Location = new System.Drawing.Point(3, 293);
			this.tbExcelTitle.Name = "tbExcelTitle";
			this.tbExcelTitle.Size = new System.Drawing.Size(163, 21);
			this.tbExcelTitle.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 150);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(163, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "筛选数据";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 2;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Controls.Add(this.btnDeleteRow, 0, 0);
			this.tableLayoutPanel3.Controls.Add(this.btnDeleteColumn, 1, 0);
			this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 170);
			this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 1;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(169, 30);
			this.tableLayoutPanel3.TabIndex = 6;
			// 
			// btnDeleteRow
			// 
			this.btnDeleteRow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDeleteRow.Location = new System.Drawing.Point(3, 3);
			this.btnDeleteRow.Name = "btnDeleteRow";
			this.btnDeleteRow.Size = new System.Drawing.Size(78, 24);
			this.btnDeleteRow.TabIndex = 0;
			this.btnDeleteRow.Text = "删除所在行";
			this.btnDeleteRow.UseVisualStyleBackColor = true;
			this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
			// 
			// btnDeleteColumn
			// 
			this.btnDeleteColumn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDeleteColumn.Location = new System.Drawing.Point(87, 3);
			this.btnDeleteColumn.Name = "btnDeleteColumn";
			this.btnDeleteColumn.Size = new System.Drawing.Size(79, 24);
			this.btnDeleteColumn.TabIndex = 1;
			this.btnDeleteColumn.Text = "删除所在列";
			this.btnDeleteColumn.UseVisualStyleBackColor = true;
			this.btnDeleteColumn.Click += new System.EventHandler(this.btnDeleteColumn_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(163, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "表名";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tbSheetName
			// 
			this.tbSheetName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tbSheetName.Location = new System.Drawing.Point(3, 73);
			this.tbSheetName.Name = "tbSheetName";
			this.tbSheetName.Size = new System.Drawing.Size(163, 21);
			this.tbSheetName.TabIndex = 8;
			// 
			// btnRead
			// 
			this.btnRead.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnRead.Location = new System.Drawing.Point(3, 103);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(163, 24);
			this.btnRead.TabIndex = 9;
			this.btnRead.Text = "读取数据表";
			this.btnRead.UseVisualStyleBackColor = true;
			this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// DbfWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 631);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(800, 670);
			this.Name = "DbfWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "数据库导出设置";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.contextMenuStrip.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel3.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.Label labDBFName;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button btnFInish;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSelectFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Button btnDeleteRow;
		private System.Windows.Forms.Button btnDeleteColumn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbSheetName;
		private System.Windows.Forms.Button btnRead;
		private System.Windows.Forms.TextBox tbExcelTitle;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem deleteColumnMenu;
		private System.Windows.Forms.ToolStripMenuItem deleteRowMenu;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
	}
}