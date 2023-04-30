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
    public partial class FrmSiparisSevk : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=HALIL;Initial Catalog=ERP;Integrated Security=True");
        public FrmSiparisSevk()
        {
            InitializeComponent();
        }

        void musterilistesicekme()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT MUSTERI_KODU, MUSTERI_ADI FROM TBL_MUSTERIKAYITLARI",conn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            searchLookUpEdit1.Properties.ValueMember = "MUSTERI_KODU";
            searchLookUpEdit1.Properties.DisplayMember = "MUSTERI_ADI";
            searchLookUpEdit1.Properties.DataSource = dt;
            conn.Close();
        }
        void siparislistesicekme()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT SIPARIS_NO,TESLIM_TARIHI,TOPLAM_TUTAR FROM TBL_SIPARISLER WHERE SIPARIS_NO NOT IN (SELECT DISTINCT SIPARIS_NO FROM TBL_SIPARISKALEMLERI where URETIMDURUMU = 'K' OR URETIMDURUMU = 'A' OR URETIMDURUMU = 'S') AND MUSTERI_KODU = '"+searchLookUpEdit1.EditValue+"'  ", conn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridsiparislistesi.DataSource = dt;
            conn.Close();
        }
        private void FrmSiparisSevk_Load(object sender, EventArgs e)
        {
            searchLookUpEdit1.EditValue = "";
            gridviewsiparis.OptionsBehavior.Editable = false;
            gridviewsiparisiceri.OptionsBehavior.Editable = false;
            musterilistesicekme();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            siparislistesicekme();
        }

        string z;
        private void gridviewsiparis_Click(object sender, EventArgs e)
        {
            DataRow x = gridviewsiparis.GetDataRow(gridviewsiparis.FocusedRowHandle);
            z = x["SIPARIS_NO"].ToString();
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT STOK_KODU,STOK_ADI,MIKTAR,URUN_ACIKLAMASI,SIPKALEM_ID FROM TBL_SIPARISKALEMLERI WHERE SIPARIS_NO = '"+z+"'", conn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridsiparisicerik.DataSource = dt;
            conn.Close();
                
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int y = Convert.ToInt16(gridviewsiparisiceri.RowCount.ToString());
            for(int i=0; i <= y-1; i++)
            {
                string musterikodu = "";
                string stokkodu = "";
                string stokadi = "";
                string miktar = "";
                string musteriadi = "";
                string kalemID = gridviewsiparisiceri.GetRowCellValue(i,"SIPKALEM_ID").ToString();
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("SELECT S.MUSTERI_KODU,SK.STOK_KODU,SK.STOK_ADI,SK.MIKTAR,MK.MUSTERI_ADI FROM TBL_SIPARISKALEMLERI SK LEFT JOIN TBL_SIPARISLER S ON SK.SIPARIS_NO = S.SIPARIS_NO LEFT JOIN TBL_MUSTERIKAYITLARI MK ON S.MUSTERI_KODU = MK.MUSTERI_KODU WHERE SIPKALEM_ID = '"+kalemID+"'", conn);
                SqlDataReader dr = sorgu1.ExecuteReader();
                while(dr.Read())
                {
                    musterikodu = dr[0].ToString();
                    stokkodu = dr[1].ToString();
                    stokadi = dr[2].ToString();
                    miktar = dr[3].ToString();
                    musteriadi = dr[4].ToString();
                }
                conn.Close();

                conn.Open();
                SqlCommand sorgu2 = new SqlCommand("INSERT INTO TBL_STOK_HAREKETLERI (URETIMSONUKAYDI_NUMARASI,ISEMRI_NUMARASI,STOK_KODU,STOK_ADI,G_MIKTAR,C_MIKTAR,MUSTERI_ADI,ACIKLAMA) VALUES ('"+musterikodu+"','','"+stokkodu+"','"+stokadi+"','0','"+miktar.Replace(',','.')+"','"+musteriadi+"','SEVKİYAT')", conn);
                sorgu2.ExecuteNonQuery();
                conn.Close();
            }
            conn.Open();
            SqlCommand sorgu3 = new SqlCommand("UPDATE TBL_SIPARISKALEMLERI SET URETIMDURUMU = 'S' WHERE SIPARIS_NO = '"+z+"'", conn);
            sorgu3.ExecuteNonQuery();
            conn.Close();
            siparislistesicekme();
            gridsiparislistesi.DataSource = "";
            gridsiparisicerik.DataSource = "";
        }
    }
}
