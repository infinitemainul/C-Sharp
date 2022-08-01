using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Bsinesslogiclayer;

namespace WindowsFormsApp1.Presentationlayer
{
    public partial class HomeForm : Form
    {
        int id;
        Eventservice even;
        Events ev;
        string create;
        public HomeForm(int uid)
        {
            even = new Eventservice();
            id = uid;
            InitializeComponent();
            load();
           
        }
        void load()
        {
            AlldataGridView1.DataSource = even.GetAllEvent(id);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string path;
        static int count;
        

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                count++;
                pictureBox1.Image = new Bitmap(fd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                path = @"C:\Users\ASUS\Desktop\Project\" + count + ".jpg";
                File.Copy(fd.FileName, path);





            }





        }

        private void button2_Click(object sender, EventArgs e)
        {
            even = new Eventservice();
            int result = even.AddEvent(Namebox.Text, Createdate.Value.Date.ToString(), Eventdate.Value.Date.ToString(), path, Descriptionbox.Text, id, Importancebox.Text);
            if (result == 1)
            {
              

                MessageBox.Show("Event Added");
                load();
                


            }
            else
            {
               
                MessageBox.Show("Error");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int eventid = Int32.Parse(textBox1.Text);
            even = new Eventservice();
            ev = new Events();
            ev = even.Getthatevent(eventid);
                Enamebox.Text = ev.Name;
                Eeventdatebox.Value = DateTime.Parse(ev.Eventdate);
                Edescriptionbox.Text = ev.Description;
              //  Emodifydatebox.Value = DateTime.Parse(ev.Modifydate);
                Eimportancebox.Text = ev.Importance;
                create = ev.Createdate;
                if (ev.Pic != null)
                {
                    path = ev.Pic;
                    Image image = Image.FromFile(ev.Pic);
                    this.pictureBox2.Image = image;
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                }


           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            even = new Eventservice();
           
           
            int result = even.UpdateEvent(Enamebox.Text,create, Emodifydatebox.Value.Date.ToString(), Eeventdatebox.Value.Date.ToString(), path, Edescriptionbox.Text, id, Eimportancebox.Text, Int32.Parse(textBox1.Text));
            if (result == 1)
            {
                

                MessageBox.Show("Event Updated");
                load();


            }
            else
            {
               
                MessageBox.Show("Error");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            even = new Eventservice();
           

            int result = even.DeleteEvent(Convert.ToInt32(Eventidbox.Text));
            if (result == 1)
            {
                
                MessageBox.Show("Event Deleted");
                load();

            }
            else
            {
                
                MessageBox.Show("Error");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                count++;
                pictureBox1.Image = new Bitmap(fd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                path = @"C:\Users\ASUS\Desktop\Project\" + count + ".jpg";
                File.Copy(fd.FileName, path);





            }

        }
    }
}
