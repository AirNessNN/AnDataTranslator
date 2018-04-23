namespace AnData {
	partial class ExcelWindow {
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose ( bool disposing ) {
			if (disposing && (components != null)) {
				components.Dispose( );
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码
		 
		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent () {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelWindow));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.labFileName = new System.Windows.Forms.Label();
			this.gridView = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.btnFinish = new System.Windows.Forms.Button();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.row = new System.Windows.Forms.NumericUpDown();
			this.column = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.btnReadExcel = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.cobSheetName = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.btnDeleteColumn = new System.Windows.Forms.Button();
			this.btnDeleteRow = new System.Windows.Forms.Button();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
			this.tableLayoutPanel2.SuspendLayout();
			this.tableLayoutPanel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.row)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.column)).BeginInit();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 177F));
			this.tableLayoutPanel1.Controls.Add(this.labFileName, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.gridView, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(884, 561);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// labFileName
			// 
			this.labFileName.AutoSize = true;
			this.labFileName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labFileName.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labFileName.Location = new System.Drawing.Point(3, 0);
			this.labFileName.Name = "labFileName";
			this.labFileName.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
			this.labFileName.Size = new System.Drawing.Size(701, 38);
			this.labFileName.TabIndex = 1;
			this.labFileName.Text = "文件路径";
			this.labFileName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// gridView
			// 
			this.gridView.AllowUserToOrderColumns = true;
			this.gridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
			this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.gridView.Location = new System.Drawing.Point(3, 42);
			this.gridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.gridView.MultiSelect = false;
			this.gridView.Name = "gridView";
			this.gridView.ReadOnly = true;
			this.gridView.RowTemplate.Height = 23;
			this.gridView.RowTemplate.ReadOnly = true;
			this.gridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.gridView.Size = new System.Drawing.Size(701, 515);
			this.gridView.TabIndex = 2;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.btnFinish, 0, 11);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 6);
			this.tableLayoutPanel2.Controls.Add(this.label2, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.btnReadExcel, 0, 7);
			this.tableLayoutPanel2.Controls.Add(this.label3, 0, 8);
			this.tableLayoutPanel2.Controls.Add(this.cobSheetName, 0, 9);
			this.tableLayoutPanel2.Controls.Add(this.label6, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.btnDeleteColumn, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.btnDeleteRow, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.checkBox1, 0, 3);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(710, 42);
			this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 12;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(171, 515);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// btnFinish
			// 
			this.btnFinish.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnFinish.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnFinish.Location = new System.Drawing.Point(3, 484);
			this.btnFinish.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnFinish.Name = "btnFinish";
			this.btnFinish.Size = new System.Drawing.Size(165, 27);
			this.btnFinish.TabIndex = 3;
			this.btnFinish.Text = "完成筛选";
			this.btnFinish.UseVisualStyleBackColor = true;
			this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.Controls.Add(this.row, 0, 0);
			this.tableLayoutPanel4.Controls.Add(this.column, 1, 0);
			this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 264);
			this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 1;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(163, 27);
			this.tableLayoutPanel4.TabIndex = 11;
			// 
			// row
			// 
			this.row.Location = new System.Drawing.Point(3, 4);
			this.row.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.row.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.row.Name = "row";
			this.row.Size = new System.Drawing.Size(75, 23);
			this.row.TabIndex = 0;
			this.row.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// column
			// 
			this.column.Location = new System.Drawing.Point(84, 4);
			this.column.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.column.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.column.Name = "column";
			this.column.Size = new System.Drawing.Size(75, 23);
			this.column.TabIndex = 1;
			this.column.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 232);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 28);
			this.label2.TabIndex = 12;
			this.label2.Text = "Excel数据设置(行，列)";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnReadExcel
			// 
			this.btnReadExcel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnReadExcel.Location = new System.Drawing.Point(3, 299);
			this.btnReadExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnReadExcel.Name = "btnReadExcel";
			this.btnReadExcel.Size = new System.Drawing.Size(165, 27);
			this.btnReadExcel.TabIndex = 13;
			this.btnReadExcel.Text = "读取Excel文件";
			this.btnReadExcel.UseVisualStyleBackColor = true;
			this.btnReadExcel.Click += new System.EventHandler(this.btnReadExcel_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 330);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(165, 28);
			this.label3.TabIndex = 14;
			this.label3.Text = "选择工作表";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cobSheetName
			// 
			this.cobSheetName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cobSheetName.FormattingEnabled = true;
			this.cobSheetName.Location = new System.Drawing.Point(3, 362);
			this.cobSheetName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.cobSheetName.Name = "cobSheetName";
			this.cobSheetName.Size = new System.Drawing.Size(165, 25);
			this.cobSheetName.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(3, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(165, 28);
			this.label6.TabIndex = 16;
			this.label6.Text = "筛选设置";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// btnDeleteColumn
			// 
			this.btnDeleteColumn.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDeleteColumn.Location = new System.Drawing.Point(3, 32);
			this.btnDeleteColumn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnDeleteColumn.Name = "btnDeleteColumn";
			this.btnDeleteColumn.Size = new System.Drawing.Size(165, 27);
			this.btnDeleteColumn.TabIndex = 17;
			this.btnDeleteColumn.Text = "删除所在列";
			this.btnDeleteColumn.UseVisualStyleBackColor = true;
			this.btnDeleteColumn.Click += new System.EventHandler(this.btnDeleteColumn_Click);
			// 
			// btnDeleteRow
			// 
			this.btnDeleteRow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnDeleteRow.Location = new System.Drawing.Point(3, 67);
			this.btnDeleteRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btnDeleteRow.Name = "btnDeleteRow";
			this.btnDeleteRow.Size = new System.Drawing.Size(165, 27);
			this.btnDeleteRow.TabIndex = 18;
			this.btnDeleteRow.Text = "删除所在行";
			this.btnDeleteRow.UseVisualStyleBackColor = true;
			this.btnDeleteRow.Click += new System.EventHandler(this.btnDeleteRow_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.checkBox1.Location = new System.Drawing.Point(3, 102);
			this.checkBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
			this.checkBox1.Size = new System.Drawing.Size(165, 27);
			this.checkBox1.TabIndex = 19;
			this.checkBox1.Text = "跳过空行";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.ForeColor = System.Drawing.Color.Red;
			this.label1.Location = new System.Drawing.Point(710, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(171, 38);
			this.label1.TabIndex = 4;
			this.label1.Text = "数据将会从左到右填充";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// ExcelWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(884, 561);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MinimumSize = new System.Drawing.Size(900, 600);
			this.Name = "ExcelWindow";
			this.Text = "Excel编辑器";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ExcelWindow_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.tableLayoutPanel4.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.row)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.column)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label labFileName;
		private System.Windows.Forms.DataGridView gridView;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button btnFinish;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.NumericUpDown row;
		private System.Windows.Forms.NumericUpDown column;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnReadExcel;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cobSheetName;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button btnDeleteColumn;
		private System.Windows.Forms.Button btnDeleteRow;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}

