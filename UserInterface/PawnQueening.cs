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
    public partial class PawnQueening : Form
    {
        public PieceType type;
        public PawnQueening()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Name = "Pawn Queening";
        }

        private void Queenbox_Click(object sender, EventArgs e)
        {
            this.type = PieceType.QUEEN;
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void Queenbox_MouseLeave(object sender, EventArgs e)
        {
            Queenbox.BackColor = Color.FromArgb(193, 154, 107);
        }

        private void Queenbox_MouseEnter(object sender, EventArgs e)
        {
            Queenbox.BackColor = Color.FromArgb(0, 155, 108);
        }
        private void Rookbox_Click(object sender, EventArgs e)
        {
            this.type = PieceType.ROOK;
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void Rookbox_MouseLeave(object sender, EventArgs e)
        {
            Rookbox.BackColor = Color.FromArgb(193, 154, 107);
        }

        private void Rookbox_MouseEnter(object sender, EventArgs e)
        {
            Rookbox.BackColor = Color.FromArgb(0, 155, 108);
        }
        private void Bishop_Click(object sender, EventArgs e)
        {
            this.type = PieceType.BISHOP;
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void Bishop_MouseLeave(object sender, EventArgs e)
        {
            Bishopbox.BackColor = Color.FromArgb(193, 154, 107);
        }

        private void Bishop_MouseEnter(object sender, EventArgs e)
        {
            Bishopbox.BackColor = Color.FromArgb(0, 155, 108);
        }
        private void Knightbox_Click(object sender, EventArgs e)
        {
            this.type = PieceType.KNIGHT;
            this.Close();
            this.DialogResult = DialogResult.OK;
        }

        private void Knightbox_MouseLeave(object sender, EventArgs e)
        {
            Knightbox.BackColor = Color.FromArgb(193, 154, 107);
        }

        private void Knightbox_MouseEnter(object sender, EventArgs e)
        {
            Knightbox.BackColor = Color.FromArgb(0, 155, 108);
        }

    }
}
