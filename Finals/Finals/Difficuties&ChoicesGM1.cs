
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Finals
{
	/// <summary>
	/// Description of Difficuties_ChoicesGM1.
	/// </summary>
	public partial class Difficuties_ChoicesGM1 : Form
	{
		public Difficuties_ChoicesGM1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Difficuties_ChoicesGM1FormClosed(object sender, FormClosedEventArgs e)
		{
			GameModes GM = new GameModes();
			GM.Show();
			SetVisibleCore(false);
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			pnlAdditionDifficulties.Show();
		}
		
		void BtnAdditionEasyClick(object sender, EventArgs e)
		{
			Addition addForm = new Addition();
			addForm.Show();
			SetVisibleCore(false);
		}
		
		void BtnAdditionAverageClick(object sender, EventArgs e)
		{
			AdditionAverage addAform = new AdditionAverage();
			addAform.Show();
			SetVisibleCore(false);
		}
	
		void BtnAdditionHardClick(object sender, EventArgs e)
		{
			AdditionHard addHform = new AdditionHard();
			addHform.Show();
			SetVisibleCore(false);
		}
		
		
	}
}
