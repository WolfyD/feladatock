namespace feladatok
{
	partial class f_Editor
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.btn_Menu_File = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_NewFile = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Open = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Save = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tb_Text = new System.Windows.Forms.TextBox();
			this.ofd = new System.Windows.Forms.OpenFileDialog();
			this.szerkesztésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Back = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Menu_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Copy = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Cut = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Paste = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Delete = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_About = new System.Windows.Forms.ToolStripMenuItem();
			this.sfd = new System.Windows.Forms.SaveFileDialog();
			this.cms_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btn_CMS_Undo = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_CMS_SelectAll = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_CMS_Copy = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_CMS_Cut = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_CMS_Paste = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.btn_Style = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_Font = new System.Windows.Forms.ToolStripMenuItem();
			this.fnt_FontDialog = new System.Windows.Forms.FontDialog();
			this.btn_Menu_FontColor = new System.Windows.Forms.ToolStripMenuItem();
			this.btn_Menu_BackColor = new System.Windows.Forms.ToolStripMenuItem();
			this.cd_FontColor = new System.Windows.Forms.ColorDialog();
			this.cd_BackColor = new System.Windows.Forms.ColorDialog();
			this.menuStrip1.SuspendLayout();
			this.cms_Menu.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Menu_File,
            this.szerkesztésToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.btn_Style});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(461, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// btn_Menu_File
			// 
			this.btn_Menu_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Menu_NewFile,
            this.btn_Menu_Open,
            this.btn_Menu_Save,
            this.toolStripSeparator1,
            this.btn_Menu_Exit});
			this.btn_Menu_File.Name = "btn_Menu_File";
			this.btn_Menu_File.Size = new System.Drawing.Size(37, 20);
			this.btn_Menu_File.Text = "Fájl";
			// 
			// btn_Menu_NewFile
			// 
			this.btn_Menu_NewFile.Name = "btn_Menu_NewFile";
			this.btn_Menu_NewFile.Size = new System.Drawing.Size(158, 22);
			this.btn_Menu_NewFile.Text = "Új Fájl";
			this.btn_Menu_NewFile.Click += new System.EventHandler(this.btn_Menu_NewFile_Click);
			// 
			// btn_Menu_Open
			// 
			this.btn_Menu_Open.Name = "btn_Menu_Open";
			this.btn_Menu_Open.Size = new System.Drawing.Size(158, 22);
			this.btn_Menu_Open.Text = "Megnyitás";
			this.btn_Menu_Open.Click += new System.EventHandler(this.btn_Menu_Open_Click);
			// 
			// btn_Menu_Save
			// 
			this.btn_Menu_Save.Name = "btn_Menu_Save";
			this.btn_Menu_Save.ShortcutKeyDisplayString = "Ctrl + s";
			this.btn_Menu_Save.Size = new System.Drawing.Size(158, 22);
			this.btn_Menu_Save.Text = "Mentés";
			this.btn_Menu_Save.ToolTipText = "Mentés";
			this.btn_Menu_Save.Click += new System.EventHandler(this.btn_Menu_Save_Click);
			// 
			// btn_Menu_Exit
			// 
			this.btn_Menu_Exit.Name = "btn_Menu_Exit";
			this.btn_Menu_Exit.Size = new System.Drawing.Size(158, 22);
			this.btn_Menu_Exit.Text = "Kilépés";
			this.btn_Menu_Exit.Click += new System.EventHandler(this.btn_Menu_Exit_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
			// 
			// tb_Text
			// 
			this.tb_Text.AcceptsReturn = true;
			this.tb_Text.AcceptsTab = true;
			this.tb_Text.ContextMenuStrip = this.cms_Menu;
			this.tb_Text.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_Text.Location = new System.Drawing.Point(0, 24);
			this.tb_Text.Multiline = true;
			this.tb_Text.Name = "tb_Text";
			this.tb_Text.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tb_Text.Size = new System.Drawing.Size(461, 353);
			this.tb_Text.TabIndex = 1;
			// 
			// ofd
			// 
			this.ofd.FileName = "openFileDialog1";
			this.ofd.Filter = "Text Files|*.txt;*.html|RTF Files|*.rtf|All Files|*.*";
			// 
			// szerkesztésToolStripMenuItem
			// 
			this.szerkesztésToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Menu_Back,
            this.toolStripSeparator2,
            this.btn_Menu_SelectAll,
            this.btn_Menu_Copy,
            this.btn_Menu_Cut,
            this.btn_Menu_Paste,
            this.btn_Menu_Delete});
			this.szerkesztésToolStripMenuItem.Name = "szerkesztésToolStripMenuItem";
			this.szerkesztésToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.szerkesztésToolStripMenuItem.Text = "Szerkesztés";
			this.szerkesztésToolStripMenuItem.DropDownOpening += new System.EventHandler(this.szerkesztésToolStripMenuItem_DropDownOpening);
			// 
			// btn_Menu_Back
			// 
			this.btn_Menu_Back.Name = "btn_Menu_Back";
			this.btn_Menu_Back.ShortcutKeyDisplayString = "Ctrl + z";
			this.btn_Menu_Back.Size = new System.Drawing.Size(210, 22);
			this.btn_Menu_Back.Text = "Vissza";
			this.btn_Menu_Back.Click += new System.EventHandler(this.btn_Menu_Back_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(207, 6);
			// 
			// btn_Menu_SelectAll
			// 
			this.btn_Menu_SelectAll.Name = "btn_Menu_SelectAll";
			this.btn_Menu_SelectAll.ShortcutKeyDisplayString = "Ctrl + a ";
			this.btn_Menu_SelectAll.Size = new System.Drawing.Size(210, 22);
			this.btn_Menu_SelectAll.Text = "Összes Kijelölése";
			this.btn_Menu_SelectAll.Click += new System.EventHandler(this.btn_Menu_SelectAll_Click);
			// 
			// btn_Menu_Copy
			// 
			this.btn_Menu_Copy.Name = "btn_Menu_Copy";
			this.btn_Menu_Copy.ShortcutKeyDisplayString = "Ctrl + c";
			this.btn_Menu_Copy.Size = new System.Drawing.Size(210, 22);
			this.btn_Menu_Copy.Text = "Másolás";
			this.btn_Menu_Copy.Click += new System.EventHandler(this.btn_Menu_Copy_Click);
			// 
			// btn_Menu_Cut
			// 
			this.btn_Menu_Cut.Name = "btn_Menu_Cut";
			this.btn_Menu_Cut.ShortcutKeyDisplayString = "Ctrl + x";
			this.btn_Menu_Cut.Size = new System.Drawing.Size(210, 22);
			this.btn_Menu_Cut.Text = "Kivágás";
			this.btn_Menu_Cut.Click += new System.EventHandler(this.btn_Menu_Cut_Click);
			// 
			// btn_Menu_Paste
			// 
			this.btn_Menu_Paste.Name = "btn_Menu_Paste";
			this.btn_Menu_Paste.ShortcutKeyDisplayString = "Ctrl + v";
			this.btn_Menu_Paste.Size = new System.Drawing.Size(210, 22);
			this.btn_Menu_Paste.Text = "Beillesztés";
			this.btn_Menu_Paste.Click += new System.EventHandler(this.btn_Menu_Paste_Click);
			// 
			// btn_Menu_Delete
			// 
			this.btn_Menu_Delete.Name = "btn_Menu_Delete";
			this.btn_Menu_Delete.ShortcutKeyDisplayString = "del";
			this.btn_Menu_Delete.Size = new System.Drawing.Size(210, 22);
			this.btn_Menu_Delete.Text = "Törlés";
			this.btn_Menu_Delete.Click += new System.EventHandler(this.btn_Menu_Delete_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Menu_About});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// btn_Menu_About
			// 
			this.btn_Menu_About.Name = "btn_Menu_About";
			this.btn_Menu_About.Size = new System.Drawing.Size(152, 22);
			this.btn_Menu_About.Text = "About";
			this.btn_Menu_About.Click += new System.EventHandler(this.btn_Menu_About_Click);
			// 
			// sfd
			// 
			this.sfd.Filter = "Text Files|*.txt|All Files|*.*";
			// 
			// cms_Menu
			// 
			this.cms_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_CMS_Undo,
            this.toolStripSeparator3,
            this.btn_CMS_SelectAll,
            this.btn_CMS_Copy,
            this.btn_CMS_Cut,
            this.btn_CMS_Paste});
			this.cms_Menu.Name = "cms_Menu";
			this.cms_Menu.Size = new System.Drawing.Size(155, 120);
			// 
			// btn_CMS_Undo
			// 
			this.btn_CMS_Undo.Name = "btn_CMS_Undo";
			this.btn_CMS_Undo.Size = new System.Drawing.Size(154, 22);
			this.btn_CMS_Undo.Text = "Visszavon";
			this.btn_CMS_Undo.Click += new System.EventHandler(this.btn_CMS_Undo_Click);
			// 
			// btn_CMS_SelectAll
			// 
			this.btn_CMS_SelectAll.Name = "btn_CMS_SelectAll";
			this.btn_CMS_SelectAll.Size = new System.Drawing.Size(154, 22);
			this.btn_CMS_SelectAll.Text = "Mindent Kijelöl";
			this.btn_CMS_SelectAll.Click += new System.EventHandler(this.btn_CMS_SelectAll_Click);
			// 
			// btn_CMS_Copy
			// 
			this.btn_CMS_Copy.Name = "btn_CMS_Copy";
			this.btn_CMS_Copy.Size = new System.Drawing.Size(154, 22);
			this.btn_CMS_Copy.Text = "Másolás";
			this.btn_CMS_Copy.Click += new System.EventHandler(this.btn_CMS_Copy_Click);
			// 
			// btn_CMS_Cut
			// 
			this.btn_CMS_Cut.Name = "btn_CMS_Cut";
			this.btn_CMS_Cut.Size = new System.Drawing.Size(154, 22);
			this.btn_CMS_Cut.Text = "Kivágás";
			this.btn_CMS_Cut.Click += new System.EventHandler(this.btn_CMS_Cut_Click);
			// 
			// btn_CMS_Paste
			// 
			this.btn_CMS_Paste.Name = "btn_CMS_Paste";
			this.btn_CMS_Paste.Size = new System.Drawing.Size(154, 22);
			this.btn_CMS_Paste.Text = "Beillesztés";
			this.btn_CMS_Paste.Click += new System.EventHandler(this.btn_CMS_Paste_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(151, 6);
			// 
			// btn_Style
			// 
			this.btn_Style.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Menu_Font,
            this.btn_Menu_FontColor,
            this.btn_Menu_BackColor});
			this.btn_Style.Name = "btn_Style";
			this.btn_Style.Size = new System.Drawing.Size(47, 20);
			this.btn_Style.Text = "Stílus";
			// 
			// btn_Menu_Font
			// 
			this.btn_Menu_Font.Name = "btn_Menu_Font";
			this.btn_Menu_Font.Size = new System.Drawing.Size(152, 22);
			this.btn_Menu_Font.Text = "Betütípus";
			this.btn_Menu_Font.Click += new System.EventHandler(this.btn_Menu_Font_Click);
			// 
			// btn_Menu_FontColor
			// 
			this.btn_Menu_FontColor.Name = "btn_Menu_FontColor";
			this.btn_Menu_FontColor.Size = new System.Drawing.Size(152, 22);
			this.btn_Menu_FontColor.Text = "Betüszín";
			this.btn_Menu_FontColor.Click += new System.EventHandler(this.btn_Menu_FontColor_Click);
			// 
			// btn_Menu_BackColor
			// 
			this.btn_Menu_BackColor.Name = "btn_Menu_BackColor";
			this.btn_Menu_BackColor.Size = new System.Drawing.Size(152, 22);
			this.btn_Menu_BackColor.Text = "Háttérszín";
			this.btn_Menu_BackColor.Click += new System.EventHandler(this.btn_Menu_BackColor_Click);
			// 
			// cd_BackColor
			// 
			this.cd_BackColor.Color = System.Drawing.Color.White;
			// 
			// f_Editor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(461, 377);
			this.Controls.Add(this.tb_Text);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "f_Editor";
			this.Text = "Szövegszerkesztő";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.cms_Menu.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_File;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_NewFile;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Open;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Save;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Exit;
		private System.Windows.Forms.TextBox tb_Text;
		private System.Windows.Forms.OpenFileDialog ofd;
		private System.Windows.Forms.ToolStripMenuItem szerkesztésToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Back;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_SelectAll;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Copy;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Cut;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Paste;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Delete;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_About;
		private System.Windows.Forms.SaveFileDialog sfd;
		private System.Windows.Forms.ContextMenuStrip cms_Menu;
		private System.Windows.Forms.ToolStripMenuItem btn_CMS_Undo;
		private System.Windows.Forms.ToolStripMenuItem btn_CMS_SelectAll;
		private System.Windows.Forms.ToolStripMenuItem btn_CMS_Copy;
		private System.Windows.Forms.ToolStripMenuItem btn_CMS_Cut;
		private System.Windows.Forms.ToolStripMenuItem btn_CMS_Paste;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem btn_Style;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_Font;
		private System.Windows.Forms.FontDialog fnt_FontDialog;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_FontColor;
		private System.Windows.Forms.ToolStripMenuItem btn_Menu_BackColor;
		private System.Windows.Forms.ColorDialog cd_FontColor;
		private System.Windows.Forms.ColorDialog cd_BackColor;
	}
}