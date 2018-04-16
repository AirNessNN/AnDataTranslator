using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;


namespace AnData {
	/// <summary>
	/// 文件抽象类
	/// </summary>
	public abstract class DataFile {

		/// <summary>
		/// 本文件的绝对路径
		/// </summary>
		public string FilePath { get { return fileName; }set { fileName = value; } }

		/// <summary>
		/// 文件的名字,如果写入，则使用这个名字
		/// </summary>
		public string FileName { get; set; }

		/// <summary>
		/// 文件是否存在
		/// </summary>
		public bool FileExist { get { return File.Exists(FilePath); } }

		/// <summary>
		/// 是否已经加载
		/// </summary>
		public bool Loaded { get { return isLoaded; } }

		/// <summary>
		/// 供内部使用，设置加载状态
		/// </summary>
		protected bool IsLoaded { set { isLoaded = value; } }

		private bool isLoaded = false;
		private bool isFileExist = false;
		private string fileName = "";



		/// <summary>
		/// 获取FileInfo实例对象
		/// </summary>
		/// <returns></returns>
		public FileInfo GetFile () {
			if (FilePath == null || FilePath == "")
				return null;
			return new FileInfo(FilePath);
		}

		public abstract bool ReadFile ( string path );

		public abstract bool WriteFile ( string path );

		public abstract bool WriteFile ();

		public abstract void Close ();

	}
}