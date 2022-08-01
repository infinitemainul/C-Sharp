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
    public partial class ViewStudentInformation : Form
    {
        public ViewStudentInformation()
        {
            InitializeComponent();
        }

        private void txtSearchEnrollement_TextChanged(object sender, EventArgs e)
        {
            if(txtSearchEnrollement.Text != "")
            {
                Image image = Image.FromFile("C:/Users/rahad/Downloads/Liberay Management System/search1.gif");
                pictureBox1.Image = image;
                //label1.Hide();
                label1.Visible = false;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-GN8C826; database = master; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
               
                cmd.CommandText = "select * from NewStudent where enroll LIKE '"+txtSearchEnrollement.Text+"%'";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            else
            {
                Image image = Image.FromFile("C:/Users/rahad/Downloads/Liberay Management System/search.gif");
                pictureBox1.Image = image;
                label1.Visible = true;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-GN8C826; database = master; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NewStudent";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void ViewStudentInformation_Load(object sender, EventArgs e)
        {
            panel2.Visible = false;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-GN8C826; database = master; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }

        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            panel2.Visible = true;
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = DESKTOP-GN8C826; database = master; integrated security = True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewStudent where stuid = "+bid+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            
            rowid = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());

            txtSName.Text = ds.Tables[0].Rows[0][1].ToString();
            txtEnrollment.Text = ds.Tables[0].Rows[0][2].ToString();
            txtDepartment.Text = ds.Tables[0].Rows[0][3].ToString();
            txtSemester.Text = ds.Tables[0].Rows[0][4].ToString();
            txtContact.Text = ds.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = ds.Tables[0].Rows[0][6].ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string sname = txtSName.Text;
            string enroll = txtEnrollment.Text;
            string dep = txtDepartment.Text;
            string sem = txtSemester.Text;
            string contact = txtContact.Text;
            string semail = txtEmail.Text;

            if (MessageBox.Show("Data will be Updated", "Success", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-GN8C826; database = master; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                //  sname, enroll, dep, sem, contact, email         same work as we take bid instead of rowid
                cmd.CommandText = "update NewStudent set sname ='" + sname + "',enroll ='" + enroll + "',dep ='" + dep + "',sem ='" + sem + "',contact ='" + contact + "',email ='" + semail + "' where stuid = " + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                ViewStudentInformation_Load(this, null);
                
            }

            //**************************by doing this below code i can see the imidate update****************************

            //SqlConnection cn = new SqlConnection();
            //cn.ConnectionString = "data source = DESKTOP-GN8C826; database = master; integrated security = True";
            //SqlCommand m = new SqlCommand();
            //m.Connection = cn;

            //m.CommandText = "select * from NewStudent";
            //SqlDataAdapter daa = new SqlDataAdapter(m);
            //DataSet dss = new DataSet();
            //daa.Fill(dss);

            //dataGridView1.DataSource = dss.Tables[0];
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ViewStudentInformation_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Data will be Deleted", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = DESKTOP-GN8C826; database = master; integrated security = True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete from NewStudent where stuid = " + rowid + "";
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                ViewStudentInformation_Load(this, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Unsaved Data will be lost","Are you sure?",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
