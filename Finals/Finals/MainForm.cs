
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Finals
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void BtnLogINClick(object sender, EventArgs e)
		{
			GameModes GM = new GameModes();
			GM.Show();
			SetVisibleCore(false);
		}
	}
}
