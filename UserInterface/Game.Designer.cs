
namespace UserInterface
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUndo = new System.Windows.Forms.Label();
            this.lbHint = new System.Windows.Forms.Label();
            this.lbResign = new System.Windows.Forms.Label();
            this.lbNewGame = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ret = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbUndo
            // 
            this.lbUndo.AutoSize = true;
            this.lbUndo.BackColor = System.Drawing.Color.Transparent;
            this.lbUndo.Font = new System.Drawing.Font("04b03", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUndo.ForeColor = System.Drawing.Color.Black;
            this.lbUndo.Location = new System.Drawing.Point(35, 37);
            this.lbUndo.Name = "lbUndo";
            this.lbUndo.Size = new System.Drawing.Size(93, 29);
            this.lbUndo.TabIndex = 5;
            this.lbUndo.Text = "UNDO";
            this.lbUndo.Click += new System.EventHandler(this.lbUndo_Click);
            this.lbUndo.MouseEnter += new System.EventHandler(this.lbUndo_MouseEnter);
            this.lbUndo.MouseLeave += new System.EventHandler(this.lbUndo_MouseLeave);
            // 
            // lbHint
            // 
            this.lbHint.AutoSize = true;
            this.lbHint.BackColor = System.Drawing.Color.Transparent;
            this.lbHint.Font = new System.Drawing.Font("04b03", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHint.ForeColor = System.Drawing.Color.Black;
            this.lbHint.Location = new System.Drawing.Point(35, 171);
            this.lbHint.Name = "lbHint";
            this.lbHint.Size = new System.Drawing.Size(85, 29);
            this.lbHint.TabIndex = 6;
            this.lbHint.Text = "HINT";
            this.lbHint.Click += new System.EventHandler(this.lbHint_Click);
            this.lbHint.MouseEnter += new System.EventHandler(this.lbHint_MouseEnter);
            this.lbHint.MouseLeave += new System.EventHandler(this.lbHint_MouseLeave);
            // 
            // lbResign
            // 
            this.lbResign.AutoSize = true;
            this.lbResign.BackColor = System.Drawing.Color.Transparent;
            this.lbResign.Font = new System.Drawing.Font("04b03", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResign.ForeColor = System.Drawing.Color.Black;
            this.lbResign.Location = new System.Drawing.Point(35, 300);
            this.lbResign.Name = "lbResign";
            this.lbResign.Size = new System.Drawing.Size(125, 29);
            this.lbResign.TabIndex = 7;
            this.lbResign.Text = "RESIGN";
            this.lbResign.Click += new System.EventHandler(this.lbResign_Click);
            this.lbResign.MouseEnter += new System.EventHandler(this.lbResign_MouseEnter);
            this.lbResign.MouseLeave += new System.EventHandler(this.lbResign_MouseLeave);
            // 
            // lbNewGame
            // 
            this.lbNewGame.AutoSize = true;
            this.lbNewGame.BackColor = System.Drawing.Color.Transparent;
            this.lbNewGame.Font = new System.Drawing.Font("04b03", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewGame.ForeColor = System.Drawing.Color.Black;
            this.lbNewGame.Location = new System.Drawing.Point(35, 461);
            this.lbNewGame.Name = "lbNewGame";
            this.lbNewGame.Size = new System.Drawing.Size(167, 29);
            this.lbNewGame.TabIndex = 8;
            this.lbNewGame.Text = "NEW GAME";
            this.lbNewGame.Click += new System.EventHandler(this.lbNewGame_Click);
            this.lbNewGame.MouseEnter += new System.EventHandler(this.lbNewGame_MouseEnter);
            this.lbNewGame.MouseLeave += new System.EventHandler(this.lbNewGame_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.ret);
            this.panel1.Controls.Add(this.lbUndo);
            this.panel1.Controls.Add(this.lbNewGame);
            this.panel1.Controls.Add(this.lbHint);
            this.panel1.Controls.Add(this.lbResign);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(83, 205);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 699);
            this.panel1.TabIndex = 9;
            // 
            // ret
            // 
            this.ret.AutoSize = true;
            this.ret.BackColor = System.Drawing.Color.Transparent;
            this.ret.Font = new System.Drawing.Font("04b03", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ret.ForeColor = System.Drawing.Color.Black;
            this.ret.Location = new System.Drawing.Point(35, 612);
            this.ret.Name = "ret";
            this.ret.Size = new System.Drawing.Size(187, 29);
            this.ret.TabIndex = 9;
            this.ret.Text = "MAIN MENU";
            this.ret.Click += new System.EventHandler(this.ret_Click);
            this.ret.MouseEnter += new System.EventHandler(this.ret_MouseEnter);
            this.ret.MouseLeave += new System.EventHandler(this.ret_MouseLeave);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UserInterface.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbUndo;
        private System.Windows.Forms.Label lbHint;
        private System.Windows.Forms.Label lbResign;
        private System.Windows.Forms.Label lbNewGame;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ret;
    }
}