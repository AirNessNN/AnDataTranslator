using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace AnData.Class {

	/// <summary>
	/// 表示一个数据集合的包装类
	/// </summary>
	public class QueueData {

		/// <summary>
		/// 数据集合
		/// </summary>
		private Queue<object> data = null;

		/// <summary>
		/// 获取或设置集合的名字
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// 获取该集合包装类内部的所有元素
		/// </summary>
		public int Count {
			get {
				if (data == null)
					return 0;
				return data.Count;
			}
		}



		/// <summary>
		/// 移除并返回头部的元素，空栈则抛出异常
		/// </summary>
		/// <returns></returns>
		public object Poll () {
			if (null == data)
				return null;
			return data.Dequeue( );
		}

		/// <summary>
		/// 在队尾添加一个元素
		/// </summary>
		/// <param name="value"></param>
		public void Pull (object value) {
			if (null == data)
				data = new Queue<object>( );
			if (null == value)
				return;
			data.Enqueue(value);
		}

		/// <summary>
		/// 返回一个索引所在位置的元素，不存在返回null
		/// </summary>
		/// <param name="index"></param>
		/// <returns></returns>
		public object Get(int index ) {
			if (null == data)
				return null;
			if (!(data.Count > index))
				return null;
			return data.ElementAt(index);
		}


		public object[] ToArray () {
			if (data == null)
				return null;
			return data.ToArray( );
		}

		public Queue<object> GetQueue () {
			return data;
		}
	}
}
