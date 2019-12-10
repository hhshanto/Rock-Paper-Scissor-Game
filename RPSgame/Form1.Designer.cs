namespace RPSgame
{
    partial class Form1
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
            this.playeLabel = new System.Windows.Forms.Label();
            this.computerLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rockBtn = new System.Windows.Forms.Button();
            this.paperBtn = new System.Windows.Forms.Button();
            this.scissorBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.checkbox = new System.Windows.Forms.CheckBox();
            this.playerScorelabel = new System.Windows.Forms.Label();
            this.computerScorelabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.closeBtn = new System.Windows.Forms.Button();
            this.playAgainBtn = new System.Windows.Forms.Button();
            this.historyLabel = new System.Windows.Forms.Label();
            this.Chistory2 = new System.Windows.Forms.Label();
            this.Phistory = new System.Windows.Forms.Label();
            this.Chistory = new System.Windows.Forms.Label();
            this.playeLabel2 = new System.Windows.Forms.Label();
            this.helpBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // playeLabel
            // 
            this.playeLabel.AutoSize = true;
            this.playeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playeLabel.Location = new System.Drawing.Point(75, 76);
            this.playeLabel.Name = "playeLabel";
            this.playeLabel.Size = new System.Drawing.Size(73, 25);
            this.playeLabel.TabIndex = 0;
            this.playeLabel.Text = "Player";
            // 
            // computerLabel
            // 
            this.computerLabel.AutoSize = true;
            this.computerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerLabel.Location = new System.Drawing.Point(321, 76);
            this.computerLabel.Name = "computerLabel";
            this.computerLabel.Size = new System.Drawing.Size(106, 25);
            this.computerLabel.TabIndex = 1;
            this.computerLabel.Text = "Computer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(35, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 321);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(278, 114);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 321);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(227, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "VS";
            // 
            // rockBtn
            // 
            this.rockBtn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rockBtn.Location = new System.Drawing.Point(35, 462);
            this.rockBtn.Name = "rockBtn";
            this.rockBtn.Size = new System.Drawing.Size(131, 41);
            this.rockBtn.TabIndex = 5;
            this.rockBtn.Text = "ROCK";
            this.rockBtn.UseVisualStyleBackColor = true;
            this.rockBtn.Click += new System.EventHandler(this.rockBtn_Click);
            // 
            // paperBtn
            // 
            this.paperBtn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paperBtn.Location = new System.Drawing.Point(35, 519);
            this.paperBtn.Name = "paperBtn";
            this.paperBtn.Size = new System.Drawing.Size(131, 41);
            this.paperBtn.TabIndex = 6;
            this.paperBtn.Text = "PAPER";
            this.paperBtn.UseVisualStyleBackColor = true;
            this.paperBtn.Click += new System.EventHandler(this.paperBtn_Click);
            // 
            // scissorBtn
            // 
            this.scissorBtn.Font = new System.Drawing.Font("Lucida Sans Typewriter", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scissorBtn.Location = new System.Drawing.Point(35, 576);
            this.scissorBtn.Name = "scissorBtn";
            this.scissorBtn.Size = new System.Drawing.Size(131, 41);
            this.scissorBtn.TabIndex = 7;
            this.scissorBtn.Text = "SCISSOR";
            this.scissorBtn.UseVisualStyleBackColor = true;
            this.scissorBtn.Click += new System.EventHandler(this.scissorBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(503, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(327, 285);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(573, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Score";
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Location = new System.Drawing.Point(678, 79);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(134, 21);
            this.checkbox.TabIndex = 10;
            this.checkbox.Text = "Enable Gridlines";
            this.checkbox.UseVisualStyleBackColor = true;
            this.checkbox.CheckedChanged += new System.EventHandler(this.checkbox_CheckedChanged);
            // 
            // playerScorelabel
            // 
            this.playerScorelabel.AutoSize = true;
            this.playerScorelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScorelabel.Location = new System.Drawing.Point(519, 417);
            this.playerScorelabel.Name = "playerScorelabel";
            this.playerScorelabel.Size = new System.Drawing.Size(56, 20);
            this.playerScorelabel.TabIndex = 11;
            this.playerScorelabel.Text = "Player";
            // 
            // computerScorelabel
            // 
            this.computerScorelabel.AutoSize = true;
            this.computerScorelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computerScorelabel.Location = new System.Drawing.Point(641, 417);
            this.computerScorelabel.Name = "computerScorelabel";
            this.computerScorelabel.Size = new System.Drawing.Size(82, 20);
            this.computerScorelabel.TabIndex = 12;
            this.computerScorelabel.Text = "Computer";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox1.Location = new System.Drawing.Point(519, 440);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(56, 31);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "0";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox2.Location = new System.Drawing.Point(645, 440);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(59, 31);
            this.textBox2.TabIndex = 14;
            this.textBox2.Text = "0";
            // 
            // closeBtn
            // 
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(678, 593);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(134, 61);
            this.closeBtn.TabIndex = 15;
            this.closeBtn.Text = "Close";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // playAgainBtn
            // 
            this.playAgainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainBtn.Location = new System.Drawing.Point(735, 417);
            this.playAgainBtn.Name = "playAgainBtn";
            this.playAgainBtn.Size = new System.Drawing.Size(95, 54);
            this.playAgainBtn.TabIndex = 16;
            this.playAgainBtn.Text = "Play Again";
            this.playAgainBtn.UseVisualStyleBackColor = true;
            this.playAgainBtn.Click += new System.EventHandler(this.playAgainBtn_Click);
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Location = new System.Drawing.Point(326, 495);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(52, 17);
            this.historyLabel.TabIndex = 17;
            this.historyLabel.Text = "History";
            // 
            // Chistory2
            // 
            this.Chistory2.AutoSize = true;
            this.Chistory2.Location = new System.Drawing.Point(381, 543);
            this.Chistory2.Name = "Chistory2";
            this.Chistory2.Size = new System.Drawing.Size(16, 17);
            this.Chistory2.TabIndex = 18;
            this.Chistory2.Text = "0";
            // 
            // Phistory
            // 
            this.Phistory.AutoSize = true;
            this.Phistory.Location = new System.Drawing.Point(301, 543);
            this.Phistory.Name = "Phistory";
            this.Phistory.Size = new System.Drawing.Size(16, 17);
            this.Phistory.TabIndex = 19;
            this.Phistory.Text = "0";
            // 
            // Chistory
            // 
            this.Chistory.AutoSize = true;
            this.Chistory.Location = new System.Drawing.Point(362, 519);
            this.Chistory.Name = "Chistory";
            this.Chistory.Size = new System.Drawing.Size(69, 17);
            this.Chistory.TabIndex = 20;
            this.Chistory.Text = "Computer";
            // 
            // playeLabel2
            // 
            this.playeLabel2.AutoSize = true;
            this.playeLabel2.Location = new System.Drawing.Point(289, 519);
            this.playeLabel2.Name = "playeLabel2";
            this.playeLabel2.Size = new System.Drawing.Size(48, 17);
            this.playeLabel2.TabIndex = 21;
            this.playeLabel2.Text = "Player";
            // 
            // helpBtn
            // 
            this.helpBtn.Location = new System.Drawing.Point(777, 12);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(75, 33);
            this.helpBtn.TabIndex = 22;
            this.helpBtn.Text = "Help";
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(886, 684);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.playeLabel2);
            this.Controls.Add(this.Chistory);
            this.Controls.Add(this.Phistory);
            this.Controls.Add(this.Chistory2);
            this.Controls.Add(this.historyLabel);
            this.Controls.Add(this.playAgainBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.computerScorelabel);
            this.Controls.Add(this.playerScorelabel);
            this.Controls.Add(this.checkbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.scissorBtn);
            this.Controls.Add(this.paperBtn);
            this.Controls.Add(this.rockBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.computerLabel);
            this.Controls.Add(this.playeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rock Paper Scissor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label playeLabel;
        private System.Windows.Forms.Label computerLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rockBtn;
        private System.Windows.Forms.Button paperBtn;
        private System.Windows.Forms.Button scissorBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkbox;
        private System.Windows.Forms.Label playerScorelabel;
        private System.Windows.Forms.Label computerScorelabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button playAgainBtn;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.Label Chistory2;
        private System.Windows.Forms.Label Phistory;
        private System.Windows.Forms.Label Chistory;
        private System.Windows.Forms.Label playeLabel2;
        private System.Windows.Forms.Button helpBtn;
    }
}

