
namespace UserInterface
{
    partial class Pickside
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pickside));
            this.label5 = new System.Windows.Forms.Label();
            this.blackLabel = new System.Windows.Forms.Label();
            this.randomLabel = new System.Windows.Forms.Label();
            this.whiteLabel = new System.Windows.Forms.Label();
            this.Blackside = new System.Windows.Forms.PictureBox();
            this.Whiteside = new System.Windows.Forms.PictureBox();
            this.Random = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Blackside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Whiteside)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Random)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("04b03", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(64, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 19);
            this.label5.TabIndex = 20;
            this.label5.Text = "PICK SIDE";
            // 
            // blackLabel
            // 
            this.blackLabel.AutoSize = true;
            this.blackLabel.BackColor = System.Drawing.Color.DimGray;
            this.blackLabel.Font = new System.Drawing.Font("04b03", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blackLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.blackLabel.Location = new System.Drawing.Point(332, 249);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Size = new System.Drawing.Size(65, 19);
            this.blackLabel.TabIndex = 19;
            this.blackLabel.Text = "BLACK";
            // 
            // randomLabel
            // 
            this.randomLabel.AutoSize = true;
            this.randomLabel.BackColor = System.Drawing.Color.DimGray;
            this.randomLabel.Font = new System.Drawing.Font("04b03", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.randomLabel.Location = new System.Drawing.Point(200, 261);
            this.randomLabel.Name = "randomLabel";
            this.randomLabel.Size = new System.Drawing.Size(76, 17);
            this.randomLabel.TabIndex = 18;
            this.randomLabel.Text = "RANDOM";
            // 
            // whiteLabel
            // 
            this.whiteLabel.AutoSize = true;
            this.whiteLabel.BackColor = System.Drawing.Color.DimGray;
            this.whiteLabel.Font = new System.Drawing.Font("04b03", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.whiteLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.whiteLabel.Location = new System.Drawing.Point(86, 259);
            this.whiteLabel.Name = "whiteLabel";
            this.whiteLabel.Size = new System.Drawing.Size(65, 19);
            this.whiteLabel.TabIndex = 17;
            this.whiteLabel.Text = "WHITE";
            // 
            // Blackside
            // 
            this.Blackside.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Blackside.Image = ((System.Drawing.Image)(resources.GetObject("Blackside.Image")));
            this.Blackside.Location = new System.Drawing.Point(314, 52);
            this.Blackside.Name = "Blackside";
            this.Blackside.Size = new System.Drawing.Size(96, 272);
            this.Blackside.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Blackside.TabIndex = 16;
            this.Blackside.TabStop = false;
            this.Blackside.MouseEnter += new System.EventHandler(this.Blackside_MouseEnter);
            this.Blackside.MouseLeave += new System.EventHandler(this.Blackside_MouseLeave);
            // 
            // Whiteside
            // 
            this.Whiteside.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Whiteside.Image = ((System.Drawing.Image)(resources.GetObject("Whiteside.Image")));
            this.Whiteside.Location = new System.Drawing.Point(68, 52);
            this.Whiteside.Name = "Whiteside";
            this.Whiteside.Size = new System.Drawing.Size(93, 272);
            this.Whiteside.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Whiteside.TabIndex = 15;
            this.Whiteside.TabStop = false;
            this.Whiteside.MouseEnter += new System.EventHandler(this.Whiteside_MouseEnter);
            this.Whiteside.MouseLeave += new System.EventHandler(this.Whiteside_MouseLeave);
            // 
            // Random
            // 
            this.Random.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Random.Image = ((System.Drawing.Image)(resources.GetObject("Random.Image")));
            this.Random.Location = new System.Drawing.Point(189, 52);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(96, 272);
            this.Random.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Random.TabIndex = 14;
            this.Random.TabStop = false;
            this.Random.MouseEnter += new System.EventHandler(this.Random_MouseEnter);
            this.Random.MouseLeave += new System.EventHandler(this.Random_MouseLeave);
            // 
            // Pickside
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(489, 375);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.blackLabel);
            this.Controls.Add(this.randomLabel);
            this.Controls.Add(this.whiteLabel);
            this.Controls.Add(this.Blackside);
            this.Controls.Add(this.Whiteside);
            this.Controls.Add(this.Random);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pickside";
            this.Text = "Pickside";
            ((System.ComponentModel.ISupportInitialize)(this.Blackside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Whiteside)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Random)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox Blackside;
        private System.Windows.Forms.PictureBox Whiteside;
        private System.Windows.Forms.PictureBox Random;
        private System.Windows.Forms.Label blackLabel;
        private System.Windows.Forms.Label randomLabel;
        private System.Windows.Forms.Label whiteLabel;
    }
}