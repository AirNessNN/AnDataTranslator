using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace AnData.Class {

	public class DatabaseFile : DataFile {

		public string DBDirectory { get { return new FileInfo(FileName).DirectoryName; } }

		public string Name { get { return new FileInfo(FileName).Name; } }

		public DatabaseFile(string fileName ) {
			if (!File.Exists(fileName))
				return;
			FileName = fileName;
			IsLoaded = true;
		}



		/// <summary>
		/// 获取DBF的DataTable
		/// </summary>
		/// <param name="tableName"></param>
		/// <param name="defaultDir"></param>
		/// <returns></returns>
		public DataTable GetDbfData ( string tableName) {
			if (!Loaded)
				return null;

			string mulu = DBDirectory;
			OleDbConnection conn = GetOpenedConnection();

			string sql = string.Format(@"select * from "+tableName);
			OleDbDataAdapter odbcDataAdapt = new OleDbDataAdapter(sql,conn);
			DataTable dtData = new DataTable( );
			odbcDataAdapt.Fill(dtData);
			conn.Close( );
			return dtData;
		}


		/// <summary>
		/// 测试连接，连接成功则返回数据表的版本信息
		/// </summary>
		/// <returns></returns>
		public string TestConnection () {
			if (!Loaded)
				return null;

			OleDbConnection con = GetOpenedConnection( );
			if (con == null)
				return null;
			string version = con.ServerVersion;
			con.Close( );
			return version;
		}

		/// <summary>
		/// 创建一个已经打开的数据库连接实例
		/// </summary>
		/// <returns></returns>
		public OleDbConnection GetOpenedConnection () {
			if (!Loaded)
				return null;

			FileInfo fi = new FileInfo(FileName);
			string mulu = fi.DirectoryName;
			string filename = fi.Name;
			OleDbConnection conn = new OleDbConnection( );
			string connStr = @"Driver={Microsoft Visual FoxPro Driver};Provider=VFPOLEDB;Data Source=" + mulu + ";Collating Sequence=machine;";
			conn.ConnectionString = connStr;
			try {
				conn.Open( );
			}catch(Exception ex) {
				Debug.WriteLine(ex.Message);
				return null;
			}
			return conn;
		}


		public override void Close () {
			throw new NotImplementedException( );
		}

		public override bool ReadFile ( string path ) {
			throw new NotImplementedException( );
		}

		public override bool WriteFile () {
			throw new NotImplementedException( );
		}

		public override bool WriteFile ( string path ) {
			throw new NotImplementedException( );
		}

		public void debug ( object name ) {
			Debug.WriteLine(name);
		}
	}
}
