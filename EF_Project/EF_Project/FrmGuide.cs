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
    public partial class FrmGuide : Form
    {
        public FrmGuide()
        {
            InitializeComponent();
        }

        DbEFEntities db = new DbEFEntities();

        void Listele()
        {
            dataGridView1.DataSource = db.TblGuide.ToList();
        }
        private void FrmGuide_Load(object sender, EventArgs e)
        {
            Listele();
        }
        private void btnListele_Click_1(object sender, EventArgs e)
        {
            Listele();
            MessageBox.Show("Listeleme işlemi yapılmıştır.", "Bilgi");
        }
        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            TblGuide tblGuide = new TblGuide();
            tblGuide.GuideName = txtad.Text;
            tblGuide.GuideSurname = txtsoyad.Text;
            db.TblGuide.Add(tblGuide);
            db.SaveChanges();
            MessageBox.Show("Ekleme işlemi yapılmıştır", "Bilgi", MessageBoxButtons.OK);
            Listele();
        }
        private void btnSil_Click_1(object sender, EventArgs e)
        {
            var id = int.Parse(txtid.Text);
            var guide = db.TblGuide.Find(id);
            db.TblGuide.Remove(guide);
            db.SaveChanges();
            MessageBox.Show("Silme işlemi yapılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
        }
        private void btnGuncelle_Click_1(object sender, EventArgs e)
        {
            var id = int.Parse(txtid.Text);
            var bulunanid = db.TblGuide.Find(id);

            bulunanid.GuideName = txtad.Text;
            bulunanid.GuideSurname = txtsoyad.Text;
            db.SaveChanges();
            MessageBox.Show("Güncelleme işlemi yapılmıştır", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
        }
        private void btnid_Click_1(object sender, EventArgs e)
        {
            var id = int.Parse(txtid.Text);

            var values = db.TblGuide.Where(x => x.GuideId == id).ToList();
            dataGridView1.DataSource = values;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtid.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
