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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginService loginService = new LoginService();
            string username = textBoxName.Text;
            string password = textBoxPassword.Text;

            if (username == string.Empty || password == string.Empty)
            {
                MessageBox.Show("Input UserName and Password Correctly");

            }
            else
            {
                int result = loginService.LoginValidation(username, password);
                if (result > 0)
                {
                    if (result == 1)
                    {
                        Admin a = new Admin();
                        a.Show();
                        this.Hide();
                    }

                    else if (result == 2)
                    {
                        Customer c = new Customer();
                        c.Show();
                        this.Hide();
                    }

                    else if (result == 3)
                    {
                        Owner o = new Owner();
                        o.Show();
                        this.Hide();
                    }
                    else if(result == 0)
                    {
                        MessageBox.Show("User does not exist.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            
            
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register r = new Register();
            r.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxName.Text = "";
            textBoxPassword.Text = "";

        }
    }
}
