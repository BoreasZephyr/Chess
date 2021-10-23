
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
            this.ret = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ret
            // 
            this.ret.AutoSize = true;
            this.ret.BackColor = System.Drawing.Color.Transparent;
            this.ret.Font = new System.Drawing.Font("04b03", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ret.ForeColor = System.Drawing.Color.White;
            this.ret.Location = new System.Drawing.Point(1592, 751);
            this.ret.Name = "ret";
            this.ret.Size = new System.Drawing.Size(272, 29);
            this.ret.TabIndex = 4;
            this.ret.Text = "RETURN TO MENU";
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
            this.Controls.Add(this.ret);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ret;
    }
}