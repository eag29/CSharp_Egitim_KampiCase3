using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_Project
{
    public partial class FrmLocation : Form
    {
        public FrmLocation()
        {
            InitializeComponent();
        }

        DbEFEntities db = new DbEFEntities();

        void Listele()
        {
            dataGridView1.DataSource = db.TblLocation.ToList();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            Listele();
            MessageBox.Show("Lokasyonlar Listelenmiştir. ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmLocation_Load_1(object sender, EventArgs e)
        {
            Listele();

            var values = db.TblGuide.Select(x => new
            {
                FullName = x.GuideName + " " + x.GuideSurname,
                x.GuideId
            }
            ).ToList();
            cmbRehber.DisplayMember = "FullName";
            cmbRehber.ValueMember = "GuideId";
            cmbRehber.DataSource = values;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TblLocation tblLocation = new TblLocation();
            tblLocation.City = txtsehir.Text;
            tblLocation.Country = txtulke.Text;
            tblLocation.Capacity = byte.Parse(numericUpDown1.Value.ToString());
            tblLocation.Price = Convert.ToInt32(txtFiyat.Text);
            tblLocation.DayNight = txtGunGece.Text;
            tblLocation.GuideId = int.Parse(cmbRehber.SelectedValue.ToString());
            db.TblLocation.Add(tblLocation);
            db.SaveChanges();
            MessageBox.Show("Lokasyon Eklenmiştir. ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtid.Text);
            var bulunanid = db.TblLocation.Find(id);
            db.TblLocation.Remove(bulunanid);
            db.SaveChanges();
            MessageBox.Show("Lokasyon Silinmiştir. ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            var id = int.Parse(txtid.Text);
            var bulunanid = db.TblLocation.Find(id);
            bulunanid.Country = txtulke.Text;
            bulunanid.City = txtsehir.Text;
            bulunanid.Capacity = byte.Parse(numericUpDown1.Value.ToString());
            bulunanid.Price = Convert.ToInt32(txtFiyat.Text);
            bulunanid.DayNight = txtGunGece.Text;
            bulunanid.GuideId = int.Parse(cmbRehber.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Lokasyon Güncellenmiştir. ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtsehir.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtulke.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            numericUpDown1.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtGunGece.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            cmbRehber.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
