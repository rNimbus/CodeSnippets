
namespace Finals
{
	partial class MainForm
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
			this.btnLogIN = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnLogIN
			// 
			this.btnLogIN.Location = new System.Drawing.Point(220, 240);
			this.btnLogIN.Name = "btnLogIN";
			this.btnLogIN.Size = new System.Drawing.Size(165, 52);
			this.btnLogIN.TabIndex = 0;
			this.btnLogIN.Text = "LogIn";
			this.btnLogIN.UseVisualStyleBackColor = true;
			this.btnLogIN.Click += new System.EventHandler(this.BtnLogINClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(616, 374);
			this.Controls.Add(this.btnLogIN);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Finals";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button btnLogIN;
	}
}
