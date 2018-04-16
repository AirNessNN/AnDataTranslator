using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnData.Interface {
	/// <summary>
	/// 定义任务的标准
	/// </summary>
	 public interface ITask {

		string TargetPath { get; set; }

		string ModelPath { get; set; }

		bool Loaded { get; }

		/// <summary>
		/// 开始任务
		/// </summary>
		void Start ();

		/// <summary>
		/// 停止任务
		/// </summary>
		void Stop ();

		/// <summary>
		/// 销毁该任务，并且释放资源
		/// </summary>
		void Dispose ();

		/// <summary>
		/// 设置状态监听器
		/// </summary>
		/// <param name="I"></param>
		void SetTaskListener ( ITaskListener I );
	}
}
