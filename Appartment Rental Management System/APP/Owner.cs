using Entity;
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
    public partial class Owner : Form
    {
        public Owner()
        {
            InitializeComponent();
        }
        void UpdateGridView()
        {
            ApartmentService aps = new ApartmentService();
            dataGridView1.DataSource = aps.GetAllApartments();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Owner_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OwnerApartment oa = new OwnerApartment();
            oa.Show();
            
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Payment p1 = new Payment();
            p1.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ApartmentService aps = new ApartmentService();
            int result = aps.Insert(new Apartment() { Area = textBoxArea.Text, RoadNo = Convert.ToInt32(textBoxRoad.Text), HouseNo = Convert.ToInt32(textBoxHouse.Text), Rent = Convert.ToInt32(textBoxRoad.Text), BedRoom = Convert.ToInt32(textBoxBed.Text), WashRoom = Convert.ToInt32(textBoxWash.Text), Balcony= Convert.ToInt32(textBoxBalcony.Text) });
            if (result > 0)
            {
                MessageBox.Show("Apartment Posted");
                UpdateGridView();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Owner_Load(object sender, EventArgs e)
        {

        }
    }
}
