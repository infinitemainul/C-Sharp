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
    public partial class OwnerApartment : Form
    {
        public OwnerApartment()
        {
            InitializeComponent();
        }
        void UpdateGridView()
        {
            ApartmentService aps = new ApartmentService();
            dataGridView1.DataSource = aps.GetAllApartments();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Owner owner = new Owner();
            owner.Show();
            this.Hide();
        }

        private void OwnerApartment_Load(object sender, EventArgs e)
        {
            ApartmentService catService = new ApartmentService();
            dataGridView1.DataSource = catService.GetAllApartments();
        }
    }
}
