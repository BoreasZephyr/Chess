
namespace UserInterface
{
    partial class Menu
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
            this.play = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.play2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.AutoSize = true;
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.Font = new System.Drawing.Font("04b03", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.play.Location = new System.Drawing.Point(454, 102);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(138, 48);
            this.play.TabIndex = 4;
            this.play.Text = "PLAY";
            this.play.Click += new System.EventHandler(this.play_Click);
            this.play.MouseEnter += new System.EventHandler(this.play_MouseEnter);
            this.play.MouseLeave += new System.EventHandler(this.play_MouseLeave);
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Font = new System.Drawing.Font("04b03", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.exit.Location = new System.Drawing.Point(454, 257);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(126, 48);
            this.exit.TabIndex = 5;
            this.exit.Text = "EXIT";
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // play2
            // 
            this.play2.AutoSize = true;
            this.play2.BackColor = System.Drawing.Color.Transparent;
            this.play2.Font = new System.Drawing.Font("04b03", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.play2.Location = new System.Drawing.Point(364, 180);
            this.play2.Name = "play2";
            this.play2.Size = new System.Drawing.Size(362, 48);
            this.play2.TabIndex = 6;
            this.play2.Text = "PLAY WITH AI";
            this.play2.Click += new System.EventHandler(this.play2_Click);
            this.play2.MouseEnter += new System.EventHandler(this.play2_MouseEnter);
            this.play2.MouseLeave += new System.EventHandler(this.play2_MouseLeave);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UserInterface.Properties.Resources.photo_1580541832626_2a7131ee809f;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1000, 638);
            this.Controls.Add(this.play2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.play);
            this.Font = new System.Drawing.Font("04b03", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chess";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label play;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label play2;
    }
}