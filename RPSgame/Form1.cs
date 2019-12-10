using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPSgame
{
    public partial class Form1 : Form
    {
        public static int player1 = 0;
        public static int computer = 0;
        public static int rock = 0;
        public static int paper = 0;
        public static int scissor = 0;
        public static int historyplayer = 0;
        public static int historycom = 0;

        Random rnd = new Random();
        public Form1()
        {
            
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;

        }
        public string PlayeLabel
        {
            get
            {
                return this.playeLabel.Text;
            }
            set
            {
                this.playeLabel.Text = value;
            }
        }
        public string PlayeLabel2
        {
            get
            {
                return this.playeLabel2.Text;
            }
            set
            {
                this.playeLabel2.Text = value;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            DialogResult dialog = new DialogResult();
            dialog = MessageBox.Show("Do you want to close?", "Alert!", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void rockBtn_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\" + "rock.bmp");


            int rand = rnd.Next(1, 30);

            if (rand >= 1 && rand <= 10)
            {
                this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\" + "rock.bmp");
                rock = 1;
                scissor = 0;
                paper = 0;
            }
            if (rand >= 11 && rand <= 20)
            {
                this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\" + "paper.bmp");
                rock = 0;
                scissor = 0;
                paper = 1;
            }
            if (rand >= 21 && rand <= 30)
            {
                this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\" + "scissors.bmp");
                rock = 0;
                scissor = 1;
                paper = 0;
            }

            if(rock==1)
            {
                textBox1.Text =""+player1;
                textBox2.Text =""+computer;
                string[] row1 = new string[] { "Rock", "Rock", "Tie" };
                dataGridView1.Rows.Add(row1);
            }
            if (paper == 1)
            {
                computer += 1;
                textBox1.Text = "" + player1;
                textBox2.Text = "" + computer;
                string[] row1 = new string[] { "Rock", "Paper", "Computer" };
                dataGridView1.Rows.Add(row1);
            }
            if (scissor == 1)
            {
                player1 += 1;
                textBox1.Text = "" + player1;
                textBox2.Text = "" + computer;
                string[] row1 = new string[] { "Rock", "Scissor", playeLabel.Text };
                dataGridView1.Rows.Add(row1);
            }
            if(checkGame(player1,computer))
            {
                if (player1 > computer)
                {
                    MessageBox.Show("Game Over.\n" + playeLabel.Text + " Wins.\n" + playeLabel.Text + "= " + player1 + "\nComputer= " + computer);
                    historyplayer +=1;
                    rockBtn.Enabled = false;
                    paperBtn.Enabled = false;
                    scissorBtn.Enabled = false;
                }
                if (player1 < computer)
                {
                    MessageBox.Show("Game Over.\n" + computerLabel.Text + " Wins\nLOL\n" + playeLabel.Text + "= " + player1 + "\nComputer= " + computer);
                    historycom += 1;
                    rockBtn.Enabled = false;
                    paperBtn.Enabled = false;
                    scissorBtn.Enabled = false;

                }
                
                Phistory.Text =String.Format("" + historyplayer);
                Chistory2.Text = String.Format("" + historycom);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void paperBtn_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\" + "paper.bmp");

            int rand = rnd.Next(1, 30);

            if (rand >= 1 && rand <= 10)
            {
                this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\" + "rock.bmp");
                rock = 1;
                scissor = 0;
                paper = 0;
            }
            if (rand >= 11 && rand <= 20)
            {
                this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\" + "paper.bmp");
                rock = 0;
                scissor = 0;
                paper = 1;
            }
            if (rand >= 21 && rand <= 30)
            {
                this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\" + "scissors.bmp");
                rock = 0;
                scissor = 1;
                paper = 0;
            }

            if (rock == 1)
            {
                player1 += 1;
                textBox1.Text = "" + player1;
                textBox2.Text = "" + computer;
                string[] row1 = new string[] { "Paper", "Rock", playeLabel.Text };
                dataGridView1.Rows.Add(row1);
            }
            if (paper == 1)
            {
                textBox1.Text = "" + player1;
                textBox2.Text = "" + computer;
                string[] row1 = new string[] { "Paper", "Paper", "Tie"};
                dataGridView1.Rows.Add(row1);
            }
            if (scissor == 1)
            {
                computer += 1;
                textBox1.Text = "" + player1;
                textBox2.Text = "" + computer;
                string[] row1 = new string[] { "Paper", "Scissor", computerLabel.Text };
                dataGridView1.Rows.Add(row1);
            }
            if (checkGame(player1, computer))
            {
                if (player1 > computer)
                {
                    MessageBox.Show("Game Over.\n" + playeLabel.Text + " Wins.\n" + playeLabel.Text + "= " + player1 + "\nComputer= " + computer);
                    historyplayer += 1;
                    rockBtn.Enabled = false;
                    paperBtn.Enabled = false;
                    scissorBtn.Enabled = false;
                }
                if (player1 < computer)
                {
                    MessageBox.Show("Game Over.\n" + computerLabel.Text + " Wins\nLOL\n" + playeLabel.Text + "= " + player1 + "\nComputer= " + computer);
                    historycom += 1;
                    rockBtn.Enabled = false;
                    paperBtn.Enabled = false;
                    scissorBtn.Enabled = false;

                }
                Phistory.Text = String.Format("" + historyplayer);
                Chistory2.Text = String.Format("" + historycom);

            }
        }

        private void scissorBtn_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\" + "scissors.bmp");
            int rand = rnd.Next(1, 30);

            if (rand >= 1 && rand <= 10)
            {
                this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\" + "rock.bmp");
                rock = 1;
                scissor = 0;
                paper = 0;
            }
            if (rand >= 11 && rand <= 20)
            {
                this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\" + "paper.bmp");
                rock = 0;
                scissor = 0;
                paper = 1;
            }
            if (rand >= 21 && rand <= 30)
            {
                this.pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\" + "scissors.bmp");
                rock = 0;
                scissor = 1;
                paper = 0;
            }

            if(rock==1)
            {
                computer += 1;
                textBox1.Text =""+player1;
                textBox2.Text =""+computer;
                string[] row1 = new string[] { "Scissor", "Rock", computerLabel.Text };
                dataGridView1.Rows.Add(row1);
            }
            if (paper == 1)
            {
                player1 += 1;
                textBox1.Text = "" + player1;
                textBox2.Text = "" + computer;
                string[] row1 = new string[] { "Scissor", "Paper", playeLabel.Text };
                dataGridView1.Rows.Add(row1);
            }
            if (scissor == 1)
            {
                textBox1.Text = "" + player1;
                textBox2.Text = "" + computer;
                string[] row1 = new string[] { "Scissor", "Scissor", "Tie" };
                dataGridView1.Rows.Add(row1);
            }
            if(checkGame(player1,computer))
            {
                if (player1 > computer)
                {
                    MessageBox.Show("Game Over.\n" + playeLabel.Text + " Wins.\n" + playeLabel.Text + "= " + player1 + "\nComputer= " + computer);
                    historyplayer += 1;
                    rockBtn.Enabled = false;
                    paperBtn.Enabled = false;
                    scissorBtn.Enabled = false;
                }
                if (player1 < computer)
                {
                    MessageBox.Show("Game Over.\n" + computerLabel.Text + " Wins\nLOL\n" + playeLabel.Text + "= " + player1 + "\nComputer= " + computer);
                    historycom += 1;
                    rockBtn.Enabled = false;
                    paperBtn.Enabled = false;
                    scissorBtn.Enabled = false;

                }
                Phistory.Text = String.Format("" + historyplayer);
                Chistory2.Text = String.Format("" + historycom);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.ColumnCount=3;
            dataGridView1.Columns[0].Width = 80;
            dataGridView1.Columns[1].Width = 80;
            dataGridView1.Columns[2].Width = 80;
            dataGridView1.Columns[0].Name = ""+ playeLabel.Text;
            dataGridView1.Columns[1].Name = "Computer";
            dataGridView1.Columns[2].Name = "Winner";


        }
        private bool checkGame(int a, int b)
        {
            if(a==5 || b==5)
            {
                return true;

            }
            return false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox.Checked == true)
            {
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            }
            else
                dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;

        }

        private void playAgainBtn_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            textBox1.Text = "0";
            textBox2.Text = "0";
            player1 = 0;
            computer = 0;
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            rockBtn.Enabled = true;
            paperBtn.Enabled = true;
            scissorBtn.Enabled = true;

        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
                 MessageBox.Show("The winner is decided by a set of rules:\n ->Rock breaks scissors\n ->Paper covers rock\n ->Scissors cut paper\n ->There is a tie (both players pick the same thing)");
        }
    }
}
