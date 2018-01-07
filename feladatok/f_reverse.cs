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
	public partial class f_reverse : Form
	{
		public f_reverse()
		{
			InitializeComponent();
		}

		private void btn_Reverse_Click(object sender, EventArgs e)
		{
			//Ellenőrizzük, hogy van-e szöveg a dobozban
			if (tb_Text.Text != "")
			{
				//Letároljuk a szöveget a dobozból
				string txt = tb_Text.Text;
				//Kiszedjük a hosszát
				int len = txt.Length;

				//Temporary változó
				string tmp = "";

				//For loop (a hossztól nulláig)
				//az első elem hiányzik mert már létrehoztuk feljebb
				for(; len > 0; len--)
				{
					//Hozzáadjuk a temporary változóhoz a len-1-edik karaktert a szövegből
					tmp += txt[len - 1];
				}

				//Kiíratjuk az eredményt
				lbl_ReversedText.Text = tmp;
			}
		}

		private void btn_Copy_Click(object sender, EventArgs e)
		{
			//Vágólapra helyezzük a label tartalmát
			Clipboard.SetText(lbl_ReversedText.Text);
		}
	}
}
