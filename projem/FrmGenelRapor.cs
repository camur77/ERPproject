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
    public partial class FrmGenelRapor : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=HALIL;Initial Catalog=ERP;Integrated Security=True");
        public FrmGenelRapor()
        {
            InitializeComponent();
        }

        void sevkehazirsiparislistesi()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT SIPARIS_NO AS 'SİPARİŞ NUMARASI', MK.MUSTERI_ADI AS 'MÜŞTERİ ADI',TESLIM_TARIHI AS 'TESLİM TARİHİ', TOPLAM_TUTAR AS 'TOPLAM TUTAR' FROM TBL_SIPARISLER SIP LEFT JOIN TBL_MUSTERIKAYITLARI MK ON SIP.MUSTERI_KODU = MK.MUSTERI_KODU WHERE SIPARIS_NO NOT IN (SELECT DISTINCT SIPARIS_NO FROM TBL_SIPARISKALEMLERI WHERE URETIMDURUMU = 'A' OR URETIMDURUMU = 'K' OR URETIMDURUMU = 'S')", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gridControsevkehazir.DataSource = dt;
            conn.Close();
        }

        void stokkontrolraporu()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT SK.STOK_KODU AS 'STOK KODU',SK.STOK_ADI AS 'STOK ADI', (SELECT ISNULL(SUM(MIKTAR),0) FROM TBL_SIPARISKALEMLERI SIP WHERE SIP.STOK_KODU = SK.STOK_KODU) AS 'SİPARİŞ MİKTARI',(SELECT ISNULL(SUM(MIKTAR),0) FROM TBL_ISEMRI MR WHERE MR.STOK_KODU = SK.STOK_KODU) AS 'İŞ EMRİ MİKTARI',(SELECT ISNULL(SUM(G_MIKTAR)-SUM(C_MIKTAR),0) FROM TBL_STOK_HAREKETLERI SH WHERE SH.STOK_KODU = SK.STOK_KODU) AS 'STOK MİKTARI' FROM TBL_STOKKAYITLARI SK", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gridControlstokkontrol.DataSource = dt;
            conn.Close();
        }

        void eksikisemirleri()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT STOK_KODU AS 'STOK KODU', STOK_ADI AS 'STOK ADI',MIKTAR AS 'MİKTAR',SIPKALEM_ID AS 'SİPARİŞ ID' FROM TBL_SIPARISKALEMLERI WHERE URETIMDURUMU = 'K'", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gridControlişemrigereken.DataSource = dt;
            conn.Close();
        }
        
        void urunsatısraporu()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select TOP 25 STOK_ADI AS 'STOK ADI', SUM(MIKTAR) AS 'TOPLAM SATIŞ MİKTARI' FROM TBL_SIPARISKALEMLERI SIP GROUP BY STOK_ADI ORDER BY SUM(MIKTAR) DESC", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gridControlurunsatis.DataSource = dt;
            conn.Close();
        }
        void musterilisteleme()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT TOP 10 MUSTERI_ADI AS 'MÜŞTERİ ADI', SUM(TOPLAM_TUTAR) AS 'TOPLAM CİRO' FROM TBL_SIPARISLER S LEFT JOIN TBL_MUSTERIKAYITLARI MK ON S.MUSTERI_KODU = MK.MUSTERI_KODU GROUP BY MK.MUSTERI_ADI ORDER BY SUM(TOPLAM_TUTAR) DESC", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gridControlmustericiro.DataSource = dt;
            conn.Close();
        }
        private void FrmGenelRapor_Load(object sender, EventArgs e)
        {
            gridViewişemrigereken.OptionsBehavior.Editable = false;
            gridViewmustericiro.OptionsBehavior.Editable = false;
            gridViewstokkontrol.OptionsBehavior.Editable = false; 
            gridViewurunsatis.OptionsBehavior.Editable = false;
            gridViewsevkehazir.OptionsBehavior.Editable = false;

            sevkehazirsiparislistesi();
            stokkontrolraporu();
            eksikisemirleri();
            urunsatısraporu();
            musterilisteleme();
        }
    }
}
