using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnData.Component {
	public partial class MessageDialog : Form {

		private static MessageDialog dialog;

		private MessageDialog () {
			InitializeComponent( );
		}

		public static  DialogResult ShowMessageDialog () {
			dialog = new MessageDialog( );

			return dialog.ShowDialog( );
		}
	}
}
