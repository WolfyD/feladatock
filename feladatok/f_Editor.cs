using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace feladatok
{
	public partial class f_Editor : Form
	{
		public f_Editor()
		{
			InitializeComponent();
		}

		public void openFile(string filename)
		{
			string str = File.ReadAllText(filename);
			tb_Text.Text = str;

			string fn = filename.Substring(filename.LastIndexOf("\\") + 1);
			Text = fn + " - Szövegszerkesztő";
		}

		private void btn_Menu_Open_Click(object sender, EventArgs e)
		{
			DialogResult d = ofd.ShowDialog();
			if(d == DialogResult.OK)
			{
				openFile(ofd.FileName);
			}
		}

		private void btn_Menu_Save_Click(object sender, EventArgs e)
		{
			DialogResult d = sfd.ShowDialog();
			if(d == DialogResult.OK)
			{
				try
				{
					if (!File.Exists(sfd.FileName))
					{
						File.Create(sfd.FileName).Close();
					}

					File.WriteAllText(sfd.FileName, tb_Text.Text);
				}
				catch(Exception ex) { MessageBox.Show(ex.ToString()); }
			}
		}

		private void btn_Menu_Exit_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Biztosan kilépsz?","Tuti?",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
			{
				//Application.Exit();
				this.Close();
			}
		}

		private void btn_Menu_NewFile_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Biztosan törlöd a tartalmat?", "Tuti?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{
				tb_Text.Text = "";
				Text = "Névtelen - Szövegszerkesztő";
			}
		}

		private void btn_Menu_Back_Click(object sender, EventArgs e)
		{
			tb_Text.Undo();
		}

		private void btn_Menu_SelectAll_Click(object sender, EventArgs e)
		{
			tb_Text.SelectAll();
		}

		private void btn_Menu_Copy_Click(object sender, EventArgs e)
		{
			tb_Text.Copy();
		}

		private void btn_Menu_Cut_Click(object sender, EventArgs e)
		{
			tb_Text.Cut();
		}

		private void btn_Menu_Paste_Click(object sender, EventArgs e)
		{
			tb_Text.Paste();
		}

		private void btn_Menu_Delete_Click(object sender, EventArgs e)
		{
			int selstart = tb_Text.SelectionStart;
			int sellen = tb_Text.SelectionLength;
			tb_Text.Text = tb_Text.Text.Remove(selstart, sellen);
		}

		private void szerkesztésToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
		{
			btn_Menu_Back.Enabled = (tb_Text.CanUndo ? true : false);
			btn_Menu_Copy.Enabled = (tb_Text.SelectionLength > 0 ? true : false);
			btn_Menu_Cut.Enabled = (tb_Text.SelectionLength > 0 ? true : false);
			btn_Menu_Delete.Enabled = (tb_Text.SelectionLength > 0 ? true : false);
		}

		private void btn_Menu_About_Click(object sender, EventArgs e)
		{
			f_Editor_About fa = new f_Editor_About();
			fa.ShowDialog();
		}

		private void btn_CMS_Undo_Click(object sender, EventArgs e)
		{
			tb_Text.Undo();
		}

		private void btn_CMS_SelectAll_Click(object sender, EventArgs e)
		{
			tb_Text.SelectAll();
		}

		private void btn_CMS_Copy_Click(object sender, EventArgs e)
		{
			tb_Text.Copy();
		}

		private void btn_CMS_Cut_Click(object sender, EventArgs e)
		{
			tb_Text.Cut();
		}

		private void btn_CMS_Paste_Click(object sender, EventArgs e)
		{
			tb_Text.Paste();
		}

		private void btn_Menu_Font_Click(object sender, EventArgs e)
		{
			if(fnt_FontDialog.ShowDialog() == DialogResult.OK)
			{
				tb_Text.Font = fnt_FontDialog.Font;
			}
		}

		private void btn_Menu_FontColor_Click(object sender, EventArgs e)
		{
			cd_FontColor.Color = tb_Text.ForeColor;
			if(cd_FontColor.ShowDialog() == DialogResult.OK)
			{
				tb_Text.ForeColor = cd_FontColor.Color;
			}
			
		}

		private void btn_Menu_BackColor_Click(object sender, EventArgs e)
		{
			cd_BackColor.Color = tb_Text.BackColor;
			if(cd_BackColor.ShowDialog() == DialogResult.OK)
			{
				tb_Text.BackColor = cd_BackColor.Color;
			}
		}
	}
}
