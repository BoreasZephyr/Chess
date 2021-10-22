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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

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

        private void white_MouseEnter(object sender, EventArgs e)
        {
            this.white.BackColor = Color.Gray;
        }

        private void white_MouseLeave(object sender, EventArgs e)
        {
            this.white.BackColor = Color.DimGray;
        }

        private void black_MouseEnter(object sender, EventArgs e)
        {
            this.black.BackColor = Color.Gray;
        }

        private void black_MouseLeave(object sender, EventArgs e)
        {
            this.black.BackColor = Color.DimGray;
        }
    }
}
