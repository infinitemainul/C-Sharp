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
    public partial class LoginForm : Form
    {
        User user;
        int id;
        Eventservice even;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            user = new User();
            string username = userbox.Text;
            string pass = passbox.Text;
            even = new Eventservice();
           
            user = even.GetUser(username);
            if (user.Password == pass)
                {
                    
                    id = user.Id;
                    HomeForm home = new HomeForm(id);
                    home.ShowDialog();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("User name or Password is not valid");

                }
           





        }

        private void button1_Click(object sender, EventArgs e)
        {
            SigninForm signin = new SigninForm();
            signin.ShowDialog();
            this.Hide();
        }
    }
}
