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
    public partial class FrmIstatıstık : Form
    {
        public FrmIstatıstık()
        {
            InitializeComponent();
        }

        DbEFEntities db = new DbEFEntities();

        private void FrmIstatıstık_Load(object sender, EventArgs e)
        {
            #region Toplam Lokasyon Sayısı

            lblLocationCount.Text = db.TblLocation.Count().ToString();

            #endregion

            #region Toplam Kapasite Sayısı
            lblCapacityCount.Text = db.TblLocation.Sum(x => x.Capacity).ToString();
            #endregion

            #region Toplam Rehber Sayısı

            lblGuideCount.Text = db.TblGuide.Count().ToString();

            #endregion

            #region Ortalama Kapasite Sayısı

            lblAverageCapacity.Text = db.TblLocation.Average(x => x.Capacity).ToString();

            #endregion

            #region Ortalama Tur Fiyati

            lblAveragePrice.Text = db.TblLocation.Average(x => x.Price).ToString();

            #endregion

            #region Eklenen Son Ülke

            int lastCountryId = db.TblLocation.Max(x => x.LocationId);
            lblLastCountry.Text = db.TblLocation.Where(x => x.LocationId == lastCountryId).Select(y => y.Country).FirstOrDefault();

            #endregion

            #region Kapadokya Tur Kapasitesi

            lblKapadokyaTourCapacity.Text = db.TblLocation.Where(x => x.City == "Kapadokya").Select(y => y.Capacity).FirstOrDefault().ToString();

            #endregion

            #region Türkiye Ortalama Tur Kapasitesi

            lblTurkiyeCapacityTurAvrg.Text = db.TblLocation.Where(x => x.Country == "Türkiye").Average(y => y.Capacity).ToString();

            #endregion

            #region Roma Rehberinin İsmi

            var RomeGuideId = db.TblLocation.Where(x => x.City == "Roma").Select(y => y.GuideId).FirstOrDefault();
            label23.Text = db.TblGuide.Where(x => x.GuideId == RomeGuideId).Select(y => y.GuideName + " " + y.GuideSurname).FirstOrDefault().ToString();

            #endregion

            #region En Yüksek Kapasiteli Tur

            var maxCapacity = db.TblLocation.Max(x => x.Capacity);
            lblmaxTur.Text = db.TblLocation.Where(x => x.Capacity == maxCapacity).Select(y => y.Country).FirstOrDefault().ToString();

            #endregion

            #region En Pahalı Tur

            var maxLocationCount = db.TblLocation.Max(x => x.Price);
            lblmaxPriceLoaciton.Text = db.TblLocation.Where(x => x.Price == maxLocationCount).Select(y => y.City).FirstOrDefault().ToString();

            #endregion

            #region Melih Kaya Tur Sayısı

            var guidename = db.TblGuide.Where(x => x.GuideName == "Melih" && x.GuideSurname == "Kaya").Select(y => y.GuideId).FirstOrDefault();
            lblMelih.Text = db.TblLocation.Where(x => x.GuideId == guidename).Count().ToString();

            #endregion
        }
    }
}
