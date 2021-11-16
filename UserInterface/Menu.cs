using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessEngine;

namespace UserInterface
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private void play_MouseEnter(object sender, EventArgs e)
        {
            this.play.ForeColor = Color.Aqua;
        }

        private void play_MouseLeave(object sender, EventArgs e)
        {
            this.play.ForeColor = Color.White;
        }

        private void exit_MouseEnter(object sender, EventArgs e)
        {
            this.exit.ForeColor = Color.Aqua;
        }

        private void exit_MouseLeave(object sender, EventArgs e)
        {
            this.exit.ForeColor = Color.White;

        }

        private void play_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game game = new Game(3);
            game.ShowDialog();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void play2_MouseEnter(object sender, EventArgs e)
        {
            this.play2.ForeColor = Color.Aqua;
        }

        private void play2_MouseLeave(object sender, EventArgs e)
        {
            this.play2.ForeColor = Color.White;
        }

        private void play2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AI_Level level = new AI_Level();
            level.ShowDialog();
            this.Close();
        }
    }
}
