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
    public partial class FrmIsEmri : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=HALIL;Initial Catalog=ERP;Integrated Security=True");
        public FrmIsEmri()
        {
            InitializeComponent();
        }

        string x1 = "0";
        void isemrikontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_ISEMRI WHERE ISEMRI_NUMARASI = '"+txtIsEmriNumarasi.Text+"'", conn);
            SqlDataReader dataReader = sorgu1.ExecuteReader();
            while (dataReader.Read())
            {
                x1 = dataReader[0].ToString();
            }
            conn.Close();
        }

        void isemribilgisicekme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT * FROM TBL_ISEMRI WHERE ISEMRI_NUMARASI = '"+txtIsEmriNumarasi.Text+"'", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                txtStokKodu.Text = dr1[1].ToString();
                txtStokAdi.Text = dr1[2].ToString();    
                txtİsEmriAciklamasi.Text = dr1[3].ToString();
                txtİsEmriTarihi.Text = dr1[4].ToString();
                txtTeslimTarihi.Text = dr1[5].ToString();
                txtSiparisNumarasi.Text = dr1[6].ToString();
                txtMiktar.Text = dr1[7].ToString();
                txtSiparisKalemID.Text = dr1[8].ToString();
                string x = dr1[9].ToString();
                if(x == "Y")
                {
                    rbtnYeni.Checked = true;
                }
                else
                {
                    rbtnTamamlanmis.Checked = true;
                }
                
            }
            conn.Close();
            txtStokKodu.Enabled = false;
            txtMiktar.Enabled = false;
            txtMiktar.Enabled = false;
            txtSiparisNumarasi.Enabled = false;
            sbtnStokListesi.Enabled = false;
            sbtnSiparisListesi.Enabled = false;
        }

        string x2 = "0";
        void stokkartikontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT COUNT(*) FROM TBL_STOKKAYITLARI WHERE STOK_KODU = '"+txtStokKodu.Text+"'", conn);
            SqlDataReader dataReader = sorgu1.ExecuteReader();
            while (dataReader.Read())
            {
                x2 = dataReader[0].ToString();
            }
            conn.Close();
        }

        void stokbilgisicekme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT STOK_ADI FROM TBL_STOKKAYITLARI WHERE STOK_KODU = '" + txtStokKodu.Text + "'", conn);
            SqlDataReader dataReader = sorgu1.ExecuteReader();
            while (dataReader.Read())
            {
                txtStokAdi.Text = dataReader[0].ToString();
            }
            conn.Close();
        }

        void sipariskaleminiacma() // SİPARİŞ KALEMİNİ ÜRETİME AÇMA
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARISKALEMLERI SET URETIMDURUMU = 'A' WHERE SIPKALEM_ID = '"+txtSiparisKalemID.Text+"'", conn);
            sorgu1.ExecuteNonQuery();
            conn.Close();
        }

        void sipariskaleminikapatma() // SİPARİŞ KALEMİNİ ÜRETİME KAPAMA
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARISKALEMLERI SET URETIMDURUMU = 'K' WHERE SIPKALEM_ID = '" + txtSiparisKalemID.Text + "'", conn);
            sorgu1.ExecuteNonQuery();
            conn.Close();
        }

        void sipariskaleminibitirme() // SİPARİŞ KALEMİNİ SEVKE HAZIR HALE GETİRME
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_SIPARISKALEMLERI SET URETIMDURUMU = 'B' WHERE SIPKALEM_ID = '" + txtSiparisKalemID.Text + "'", conn);
            sorgu1.ExecuteNonQuery();
            conn.Close();
        }

        void isemrilistesicekme()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("SELECT ISEMRI_NUMARASI, STOK_KODU,STOK_ADI,MIKTAR AS 'MIKTAR(ADET)',DURUM FROM TBL_ISEMRI",conn);
            SqlDataAdapter da = new SqlDataAdapter(sorgu1);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            conn.Close();
                        
        }
        void siparisnocekme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT SIPARIS_NO, MIKTAR FROM TBL_SIPARISKALEMLERI WHERE SIPKALEM_ID = '"+txtSiparisKalemID.Text+"'", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                txtSiparisNumarasi.Text = dr1[0].ToString();
                txtMiktar.Text = dr1[1].ToString();
            }
            conn.Close();
        }

        void temizle()
        {
            txtİsEmriAciklamasi.Text = "";
            txtİsEmriTarihi.Text = "";
            txtMiktar.Text = "0,00";
            txtSiparisNumarasi.Text = "";
            txtSiparisKalemID.Text = "";
            txtStokAdi.Text = "";
            txtStokKodu.Text = "";
            txtTeslimTarihi.Text = "";

            txtStokKodu.Enabled = true;
            txtMiktar.Enabled = true;
            txtSiparisNumarasi.Enabled = true;
            rbtnYeni.Checked = true;
            sbtnSiparisListesi.Enabled = true;
            sbtnStokListesi.Enabled = true;

        }

        void sipnovemiktaraulasma()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT SIPARIS_NO, MIKTAR FROM TBL_SIPARISKALEMLERI WHERE SIPKALEM_ID = '"+txtSiparisKalemID.Text+"'", conn);
            SqlDataReader r = sorgu1.ExecuteReader();
            while (r.Read())
            {
                txtSiparisNumarasi.Text = r[0].ToString();
                txtMiktar.Text = r[1].ToString();
            }
            conn.Close();
        }
        private void sbtnIsEmriListesi_Click(object sender, EventArgs e)
        {
            FrmIsEmriListesi.isemrino = "isemrikayit";
            FrmIsEmriListesi frm = new FrmIsEmriListesi();
            frm.Show();
        }

        public static string stokkodu;
        public static string isemrix;
        private void sbtnSiparisListesi_Click(object sender, EventArgs e)
        {
            stokkodu = txtStokKodu.Text; 
            FrmIsEmriSiparisleri frm = new FrmIsEmriSiparisleri();
            frm.Show();
        }

        void calisanlisteleme()
        {
            comboil.Properties.Items.Clear();
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("Select CALISAN_AD FROM TBL_CALISANLAR ", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                comboil.Properties.Items.Add(dr1[0]);
            }

            conn.Close();
        }

        void atolyelisteleme()
        {
            comboboxatolye.Properties.Items.Clear();
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("Select ATOLYE_NUMARASI FROM TBL_ATOLYELER ", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                comboboxatolye.Properties.Items.Add(dr1[0]);
            }

            conn.Close();
        }
        private void FrmIsEmri_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            isemrilistesicekme();
            calisanlisteleme();
            atolyelisteleme();
        }

        private void txtIsEmriNumarasi_Leave(object sender, EventArgs e)
        {
            if(txtIsEmriNumarasi.Text == "")
            {
                txtIsEmriNumarasi.Focus();
            }
            isemrikontrol();
            if(Convert.ToInt16(x1) == 1)
            {
                isemribilgisicekme();

            }
            else
            {
                temizle();
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtIsEmriNumarasi.Text = dr["ISEMRI_NUMARASI"].ToString();
            isemribilgisicekme();
        }

        private void sbtnKaydet_Click(object sender, EventArgs e)
        {
            isemrikontrol();
            if(Convert.ToInt16(x1) == 1)
            {
                if(rbtnYeni.Checked == true)
                {
                    conn.Open();
                    SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_ISEMRI SET ISEMRI_ACIKLAMASI = '"+txtİsEmriAciklamasi.Text+"', ISEMRI_TARIHI = '"+txtİsEmriTarihi.Text+"' , TESLIM_TARIHI = '"+txtTeslimTarihi.Text+"', DURUM = 'Y' WHERE ISEMRI_NUMARASI = '"+txtIsEmriNumarasi.Text+"'", conn);
                    sorgu1.ExecuteNonQuery();
                    conn.Close();
                    sipariskaleminiacma();
                    temizle();
                    txtIsEmriNumarasi.Text = "";
                    isemrilistesicekme();
                }
                else
                {
                    conn.Open();
                    SqlCommand sorgu1 = new SqlCommand("UPDATE TBL_ISEMRI SET ISEMRI_ACIKLAMASI = '" + txtİsEmriAciklamasi.Text + "', ISEMRI_TARIHI = '" + txtİsEmriTarihi.Text + "' , TESLIM_TARIHI = '" + txtTeslimTarihi.Text + "', DURUM = 'E' WHERE ISEMRI_NUMARASI = '" + txtIsEmriNumarasi.Text + "'", conn);
                    sorgu1.ExecuteNonQuery();
                    conn.Close();
                    sipariskaleminibitirme();
                    temizle();
                    txtIsEmriNumarasi.Text = "";
                    isemrilistesicekme();

                }
            }
            else
            {
                if(rbtnYeni.Checked == true)
                {
                    conn.Open();
                    SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_ISEMRI (ISEMRI_NUMARASI,STOK_KODU,STOK_ADI,ISEMRI_ACIKLAMASI,ISEMRI_TARIHI,TESLIM_TARIHI,SIPARIS_NO,MIKTAR,SIPKALEM_ID,DURUM) VALUES ('"+txtIsEmriNumarasi.Text+"','"+txtStokKodu.Text+"','"+txtStokAdi.Text+"','"+txtİsEmriAciklamasi.Text+"','"+txtİsEmriTarihi.Text+"','"+txtTeslimTarihi.Text+"','"+txtSiparisNumarasi.Text+"','"+txtMiktar.Text.Replace(',','.')+"','"+txtSiparisKalemID.Text+"','Y')", conn);
                    sorgu1.ExecuteNonQuery();
                    conn.Close();
                    sipariskaleminiacma();
                    temizle();
                    txtIsEmriNumarasi.Text = "";
                    isemrilistesicekme();
                }
                else
                {
                    conn.Open();
                    SqlCommand sorgu1 = new SqlCommand("INSERT INTO TBL_ISEMRI (ISEMRI_NUMARASI,STOK_KODU,STOK_ADI,ISEMRI_ACIKLAMASI,ISEMRI_TARIHI,TESLIM_TARIHI,SIPARIS_NO,MIKTAR,SIPKALEM_ID,DURUM) VALUES ('" + txtIsEmriNumarasi.Text + "','" + txtStokKodu.Text + "','" + txtStokAdi.Text + "','" + txtİsEmriAciklamasi.Text + "','" + txtİsEmriTarihi.Text + "','" + txtTeslimTarihi.Text + "','" + txtSiparisNumarasi.Text + "','" + txtMiktar.Text.Replace(',', '.') + "','" + txtSiparisKalemID.Text + "','E')", conn);
                    sorgu1.ExecuteNonQuery();
                    conn.Close();
                    sipariskaleminibitirme();
                    temizle();
                    txtIsEmriNumarasi.Text = "";
                    isemrilistesicekme();
                }
            }
        }

        private void sbtnSil_Click(object sender, EventArgs e)
        {
            isemrikontrol();
            if(Convert.ToInt16(x1) == 1)
            {
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("DELETE TBL_ISEMRI WHERE ISEMRI_NUMARASI = '"+txtIsEmriNumarasi.Text+"'",conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                sipariskaleminikapatma();
                temizle() ;
                txtIsEmriNumarasi.Text = "";
                isemrilistesicekme();
            }
            else
            {
                MessageBox.Show("Böyle Bir İş Emri Kaydı Yoktur.");
            }
        }

        
        private void txtStokKodu_Leave(object sender, EventArgs e)
        {
            stokkartikontrol();
            if(Convert.ToInt16(x2) == 1)
            {
                stokbilgisicekme();
                txtSiparisNumarasi.Text = "";
                txtMiktar.Text = "";
                txtSiparisKalemID.Text = "";
                txtStokAdi.Enabled = false;
            }
            else
            {
                txtStokKodu.Focus();
            }
        }

        private void FrmIsEmri_Activated(object sender, EventArgs e)
        {
            if(isemrix == "isemri")
            {
                txtIsEmriNumarasi.Text = FrmIsEmriListesi.isemrino;
                isemribilgisicekme();
                isemrix = "";
            }
            if(isemrix == "stok")
            {
                txtStokKodu.Text = FrmStokListesi.stokkodu;
                stokbilgisicekme();
                isemrix = "";
            }
            if(isemrix == "siparis")
            {
                txtSiparisKalemID.Text = FrmIsEmriSiparisleri.kalemid;
                if(txtSiparisKalemID.Text == "")
                {

                }
                else
                {
                    sipnovemiktaraulasma();
                    txtMiktar.Enabled = false;
                    isemrix = "";
                }
            }
        }

        private void txtSiparisKalemID_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void FrmIsEmri_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmIsEmriSiparisleri.kalemid = "";
            isemrix = "";
            FrmStokListesi.stokkodu = "";
            FrmIsEmriListesi.isemrino = "";  
        }

        private void sbtnSiparisTemizle_Click(object sender, EventArgs e)
        {
            temizle();
            txtIsEmriNumarasi.Text = "";
            txtIsEmriNumarasi.Focus();
        }

        private void sbtnStokListesi_Click(object sender, EventArgs e)
        {
            FrmStokListesi.stokkodu = "isemri"; 
            FrmStokListesi frmStokListesi = new FrmStokListesi();
            frmStokListesi.Show();

        }

        private void FrmIsEmri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }
    }
}
