namespace feladatok
{
	partial class Form1
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
			this.btn_Reverse = new System.Windows.Forms.Button();
			this.btn_TextEditor = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_Reverse
			// 
			this.btn_Reverse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Reverse.Location = new System.Drawing.Point(12, 12);
			this.btn_Reverse.Name = "btn_Reverse";
			this.btn_Reverse.Size = new System.Drawing.Size(147, 23);
			this.btn_Reverse.TabIndex = 0;
			this.btn_Reverse.Text = "Szöveg Visszafordító";
			this.btn_Reverse.UseVisualStyleBackColor = true;
			this.btn_Reverse.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn_Reverse_MouseClick);
			// 
			// btn_TextEditor
			// 
			this.btn_TextEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_TextEditor.Location = new System.Drawing.Point(12, 41);
			this.btn_TextEditor.Name = "btn_TextEditor";
			this.btn_TextEditor.Size = new System.Drawing.Size(147, 23);
			this.btn_TextEditor.TabIndex = 1;
			this.btn_TextEditor.Text = "Szövegszerkesztő";
			this.btn_TextEditor.UseVisualStyleBackColor = true;
			this.btn_TextEditor.Click += new System.EventHandler(this.btn_TextEditor_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Control;
			this.ClientSize = new System.Drawing.Size(171, 147);
			this.Controls.Add(this.btn_TextEditor);
			this.Controls.Add(this.btn_Reverse);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(500, 500);
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.Text = "Feladatok";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btn_Reverse;
		private System.Windows.Forms.Button btn_TextEditor;
	}
}

