using System;
using System.Data;
using System.Windows.Forms;

namespace AnData {
	public partial class ExcelWindow : Form {

		/// <summary>
		/// Excel操作类
		/// </summary>
		private ExcelFile excel = null;

		/// <summary>
		/// 缓存表格
		/// </summary>
		private DataTable dt = null;

		/// <summary>
		/// 委托事件，完成之后自动回调
		/// </summary>
		/// <param name="dt"></param>
		public delegate void Callback ( DataTable dt );

		/// <summary>
		/// 回调
		/// </summary>
		public Callback callback;



		#region 属性
		public bool IsSelected {
			get {
				return false;
			}
		}

		/// <summary>
		/// 文件名
		/// </summary>
		public string FileName {
			get {
				return labFileName.Text;
			}
			set {
				labFileName.Text = value;
			}
		}

		/// <summary>
		/// 行起始
		/// </summary>
		public int RowStart {
			get {
				return (int)row.Value;
			}
			set {
				row.Value = value;
			}
		}

		/// <summary>
		/// 列起始
		/// </summary>
		public int ColumnStart {
			get {
				return (int)column.Value;
			}
			set {
				column.Value = value;
			}
		}

		/// <summary>
		/// 表名
		/// </summary>
		public string SheetName {
			get {
				return (string)cobSheetName.SelectedItem;
			}
		}

		public DataTable Data { get { return dt; } }
		#endregion

		public ExcelWindow (string path) {
			//加载控件
			InitializeComponent( );

			//控件设置
			//dataGridView.AllowUserToOrderColumns = false;

			//加载数据
			InitializeData(path);
		}

		public ExcelWindow(string path,int row ) {
			InitializeComponent( );

			InitializeData(path );

			this.row.Value = row;
		}

		public void InitializeData(string path ) {
			excel = new ExcelFile( );
			FileName = path;
			if (!excel.ReadFile(path)) {
				MessageBox.Show("无法读取文件，请检查文件占用情况。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				this.Close( );
				return;
			}
			RowStart = 1;
			ColumnStart = 1;
		}

		//窗口加载
		private void ExcelWindow_Load ( object sender, EventArgs e ) {
			cobSheetName.DataSource = excel.GetSheetName( );//枚举表名
		}





		//完成
		private void btnFinish_Click ( object sender, EventArgs e ) {
			callback?.Invoke(dt);//完成回调
			this.Close( );
		}

		//读取表单
		private void btnReadExcel_Click ( object sender, EventArgs e ) {
			gridView.DataSource = null;
			dt = null;

			dt= excel.GetDataTable(SheetName, RowStart-1, ColumnStart-1);
			if (dt == null) {
				MessageBox.Show("读取失败，此表可能是空表，请重新选择", "读取错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
				
			gridView.DataSource = dt;

			btnReadExcel.Text = "重新读取Excel";
		}

		//删除列
		private void btnDeleteColumn_Click ( object sender, EventArgs e ) {
			dt.Columns.RemoveAt(gridView.SelectedCells[0].ColumnIndex);
			gridView.ClearSelection( );
		}

		//删除行
		private void btnDeleteRow_Click ( object sender, EventArgs e ) {
			dt.Rows.RemoveAt(gridView.CurrentRow.Index);
			gridView.ClearSelection( );
		}

		private void checkBox1_CheckedChanged ( object sender, EventArgs e ) {
			excel.SkipNullRow = checkBox1.Checked;
		}
	}
}
