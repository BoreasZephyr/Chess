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
    public partial class Pickside : Form
    {
        public Pickside()
        {
            InitializeComponent();
        }
        private void Whiteside_MouseEnter(object sender, EventArgs e)
        {
            this.Whiteside.BackColor = Color.Gray;
            whiteLabel.BackColor = Color.Gray;
        }

        private void Whiteside_MouseLeave(object sender, EventArgs e)
        {
            this.Whiteside.BackColor = Color.DimGray;
            whiteLabel.BackColor = Color.DimGray;
        }
        private void Random_MouseEnter(object sender, EventArgs e)
        {
            this.Random.BackColor = Color.Gray;
            randomLabel.BackColor = Color.Gray;
        }

        private void Random_MouseLeave(object sender, EventArgs e)
        {
            this.Random.BackColor = Color.DimGray;
            randomLabel.BackColor = Color.DimGray;
        }
        private void Blackside_MouseEnter(object sender, EventArgs e)
        {
            this.Blackside.BackColor = Color.Gray;
            blackLabel.BackColor = Color.Gray;
        }

        private void Blackside_MouseLeave(object sender, EventArgs e)
        {
            this.Blackside.BackColor = Color.DimGray;
            blackLabel.BackColor = Color.DimGray;
        }
    }
}
