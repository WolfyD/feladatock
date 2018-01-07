using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace feladatok
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();

			Point p = new Point(1,1);
		}

		private void btn_Reverse_MouseClick(object sender, MouseEventArgs e)
		{
			f_reverse fr1 = new f_reverse();
			fr1.ShowDialog();

		}

		private void btn_TextEditor_Click(object sender, EventArgs e)
		{
			f_Editor fe = new f_Editor();
			fe.ShowDialog();
		}
	}

	public class xy
	{
		public Point pnt { get; set; }
		public int x { get { return pnt.X; } }
		public int y { get { return pnt.Y; } }
	}
}
