using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtFName.Text == "" || txtLName.Text == "" || txtUsername.Text == "" || txtEmail.Text == "" )
            {
                MessageBox.Show("Fill The Blank Text Box", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (radioButton1Male.Checked == false && radioButton2FeMale.Checked == false)
            {
                MessageBox.Show("Select Your Gender", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password did not match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txtPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Enter the Password", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (conditionCheckBox.Checked == false)
            {
                MessageBox.Show("Please select the agreement");
            }
            else
            {
                string gender;
                if (radioButton1Male.Checked)
                {
                    gender = radioButton1Male.Text;
                }
                else
                {
                    gender = radioButton2FeMale.Text;
                }
                string fname = txtFName.Text;
                string lname = txtLName.Text;
                string email = txtEmail.Text;
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-GN8C826; database = master; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                con.Open();
                cmd.CommandText = "insert into SignUp (SFName, SLName, SGender, SEmail, SUsername, SPassword) values ('" + fname + "','" + lname + "','" + gender + "','" + email + "','" + username + "','" + password + "')";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}
