namespace RPSgame
{
    partial class startForm
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
            this.startBtn = new System.Windows.Forms.Button();
            this.closeBtn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(721, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Rock-Paper-Scissor Game";
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(175, 303);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(197, 96);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // closeBtn1
            // 
            this.closeBtn1.Font = new System.Drawing.Font("Modern No. 20", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn1.Location = new System.Drawing.Point(467, 303);
            this.closeBtn1.Name = "closeBtn1";
            this.closeBtn1.Size = new System.Drawing.Size(197, 96);
            this.closeBtn1.TabIndex = 2;
            this.closeBtn1.Text = "Close";
            this.closeBtn1.UseVisualStyleBackColor = true;
            this.closeBtn1.Click += new System.EventHandler(this.closeBtn1_Click);
            // 
            // startForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 684);
            this.Controls.Add(this.closeBtn1);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "startForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissor";
            this.Load += new System.EventHandler(this.startForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button closeBtn1;
    }
}