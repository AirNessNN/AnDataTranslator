namespace AnData.Component {
	partial class GuideWindow {
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuideWindow));
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnPrevious = new System.Windows.Forms.Button();
			this.btnNext = new System.Windows.Forms.Button();
			this.btnFinish = new System.Windows.Forms.Button();
			this.mainPanel1 = new System.Windows.Forms.Panel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.startPage = new System.Windows.Forms.TabPage();
			this.label2 = new System.Windows.Forms.Label();
			this.excelPage = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.btnReadExcel = new System.Windows.Forms.Button();
			this.labExcelType = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.labExcelInfo = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnExcelFiltarte = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.btnSelectExcelFile = new System.Windows.Forms.Button();
			this.tbExcelPath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.modelPage = new System.Windows.Forms.TabPage();
			this.labModelValueInfo = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.tbMark = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnEditModel = new System.Windows.Forms.Button();
			this.labMarkCount = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnWordFileRead = new System.Windows.Forms.Button();
			this.btnWordFileSelection = new System.Windows.Forms.Button();
			this.tbWordFilePath = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.wordDirectoryPage = new System.Windows.Forms.TabPage();
			this.tst2 = new System.Windows.Forms.Label();
			this.tst1 = new System.Windows.Forms.Label();
			this.tbFileName = new System.Windows.Forms.TextBox();
			this.cbExcelColumnName = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.rdUserName = new System.Windows.Forms.RadioButton();
			this.rdExcelColumnName = new System.Windows.Forms.RadioButton();
			this.label12 = new System.Windows.Forms.Label();
			this.btnWordDirectorySelection = new System.Windows.Forms.Button();
			this.tbDirectory = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label14 = new System.Windows.Forms.Label();
			this.labTitle = new System.Windows.Forms.Label();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.mainPanel1.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.startPage.SuspendLayout();
			this.excelPage.SuspendLayout();
			this.modelPage.SuspendLayout();
			this.wordDirectoryPage.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.mainPanel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.labTitle, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(603, 411);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnPrevious);
			this.panel1.Controls.Add(this.btnNext);
			this.panel1.Controls.Add(this.btnFinish);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 368);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(597, 40);
			this.panel1.TabIndex = 1;
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.Location = new System.Drawing.Point(276, 8);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "取消";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnPrevious.Enabled = false;
			this.btnPrevious.Location = new System.Drawing.Point(357, 8);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(75, 23);
			this.btnPrevious.TabIndex = 2;
			this.btnPrevious.Text = "上一步";
			this.btnPrevious.UseVisualStyleBackColor = true;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnNext
			// 
			this.btnNext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnNext.Location = new System.Drawing.Point(438, 8);
			this.btnNext.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(75, 23);
			this.btnNext.TabIndex = 1;
			this.btnNext.Text = "下一步";
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnFinish
			// 
			this.btnFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnFinish.Enabled = false;
			this.btnFinish.Location = new System.Drawing.Point(519, 8);
			this.btnFinish.Name = "btnFinish";
			this.btnFinish.Size = new System.Drawing.Size(75, 23);
			this.btnFinish.TabIndex = 0;
			this.btnFinish.Text = "完成";
			this.btnFinish.UseVisualStyleBackColor = true;
			this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
			// 
			// mainPanel1
			// 
			this.mainPanel1.Controls.Add(this.tabControl);
			this.mainPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainPanel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.mainPanel1.Location = new System.Drawing.Point(0, 73);
			this.mainPanel1.Margin = new System.Windows.Forms.Padding(0);
			this.mainPanel1.Name = "mainPanel1";
			this.mainPanel1.Size = new System.Drawing.Size(603, 292);
			this.mainPanel1.TabIndex = 3;
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.startPage);
			this.tabControl.Controls.Add(this.excelPage);
			this.tabControl.Controls.Add(this.modelPage);
			this.tabControl.Controls.Add(this.wordDirectoryPage);
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Font = new System.Drawing.Font("微软雅黑 Light", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tabControl.Location = new System.Drawing.Point(0, -26);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(604, 323);
			this.tabControl.TabIndex = 0;
			// 
			// startPage
			// 
			this.startPage.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.startPage.Controls.Add(this.label2);
			this.startPage.Location = new System.Drawing.Point(4, 26);
			this.startPage.Name = "startPage";
			this.startPage.Padding = new System.Windows.Forms.Padding(3);
			this.startPage.Size = new System.Drawing.Size(596, 293);
			this.startPage.TabIndex = 0;
			this.startPage.Text = "startPage";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label2.Location = new System.Drawing.Point(4, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(378, 17);
			this.label2.TabIndex = 1;
			this.label2.Text = "此任务向导可以帮助您完成Excel列表数据到多页Word文档转换的设置";
			// 
			// excelPage
			// 
			this.excelPage.Controls.Add(this.label6);
			this.excelPage.Controls.Add(this.btnReadExcel);
			this.excelPage.Controls.Add(this.labExcelType);
			this.excelPage.Controls.Add(this.label5);
			this.excelPage.Controls.Add(this.labExcelInfo);
			this.excelPage.Controls.Add(this.label4);
			this.excelPage.Controls.Add(this.btnExcelFiltarte);
			this.excelPage.Controls.Add(this.label3);
			this.excelPage.Controls.Add(this.btnSelectExcelFile);
			this.excelPage.Controls.Add(this.tbExcelPath);
			this.excelPage.Controls.Add(this.label1);
			this.excelPage.Location = new System.Drawing.Point(4, 26);
			this.excelPage.Name = "excelPage";
			this.excelPage.Padding = new System.Windows.Forms.Padding(3);
			this.excelPage.Size = new System.Drawing.Size(596, 293);
			this.excelPage.TabIndex = 1;
			this.excelPage.Text = "excelPage";
			this.excelPage.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(272, 52);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(80, 17);
			this.label6.TabIndex = 10;
			this.label6.Text = "推荐进行筛选";
			// 
			// btnReadExcel
			// 
			this.btnReadExcel.Location = new System.Drawing.Point(521, 11);
			this.btnReadExcel.Name = "btnReadExcel";
			this.btnReadExcel.Size = new System.Drawing.Size(69, 23);
			this.btnReadExcel.TabIndex = 9;
			this.btnReadExcel.Text = "读取";
			this.btnReadExcel.UseVisualStyleBackColor = true;
			this.btnReadExcel.Click += new System.EventHandler(this.btnReadExcel_Click);
			// 
			// labExcelType
			// 
			this.labExcelType.AutoSize = true;
			this.labExcelType.Location = new System.Drawing.Point(82, 86);
			this.labExcelType.Name = "labExcelType";
			this.labExcelType.Size = new System.Drawing.Size(68, 17);
			this.labExcelType.TabIndex = 8;
			this.labExcelType.Text = "未选择文件";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(8, 86);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(68, 17);
			this.label5.TabIndex = 7;
			this.label5.Text = "文件类型：";
			// 
			// labExcelInfo
			// 
			this.labExcelInfo.AutoSize = true;
			this.labExcelInfo.Location = new System.Drawing.Point(82, 117);
			this.labExcelInfo.Name = "labExcelInfo";
			this.labExcelInfo.Size = new System.Drawing.Size(68, 17);
			this.labExcelInfo.TabIndex = 6;
			this.labExcelInfo.Text = "未读取行列";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(8, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 17);
			this.label4.TabIndex = 5;
			this.label4.Text = "有效数据：";
			// 
			// btnExcelFiltarte
			// 
			this.btnExcelFiltarte.Enabled = false;
			this.btnExcelFiltarte.Location = new System.Drawing.Point(169, 49);
			this.btnExcelFiltarte.Name = "btnExcelFiltarte";
			this.btnExcelFiltarte.Size = new System.Drawing.Size(75, 23);
			this.btnExcelFiltarte.TabIndex = 4;
			this.btnExcelFiltarte.Text = "启动筛选";
			this.btnExcelFiltarte.UseVisualStyleBackColor = true;
			this.btnExcelFiltarte.Click += new System.EventHandler(this.btnExcelFiltarte_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(155, 17);
			this.label3.TabIndex = 3;
			this.label3.Text = "对Excel文件进行数据筛选：";
			// 
			// btnSelectExcelFile
			// 
			this.btnSelectExcelFile.Location = new System.Drawing.Point(487, 11);
			this.btnSelectExcelFile.Name = "btnSelectExcelFile";
			this.btnSelectExcelFile.Size = new System.Drawing.Size(28, 23);
			this.btnSelectExcelFile.TabIndex = 2;
			this.btnSelectExcelFile.Text = "...";
			this.btnSelectExcelFile.UseVisualStyleBackColor = true;
			this.btnSelectExcelFile.Click += new System.EventHandler(this.btnSelectFile_Click);
			// 
			// tbExcelPath
			// 
			this.tbExcelPath.Location = new System.Drawing.Point(109, 11);
			this.tbExcelPath.Name = "tbExcelPath";
			this.tbExcelPath.Size = new System.Drawing.Size(372, 23);
			this.tbExcelPath.TabIndex = 1;
			this.tbExcelPath.TextChanged += new System.EventHandler(this.tbExcelPath_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 14);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "*Excel文件路径：";
			// 
			// modelPage
			// 
			this.modelPage.Controls.Add(this.labModelValueInfo);
			this.modelPage.Controls.Add(this.label11);
			this.modelPage.Controls.Add(this.tbMark);
			this.modelPage.Controls.Add(this.label10);
			this.modelPage.Controls.Add(this.btnEditModel);
			this.modelPage.Controls.Add(this.labMarkCount);
			this.modelPage.Controls.Add(this.label8);
			this.modelPage.Controls.Add(this.btnWordFileRead);
			this.modelPage.Controls.Add(this.btnWordFileSelection);
			this.modelPage.Controls.Add(this.tbWordFilePath);
			this.modelPage.Controls.Add(this.label7);
			this.modelPage.Location = new System.Drawing.Point(4, 26);
			this.modelPage.Name = "modelPage";
			this.modelPage.Padding = new System.Windows.Forms.Padding(3);
			this.modelPage.Size = new System.Drawing.Size(596, 293);
			this.modelPage.TabIndex = 2;
			this.modelPage.Text = "tabPage1";
			this.modelPage.UseVisualStyleBackColor = true;
			// 
			// labModelValueInfo
			// 
			this.labModelValueInfo.AutoSize = true;
			this.labModelValueInfo.Location = new System.Drawing.Point(8, 125);
			this.labModelValueInfo.Name = "labModelValueInfo";
			this.labModelValueInfo.Size = new System.Drawing.Size(0, 17);
			this.labModelValueInfo.TabIndex = 19;
			this.labModelValueInfo.Visible = false;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.ForeColor = System.Drawing.SystemColors.MenuHighlight;
			this.label11.Location = new System.Drawing.Point(220, 52);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(349, 17);
			this.label11.TabIndex = 18;
			this.label11.Text = "（标记不宜过长，会影响解析速度，推荐的标记如：##   %m ）";
			// 
			// tbMark
			// 
			this.tbMark.Location = new System.Drawing.Point(113, 49);
			this.tbMark.Name = "tbMark";
			this.tbMark.Size = new System.Drawing.Size(101, 23);
			this.tbMark.TabIndex = 17;
			this.tbMark.TextChanged += new System.EventHandler(this.tbMark_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(6, 52);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(97, 17);
			this.label10.TabIndex = 16;
			this.label10.Text = "*设置您的标记：";
			// 
			// btnEditModel
			// 
			this.btnEditModel.Enabled = false;
			this.btnEditModel.Location = new System.Drawing.Point(512, 264);
			this.btnEditModel.Name = "btnEditModel";
			this.btnEditModel.Size = new System.Drawing.Size(75, 23);
			this.btnEditModel.TabIndex = 15;
			this.btnEditModel.Text = "编辑模板";
			this.btnEditModel.UseVisualStyleBackColor = true;
			this.btnEditModel.Click += new System.EventHandler(this.btnEditModel_Click);
			// 
			// labMarkCount
			// 
			this.labMarkCount.AutoSize = true;
			this.labMarkCount.Location = new System.Drawing.Point(116, 93);
			this.labMarkCount.Name = "labMarkCount";
			this.labMarkCount.Size = new System.Drawing.Size(15, 17);
			this.labMarkCount.TabIndex = 14;
			this.labMarkCount.Text = "0";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 93);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(104, 17);
			this.label8.TabIndex = 13;
			this.label8.Text = "找到的标记数量：";
			// 
			// btnWordFileRead
			// 
			this.btnWordFileRead.Enabled = false;
			this.btnWordFileRead.Location = new System.Drawing.Point(431, 264);
			this.btnWordFileRead.Name = "btnWordFileRead";
			this.btnWordFileRead.Size = new System.Drawing.Size(75, 23);
			this.btnWordFileRead.TabIndex = 12;
			this.btnWordFileRead.Text = "读取信息";
			this.btnWordFileRead.UseVisualStyleBackColor = true;
			this.btnWordFileRead.Click += new System.EventHandler(this.btnWordFileRead_Click);
			// 
			// btnWordFileSelection
			// 
			this.btnWordFileSelection.Location = new System.Drawing.Point(559, 11);
			this.btnWordFileSelection.Name = "btnWordFileSelection";
			this.btnWordFileSelection.Size = new System.Drawing.Size(28, 23);
			this.btnWordFileSelection.TabIndex = 11;
			this.btnWordFileSelection.Text = "...";
			this.btnWordFileSelection.UseVisualStyleBackColor = true;
			this.btnWordFileSelection.Click += new System.EventHandler(this.btnWordFileSelection_Click);
			// 
			// tbWordFilePath
			// 
			this.tbWordFilePath.Location = new System.Drawing.Point(113, 11);
			this.tbWordFilePath.Name = "tbWordFilePath";
			this.tbWordFilePath.Size = new System.Drawing.Size(440, 23);
			this.tbWordFilePath.TabIndex = 10;
			this.tbWordFilePath.TextChanged += new System.EventHandler(this.tbWordFilePath_TextChanged);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 14);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(104, 17);
			this.label7.TabIndex = 0;
			this.label7.Text = "*Word模板文件：";
			// 
			// wordDirectoryPage
			// 
			this.wordDirectoryPage.Controls.Add(this.tst2);
			this.wordDirectoryPage.Controls.Add(this.tst1);
			this.wordDirectoryPage.Controls.Add(this.tbFileName);
			this.wordDirectoryPage.Controls.Add(this.cbExcelColumnName);
			this.wordDirectoryPage.Controls.Add(this.label13);
			this.wordDirectoryPage.Controls.Add(this.rdUserName);
			this.wordDirectoryPage.Controls.Add(this.rdExcelColumnName);
			this.wordDirectoryPage.Controls.Add(this.label12);
			this.wordDirectoryPage.Controls.Add(this.btnWordDirectorySelection);
			this.wordDirectoryPage.Controls.Add(this.tbDirectory);
			this.wordDirectoryPage.Controls.Add(this.label9);
			this.wordDirectoryPage.Location = new System.Drawing.Point(4, 26);
			this.wordDirectoryPage.Name = "wordDirectoryPage";
			this.wordDirectoryPage.Padding = new System.Windows.Forms.Padding(3);
			this.wordDirectoryPage.Size = new System.Drawing.Size(596, 293);
			this.wordDirectoryPage.TabIndex = 3;
			this.wordDirectoryPage.Text = "tabPage1";
			this.wordDirectoryPage.UseVisualStyleBackColor = true;
			// 
			// tst2
			// 
			this.tst2.AutoSize = true;
			this.tst2.Location = new System.Drawing.Point(55, 126);
			this.tst2.Name = "tst2";
			this.tst2.Size = new System.Drawing.Size(271, 17);
			this.tst2.TabIndex = 10;
			this.tst2.Text = "示例：填入的名称_1.docx   |   填入的名称_2.docx";
			this.tst2.Visible = false;
			// 
			// tst1
			// 
			this.tst1.AutoSize = true;
			this.tst1.Location = new System.Drawing.Point(55, 126);
			this.tst1.Name = "tst1";
			this.tst1.Size = new System.Drawing.Size(88, 17);
			this.tst1.TabIndex = 9;
			this.tst1.Text = "示例：xxx.docx";
			// 
			// tbFileName
			// 
			this.tbFileName.Location = new System.Drawing.Point(58, 87);
			this.tbFileName.Name = "tbFileName";
			this.tbFileName.Size = new System.Drawing.Size(100, 23);
			this.tbFileName.TabIndex = 8;
			this.tbFileName.Visible = false;
			// 
			// cbExcelColumnName
			// 
			this.cbExcelColumnName.FormattingEnabled = true;
			this.cbExcelColumnName.Location = new System.Drawing.Point(58, 87);
			this.cbExcelColumnName.MaxDropDownItems = 100;
			this.cbExcelColumnName.Name = "cbExcelColumnName";
			this.cbExcelColumnName.Size = new System.Drawing.Size(121, 25);
			this.cbExcelColumnName.TabIndex = 7;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(8, 90);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(44, 17);
			this.label13.TabIndex = 6;
			this.label13.Text = "命名：";
			// 
			// rdUserName
			// 
			this.rdUserName.AutoSize = true;
			this.rdUserName.Location = new System.Drawing.Point(275, 52);
			this.rdUserName.Name = "rdUserName";
			this.rdUserName.Size = new System.Drawing.Size(122, 21);
			this.rdUserName.TabIndex = 5;
			this.rdUserName.Text = "自定命名并且排序";
			this.rdUserName.UseVisualStyleBackColor = true;
			this.rdUserName.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// rdExcelColumnName
			// 
			this.rdExcelColumnName.AutoSize = true;
			this.rdExcelColumnName.Checked = true;
			this.rdExcelColumnName.Location = new System.Drawing.Point(140, 52);
			this.rdExcelColumnName.Name = "rdExcelColumnName";
			this.rdExcelColumnName.Size = new System.Drawing.Size(113, 21);
			this.rdExcelColumnName.TabIndex = 4;
			this.rdExcelColumnName.TabStop = true;
			this.rdExcelColumnName.Text = "从Excel列中选择";
			this.rdExcelColumnName.UseVisualStyleBackColor = true;
			this.rdExcelColumnName.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(6, 54);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(128, 17);
			this.label12.TabIndex = 3;
			this.label12.Text = "设置文件名命名方式：";
			// 
			// btnWordDirectorySelection
			// 
			this.btnWordDirectorySelection.Location = new System.Drawing.Point(559, 11);
			this.btnWordDirectorySelection.Name = "btnWordDirectorySelection";
			this.btnWordDirectorySelection.Size = new System.Drawing.Size(28, 23);
			this.btnWordDirectorySelection.TabIndex = 2;
			this.btnWordDirectorySelection.Text = "...";
			this.btnWordDirectorySelection.UseVisualStyleBackColor = true;
			this.btnWordDirectorySelection.Click += new System.EventHandler(this.btnWordDirectorySelection_Click);
			// 
			// tbDirectory
			// 
			this.tbDirectory.Location = new System.Drawing.Point(125, 11);
			this.tbDirectory.Name = "tbDirectory";
			this.tbDirectory.Size = new System.Drawing.Size(428, 23);
			this.tbDirectory.TabIndex = 1;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 14);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(116, 17);
			this.label9.TabIndex = 0;
			this.label9.Text = "*Word输出文件夹：";
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label14);
			this.tabPage1.Location = new System.Drawing.Point(4, 26);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(596, 293);
			this.tabPage1.TabIndex = 4;
			this.tabPage1.Text = "tabPage1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label14.Location = new System.Drawing.Point(8, 13);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(364, 17);
			this.label14.TabIndex = 0;
			this.label14.Text = "您已经完成了任务设置，现在您可以点击“完成”按钮完成本次向导。";
			// 
			// labTitle
			// 
			this.labTitle.AutoSize = true;
			this.labTitle.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.labTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.labTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.labTitle.Font = new System.Drawing.Font("微软雅黑 Light", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.labTitle.ForeColor = System.Drawing.Color.DodgerBlue;
			this.labTitle.Location = new System.Drawing.Point(3, 0);
			this.labTitle.Name = "labTitle";
			this.labTitle.Size = new System.Drawing.Size(597, 73);
			this.labTitle.TabIndex = 4;
			this.labTitle.Text = "欢迎使用An任务向导";
			this.labTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// GuideWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(603, 411);
			this.Controls.Add(this.tableLayoutPanel1);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GuideWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "任务向导";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.mainPanel1.ResumeLayout(false);
			this.tabControl.ResumeLayout(false);
			this.startPage.ResumeLayout(false);
			this.startPage.PerformLayout();
			this.excelPage.ResumeLayout(false);
			this.excelPage.PerformLayout();
			this.modelPage.ResumeLayout(false);
			this.modelPage.PerformLayout();
			this.wordDirectoryPage.ResumeLayout(false);
			this.wordDirectoryPage.PerformLayout();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnPrevious;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Button btnFinish;
		private System.Windows.Forms.Panel mainPanel1;
		private System.Windows.Forms.Label labTitle;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage startPage;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TabPage excelPage;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSelectExcelFile;
		private System.Windows.Forms.TextBox tbExcelPath;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnExcelFiltarte;
		private System.Windows.Forms.Label labExcelInfo;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label labExcelType;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnReadExcel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TabPage modelPage;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button btnWordFileRead;
		private System.Windows.Forms.Button btnWordFileSelection;
		private System.Windows.Forms.TextBox tbWordFilePath;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox tbMark;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btnEditModel;
		private System.Windows.Forms.Label labMarkCount;
		private System.Windows.Forms.TabPage wordDirectoryPage;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbDirectory;
		private System.Windows.Forms.Button btnWordDirectorySelection;
		private System.Windows.Forms.RadioButton rdUserName;
		private System.Windows.Forms.RadioButton rdExcelColumnName;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.ComboBox cbExcelColumnName;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox tbFileName;
		private System.Windows.Forms.Label tst1;
		private System.Windows.Forms.Label tst2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label labModelValueInfo;
	}
}