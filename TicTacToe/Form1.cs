using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            HomeScreen hs = new HomeScreen();
            this.Controls.Add(hs);
            hs.Location = new Point((this.ClientSize.Width - hs.Width) / 2, (this.Height - hs.Height) / 2);
        }
    }
}
