using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class AI_Level : Form
    {
        public AI_Level()
        {
            InitializeComponent();
        }

        private void easy_MouseEnter(object sender, EventArgs e)
        {
            this.easy.BackColor = Color.Gray;
            ezLabel.BackColor = Color.Gray;
        }

        private void easy_MouseLeave(object sender, EventArgs e)
        {
            this.easy.BackColor = Color.DimGray;
            ezLabel.BackColor = Color.DimGray;
        }

        private void normal_MouseEnter(object sender, EventArgs e)
        {
            this.normal.BackColor = Color.Gray;
            norLabel.BackColor = Color.Gray;
        }

        private void normal_MouseLeave(object sender, EventArgs e)
        {
            this.normal.BackColor = Color.DimGray;
            norLabel.BackColor = Color.DimGray;
        }

        private void hard_MouseEnter(object sender, EventArgs e)
        {
            this.hard.BackColor = Color.Gray;
            hardLabel.BackColor = Color.Gray;
        }

        private void hard_MouseLeave(object sender, EventArgs e)
        {
            this.hard.BackColor = Color.DimGray;
            hardLabel.BackColor = Color.DimGray;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            this.label1.ForeColor = Color.Aqua;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            this.label1.ForeColor = Color.White;
        }

        private void easy_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game game = new Game(1);
            game.ShowDialog();
            this.Close();
        }

        private void normal_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game game = new Game(3);
            game.ShowDialog();
            this.Close();
        }

        private void hard_Click(object sender, EventArgs e)
        {
            this.Hide();
            Game game = new Game(5);
            game.ShowDialog();
            this.Close();
        }
    }
}
