
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Finals
{
	/// <summary>
	/// Description of Addition.
	/// </summary>
	public partial class Addition : Form
	{
		public Random random;
		public int score = 0;
		public int scoreLimit = 100;
		public int changeTime = 10;

		public Addition()
		{
			InitializeComponent();
			random = new Random();
			RandomGen();
		}
		
		
		void Button1Click(object sender, EventArgs e)
		{
			ValidateAnswer();
			txbAnswer.Focus();
		}
		void TxbAnswerKeyDown(object sender, KeyEventArgs e)
		{
			if(e.KeyCode == Keys.Enter){
				ValidateAnswer();
				e.SuppressKeyPress = true;
			}
		}
		
		public void ValidateAnswer(){
			string correctAnswer = lblAnswer.Text;
		    string userAnswer = txbAnswer.Text;
		
		    if (correctAnswer == userAnswer)
		        {
		            RandomGen();
		        	txbAnswer.ResetText();
		        	ScoreAdd();
		        	lblTimer.Text = Convert.ToString(changeTime);
		        }
		        else
		        {
		            txbAnswer.ResetText();
		        }
		}
		public void RandomGen(){
			
			
            int num1val = random.Next(1, 9);
	        lblNum1.Text = num1val.ToString();
	
	        int num2val = random.Next(1, 9);
	        lblNum2.Text =num2val.ToString();
	
	        int answer = num1val + num2val;
	        lblAnswer.Text = answer.ToString();
					
			
		}
		public void ScoreAdd(){
			int prevLimit = 0;
			int addto = scoreLimit/10;
			if(score<scoreLimit && score>=prevLimit){
				int addScore = addto + score ;
				lblScore.Text= Convert.ToString(addScore);
				score = addScore;
			}
			
			if (score >= scoreLimit){
					prevLimit= prevLimit+ scoreLimit;
					scoreLimit= scoreLimit + 100;
					
					if (changeTime>3){
						changeTime = changeTime - 1;
					}
				}
			
			
		}
				
		
		void TimerEasyTick(object sender, EventArgs e)
		{
			switch (lblTimer.Text) {
				case "10" :lblTimer.Text ="9"; break;
				case "9" :lblTimer.Text ="8"; break;
				case "8" :lblTimer.Text ="7"; break;
				case "7" :lblTimer.Text ="6"; break;
				case "6" :lblTimer.Text ="5"; break;
				case "5" :lblTimer.Text ="4"; break;
				case "4" :lblTimer.Text ="3"; break;
				case "3" :lblTimer.Text ="2"; break;
				case "2" :lblTimer.Text ="1"; break;
				case "1" :lblTimer.Text ="0"; break;
			}
			if (lblTimer.Text == "0"){
				TimerEasy.Stop();
				Result result = new Result();
				result.Show();
				SetVisibleCore(false);
			}
			
			
		}

		
		
		
		
		
	}
}
