
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Finals
{
	/// <summary>
	/// Description of GameModes.
	/// </summary>
	public partial class GameModes : Form
	{
		public GameModes()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			Difficuties_ChoicesGM1 diffChoiceGM1 = new Difficuties_ChoicesGM1();
			diffChoiceGM1.Show();
			SetVisibleCore(false);
		}
		
		void BtnGM2Click(object sender, EventArgs e)
		{
			DifficultiesGM2 diffGM2 = new DifficultiesGM2();
			diffGM2.Show();
			SetVisibleCore(false);
		}
	}
}
