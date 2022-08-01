using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Bsinesslogiclayer;

namespace WindowsFormsApp1.Presentationlayer
{
    public partial class SigninForm : Form
    {
        Eventservice ab;
        public SigninForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Name.Text == "" || Passbox.Text == "" || Conbox.Text == "")
            {
                MessageBox.Show("Please fill all boxs");

            }
            else if (Passbox.Text != Conbox.Text)
            {
                MessageBox.Show("Confirm passward and passward must be same");
            }
            else
            {
                ab = new Eventservice();
                int result = ab.Adduser(Name.Text, Passbox.Text);
                if (result == 1)
                {
                    

                    MessageBox.Show("User Added. Now you can login with your passward");

                    LoginForm log = new LoginForm();
                    log.ShowDialog();
                    this.Hide();
                   




                }
                else
                {
                    
                    MessageBox.Show("Error");
                }

            }
        }
    }
}
