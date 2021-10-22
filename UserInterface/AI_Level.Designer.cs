
namespace UserInterface
{
    partial class AI_Level
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
            this.button1 = new System.Windows.Forms.Button();
            this.ezLabel = new System.Windows.Forms.Label();
            this.norLabel = new System.Windows.Forms.Label();
            this.hardLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.black = new System.Windows.Forms.PictureBox();
            this.white = new System.Windows.Forms.PictureBox();
            this.hard = new System.Windows.Forms.PictureBox();
            this.easy = new System.Windows.Forms.PictureBox();
            this.normal = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.black)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.white)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normal)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("04b03", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 54);
            this.button1.TabIndex = 3;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ezLabel
            // 
            this.ezLabel.AutoSize = true;
            this.ezLabel.BackColor = System.Drawing.Color.DimGray;
            this.ezLabel.Font = new System.Drawing.Font("04b03", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ezLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ezLabel.Location = new System.Drawing.Point(45, 237);
            this.ezLabel.Name = "ezLabel";
            this.ezLabel.Size = new System.Drawing.Size(55, 19);
            this.ezLabel.TabIndex = 7;
            this.ezLabel.Text = "EASY";
            // 
            // norLabel
            // 
            this.norLabel.AutoSize = true;
            this.norLabel.BackColor = System.Drawing.Color.DimGray;
            this.norLabel.Font = new System.Drawing.Font("04b03", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.norLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.norLabel.Location = new System.Drawing.Point(161, 237);
            this.norLabel.Name = "norLabel";
            this.norLabel.Size = new System.Drawing.Size(74, 17);
            this.norLabel.TabIndex = 8;
            this.norLabel.Text = "NORMAL";
            // 
            // hardLabel
            // 
            this.hardLabel.AutoSize = true;
            this.hardLabel.BackColor = System.Drawing.Color.DimGray;
            this.hardLabel.Font = new System.Drawing.Font("04b03", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hardLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.hardLabel.Location = new System.Drawing.Point(294, 237);
            this.hardLabel.Name = "hardLabel";
            this.hardLabel.Size = new System.Drawing.Size(57, 19);
            this.hardLabel.TabIndex = 9;
            this.hardLabel.Text = "HARD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("04b03", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(30, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "COLOR:";
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.black.Image = global::UserInterface.Properties.Resources.BPawn_png;
            this.black.Location = new System.Drawing.Point(225, 317);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(82, 82);
            this.black.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.black.TabIndex = 12;
            this.black.TabStop = false;
            this.black.MouseEnter += new System.EventHandler(this.black_MouseEnter);
            this.black.MouseLeave += new System.EventHandler(this.black_MouseLeave);
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.white.Image = global::UserInterface.Properties.Resources.WPawn_png;
            this.white.Location = new System.Drawing.Point(91, 317);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(84, 82);
            this.white.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.white.TabIndex = 11;
            this.white.TabStop = false;
            this.white.MouseEnter += new System.EventHandler(this.white_MouseEnter);
            this.white.MouseLeave += new System.EventHandler(this.white_MouseLeave);
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hard.Image = global::UserInterface.Properties.Resources.WQueen_png;
            this.hard.Location = new System.Drawing.Point(276, 50);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(96, 215);
            this.hard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hard.TabIndex = 6;
            this.hard.TabStop = false;
            this.hard.MouseEnter += new System.EventHandler(this.hard_MouseEnter);
            this.hard.MouseLeave += new System.EventHandler(this.hard_MouseLeave);
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.easy.Image = global::UserInterface.Properties.Resources.WPawn_png;
            this.easy.Location = new System.Drawing.Point(30, 50);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(91, 215);
            this.easy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.easy.TabIndex = 5;
            this.easy.TabStop = false;
            this.easy.MouseEnter += new System.EventHandler(this.easy_MouseEnter);
            this.easy.MouseLeave += new System.EventHandler(this.easy_MouseLeave);
            // 
            // normal
            // 
            this.normal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.normal.Image = global::UserInterface.Properties.Resources.WKnight_png;
            this.normal.Location = new System.Drawing.Point(151, 50);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(96, 215);
            this.normal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.normal.TabIndex = 4;
            this.normal.TabStop = false;
            this.normal.MouseEnter += new System.EventHandler(this.normal_MouseEnter);
            this.normal.MouseLeave += new System.EventHandler(this.normal_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("04b03", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(26, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "DIFFICULTY:";
            // 
            // AI_Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(399, 474);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.black);
            this.Controls.Add(this.white);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hardLabel);
            this.Controls.Add(this.norLabel);
            this.Controls.Add(this.ezLabel);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.normal);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AI_Level";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)(this.black)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.white)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox normal;
        private System.Windows.Forms.PictureBox easy;
        private System.Windows.Forms.PictureBox hard;
        private System.Windows.Forms.Label ezLabel;
        private System.Windows.Forms.Label norLabel;
        private System.Windows.Forms.Label hardLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox white;
        private System.Windows.Forms.PictureBox black;
        private System.Windows.Forms.Label label5;
    }
}