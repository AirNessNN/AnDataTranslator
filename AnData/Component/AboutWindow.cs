using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnData.Component {
	public partial class AboutWindow : Form {
		public AboutWindow () {
			InitializeComponent( );
			label7.Text = "版本：" + Convert.ToString(Program.Version);
		}
	}
}
