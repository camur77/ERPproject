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
    public partial class FrmSiparisListesi : Form
    {
        public static string siparisno;
        SqlConnection conn = new SqlConnection("Data Source=HALIL;Initial Catalog=ERP;Integrated Security=True");

        void Arama()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("select S.SIPARIS_NO,M.MUSTERI_ADI,S.SIPARIS_TARIHI,S.TESLIM_TARIHI from TBL_SIPARISLER S LEFT JOIN TBL_MUSTERIKAYITLARI M ON S.MUSTERI_KODU = M.MUSTERI_KODU where S.SIPARIS_NO LIKE '%%' AND M.MUSTERI_ADI LIKE '%%'", conn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            conn.Close();
        }
        public FrmSiparisListesi()
        {
            InitializeComponent();
        }

        private void FrmSiparisListesi_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            Arama();
        }

        private void txtSiparisNumarasi_TextChanged(object sender, EventArgs e)
        {
            Arama();
        }

        private void txtMusteriAdi_TextChanged(object sender, EventArgs e)
        {
            Arama();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(siparisno == "sipariskayit")
            {
                siparisno = x["SIPARIS_NO"].ToString();
                FrmSiparisler.siparisx = "siparis";
                this.Hide();
                FrmSiparisler frm = new FrmSiparisler();
                frm.Activate();
            }
            else
            {
              
            }
        }

        private void FrmSiparisListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            siparisno = "";
        }

        private void FrmSiparisListesi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }
    }
}
