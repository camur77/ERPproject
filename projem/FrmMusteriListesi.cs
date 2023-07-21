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
    public partial class FrmMusteriListesi : Form
    {
        public static string musterıkodu;
        SqlConnection conn = new SqlConnection("Data Source=HALIL;Initial Catalog=proje;Integrated Security=True");
        public FrmMusteriListesi()
        {
            InitializeComponent();
        }

        void arama()
        {
            conn.Open();    
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT MUSTERI_KODU, MUSTERI_ADI, IL ,ILCE FROM TBL_MUSTERIKAYITLARI WHERE MUSTERI_KODU LIKE '%"+txtMusteriKodu.Text+"%' AND MUSTERI_ADI LIKE '%"+txtMusteriAdi.Text+"%' AND IL LIKE '%"+txtIl.Text+"%' AND ILCE LIKE '%"+txtIlce.Text+"%'", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            sqlDataAdapter.Fill(dt);
            gridControl1.DataSource = dt;
            conn.Close();
        }
        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void FrmMusteriListesi_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            gridView1.OptionsBehavior.Editable = false;
            arama();
        }

        private void txtMusteriKodu_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtMusteriAdi_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtIl_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtIlce_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (musterıkodu == "musterikayit")
            {
                musterıkodu = x["MUSTERI_KODU"].ToString();
                this.Hide();
                FrmMusteriKayitlari frm = new FrmMusteriKayitlari();
                frm.Activate();
            }
            else
            {
                if(musterıkodu == "sipariskayit")
                {
                    musterıkodu = x["MUSTERI_KODU"].ToString();
                    FrmSiparisler.siparisx = "musteri";
                    this.Hide();
                    FrmSiparisler frm = new FrmSiparisler();
                    frm.Activate();
                }
            }
        }

        private void FrmMusteriListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            musterıkodu = "";
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void FrmMusteriListesi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }
    }
}
