using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminInformation ai1 = new AdminInformation();
            ai1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ViewData vd = new ViewData();
            vd.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
