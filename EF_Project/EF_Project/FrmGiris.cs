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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnGuide_Click(object sender, EventArgs e)
        {
            FrmGuide frmGuide = new FrmGuide();
            frmGuide.Show();
            this.Hide();
        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            FrmLocation frmLocation = new FrmLocation();
            frmLocation.Show();
            this.Hide();
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            FrmIstatıstık frmIstatıstık = new FrmIstatıstık();
            frmIstatıstık.Show();
            this.Hide();
        }
    }
}
