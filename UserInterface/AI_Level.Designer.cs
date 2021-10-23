
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AI_Level));
            this.ezLabel = new System.Windows.Forms.Label();
            this.norLabel = new System.Windows.Forms.Label();
            this.hardLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.hard = new System.Windows.Forms.PictureBox();
            this.easy = new System.Windows.Forms.PictureBox();
            this.normal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.easy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.normal)).BeginInit();
            this.SuspendLayout();
            // 
            // ezLabel
            // 
            this.ezLabel.AutoSize = true;
            this.ezLabel.BackColor = System.Drawing.Color.DimGray;
            this.ezLabel.Font = new System.Drawing.Font("04b03", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ezLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ezLabel.Location = new System.Drawing.Point(237, 305);
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
            this.norLabel.Location = new System.Drawing.Point(351, 307);
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
            this.hardLabel.Location = new System.Drawing.Point(483, 305);
            this.hardLabel.Name = "hardLabel";
            this.hardLabel.Size = new System.Drawing.Size(57, 19);
            this.hardLabel.TabIndex = 9;
            this.hardLabel.Text = "HARD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("04b03", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(215, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "DIFFICULTY:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("04b03", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(24, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = " ⇦ RETURN";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // hard
            // 
            this.hard.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hard.Image = ((System.Drawing.Image)(resources.GetObject("hard.Image")));
            this.hard.Location = new System.Drawing.Point(465, 98);
            this.hard.Name = "hard";
            this.hard.Size = new System.Drawing.Size(96, 272);
            this.hard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hard.TabIndex = 6;
            this.hard.TabStop = false;
            this.hard.MouseEnter += new System.EventHandler(this.hard_MouseEnter);
            this.hard.MouseLeave += new System.EventHandler(this.hard_MouseLeave);
            // 
            // easy
            // 
            this.easy.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.easy.Image = ((System.Drawing.Image)(resources.GetObject("easy.Image")));
            this.easy.Location = new System.Drawing.Point(219, 98);
            this.easy.Name = "easy";
            this.easy.Size = new System.Drawing.Size(93, 272);
            this.easy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.easy.TabIndex = 5;
            this.easy.TabStop = false;
            this.easy.MouseEnter += new System.EventHandler(this.easy_MouseEnter);
            this.easy.MouseLeave += new System.EventHandler(this.easy_MouseLeave);
            // 
            // normal
            // 
            this.normal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.normal.Image = ((System.Drawing.Image)(resources.GetObject("normal.Image")));
            this.normal.Location = new System.Drawing.Point(340, 98);
            this.normal.Name = "normal";
            this.normal.Size = new System.Drawing.Size(96, 272);
            this.normal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.normal.TabIndex = 4;
            this.normal.TabStop = false;
            this.normal.MouseEnter += new System.EventHandler(this.normal_MouseEnter);
            this.normal.MouseLeave += new System.EventHandler(this.normal_MouseLeave);
            // 
            // AI_Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(783, 520);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hardLabel);
            this.Controls.Add(this.norLabel);
            this.Controls.Add(this.ezLabel);
            this.Controls.Add(this.hard);
            this.Controls.Add(this.easy);
            this.Controls.Add(this.normal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AI_Level";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)(this.hard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.easy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.normal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox normal;
        private System.Windows.Forms.PictureBox easy;
        private System.Windows.Forms.PictureBox hard;
        private System.Windows.Forms.Label ezLabel;
        private System.Windows.Forms.Label norLabel;
        private System.Windows.Forms.Label hardLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}