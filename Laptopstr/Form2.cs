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
    public partial class Form2 : Form
    {
        LaptopStrEntities db = new LaptopStrEntities();
        databarang data = new databarang();
        datauser user = new datauser();
        int id;
        public Form2()
        {
            InitializeComponent();
        }
        void clear()
        {
            txtbnama.Text = txtbharga.Text = txtbstok.Text = "";
            btncreate.Text = "Save";
            user.idbarang = 0;
        }

        void LoadData()
        {
            var data = db.databarangs.ToList();
            dataGridView1.DataSource = data;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ReadOnly = true;
            if (dataGridView1.Columns["Hapus"] == null)
            {
                DataGridViewImageColumn btnHapus = new DataGridViewImageColumn
                {
                    Name = "Hapus",
                    HeaderText = "Aksi",
                    Image = Properties.Resources.Trash,
                    ImageLayout = DataGridViewImageCellLayout.Zoom
                };
                dataGridView1.Columns.Add(btnHapus);
            }
        }
        private void btncreate_Click(object sender, EventArgs e)
        {
            data.Nama = txtbnama.Text.Trim();
            data.Harga = txtbharga.Text.Trim();
            data.Stok = txtbstok.Text.Trim();
            db.databarangs.Add(data);
            db.SaveChanges();
            clear();
            LoadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            if (e.RowIndex >= 0)
            {
                id = (int)row.Cells["idbarang"].Value;
                txtbnama.Text = row.Cells["Nama"].Value.ToString();
                txtbharga.Text = row.Cells["Harga"].Value.ToString();
                txtbstok.Text = row.Cells["Stok"].Value.ToString();
                if (row.Cells["Hapus"].Selected)
                {
                    int id = (int)row.Cells["idbarang"].Value;
                    var msg = MessageBox.Show("Apakah Anda Ingin Menghapus Data Ini?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (msg == DialogResult.Yes)
                    {
                        var data = db.databarangs.FirstOrDefault(x => x.idbarang == id);
                        db.databarangs.Remove(data);
                        db.SaveChanges();
                        MessageBox.Show("Data berhasil dihapus", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                }

            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            var barang = db.databarangs.FirstOrDefault(x => x.idbarang == id);
            barang.Nama = txtbnama.Text;
            barang.Harga = txtbharga.Text;
            barang.Stok = txtbstok.Text;
            db.SaveChanges();
            MessageBox.Show("Data Berhasil Di Update");
            LoadData();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
