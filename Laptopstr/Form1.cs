using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laptopstr
{
    public partial class Form1 : Form
    {
        LaptopStrEntities db = new LaptopStrEntities(); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void login()
        {
            var Nama = txtbnama.Text;
            var Password = txtbpassword.Text;   
            var Data = db.datausers.FirstOrDefault(x => x.Nama == Nama && x.Password == Password);
            if (Data != null)
            {
                MessageBox.Show("Welcome " + Data.Nama);
                Form2 form2 = new Form2();
                form2.Show();
                this.Hide();    
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();    
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register regis = new register();
            regis.ShowDialog(); 
        }
    }
}
