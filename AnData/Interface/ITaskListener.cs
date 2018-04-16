using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AnData.Interface {
	/// <summary>
	/// 任务监听器，实现监听接口以监听任务状态
	/// </summary>
	public interface ITaskListener {
		/// <summary>
		/// 状态改变方法
		/// </summary>
		/// <param name="operateIndex">正在操作的Index</param>
		/// <param name="valueCount">总数目</param>
		/// <param name="failCount">失败的数目</param>
		void StateChange (int operateIndex,int valueCount,int  failCount);
	}
}
