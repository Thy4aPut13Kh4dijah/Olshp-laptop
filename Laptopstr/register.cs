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
    public partial class register : Form
    {
        LaptopStrEntities db = new LaptopStrEntities();
        public register()
        {
            InitializeComponent();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }

        void regist() 
        {
            datauser d = new datauser();
            d.Nama = txtbnama.Text; 
            d.Password = txtbpassword.Text;

            db.datausers.Add(d);
            db.SaveChanges();
            MessageBox.Show("Yeay berhasil");
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            regist();   
        }
    }
}
