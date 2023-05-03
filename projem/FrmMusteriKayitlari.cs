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
    public partial class FrmMusteriKayitlari : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=HALIL;Initial Catalog=ERP;Integrated Security=True");
        public FrmMusteriKayitlari()
        {
            InitializeComponent();
        }

        string x1 = "0";

        void musterikontrol()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("Select count(*) from TBL_MUSTERIKAYITLARI WHERE MUSTERI_KODU ='" + txtMusteriKodu.Text + "' ",conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read()) 
            {
                x1 = dr1[0].ToString();
            }

            conn.Close();
        }

        void musteribilgisicekme()
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("Select * from TBL_MUSTERIKAYITLARI WHERE MUSTERI_KODU ='" + txtMusteriKodu.Text + "' ",conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtMusteriAdi.Text = dr[1].ToString();
                txtAdres.Text = dr[2].ToString();
                comboil.Text = dr[3].ToString();
                comboilce.Text = dr[4].ToString();
                txtTelefon.Text = dr[5].ToString();
                txtEposta.Text = dr[6].ToString();  
                string x = dr[7].ToString();
                if(x == "A")
                {
                    rbtnalici.Checked = true;
                }
                else
                {
                    rbtnsatici.Checked = true;
                }
            }
            conn.Close();
            illisteleme();
            ilcelisteleme();
        }
        void illisteleme()
        {
            comboil.Properties.Items.Clear();
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("Select ISIM FROM TBL_IL ", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                comboil.Properties.Items.Add(dr1[0]);
            }

            conn.Close();
        }
        void ilcelisteleme()
        {
            comboilce.Properties.Items.Clear();
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("Select ISIM from TBL_ILCE WHERE IL_ID = '"+(comboil.SelectedIndex + 1)+"'  ", conn);
            SqlDataReader dr1 = sorgu1.ExecuteReader();
            while (dr1.Read())
            {
                comboilce.Properties.Items.Add(dr1[0]);
            }

            conn.Close();
        }

        void temizle()
        {
            txtAdres.Text = "";
            txtEposta.Text = "";
            txtMusteriAdi.Text = "";
            txtTelefon.Text = "";
            comboil.Properties.Items.Clear();
            comboil.Text = "";
            comboilce.Properties.Items.Clear();
            comboilce.Text = "";
            rbtnalici.Checked = false;
            rbtnsatici.Checked = false; 

        }
        private void sbtnStokListesi_Click(object sender, EventArgs e)
        {
            FrmMusteriListesi.musterıkodu = "musterikayit";
            FrmMusteriListesi frm = new FrmMusteriListesi();    
            frm.Show();
        }

        private void FrmMusteriKayitlari_Load(object sender, EventArgs e)
        {
            illisteleme();
        }

        private void txtMusteriKodu_Leave(object sender, EventArgs e)
        {
            if(txtMusteriKodu.Text == "")
            {
                txtMusteriKodu.Focus();
            }
            else
            {
                //FrmMusteriListesi.musterikodu = txtMusteriKodu.Text;
                musterikontrol();
                if (Convert.ToInt16(x1) == 1)
                {
                    //çek
                    //temizle();
                    musteribilgisicekme();
                    ilcelisteleme();
                }
                else
                {
                    temizle();
                    illisteleme();
                }

            }

            
        }

       

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            musterikontrol();
            if(Convert.ToInt16(x1) == 1)
            {
                //güncelle
                if(rbtnalici.Checked == true)
                {
                    //alıcı güncelleme
                    conn.Open();
                    SqlCommand sorgu1 = new SqlCommand("update TBL_MUSTERIKAYITLARI SET MUSTERI_ADI = '"+txtMusteriAdi.Text+"' , ADRES = '"+txtAdres.Text+"' , IL = '"+comboil.Text+"' , ILCE = '"+comboilce.Text+"' , TELEFON = '"+txtTelefon.Text+"' , E_POSTA = '"+txtEposta.Text+"' , TIP = 'A' where MUSTERI_KODU = '"+txtMusteriKodu.Text+"'",conn);
                    sorgu1.ExecuteNonQuery();
                    conn.Close();
                    temizle();
                    txtMusteriKodu.Text = "";
                    illisteleme();
                    
                }
                else
                {
                    //satici güncelleme
                    conn.Open();
                    SqlCommand sorgu1 = new SqlCommand("update TBL_MUSTERIKAYITLARI SET MUSTERI_ADI = '" + txtMusteriAdi.Text + "' , ADRES = '" + txtAdres.Text + "' , IL = '" + comboil.Text + "' , ILCE = '" + comboilce.Text + "' , TELEFON = '" + txtTelefon.Text + "' , E_POSTA = '" + txtEposta.Text + "' , TIP = 'S' where MUSTERI_KODU = '\"+txtMusteriKodu.Text+\"'", conn);
                    sorgu1.ExecuteNonQuery();
                    conn.Close();
                    temizle();
                    txtMusteriKodu.Text = "";
                    illisteleme();
                    
                }
            }
            else
            {
                // ekle
                if(rbtnalici.Checked == true)
                {
                    //alıcı eklemesi
                    conn.Open();
                    SqlCommand sorgu1 = new SqlCommand("insert into TBL_MUSTERIKAYITLARI (MUSTERI_KODU,MUSTERI_ADI,ADRES,IL,ILCE,TELEFON,E_POSTA,TIP) values ('"+txtMusteriKodu.Text+"','"+txtMusteriAdi.Text+"','"+txtAdres.Text+"','"+comboil.Text+"','"+comboilce.Text+"','"+txtTelefon.Text+"','"+txtEposta.Text+"','A') ", conn);
                    sorgu1.ExecuteNonQuery();
                    conn.Close();
                    temizle();
                    txtMusteriKodu.Text = "";
                    illisteleme();
                    
                }
                else
                {
                    //satici ekleme
                    conn.Open();
                    SqlCommand sorgu1 = new SqlCommand("insert into TBL_MUSTERIKAYITLARI (MUSTERI_KODU,MUSTERI_ADI,ADRES,IL,ILCE,TELEFON,E_POSTA,TIP) values ('" + txtMusteriKodu.Text + "','" + txtMusteriAdi.Text + "','" + txtAdres.Text + "','" + comboil.Text + "','" + comboilce.Text + "','" + txtTelefon.Text + "','" + txtEposta.Text + "','S') ", conn);
                    sorgu1.ExecuteNonQuery();
                    conn.Close();
                    temizle();
                    txtMusteriKodu.Text = "";
                    illisteleme();
                   
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
                    conn.Open();
                    SqlCommand sorgu1 = new SqlCommand("delete TBL_MUSTERIKAYITLARI WHERE MUSTERI_KODU = '"+txtMusteriKodu.Text+"'", conn);
                    sorgu1.ExecuteNonQuery();
                    conn.Close();
                    temizle();
                    txtMusteriKodu.Text = "";
                    illisteleme();
                    
        }

        private void comboil_Leave(object sender, EventArgs e)
        {
            ilcelisteleme();
            comboilce.Text = "";
        }

        private void comboil_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmMusteriKayitlari_Activated(object sender, EventArgs e)
        {
            if(FrmMusteriListesi.musterıkodu == "")
            {
                temizle();
                txtMusteriKodu.Text = "";
            }
            else
            {
                txtMusteriKodu.Text = FrmMusteriListesi.musterıkodu;
                musteribilgisicekme();
            }
        }

        private void FrmMusteriKayitlari_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmMusteriListesi.musterıkodu = "";
        }

        private void comboil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
