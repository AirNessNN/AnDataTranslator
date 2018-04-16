using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.SS.Util;
using NPOI.XSSF.UserModel;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AnData {
	/// <summary>
	/// Excel文件实例
	/// 
	/// </summary>
	public class ExcelFile : DataFile {

		#region 常量
		/// <summary>
		/// Xlsx文档模式
		/// </summary>
		public const int MODE_XLSX = 0;

		/// <summary>
		/// Xls文档模式
		/// </summary>
		public const int MODE_XLS = 1;
		#endregion

		#region 私有变量
		//私有变量
		/// <summary>
		/// 文件流：读取Excel文件
		/// </summary>
		private FileStream fs = null;

		/// <summary>
		/// Excel工作簿：用来操作整个xlsx或xls文档
		/// </summary>
		private IWorkbook workbook = null;

		/// <summary>
		/// true是07版本，反之是03版本
		/// 07用XSSFWorkbook
		/// 03用HSSFWorkbook
		/// </summary>
		private bool isXlsx = false;
		#endregion

		#region 属性
		/// <summary>
		/// 获取ExcelFile的模式
		/// </summary>
		public bool IsCreateModel { get; private set; }

		#endregion





		/// <summary>
		/// 空参构造函数
		/// </summary>
		public ExcelFile () {}


		/// <summary>
		/// 创建一个标准的Xlsx文件并直接写入文件
		/// </summary>
		/// <param name="filePath">文件名字</param>
		/// <returns></returns>
		public bool CreateWorkbook (string filePath) {
			if (filePath == "")
				return false;

			isXlsx = true;//设置XLSX模式
			IsCreateModel = true;//设置模式

			//创建Workbook和Sheet
			workbook = new XSSFWorkbook( );
			workbook.CreateSheet("Sheet1");
			workbook.CreateSheet("Sheet2");
			workbook.CreateSheet("Sheet3");

			//写入
			WriteFile(filePath);

			//完成
			IsLoaded = true;
			return true;
		}
		

		/// <summary>
		/// 替换工作表名称
		/// </summary>
		/// <param name="oldName">旧表名</param>
		/// <param name="newName">新表名</param>
		/// <returns></returns>
		public bool ReplaceSheetName (string oldName,string newName) {
			if (oldName == "")
				return false;
			if (newName == "")
				return false;

			int index = workbook.GetSheetIndex(oldName);
			if (index < 0)
				return false;
			workbook.SetSheetName(index, newName);
			//保存更改
			WriteFile( );
			return true;
		}


		/// <summary>
		/// 填充数据
		/// </summary>
		/// <param name="dt"></param>
		/// <param name="sheetName">工作表名称</param>
		/// <param name="tableName">表的标题</param>
		/// <returns></returns>
		public bool FillData (DataTable dt,string sheetName,string tableName) {
			if (dt == null)
				return false;
			if (sheetName == "")
				return false;

			if (!Loaded)
				return false;

			ISheet sheet = null;
			int index = workbook.GetSheetIndex(sheetName);
			if (index < 0)
				sheet = workbook.CreateSheet(sheetName);
			else
				sheet = workbook.GetSheetAt(index);


			//获取表头
			int columnSize = dt.Columns.Count;
			if (columnSize < 1)
				return false;

			//在A1创建一个单元格
			IRow row = sheet.CreateRow(0);
			ICell cell = row.CreateCell(0);
			//设置标题
			cell.SetCellValue(tableName);
			//创建样式
			ICellStyle style = workbook.CreateCellStyle( );
			style.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;//设置居中
			IFont font = workbook.CreateFont( );
			font.FontHeight = 20 * 20;
			style.SetFont(font);
			cell.CellStyle = style;
			//合并单元格
			sheet.AddMergedRegion(new CellRangeAddress(0, 0, 0, columnSize - 1));

			//填充数据
			string[] heads = new string[dt.Columns.Count];
			for(int i = 0; i < heads.Length; i++) {
				heads[i] = dt.Columns[i].ToString( );

			}

			return true;
		}

		/// <summary>
		/// 根据读取的Excel返回一个DataTable表
		/// </summary>
		/// <param name="sheetName">要读取数据的表名</param>
		/// <param name="rowIndex">行索引：从0开始计数</param>
		/// <param name="columnIndex">列索引：从0开始计数</param>
		/// <returns></returns>
		public DataTable GetDataTable (string sheetName, int rowIndex, int columnIndex) {
			if (!Loaded)//未加载
				return null;

			ISheet sheet = null;//工作表对象

			int startRow = 0;//开始的行数，用于定位表头之后的数据起始点

			IFormulaEvaluator evalor = null;//动态公式计算器
			if (isXlsx)//判断07还是03版本
				evalor = new XSSFFormulaEvaluator(workbook);
			else
				evalor = new HSSFFormulaEvaluator(workbook);


			//实例DataTable
			DataTable dt = new DataTable( );



			if (sheetName != null) {
				sheet = workbook.GetSheet(sheetName);
				if (sheet == null) {
					sheet = workbook.GetSheetAt(0);
				}
			} else {
				sheet = workbook.GetSheetAt(0);
			}
			
			//实际操作
			if (sheet != null) {
				sheet.ForceFormulaRecalculation = true;//自动计算函数
				IRow header = sheet.GetRow(rowIndex);

				if (header == null) {
					return null;
				}

				int cellCount = header.LastCellNum;//列数
				//表头的处理
				for (int i = columnIndex; i < cellCount; i++) {
					ICell cell = header.GetCell(i);//循环获第一行所有的值
					if (cell != null) {
						string cellValue = null;
						try {
							cellValue = cell.StringCellValue;
						} catch {
							cellValue = "*";
						}
						if (cellValue != null) {
							DataColumn column = new DataColumn(cellValue);//转换成Data列
							try {
								dt.Columns.Add(column);//添加到DataTable
							} catch {
								DataColumn _column = new DataColumn(cellValue+"_r");//转换成Data列
								dt.Columns.Add(_column);//添加到DataTable
							}
						}
					}
				}
				startRow = 1 + rowIndex;//开始行数+1


				//获取最后一行标号
				int rowCount = sheet.LastRowNum;
				for (int i = startRow; i < rowCount; i++) {

					IRow row = sheet.GetRow(i);//获取行

					if (row == null)//无行则跳过本次循环
						continue;

					DataRow dataRow = dt.NewRow( );//创建新行
					
					//循环单行内的元素：从此行的开始元素开始录入，到表头的尾元素结束
					for (int j = columnIndex ; j < cellCount; j++) {
						if (row.GetCell(j) != null) {
							//判断格式为函数
							var cell = row.GetCell(j);

							if (cell.CellType == CellType.Formula) {
								var formulaValue = evalor.Evaluate(cell);
								if (formulaValue.CellType == CellType.Numeric)
									dataRow[j] = Convert.ToString(formulaValue.NumberValue);
								if (formulaValue.CellType == CellType.Numeric)
									dataRow[j] = formulaValue.StringValue;
								dataRow[j] = Convert.ToString(formulaValue.NumberValue);
							} else {
								//将数据添加到dataRow中
								try {
									//j-columnIndex录入的是dataRow，下标不可能超过个数，所以要减去columnIndex
									dataRow[j-columnIndex] = cell.ToString( );
								} catch(Exception ex) {
									Debug.WriteLine("出错的下标："+j);
									string text = ex.Message + "请尝试从下一行开始。";
									MessageBox.Show(text, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
									return dt;
								}
							}
						}
					}
					dt.Rows.Add(dataRow);//添加到DataTable
				}
			}
			return dt;
		}


		/// <summary>
		/// 根据读取的Excel返回一个DataTable表，下标从0,0开始
		/// </summary>
		/// <param name="sheetName">要读取数据的表名</param>
		/// <returns></returns>
		public DataTable GetDataTable (string sheetName) {
			return GetDataTable(sheetName, 0, 0);
		}


		/// <summary>
		/// 获取该工作簿的Sheet名称枚举
		/// 返回：string[]
		/// </summary>
		/// <returns>返回一个string数组</returns>
		public string[] GetSheetName () {
			if (!Loaded)
				return null;
			if (workbook.NumberOfSheets == 0)
				return null;

			string[] sheetNames = new string[workbook.NumberOfSheets];
			for(int i = 0; i < workbook.NumberOfSheets; i++) {
				sheetNames[i] = workbook.GetSheetName(i);
			}
			return sheetNames;
		}


		/// <summary>
		/// 关闭并释放文件资源
		/// </summary>
		public void CloseFile () {
			try {
				if (fs != null)
					fs.Close( );
				fs = null;
			} catch {
				return;
			}
		}


		/// <summary>
		/// 载入文件，以便后续对Excel进行操作
		/// </summary>
		/// <param name="path"></param>
		/// <returns></returns>
		public override bool ReadFile ( string path ) {
			if (!File.Exists(path))
				return false;
			FilePath = path;

			if (Loaded) {
				this.CloseFile( );
			}


			//读取工作簿
			try {
				fs = new FileStream(path, FileMode.Open, FileAccess.Read);
			} catch (Exception ex) {
				MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
				fs = null;
				return false;
			}
			if (path.IndexOf(".xlsx") > 0) {
				isXlsx = true;
				workbook = new XSSFWorkbook(fs);
			}else if (path.IndexOf(".xls") > 0)
				workbook = new HSSFWorkbook(fs);

			if (workbook == null) {

				return false;
			}

			//确认加载完成
			CloseFile( );
			IsLoaded = true;
			return true;
		}

		public override bool WriteFile () {
			try {
				FileStream fs = new FileStream(FilePath, FileMode.Create);
				workbook.Write(fs);
				fs.Close( );
			} catch {
				return false;
			}
			return true;
		}

		public override bool WriteFile ( string path ) {
			try {
				FileStream fs = new FileStream(path, FileMode.Create);
				workbook.Write(fs);
				fs.Close( );
			} catch {
				return false;
			}
			return true;
		}

		public override void Close () {
			CloseFile( );
		}
	}
}