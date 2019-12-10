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
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {

            this.Hide();
            PNameForm pname = new PNameForm();
            pname.Show();
        }

        private void closeBtn1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void startForm_Load(object sender, EventArgs e)
        {

        }
    }
}
