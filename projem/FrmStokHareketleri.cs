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
    public partial class FrmStokHareketleri : Form
    {
        public static String stokhareketx;
        SqlConnection conn = new SqlConnection("Data Source=HALIL;Initial Catalog=ERP;Integrated Security=True");
        public FrmStokHareketleri()
        {
            InitializeComponent();
        }

        private void sbtnStokListesi_Click(object sender, EventArgs e)
        {
            FrmStokListesi.stokkodu = "stokhareket";
            FrmStokListesi frm = new FrmStokListesi();
            frm.Show();
        }

        private void FrmStokHareketleri_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
        }

        void stokbilgisicekme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("select SK.STOK_ADI, GK.GRUP_KODU from TBL_STOKKAYITLARI SK left join TBL_GRUPKOD GK ON SK.GRUP_KODU = GK.GRUP_KODU WHERE STOK_KODU = '"+txtStokKodu.Text+"'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtStokAdi.Text = dr[0].ToString();
                txtGrupAd.Text = dr[1].ToString();
            }
            conn.Close();

            conn.Open();
            SqlCommand sorgu2 = new SqlCommand(" SELECT ISNULL((SUM(G_MIKTAR))-(SUM(C_MIKTAR)),0) AS 'STOK MİKTARI' FROM TBL_STOK_HAREKETLERI where STOK_KODU = '"+txtStokKodu.Text+"' ", conn);
            SqlDataReader dr1 = sorgu2.ExecuteReader();
            while (dr1.Read())
            {
                txtStokMiktari.Text = dr1[0].ToString();
            }
            conn.Close();
        }
        void stokhareketlistesicekme()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT URETIMSONUKAYDI_NUMARASI AS 'ÜRETİM SONU KAYDI', ISEMRI_NUMARASI AS 'İŞ EMRİ NUMARASI', ACIKLAMA AS 'AÇIKLAMA', STOK_KODU AS 'STOK KODU', STOK_ADI AS 'STOK ADI', G_MIKTAR AS 'ÜRETİM MİKTARI', C_MIKTAR AS 'SEVK MİKTARI', MUSTERI_ADI AS 'MÜŞTERİ ADI' FROM TBL_STOK_HAREKETLERI WHERE STOK_KODU = '"+txtStokKodu.Text+"'", conn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            conn.Close();
        }

        void temizle()
        {
            txtStokAdi.Text = "";
            txtStokKodu.Text = "";
            txtGrupAd.Text = "";
            txtStokMiktari.Text = "";
            gridControl1.DataSource = "";
        }

        private void txtStokKodu_Leave(object sender, EventArgs e)
        {
            stokbilgisicekme();
            stokhareketlistesicekme();
        }

        private void sbtnSiparisTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void FrmStokHareketleri_Activated(object sender, EventArgs e)
        {
            if(stokhareketx == "stok")
            {
                txtStokKodu.Text = FrmStokListesi.stokkodu;
                stokbilgisicekme();
                stokhareketlistesicekme();
                stokhareketx = "";
            }
        }

        private void FrmStokHareketleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmStokListesi.stokkodu = "";
            stokhareketx = "";
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            DataGridView dg = sender as DataGridView;
            string tur = Convert.ToString(gridView1.GetRowCellValue(e.RowHandle, "AÇIKLAMA"));
            if(tur == "ÜRETİM")
            {
                e.Appearance.BackColor = Color.Green;
            }
            else
            {
                e.Appearance.BackColor = Color.Red;
            }
            
        }
    }
}
