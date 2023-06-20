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
    
    public partial class FrmUretimSonuKayitlari : Form
    {
        public static string fisx = "";
        SqlConnection conn = new SqlConnection("Data Source=HALIL;Initial Catalog=ERP;Integrated Security=True");
        public FrmUretimSonuKayitlari()
        {
            InitializeComponent();
        }

        string x1 = "0";
        void uretimsonukaydikontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_URETIMSONUKAYITLARI WHERE URETIMSONUKAYDI_NUMARASI = '"+txtFisNo.Text+"'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x1 = dr[0].ToString();
            }
            conn.Close();
        }

        void uretimsonukaydibilgisicekme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("Select ISEMRI_NUMARASI FROM TBL_URETIMSONUKAYITLARI WHERE URETIMSONUKAYDI_NUMARASI = '"+txtFisNo.Text+"'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtIsEmriNumarasi.Text = dr[0].ToString();
            }
            conn.Close();
            txtIsEmriNumarasi.Enabled = false;
            sbtnİsEmriListesi.Enabled = false;

        }
        string x2= "0";
        void isemrikontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("select count(*) from TBL_ISEMRI WHERE ISEMRI_NUMARASI = '"+txtIsEmriNumarasi.Text+"' ", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                x2 = dr1[0].ToString();
            }
            conn.Close();
        }
        void isemribilgisicekme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT MR.SIPARIS_NO, MR.STOK_KODU,MR.STOK_ADI,MR.SIPKALEM_ID,MR.MIKTAR,SIP.MUSTERI_KODU,MK.MUSTERI_ADI from TBL_ISEMRI MR LEFT JOIN TBL_SIPARISLER SIP ON MR.SIPARIS_NO = SIP.SIPARIS_NO LEFT JOIN TBL_MUSTERIKAYITLARI MK ON SIP.MUSTERI_KODU = MK.MUSTERI_KODU WHERE MR.ISEMRI_NUMARASI = '"+txtIsEmriNumarasi.Text+"' ", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                txtSiparisNumarasi.Text = dr1[0].ToString();
                txtStokKodu.Text = dr1[1].ToString();
                txtStokAdi.Text = dr1[2].ToString();
                txtKalemId.Text = dr1[3].ToString();
                txtMiktar.Text = dr1[4].ToString();
                txtMusteriKodu.Text = dr1[5].ToString();
                txtMusteriAdi.Text = dr1[6].ToString();
            }
            conn.Close();
        }
        void stoguuretimealma()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARISKALEMLERI SET URETIMDURUMU = 'A' WHERE SIPKALEM_ID = '"+txtKalemId.Text+"'", conn);
            sorgu1.ExecuteNonQuery();
            conn.Close();
        }
        void stogusevkehazirlama()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARISKALEMLERI SET URETIMDURUMU = 'B' WHERE SIPKALEM_ID = '"+txtKalemId.Text+"'", conn);
            sorgu1.ExecuteNonQuery();
            conn.Close();
        }
        void isemriniacma()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_ISEMRI SET DURUM = 'Y' WHERE ISEMRI_NUMARASI = '"+txtIsEmriNumarasi.Text+"'", conn);
            sorgu1.ExecuteNonQuery();
            conn.Close();
        }
        void isemrinikapatma()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_ISEMRI SET DURUM = 'E' WHERE ISEMRI_NUMARASI = '"+txtIsEmriNumarasi.Text+"'", conn);
            sorgu1.ExecuteNonQuery();
            conn.Close();
        }
        
        void temizle()
        {
            txtIsEmriNumarasi.Text = "";
            txtKalemId.Text = "";
            txtMiktar.Text = "";
            txtMusteriAdi.Text = "";
            txtMusteriKodu.Text = "";
            txtSiparisNumarasi.Text = "";
            txtStokAdi.Text = "";
            txtStokKodu.Text = "";
            txtIsEmriNumarasi.Enabled = true;
            sbtnİsEmriListesi.Enabled = true;
        }

        string y1 = "";
        void uretimsonukaydinumarasihesaplama()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT TOP 1 CONCAT('U',REPLICATE('0',10-(LEN(SUBSTRING(URETIMSONUKAYDI_NUMARASI,2,9)+1)+1)),SUBSTRING(URETIMSONUKAYDI_NUMARASI,2,9)+1) FROM TBL_URETIMSONUKAYITLARI ORDER BY URETIMSONUKAYDI_NUMARASI DESC", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                y1 = dr1[0].ToString();
            }
            conn.Close();
        }
        void stokhareketkaydigirisi()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_STOK_HAREKETLERI (URETIMSONUKAYDI_NUMARASI,ISEMRI_NUMARASI,STOK_KODU,STOK_ADI,G_MIKTAR,C_MIKTAR,MUSTERI_ADI,ACIKLAMA) VALUES ('"+txtFisNo.Text+"','"+txtIsEmriNumarasi.Text+"','"+txtStokKodu.Text+"','"+txtStokAdi.Text+"','"+txtMiktar.Text.Replace(',','.')+"','0','"+txtMusteriAdi.Text+"','ÜRETİM')",conn);
            sorgu1.ExecuteNonQuery();
            conn.Close();
        }
        void stokhareketkaydisilme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand(" DELETE TBL_STOK_HAREKETLERI WHERE URETIMSONUKAYDI_NUMARASI = '"+txtFisNo.Text+"' ", conn);
            sorgu1.ExecuteNonQuery();
            conn.Close();
        }
        private void sbtnFisListesi_Click(object sender, EventArgs e)
        {
            FrmUretimSonuKayitListesi.fisno = "uretimsonukaydi";
            FrmUretimSonuKayitListesi frm = new FrmUretimSonuKayitListesi();
            frm.Show();
        }

        private void FrmUretimSonuKayitlari_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            uretimsonukaydinumarasihesaplama();
            txtFisNo.Text = y1;
        }

        private void txtIsEmriNumarasi_Leave(object sender, EventArgs e)
        {
            if(txtIsEmriNumarasi.Text == "")
            {
                txtIsEmriNumarasi.Focus();
            }
            else
            {
                isemrikontrol();
                if(Convert.ToInt16(x2)== 1)
                {
                    isemribilgisicekme();
                    txtSiparisNumarasi.Enabled = false;
                    txtStokAdi.Enabled = false;
                    txtMusteriAdi.Enabled = false;
                    txtMiktar.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Girilen İş Emri Numarasına Ait Bir Kayıt Bulunamamaktadır.");
                    txtIsEmriNumarasi.Focus();

                }
            }
            

        }

        private void txtFisNo_Leave(object sender, EventArgs e)
        {
            if(txtFisNo.Text == "")
            {
                txtFisNo.Focus();
            }
            else
            {
                uretimsonukaydikontrol();
                if(Convert.ToInt16(x1)== 1)
                {
                    uretimsonukaydibilgisicekme();
                    isemribilgisicekme();
                }
                else
                {
                    temizle();
                    txtIsEmriNumarasi.Enabled = true;
                    sbtnİsEmriListesi.Enabled = true;
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(txtFisNo.Text == "" || txtIsEmriNumarasi.Text == "")
            {
                MessageBox.Show("Lütfen Gerekli Olan Bilgileri Doldurunuz.");
                //temizle();
            }
            else
            {
                uretimsonukaydikontrol();
                if(Convert.ToInt16(x1)== 1)
                {
                    MessageBox.Show("Mevcut Üretim Sonu Kaydı Sistemde Bulunmamaktadır.");
                }
                else
                {
                    stogusevkehazirlama();
                    isemrinikapatma();
                    stokhareketkaydigirisi();
                    conn.Open();
                    SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_URETIMSONUKAYITLARI (URETIMSONUKAYDI_NUMARASI,ISEMRI_NUMARASI,STOK_KODU,STOK_ADI,MIKTAR,SIPARIS_NUMARASI,SIPKALEM_ID,MUSTERI_KODU,MUSTERI_ADI) VALUES ('"+txtFisNo.Text+"','"+txtIsEmriNumarasi.Text+"','"+txtStokKodu.Text+"','"+txtStokAdi.Text+"','"+txtMiktar.Text.Replace(',','.')+"','"+txtSiparisNumarasi.Text+"','"+txtKalemId.Text+"','"+txtMusteriKodu.Text+"','"+txtMusteriAdi.Text+"')",conn);
                    sorgu1.ExecuteNonQuery();
                    conn.Close();
                    temizle();
                    txtFisNo.Text = "";
                }
            }
            uretimsonukaydinumarasihesaplama();
            txtFisNo.Text = y1;
            conn.Open();
            SqlCommand sorgu16 = new SqlCommand(" update TBL_STOKPARCALARI set STOK_MIKTARI = STOK_MIKTARI - 1", conn);
            sorgu16.ExecuteNonQuery();
            conn.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(txtFisNo.Text == "" || txtIsEmriNumarasi.Text == "")
            {
                //temizle();
                MessageBox.Show("Gerekli Olan Yerleri Doldurunuz.");
            }
            else
            {
                uretimsonukaydikontrol();
                if(Convert.ToInt16(x1) == 1)
                {
                    stoguuretimealma();
                    isemriniacma();
                    stokhareketkaydisilme();
                    conn.Open();
                    SqlCommand sorgu1 = new SqlCommand("DELETE TBL_URETIMSONUKAYITLARI WHERE URETIMSONUKAYDI_NUMARASI = '"+txtFisNo.Text+"'", conn);
                    sorgu1.ExecuteNonQuery();
                    conn.Close();
                    temizle();
                    txtFisNo.Text = "";
                }
                else
                {
                    MessageBox.Show("Mevcut Uretim Sonu Kaydı Bulunamamaktadır.");
                }
            }
            uretimsonukaydinumarasihesaplama();
            txtFisNo.Text = y1;
        }

        private void sbtnİsEmriListesi_Click(object sender, EventArgs e)
        {
            FrmIsEmriListesi.isemrino = "uretimsonukayit";
            FrmIsEmriListesi frm = new FrmIsEmriListesi();
            frm.Show();
        }

        private void FrmUretimSonuKayitlari_Activated(object sender, EventArgs e)
        {
            if(fisx == "isemri")
            {
                txtIsEmriNumarasi.Text = FrmIsEmriListesi.isemrino;
                isemribilgisicekme();
                fisx = "";
            }
            if(fisx == "uretimsonukaydi")
            {
                txtFisNo.Text = FrmUretimSonuKayitListesi.fisno;
                uretimsonukaydibilgisicekme();
                isemribilgisicekme();
                fisx = "";
            }
        }

        private void FrmUretimSonuKayitlari_FormClosed(object sender, FormClosedEventArgs e)
        {
            fisx = "";
        }

        private void sbtnSiparisTemizle_Click(object sender, EventArgs e)
        {
            temizle();
            
            uretimsonukaydinumarasihesaplama();
            txtFisNo.Text = y1;
        }

        private void FrmUretimSonuKayitlari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
            if(e.KeyCode == Keys.Enter)
            {
                btnKaydet.PerformClick();
            }
        }
    }
}
