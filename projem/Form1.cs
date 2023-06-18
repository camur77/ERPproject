using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStokKayıtları frm = new FrmStokKayıtları();
            frm.Show();        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMusteriKayitlari frm = new FrmMusteriKayitlari();
            frm.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSiparisler frm = new FrmSiparisler();   
            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmIsEmri frmIsEmri = new FrmIsEmri();
            frmIsEmri.Show();   
        }

        private void z_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUretimSonuKayitlari frm = new FrmUretimSonuKayitlari();
            frm.Show();
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStokHareketleri frm = new FrmStokHareketleri();
            frm.Show();
        }

        private void St_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmStokHareketleri frm = new FrmStokHareketleri();
            frm.Show();
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmSiparisSevk frmSiparisSevk = new FrmSiparisSevk();
            frmSiparisSevk.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGenelRapor frmGenelRapor = new FrmGenelRapor();
            frmGenelRapor.MdiParent = this;
            frmGenelRapor.Show();
        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUretilecekIsEmirleri frm = new FrmUretilecekIsEmirleri();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
