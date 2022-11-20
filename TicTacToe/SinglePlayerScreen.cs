using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class SinglePlayerScreen : UserControl
    {
        public enum Player{
            X, O
        }

        Player currentPlayer;
        Random random = new Random();
        List<Button> buttons;
        int playerWinCounter = 0;
        int CPUWinCounter = 0;

        public SinglePlayerScreen()
        {
            InitializeComponent();
            RestartGame();
        }

        private void CPUmove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = random.Next(buttons.Count);
                buttons[index].Enabled = false;
                currentPlayer = Player.O;
                buttons[index].Text = currentPlayer.ToString();
                buttons[index].BackColor = Color.OliveDrab;
                buttons.RemoveAt(index);
                CheckGame();
                CPUTimer.Stop();
            }
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;
            if (CPUTimer.Enabled == false)
            {
                currentPlayer = Player.X;
                button.Text = currentPlayer.ToString();
                button.Enabled = false;
                button.BackColor = Color.IndianRed;
                buttons.Remove(button);
                CheckGame();
                CPUTimer.Start();
            }
        }
            

        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        public void CheckGame()
        {
            Boolean checkWin = false;

            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
                || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
                || button7.Text == "X" && button8.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
                || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
                || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
                || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
                || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                CPUTimer.Stop();
                checkWin = true;
                MessageBox.Show("Player 1 Wins");
                playerWinCounter++;
                player1PointsLabel.Text = playerWinCounter + "";
                RestartGame();
            }
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
                || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
                || button7.Text == "O" && button8.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
                || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
                || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
                || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
                || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                CPUTimer.Stop();
                checkWin = true;
                MessageBox.Show("CPU Wins");
                CPUWinCounter++;
                CPUPointsLabel.Text = CPUWinCounter + "";
                RestartGame();
            }

            if (buttons.Any() == false && checkWin == false)
            {
                MessageBox.Show("Its A Draw");
                RestartGame();
            }
        }

        public void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4,
                button5, button6, button7, button8, button9 };

            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "?";
                x.BackColor = Color.LemonChiffon;
            }
        }

        private void MainMenu(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            HomeScreen hs = new HomeScreen();
            f.Controls.Add(hs);
            hs.Location = new Point((f.Width - hs.Width) / 2, (f.Height - hs.Height) / 2);
            hs.Focus();
        }
    }
}
