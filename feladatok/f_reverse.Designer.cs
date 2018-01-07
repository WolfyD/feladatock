namespace feladatok
{
	partial class f_reverse
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
			this.label1 = new System.Windows.Forms.Label();
			this.tb_Text = new System.Windows.Forms.TextBox();
			this.btn_Reverse = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.lbl_ReversedText = new System.Windows.Forms.Label();
			this.btn_Copy = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Szöveg: ";
			// 
			// tb_Text
			// 
			this.tb_Text.Location = new System.Drawing.Point(67, 6);
			this.tb_Text.Name = "tb_Text";
			this.tb_Text.Size = new System.Drawing.Size(117, 20);
			this.tb_Text.TabIndex = 1;
			this.tb_Text.Text = "Hello Világ!";
			// 
			// btn_Reverse
			// 
			this.btn_Reverse.Location = new System.Drawing.Point(15, 34);
			this.btn_Reverse.Name = "btn_Reverse";
			this.btn_Reverse.Size = new System.Drawing.Size(107, 23);
			this.btn_Reverse.TabIndex = 2;
			this.btn_Reverse.Text = "Reverse";
			this.btn_Reverse.UseVisualStyleBackColor = true;
			this.btn_Reverse.Click += new System.EventHandler(this.btn_Reverse_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 67);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Fordítás: ";
			// 
			// lbl_ReversedText
			// 
			this.lbl_ReversedText.AutoSize = true;
			this.lbl_ReversedText.Location = new System.Drawing.Point(64, 67);
			this.lbl_ReversedText.Name = "lbl_ReversedText";
			this.lbl_ReversedText.Size = new System.Drawing.Size(58, 13);
			this.lbl_ReversedText.TabIndex = 4;
			this.lbl_ReversedText.Text = "-----------------";
			// 
			// btn_Copy
			// 
			this.btn_Copy.Location = new System.Drawing.Point(15, 95);
			this.btn_Copy.Name = "btn_Copy";
			this.btn_Copy.Size = new System.Drawing.Size(107, 23);
			this.btn_Copy.TabIndex = 5;
			this.btn_Copy.Text = "Copy to Clipboard";
			this.btn_Copy.UseVisualStyleBackColor = true;
			this.btn_Copy.Click += new System.EventHandler(this.btn_Copy_Click);
			// 
			// f_reverse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(197, 133);
			this.Controls.Add(this.btn_Copy);
			this.Controls.Add(this.lbl_ReversedText);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_Reverse);
			this.Controls.Add(this.tb_Text);
			this.Controls.Add(this.label1);
			this.Name = "f_reverse";
			this.Text = "Reverse";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_Text;
		private System.Windows.Forms.Button btn_Reverse;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label lbl_ReversedText;
		private System.Windows.Forms.Button btn_Copy;
	}
}