﻿
namespace Finals
{
	partial class Addition
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
			this.components = new System.ComponentModel.Container();
			this.lblNum1 = new System.Windows.Forms.Label();
			this.lblNum2 = new System.Windows.Forms.Label();
			this.AdditionSign = new System.Windows.Forms.Label();
			this.EqualSign = new System.Windows.Forms.Label();
			this.txbAnswer = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.lblAnswer = new System.Windows.Forms.Label();
			this.lblScore = new System.Windows.Forms.Label();
			this.TimerEasy = new System.Windows.Forms.Timer(this.components);
			this.lblTimer = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lblNum1
			// 
			this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNum1.Location = new System.Drawing.Point(92, 170);
			this.lblNum1.Name = "lblNum1";
			this.lblNum1.Size = new System.Drawing.Size(114, 86);
			this.lblNum1.TabIndex = 0;
			this.lblNum1.Text = "0";
			// 
			// lblNum2
			// 
			this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNum2.Location = new System.Drawing.Point(276, 170);
			this.lblNum2.Name = "lblNum2";
			this.lblNum2.Size = new System.Drawing.Size(167, 86);
			this.lblNum2.TabIndex = 1;
			this.lblNum2.Text = "0";
			// 
			// AdditionSign
			// 
			this.AdditionSign.BackColor = System.Drawing.Color.Transparent;
			this.AdditionSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AdditionSign.Location = new System.Drawing.Point(198, 170);
			this.AdditionSign.Name = "AdditionSign";
			this.AdditionSign.Size = new System.Drawing.Size(72, 86);
			this.AdditionSign.TabIndex = 2;
			this.AdditionSign.Text = "+";
			// 
			// EqualSign
			// 
			this.EqualSign.BackColor = System.Drawing.Color.Transparent;
			this.EqualSign.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EqualSign.Location = new System.Drawing.Point(416, 170);
			this.EqualSign.Name = "EqualSign";
			this.EqualSign.Size = new System.Drawing.Size(72, 86);
			this.EqualSign.TabIndex = 3;
			this.EqualSign.Text = "=";
			// 
			// txbAnswer
			// 
			this.txbAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txbAnswer.Location = new System.Drawing.Point(479, 170);
			this.txbAnswer.Name = "txbAnswer";
			this.txbAnswer.Size = new System.Drawing.Size(201, 83);
			this.txbAnswer.TabIndex = 4;
			this.txbAnswer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxbAnswerKeyDown);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(488, 275);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(177, 40);
			this.button1.TabIndex = 5;
			this.button1.Text = "Enter";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// lblAnswer
			// 
			this.lblAnswer.Location = new System.Drawing.Point(291, -2);
			this.lblAnswer.Name = "lblAnswer";
			this.lblAnswer.Size = new System.Drawing.Size(207, 96);
			this.lblAnswer.TabIndex = 6;
			this.lblAnswer.Visible = false;
			// 
			// lblScore
			// 
			this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblScore.Location = new System.Drawing.Point(-2, -2);
			this.lblScore.Name = "lblScore";
			this.lblScore.Size = new System.Drawing.Size(161, 85);
			this.lblScore.TabIndex = 7;
			this.lblScore.Text = "0";
			// 
			// TimerEasy
			// 
			this.TimerEasy.Enabled = true;
			this.TimerEasy.Interval = 1000;
			this.TimerEasy.Tick += new System.EventHandler(this.TimerEasyTick);
			// 
			// lblTimer
			// 
			this.lblTimer.Font = new System.Drawing.Font("Tahoma", 50.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblTimer.Location = new System.Drawing.Point(669, -2);
			this.lblTimer.Name = "lblTimer";
			this.lblTimer.Size = new System.Drawing.Size(132, 85);
			this.lblTimer.TabIndex = 8;
			this.lblTimer.Text = "10";
			// 
			// Addition
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(802, 403);
			this.Controls.Add(this.lblTimer);
			this.Controls.Add(this.lblScore);
			this.Controls.Add(this.lblAnswer);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txbAnswer);
			this.Controls.Add(this.EqualSign);
			this.Controls.Add(this.lblNum1);
			this.Controls.Add(this.lblNum2);
			this.Controls.Add(this.AdditionSign);
			this.Name = "Addition";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Addition";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Label lblTimer;
		private System.Windows.Forms.Timer TimerEasy;
		private System.Windows.Forms.Label lblScore;
		private System.Windows.Forms.Label lblAnswer;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox txbAnswer;
		private System.Windows.Forms.Label EqualSign;
		private System.Windows.Forms.Label AdditionSign;
		private System.Windows.Forms.Label lblNum2;
		private System.Windows.Forms.Label lblNum1;
		
		
	}
}
