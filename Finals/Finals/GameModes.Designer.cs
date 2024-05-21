
namespace Finals
{
	partial class GameModes
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
			this.btnGM1 = new System.Windows.Forms.Button();
			this.btnGM2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnGM1
			// 
			this.btnGM1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGM1.Location = new System.Drawing.Point(204, 174);
			this.btnGM1.Name = "btnGM1";
			this.btnGM1.Size = new System.Drawing.Size(176, 70);
			this.btnGM1.TabIndex = 0;
			this.btnGM1.Text = "GameMode1";
			this.btnGM1.UseVisualStyleBackColor = true;
			this.btnGM1.Click += new System.EventHandler(this.Button1Click);
			// 
			// btnGM2
			// 
			this.btnGM2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnGM2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
			this.btnGM2.Location = new System.Drawing.Point(448, 174);
			this.btnGM2.Name = "btnGM2";
			this.btnGM2.Size = new System.Drawing.Size(176, 70);
			this.btnGM2.TabIndex = 1;
			this.btnGM2.Text = "GameMode2";
			this.btnGM2.UseVisualStyleBackColor = true;
			this.btnGM2.Click += new System.EventHandler(this.BtnGM2Click);
			// 
			// GameModes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(802, 403);
			this.Controls.Add(this.btnGM2);
			this.Controls.Add(this.btnGM1);
			this.Name = "GameModes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "GameModes";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnGM2;
		private System.Windows.Forms.Button btnGM1;
	}
}
