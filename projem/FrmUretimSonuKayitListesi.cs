using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projem
{
    public partial class FrmUretimSonuKayitListesi : Form
    {
        public static string fisno;
        SqlConnection conn = new SqlConnection("Data Source=HALIL;Initial Catalog=proje;Integrated Security=True");
        public FrmUretimSonuKayitListesi()
        {
            InitializeComponent();
        }

        void arama()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT URETIMSONUKAYDI_NUMARASI, ISEMRI_NUMARASI, STOK_KODU, STOK_ADI, SIPARIS_NUMARASI, MUSTERI_ADI FROM TBL_URETIMSONUKAYITLARI   WHERE URETIMSONUKAYDI_NUMARASI LIKE '%"+txtFisNo.Text+"%'   AND SIPARIS_NUMARASI LIKE '%"+txtSiparisNo.Text+"%' AND STOK_KODU LIKE '%"+txtStokKodu.Text+"%'   AND STOK_ADI LIKE '%"+txtStokAdi.Text+"%'   AND MUSTERI_ADI LIKE '%"+txtMüsteriAdi.Text+"%'  AND ISEMRI_NUMARASI LIKE '%"+txtİsEmriNumarasi.Text+"%'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            gridControl1.DataSource = dt;
            conn.Close();
        }

        private void Si_Enter(object sender, EventArgs e)
        {

        }

        private void FrmUretimSonuKayitListesi_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            gridView1.OptionsBehavior.Editable = false;
            arama();
        }

        private void txtFisNo_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtSiparisNo_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtStokKodu_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtStokAdi_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtMüsteriAdi_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtİsEmriNumarasi_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(fisno == "uretimsonukaydi")
            {
                fisno = x["URETIMSONUKAYDI_NUMARASI"].ToString();
                FrmUretimSonuKayitlari.fisx = "uretimsonukaydi";
                this.Hide();
                FrmUretimSonuKayitlari frm = new FrmUretimSonuKayitlari();
                frm.Activate();
            }
        }

        private void FrmUretimSonuKayitListesi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }
    }
}
