
namespace Finals
{
	partial class Difficuties_ChoicesGM1
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAdditon = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.pnlAdditionDifficulties = new System.Windows.Forms.Panel();
			this.btnAdditionEasy = new System.Windows.Forms.Button();
			this.btnAdditionHard = new System.Windows.Forms.Button();
			this.btnAdditionAverage = new System.Windows.Forms.Button();
			this.pnlAdditionDifficulties.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnAdditon
			// 
			this.btnAdditon.Location = new System.Drawing.Point(99, 37);
			this.btnAdditon.Name = "btnAdditon";
			this.btnAdditon.Size = new System.Drawing.Size(134, 73);
			this.btnAdditon.TabIndex = 0;
			this.btnAdditon.Text = "Addition";
			this.btnAdditon.UseVisualStyleBackColor = true;
			this.btnAdditon.Click += new System.EventHandler(this.Button1Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(99, 132);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(134, 73);
			this.button2.TabIndex = 1;
			this.button2.Text = "button2";
			this.button2.UseVisualStyleBackColor = true;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(99, 226);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(134, 73);
			this.button3.TabIndex = 2;
			this.button3.Text = "button3";
			this.button3.UseVisualStyleBackColor = true;
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(99, 318);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(134, 73);
			this.button4.TabIndex = 3;
			this.button4.Text = "button4";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// pnlAdditionDifficulties
			// 
			this.pnlAdditionDifficulties.BackColor = System.Drawing.Color.Maroon;
			this.pnlAdditionDifficulties.Controls.Add(this.btnAdditionEasy);
			this.pnlAdditionDifficulties.Controls.Add(this.btnAdditionHard);
			this.pnlAdditionDifficulties.Controls.Add(this.btnAdditionAverage);
			this.pnlAdditionDifficulties.Location = new System.Drawing.Point(314, 53);
			this.pnlAdditionDifficulties.Name = "pnlAdditionDifficulties";
			this.pnlAdditionDifficulties.Size = new System.Drawing.Size(380, 246);
			this.pnlAdditionDifficulties.TabIndex = 4;
			this.pnlAdditionDifficulties.Visible = false;
			// 
			// btnAdditionEasy
			// 
			this.btnAdditionEasy.Location = new System.Drawing.Point(50, 44);
			this.btnAdditionEasy.Name = "btnAdditionEasy";
			this.btnAdditionEasy.Size = new System.Drawing.Size(77, 30);
			this.btnAdditionEasy.TabIndex = 3;
			this.btnAdditionEasy.Text = "Easy";
			this.btnAdditionEasy.UseVisualStyleBackColor = true;
			this.btnAdditionEasy.Click += new System.EventHandler(this.BtnAdditionEasyClick);
			// 
			// btnAdditionHard
			// 
			this.btnAdditionHard.Location = new System.Drawing.Point(266, 168);
			this.btnAdditionHard.Name = "btnAdditionHard";
			this.btnAdditionHard.Size = new System.Drawing.Size(77, 30);
			this.btnAdditionHard.TabIndex = 2;
			this.btnAdditionHard.Text = "Hard";
			this.btnAdditionHard.UseVisualStyleBackColor = true;
			this.btnAdditionHard.Click += new System.EventHandler(this.BtnAdditionHardClick);
			// 
			// btnAdditionAverage
			// 
			this.btnAdditionAverage.Location = new System.Drawing.Point(158, 113);
			this.btnAdditionAverage.Name = "btnAdditionAverage";
			this.btnAdditionAverage.Size = new System.Drawing.Size(77, 30);
			this.btnAdditionAverage.TabIndex = 1;
			this.btnAdditionAverage.Text = "Average";
			this.btnAdditionAverage.UseVisualStyleBackColor = true;
			this.btnAdditionAverage.Click += new System.EventHandler(this.BtnAdditionAverageClick);
			// 
			// Difficuties_ChoicesGM1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(802, 403);
			this.Controls.Add(this.pnlAdditionDifficulties);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnAdditon);
			this.Name = "Difficuties_ChoicesGM1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Difficuties_ChoicesGM1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Difficuties_ChoicesGM1FormClosed);
			this.pnlAdditionDifficulties.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnAdditionEasy;
		private System.Windows.Forms.Button btnAdditionAverage;
		private System.Windows.Forms.Button btnAdditionHard;
		private System.Windows.Forms.Panel pnlAdditionDifficulties;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button btnAdditon;
		
		
	}
}
