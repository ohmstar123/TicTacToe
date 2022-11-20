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
    public partial class MultiplayerScreen : UserControl
    {
        public enum Player
        {
            X, O
        }

        Player player1;
        Player player2;
        Random random = new Random();
        List<Button> buttons;
        int player1WinCounter = 0;
        int player2WinCounter = 0;
        int turnCounter = 0;

        public MultiplayerScreen()
        {
            InitializeComponent();
            RestartGame();
        }

        private void PlayerClickButton(object sender, EventArgs e)
        {
            var button = (Button)sender;

            if (turnCounter % 2 == 0)
            {
                turnLabel.Text = "Turn: Player 2 (O)";
                player1 = Player.X;
                button.Text = player1.ToString();
                button.Enabled = false;
                button.BackColor = Color.IndianRed;
                buttons.Remove(button);
                CheckGame();
            }
            else
            {
                turnLabel.Text = "Turn: Player 1 (X)";
                player2 = Player.O;
                button.Text = player2.ToString();
                button.Enabled = false;
                button.BackColor = Color.OliveDrab;
                buttons.Remove(button);
                CheckGame();
            }

            turnCounter++;
        }

        private void RestartGame(object sender, EventArgs e)
        {
            RestartGame();
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

        private void CheckGame()
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
                checkWin = true;
                MessageBox.Show("Player 1 Wins");
                player1WinCounter++;
                player1PointsLabel.Text = player1WinCounter + "";
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
                checkWin = true;
                MessageBox.Show("Player 2 Wins");
                player2WinCounter++;
                player2PointsLabel.Text = player2WinCounter + "";
                RestartGame();
            }

            if (buttons.Any() == false && checkWin == false)
            {
                MessageBox.Show("Its A Draw");
                RestartGame();
            }

        }

        private void RestartGame()
        {
            buttons = new List<Button> { button1, button2, button3, button4, 
                button5, button6, button7, button8, button9 };

            foreach (Button x in buttons)
            {
                x.Enabled = true;
                x.Text = "?";
                x.BackColor = Color.LemonChiffon;
            }

            turnCounter = 0;
        }
    }
}
