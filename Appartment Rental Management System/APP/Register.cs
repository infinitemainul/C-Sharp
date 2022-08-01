using Services;
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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationService registration = new RegistrationService();
            int usertype = 0;
            if (radioButtonCustomer.Checked)
            {
                usertype = 2;
            }
            else { usertype = 3; }

            int result = registration.UserRegistration(textBoxName.Text, textBoxEmail.Text, textBoxContact.Text, textBoxUName.Text,textBoxPassword.Text, usertype);
            if (result > 0)
            {
                MessageBox.Show("Account Created");
                Login login = new Login();
                this.Hide();
                login.Show();
            }
            else
            {
                MessageBox.Show("Error");
            }

           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
    }
}
