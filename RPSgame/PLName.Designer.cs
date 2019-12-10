namespace RPSgame
{
    partial class PNameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.playerNameBox = new System.Windows.Forms.TextBox();
            this.plnameBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(138, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Your Name";
            // 
            // playerNameBox
            // 
            this.playerNameBox.Location = new System.Drawing.Point(152, 126);
            this.playerNameBox.Name = "playerNameBox";
            this.playerNameBox.Size = new System.Drawing.Size(133, 22);
            this.playerNameBox.TabIndex = 1;
            this.playerNameBox.TextChanged += new System.EventHandler(this.playerNameBox_TextChanged);
            // 
            // plnameBtn
            // 
            this.plnameBtn.Location = new System.Drawing.Point(219, 181);
            this.plnameBtn.Name = "plnameBtn";
            this.plnameBtn.Size = new System.Drawing.Size(100, 34);
            this.plnameBtn.TabIndex = 2;
            this.plnameBtn.Text = "Enter";
            this.plnameBtn.UseVisualStyleBackColor = true;
            this.plnameBtn.Click += new System.EventHandler(this.plnameBtn_Click);
            // 
            // PNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 291);
            this.Controls.Add(this.plnameBtn);
            this.Controls.Add(this.playerNameBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "PNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Player Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox playerNameBox;
        private System.Windows.Forms.Button plnameBtn;
    }
}