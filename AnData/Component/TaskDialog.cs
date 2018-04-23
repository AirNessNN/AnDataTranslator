using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnData.Component {
	public partial class TaskDialog : Form {

		public string Title {
			get {
				return labTitle.Text;
			}
			set {
				labTitle.Text = value;
				
			}
		}

		public string Info {
			get {
				return tbInfo.Text;
			}
			set {
				tbInfo.Text += value + "\r\n";
				tbInfo.SelectionStart = tbInfo.TextLength;
				tbInfo.ScrollToCaret( );
			}
		}

		public TaskDialog () {
			InitializeComponent( );
			Control.CheckForIllegalCrossThreadCalls = false;
		}

		public void SetCursor(bool b ) {
			if (b) {
				this.Cursor = Cursors.Arrow;
				this.labTitle.Cursor = Cursors.Arrow;
				this.tbInfo.Cursor = Cursors.Arrow;
			}else {
				this.Cursor = Cursors.WaitCursor;
				this.labTitle.Cursor = Cursors.WaitCursor;
				this.tbInfo.Cursor = Cursors.WaitCursor;
			}
		}
	}
}
