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
    public partial class FrmSiparisler : Form
    {
        public static string siparisx;
        string sipkalem = "";
        SqlConnection conn = new SqlConnection("Data Source=HALIL;Initial Catalog=ERP;Integrated Security=True");
        public FrmSiparisler()
        {
            InitializeComponent();
        }
        string x1 = "0";
        void sipariskontrol()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM TBL_SIPARISLER WHERE SIPARIS_NO = '"+txtSiparisNumarasi.Text+"'",conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                x1 = reader[0].ToString();
            }
            conn.Close();
        }

        void siparisbilgisicekme()
        {
            conn.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM TBL_SIPARISLER where SIPARIS_NO = '"+txtSiparisNumarasi.Text+"' ", conn);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtMusteriKodu.Text = reader[1].ToString();
                txtSiparisTarihi.Text = reader[2].ToString();
                txtTeslimTarihi.Text = reader[3].ToString();
                txtToplamTutar.Text = reader[4].ToString();
            }
            conn.Close();
        }
        void siparisbilgisicekme2()
        {
            conn.Open();
            DataTable dataTable = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("select STOK_KODU, STOK_ADI, MIKTAR AS 'MIKTAR(ADET)', FIYAT, KDV, SIPKALEM_ID FROM TBL_SIPARISKALEMLERI WHERE SIPARIS_NO = '"+txtSiparisNumarasi.Text+"'",conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sorgu1);
            sqlDataAdapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
            conn.Close();
        }

        string x2 = "0";
        void musterikontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("select count(*) FROM TBL_MUSTERIKAYITLARI WHERE MUSTERI_KODU = '"+txtMusteriKodu.Text+"'",conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x2 = dr1[0].ToString();
            }

            conn.Close();
        }
        void musteribilgisicekme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("select MUSTERI_ADI, IL , ILCE FROM TBL_MUSTERIKAYITLARI WHERE MUSTERI_KODU = '" + txtMusteriKodu.Text + "'", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                txtMusteriAdi.Text = dr1[0].ToString();
                txtIl.Text = dr1[1].ToString();
                txtIlce.Text = dr1[2].ToString();
            }
            conn.Close();

        }
        string x3 = "0";
        void stokkontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("select count(*) FROM TBL_STOKKAYITLARI WHERE STOK_KODU = '" + txtStokKodu.Text + "'", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x3 = dr1[0].ToString();
            }

            conn.Close();

        }
        void stokbilgisicekme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT STOK_ADI, GRUP_KODU, FIYAT,KDV_ORANI FROM TBL_STOKKAYITLARI WHERE STOK_KODU = '" + txtStokKodu.Text + "'", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                txtStokAdı.Text = dr1[0].ToString();
                txtKDV.Text = dr1[3].ToString();
                txtFiyat.Text = dr1[2].ToString();
            }
            conn.Close();
        }
        void geneltoplamhesaplama()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("select SUM((MIKTAR*FIYAT)*((KDV/100)+1)) as GENELTOPLAM FROM TBL_SIPARISKALEMLERI WHERE SIPARIS_NO = '" + txtSiparisNumarasi.Text + "' GROUP BY SIPARIS_NO", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                txtToplamTutar.Text = dr1[0].ToString();
            }

            conn.Close();
        }
        string x4 = "0";
        void kalemsayma()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("select count(*) from TBL_SIPARISKALEMLERI WHERE SIPARIS_NO = '"+txtSiparisNumarasi.Text+"'",conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x4 = dr1[0].ToString();
                txtToplamTutar.Text = dr1[0].ToString();
            }

            conn.Close() ;
        }
        void temizle1()
        {
            txtStokKodu.Text = "";
            txtStokAdı.Text = "";
            txtUrunAcıklaması.Text = "";
            txtFiyat.Text = "";
            txtKDV.Text = "";
            txtMiktar.Text = "";
        }
        void temizle2()
        {
            txtSiparisTarihi.Text = "";
            txtTeslimTarihi.Text = "";
            txtMusteriKodu.Text = "";
            txtIl.Text = "";
            txtIlce.Text = "";
            txtToplamTutar.Text = "";
            temizle1();
        }

        string x6 = "0";
        void sipgenelisemrikontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("select count(*) FROM TBL_SIPARISKALEMLERI WHERE SIPARIS_NO = '" +txtSiparisNumarasi.Text+ "' and (URETIMDURUMU = 'A' OR URETIMDURUMU = 'B' OR URETIMDURUMU = 'S')", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x6 = dr1[0].ToString();
            }

            conn.Close();
        }
        string x5 = "0";
        void sipkalemisemrikontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT URETIMDURUMU FROM TBL_SIPARISKALEMLERI WHERE SIPKALEM_ID = '"+sipkalem+"'", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x5 = dr1[0].ToString();
            }

            conn.Close();
        }
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void sbtnStokListesi_Click(object sender, EventArgs e)
        {
            FrmSiparisListesi.siparisno = "sipariskayit";
            FrmSiparisListesi frm = new FrmSiparisListesi();
            frm.Show();
        }

        private void FrmSiparisler_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            gridView1.OptionsBehavior.Editable = false;
            txtStokAdı.Enabled = false;
            txtKDV.Enabled = false;
            txtFiyat.Enabled = false;
            txtUrunAcıklaması.Enabled = false;
            txtMiktar.Enabled = false;
        }

        private void txtSiparisNumarasi_Leave(object sender, EventArgs e)
        {
            //FrmSiparisListesi.siparisno = "";
            txtMusteriAdi.Enabled = false;
            txtIl.Enabled = false;  
            txtIlce.Enabled = false;
            txtStokKodu.Enabled = true;

            sipariskontrol();
            if(Convert.ToInt16(x1) == 1)
            {
                siparisbilgisicekme();
                siparisbilgisicekme2();
                musteribilgisicekme();
                txtMusteriKodu.Enabled = false;
                txtStokKodu.Enabled = true;
            }
            else
            {
                if(txtSiparisNumarasi.Text == "")
                {
                    txtSiparisNumarasi.Focus();
                }
                else
                {
                    txtMusteriKodu.Enabled = true;
                    txtStokKodu.Enabled = true;
                    siparisbilgisicekme2();
                    temizle2();
                }
            }
        }

        private void txtMusteriKodu_Leave(object sender, EventArgs e)
        {
            musterikontrol();
            if(Convert.ToInt16(x2) == 1)
            {
                musteribilgisicekme();
                FrmMusteriListesi.musterıkodu = txtMusteriKodu.Text;
            }
            else
            {
                txtMusteriKodu.Focus();
            }
        }

        private void txtStokKodu_Leave(object sender, EventArgs e)
        {
            stokkontrol();
            if (Convert.ToInt16(x3) == 1)
            {
                stokbilgisicekme();
                txtUrunAcıklaması.Enabled = true;
                txtFiyat.Enabled = true;
                txtKDV.Enabled = true;
                txtMiktar.Enabled = true;
                txtMiktar.Text = "0,00";
            }
            else
            {
                txtStokKodu.Focus();
            }
        }

        private void sbtnKaydet_Click(object sender, EventArgs e)
        {
            if(sipkalem == "")
            {
                //EKLEME
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("insert into TBL_SIPARISKALEMLERI (SIPARIS_NO, STOK_KODU,STOK_ADI, MIKTAR, URUN_ACIKLAMASI, FIYAT, KDV, URETIMDURUMU) VALUES ('"+txtSiparisNumarasi.Text+"','"+txtStokKodu.Text+"','"+txtStokAdı.Text+"','"+txtMiktar.Text.Replace(',','.')+"','"+txtUrunAcıklaması.Text+"','"+txtFiyat.Text.Replace(',','.')+"','"+txtKDV.Text.Replace(',','.')+"','K')",conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                temizle1();
                siparisbilgisicekme2();
                geneltoplamhesaplama();
            }
            else
            {
                //GÜNCELLEME
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("update TBL_SIPARISKALEMLERI SET MIKTAR = '"+txtMiktar.Text.Replace(',','.')+"',URUN_ACIKLAMASI = '"+txtUrunAcıklaması.Text+"', FIYAT = '"+txtFiyat.Text.Replace(',','.')+"' , KDV= '"+txtKDV.Text.Replace(',','.')+"' where SIPKALEM_ID = '"+sipkalem+"'",conn);
                sorgu1.ExecuteNonQuery();
                temizle1();
                txtStokKodu.Enabled = true;
                conn.Close();
                siparisbilgisicekme2();
                geneltoplamhesaplama();
            }
            //siparisx = "";
            //temizle1();
            sipariskontrol();
            if(Convert.ToInt16(x1) == 1)
            {
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("update TBL_SIPARISLER SET SIPARIS_TARIHI = '"+txtSiparisTarihi.Text+"', TESLIM_TARIHI = '"+txtTeslimTarihi.Text+"', TOPLAM_TUTAR = '"+txtToplamTutar.Text.Replace(',','.')+"' where SIPARIS_NO = '"+txtSiparisNumarasi.Text+"'",conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("insert into TBL_SIPARISLER (SIPARIS_NO, MUSTERI_KODU, SIPARIS_TARIHI, TESLIM_TARIHI,TOPLAM_TUTAR) VALUES ('"+txtSiparisNumarasi.Text+"','"+txtMusteriKodu.Text+"','"+txtSiparisTarihi.Text+"','"+txtTeslimTarihi.Text+"','"+txtToplamTutar.Text.Replace(',','.')+"')",conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
            }

        }

        private void sbtnSil_Click(object sender, EventArgs e)
        {
            sipkalemisemrikontrol();
            if(x5 == "K")
            {
                conn.Open();
                SqlCommand sorgu = new SqlCommand("delete TBL_SIPARISKALEMLERI WHERE SIPKALEM_ID = '" + sipkalem + "'", conn);
                sorgu.ExecuteNonQuery();
                conn.Close();
                temizle1();
                siparisbilgisicekme2();
                sipkalem = "";
                txtStokKodu.Enabled = true;
                kalemsayma();
                if(Convert.ToInt16(x4) == 0)
                {
                    txtToplamTutar.Text = "0,00";
                }
                else
                {
                    geneltoplamhesaplama();
                }
                //geneltoplamhesaplama();
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("update TBL_SIPARISLER SET SIPARIS_TARIHI = '" + txtSiparisTarihi.Text + "', TESLIM_TARIHI = '" + txtTeslimTarihi.Text + "', TOPLAM_TUTAR = '" + txtToplamTutar.Text.Replace(',', '.') + "' where SIPARIS_NO = '" + txtSiparisNumarasi.Text + "'", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                MessageBox.Show("Bu Siparişe Ait İş Emri Kaydı Bulunmaktadır.");
            }


        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtStokKodu.Text = x["STOK_KODU"].ToString();
            txtStokAdı.Text = x["STOK_ADI"].ToString();
            txtFiyat.Text = x["FIYAT"].ToString();
            sipkalem = x["SIPKALEM_ID"].ToString();
            txtMiktar.Text = x["MIKTAR"].ToString();
            txtKDV.Text = x["KDV"].ToString();
            txtStokKodu.Enabled = false;
            txtMiktar.Enabled = true;
            txtFiyat.Enabled = true;
            txtKDV.Enabled = true;
            txtUrunAcıklaması.Enabled = true;
        }

        private void sbtnSiparisSil_Click(object sender, EventArgs e)
        {
            sipgenelisemrikontrol();
            if (Convert.ToInt16(x6) == 0)
            {
                //delete
                conn.Open();
                SqlCommand sqlCommand = new SqlCommand("delete TBL_SIPARISLER WHERE SIPARIS_NO = '"+txtSiparisNumarasi.Text+"'", conn);
                sqlCommand.ExecuteNonQuery();
                conn.Close();
                conn.Open();
                SqlCommand sqlCommand1 = new SqlCommand("delete TBL_SIPARISKALEMLERI WHERE SIPARIS_NO = '" + txtSiparisNumarasi.Text + "'", conn);
                sqlCommand1.ExecuteNonQuery();
                conn.Close();
                temizle2();
                txtSiparisNumarasi.Text = "";
                siparisbilgisicekme2();
            }
            else
            {
                //uyarı veririz
                MessageBox.Show("Bu Siparişe Ait İş Emri Kaydı Vardır, Silinemez!!");
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            sipariskontrol();
            if (Convert.ToInt16(x1) == 1)
            {
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("update TBL_SIPARISLER SET SIPARIS_TARIHI = '" + txtSiparisTarihi.Text + "', TESLIM_TARIHI = '" + txtTeslimTarihi.Text + "', TOPLAM_TUTAR = '" + txtToplamTutar.Text.Replace(',', '.') + "' where SIPARIS_NO = '" + txtSiparisNumarasi.Text + "'", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("insert into TBL_SIPARISLER (SIPARIS_NO, MUSTERI_KODU, SIPARIS_TARIHI, TESLIM_TARIHI,TOPLAM_TUTAR) VALUES ('" + txtSiparisNumarasi.Text + "','" + txtMusteriKodu.Text + "','" + txtSiparisTarihi.Text + "','" + txtTeslimTarihi.Text + "','" + txtToplamTutar.Text.Replace(',', '.') + "')", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
            }
            siparisbilgisicekme();
            temizle2();
            txtSiparisNumarasi.Text = "";
            siparisbilgisicekme2();
        }

        private void sbtnGrupKodListesi_Click(object sender, EventArgs e)
        {
            FrmMusteriListesi.musterıkodu = "sipariskayit";
            FrmMusteriListesi frmMusteriListesi = new FrmMusteriListesi();
            frmMusteriListesi.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmStokListesi.stokkodu = "sipariskayit";
            FrmStokListesi frm = new FrmStokListesi();
            frm.Show();
        }

        private void FrmSiparisler_Activated(object sender, EventArgs e)
        {
            if(siparisx == "siparis")
            {
                if (FrmSiparisListesi.siparisno == "")
                {

                }
                else
                {
                    txtSiparisNumarasi.Text = FrmSiparisListesi.siparisno;
                    siparisbilgisicekme();
                    siparisbilgisicekme2();
                    musteribilgisicekme();
                }
            }

            if(siparisx == "musteri")
            {
                if (FrmMusteriListesi.musterıkodu == "")
                {

                }
                else
                {
                    txtMusteriKodu.Text = FrmMusteriListesi.musterıkodu;
                    musteribilgisicekme();
                }
            }

            if(siparisx == "stok")
            {
                if(FrmStokListesi.stokkodu == "")
                {

                }
                else
                {
                    txtStokKodu.Text = FrmStokListesi.stokkodu;
                    stokbilgisicekme();
                }
            }    

            
            
        }

        private void FrmSiparisler_FormClosed(object sender, FormClosedEventArgs e)
        {
            siparisx = "";
            FrmMusteriListesi.musterıkodu = "";
            FrmSiparisListesi.siparisno = "";
        }

        private void FrmSiparisler_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
            if(e.KeyCode == Keys.Enter) { 
                sbtnKaydet.PerformClick();
             
            }
        }
    }
}
