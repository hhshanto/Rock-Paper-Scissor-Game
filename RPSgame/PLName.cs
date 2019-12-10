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
    public partial class PNameForm : Form
    {
        public PNameForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void plnameBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 main = new Form1();
            if(playerNameBox.Text=="")
            {
                main.PlayeLabel = "Player";
                main.PlayeLabel2= "Player";
            }
            else
            {
                main.PlayeLabel = playerNameBox.Text;
                main.PlayeLabel2 = playerNameBox.Text;
            }
            
            main.Show();
            
        }

        private void playerNameBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}