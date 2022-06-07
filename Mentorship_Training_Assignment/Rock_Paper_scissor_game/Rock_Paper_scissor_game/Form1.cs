using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_Paper_scissor_game
{
    public partial class Form1 : Form
    {
        int rounds = 3;
        int timerPerRound = 6;
        bool gameOver = false;
        string[] CPUchoiceList = { "rock", "paper", "scissor", "lizard", "spock", "paper", "lizard", "rock", "spock", "scissor" };
        int randomNumber = 0;
        Random rnd = new Random();
        string CPUChoice;
        string playerChoice;
        int playerScore;
        int CPUScore;

        public Form1()
        {
            InitializeComponent();
            CountDownTimer.Enabled = true;
            playerChoice = "none";
            txtCountDown.Text = "5";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.Rock;
            playerChoice = "rock";
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.paper;
            playerChoice = "paper";
        }

        private void btnScissor_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.Scissor;
            playerChoice = "Scissor";
        }

        private void btnLizard_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.Lizard;
            playerChoice = "Lizard";
        }

        private void btnSpock_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.Spock;
            playerChoice = "Spock";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            playerScore = 0;
            CPUScore = 0;
            rounds = 3;
            txtScore.Text= "player: " + playerScore + "-" + "CPU: " + CPUScore;
            playerChoice = "none";
            CountDownTimer.Enabled = true;
            picPlayer.Image = Properties.Resources.qq;
            picCPU.Image = Properties.Resources.qq;
            gameOver = false;
        }

        private void CountDownTimerEvent(object sender, EventArgs e)
        {
            timerPerRound -= 1;
            txtCountDown.Text = timerPerRound.ToString();
            txtRounds.Text = "Rounds: " + rounds;
            if(timerPerRound<1)
            {
                CountDownTimer.Enabled = false;
                timerPerRound = 6;
                randomNumber = rnd.Next(0, CPUchoiceList.Length);
                CPUChoice = CPUchoiceList[randomNumber];
                switch(CPUChoice)
                {
                    case "rock":
                        picCPU.Image = Properties.Resources.Rock;
                        break;
                    case "paper":
                        picCPU.Image = Properties.Resources.paper;
                        break;
                    case "scissor":
                        picCPU.Image = Properties.Resources.Scissor;
                        break;
                    case "lizard":
                        picCPU.Image = Properties.Resources.Lizard;
                        break;
                    case "spock":
                        picCPU.Image = Properties.Resources.Spock;
                        break;
                }
                if(rounds>0)
                {
                    checkGame();
                }
                else
                {
                    if(playerScore>CPUScore)
                    {
                        MessageBox.Show("player won the game");
                    }
                    else
                    {
                        MessageBox.Show("CPU won the game");
                    }
                    gameOver = true;
                }
            }
        }
        private void checkGame()
        {
            if(playerChoice=="paper" && CPUChoice=="scissor")
            {
                CPUScore += 1;
                rounds -= 1;
                MessageBox.Show("CPU wins, scissor cuts paper.");
            }
            else if (playerChoice == "rock" && CPUChoice == "paper")
            {
                CPUScore += 1;
                rounds -= 1;
                MessageBox.Show("CPU wins, Paper covers rock.");
            }
            else if (playerChoice == "lizard" && CPUChoice == "rock")
            {
                CPUScore += 1;
                rounds -= 1;
                MessageBox.Show("CPU wins, Rock crushes lizard.");
            }
            else if (playerChoice == "spock" && CPUChoice == "lizard")
            {
                CPUScore += 1;
                rounds -= 1;
                MessageBox.Show("CPU wins, Lizard poisons Spock.");
            }
            else if (playerChoice == "scissor" && CPUChoice == "spock")
            {
                CPUScore += 1;
                rounds -= 1;
                MessageBox.Show("CPU wins, Spock smashes scissors.");
            }
            else if (playerChoice == "lizard" && CPUChoice == "scissor")
            {
                CPUScore += 1;
                rounds -= 1;
                MessageBox.Show("CPU wins, Scissors decapitates lizard.");
            }
            else if (playerChoice == "paper" && CPUChoice == "lizard")
            {
                CPUScore += 1;
                rounds -= 1;
                MessageBox.Show("CPU wins, Lizard eats paper.");
            }
            else if (playerChoice == "spock" && CPUChoice == "paper")
            {
                CPUScore += 1;
                rounds -= 1;
                MessageBox.Show("CPU wins, Paper disproves Spock.");
            }
            else if (playerChoice == "rock" && CPUChoice == "spock")
            {
                CPUScore += 1;
                rounds -= 1;
                MessageBox.Show("CPU wins, Spock vaporizes rock.");
            }
            else if (playerChoice == "scissor" && CPUChoice == "rock")
            {
                CPUScore += 1;
                rounds -= 1;
                MessageBox.Show("CPU wins, Rock crushes scissors.");
            }
            else if (playerChoice == "scissor" && CPUChoice == "paper")
            {
                playerScore += 1;
                rounds -= 1;
                MessageBox.Show("player wins, scissor cuts paper.");
            }
            else if (playerChoice == "paper" && CPUChoice == "rock")
            {
                playerScore += 1;
                rounds -= 1;
                MessageBox.Show("player wins, Paper covers rock.");
            }
            else if (playerChoice == "rock" && CPUChoice == "lizard")
            {
                playerScore += 1;
                rounds -= 1;
                MessageBox.Show("player wins, Rock crushes lizard.");
            }
            else if (playerChoice == "lizard" && CPUChoice == "spock")
            {
                playerScore += 1;
                rounds -= 1;
                MessageBox.Show("player wins, Lizard poisons Spock.");
            }
            else if (playerChoice == "spock" && CPUChoice == "scissor")
            {
                playerScore += 1;
                rounds -= 1;
                MessageBox.Show("player wins, Spock smashes scissors.");
            }
            else if (playerChoice == "scissor" && CPUChoice == "lizard")
            {
                playerScore += 1;
                rounds -= 1;
                MessageBox.Show("player wins, Scissors decapitates lizard.");
            }
            else if (playerChoice == "lizard" && CPUChoice == "paper")
            {
                playerScore += 1;
                rounds -= 1;
                MessageBox.Show("player wins, Lizard eats paper.");
            }
            else if (playerChoice == "paper" && CPUChoice == "spock")
            {
                playerScore += 1;
                rounds -= 1;
                MessageBox.Show("player wins, Paper disproves Spock.");
            }
            else if (playerChoice == "spock" && CPUChoice == "rock")
            {
                playerScore += 1;
                rounds -= 1;
                MessageBox.Show("player wins, Spock vaporizes rock.");
            }
            else if (playerChoice == "rock" && CPUChoice == "scissor")
            {
                playerScore += 1;
                rounds -= 1;
                MessageBox.Show("player wins, Rock crushes scissors.");
            }
            else if (playerChoice == "none")
            {
                MessageBox.Show("make a choice");
            }
            else
            {
                MessageBox.Show("Draw!!!!");
            }
            startNextRound();
        }
        private void startNextRound()
        {
            if(gameOver==true)
            {
                return;
            }
            txtScore.Text = "player: " + playerScore + "-" + "CPU: " + CPUScore;
            playerChoice = "none";
            CountDownTimer.Enabled = true;
            picPlayer.Image = Properties.Resources.qq;
            picCPU.Image = Properties.Resources.qq;
        }
    }
}
