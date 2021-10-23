
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
            this.btUndo = new System.Windows.Forms.Button();
            this.btHint = new System.Windows.Forms.Button();
            this.btResign = new System.Windows.Forms.Button();
            this.btNew = new System.Windows.Forms.Button();
            this.btRet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btUndo
            // 
            this.btUndo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btUndo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btUndo.Font = new System.Drawing.Font("04b03", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUndo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btUndo.Location = new System.Drawing.Point(83, 277);
            this.btUndo.Name = "btUndo";
            this.btUndo.Size = new System.Drawing.Size(150, 103);
            this.btUndo.TabIndex = 1;
            this.btUndo.TabStop = false;
            this.btUndo.Text = "UNDO";
            this.btUndo.UseVisualStyleBackColor = false;
            this.btUndo.Click += new System.EventHandler(this.btUndo_Click);
            // 
            // btHint
            // 
            this.btHint.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btHint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btHint.Font = new System.Drawing.Font("04b03", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btHint.Location = new System.Drawing.Point(239, 277);
            this.btHint.Name = "btHint";
            this.btHint.Size = new System.Drawing.Size(150, 103);
            this.btHint.TabIndex = 2;
            this.btHint.TabStop = false;
            this.btHint.Text = "HINT";
            this.btHint.UseVisualStyleBackColor = false;
            // 
            // btResign
            // 
            this.btResign.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btResign.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btResign.Font = new System.Drawing.Font("04b03", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResign.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btResign.Location = new System.Drawing.Point(83, 386);
            this.btResign.Name = "btResign";
            this.btResign.Size = new System.Drawing.Size(150, 103);
            this.btResign.TabIndex = 3;
            this.btResign.TabStop = false;
            this.btResign.Text = "RESIGN";
            this.btResign.UseVisualStyleBackColor = false;
            // 
            // btNew
            // 
            this.btNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btNew.Font = new System.Drawing.Font("04b03", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btNew.Location = new System.Drawing.Point(239, 386);
            this.btNew.Name = "btNew";
            this.btNew.Size = new System.Drawing.Size(150, 103);
            this.btNew.TabIndex = 4;
            this.btNew.TabStop = false;
            this.btNew.Text = "NEW GAME";
            this.btNew.UseVisualStyleBackColor = false;
            this.btNew.Click += new System.EventHandler(this.btNew_Click);
            // 
            // btRet
            // 
            this.btRet.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRet.Font = new System.Drawing.Font("04b03", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRet.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btRet.Location = new System.Drawing.Point(83, 495);
            this.btRet.Name = "btRet";
            this.btRet.Size = new System.Drawing.Size(306, 95);
            this.btRet.TabIndex = 5;
            this.btRet.TabStop = false;
            this.btRet.Text = "MAIN MENU";
            this.btRet.UseVisualStyleBackColor = false;
            this.btRet.Click += new System.EventHandler(this.btRet_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UserInterface.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.btRet);
            this.Controls.Add(this.btNew);
            this.Controls.Add(this.btResign);
            this.Controls.Add(this.btHint);
            this.Controls.Add(this.btUndo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btUndo;
        private System.Windows.Forms.Button btHint;
        private System.Windows.Forms.Button btResign;
        private System.Windows.Forms.Button btNew;
        private System.Windows.Forms.Button btRet;
    }
}