using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projem
{
    public partial class FrmStokKayıtları : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=HALIL;Initial Catalog=ERP;Integrated Security=True");


        public FrmStokKayıtları()
        {
            InitializeComponent();
        }
        string x1 = "0"; // kontrol etmek için bir string
        void stokkartkontrol() // kontrol yapıyoruz var mı yok mu?
        {
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("select count(*) from TBL_STOKKAYITLARI WHERE STOK_KODU = '" + txtStokKodu.Text + "'",conn);
            // sorgudan bize bir sayı dönecek onu x1 e eşitledik
            SqlDataReader dr = sorgu1.ExecuteReader();
            while(dr.Read()) 
            {
                x1 = dr[0].ToString();
            }

            conn.Close();
        }

        void temizle()
        {
            // textbox ları temizleme kodu
            txtFiyat.Text = "";
            txtGrupAdi.Text = "";
            txtGrupKodu.Text = "";
            txtKdvorani.Text = "";
            txtStokAdi.Text = "";
        }
        void stokbilgisicekme()
        {
            // burdada yazdığımız text boxtaki stok koduna göre verileri boxa yazdırıyoruz.
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT * from TBL_STOKKAYITLARI where STOK_KODU = '"+ txtStokKodu.Text+ "'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtStokAdi.Text = dr[1].ToString();
                txtGrupKodu.Text = dr[2].ToString();
                txtFiyat.Text = dr[3].ToString();
                txtKdvorani.Text = dr[4].ToString();
            }

            conn.Close();
        }
        string x2 = "0";
        void grupkodukontrol()
        {
            //grup kodu var mı yok mu bakıyoruz.
            //varsa x2 ye eşitliyoruz.
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("select COUNT(*) from TBL_GRUPKOD WHERE GRUP_KODU = '"+txtGrupKodu.Text+"'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x2 = dr[0].ToString();
            }

            conn.Close() ;
        }
        void grupbilgisicekme()
        {
            //grup adimiz yani telefon mu tablet mi vs onu alıyoruz.
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT GRUP_ADI FROM TBL_GRUPKOD WHERE GRUP_KODU = '"+txtGrupKodu.Text+"'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtGrupAdi.Text = dr[0].ToString();
            }

            conn.Close();
        }
        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void sbtnStokListesi_Click(object sender, EventArgs e)
        {
            FrmStokListesi.stokkodu = "kayit";
            //buton tıklanınça açılacak
            FrmStokListesi frm = new FrmStokListesi();
            frm.Show();
        }

        private void sbtnGrupKodListesi_Click(object sender, EventArgs e)
        {
            //butona tıklanınca açılacak
            FrmStokGrupKodlari frm = new FrmStokGrupKodlari();
            frm.Show();
        }

        private void FrmStokKayıtları_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void txtStokKodu_Leave(object sender, EventArgs e)
        {
            // stokkodu boxun dan ayrılınca taba vs basınca fonksiyonlar çalışacak
            if(txtStokKodu.Text == "")
            {
                txtStokKodu.Focus();
            }
            else 
            {
                FrmStokListesi.stokkodu = txtStokKodu.Text; // stok kodu değeri hiç boşta kalmayacak
                stokkartkontrol(); // bu fonksiyondan gelene göre 
                if (Convert.ToInt16(x1) == 1) //eğer varsa
                {
                    stokbilgisicekme(); // fonksiyonlar çalışacak bilgiler gelecek
                    grupbilgisicekme();
                }
                else
                {
                    temizle(); // boxlar temizlenecek
                    
                }
            }
            
        }



        private void FrmStokKayıtları_Activated(object sender, EventArgs e)
        {
            if(FrmStokListesi.stokkodu == "")  // aktif edildiğinde orası boşsa  temizlenecek
            {

                temizle();
                txtStokKodu.Text = "";
            }
            else
            {
                txtStokKodu.Text = FrmStokListesi.stokkodu;  // boş değilse fonksiyonlar çalışacak.
                stokbilgisicekme();
                grupbilgisicekme();
            }

            
        }

        private void c(object sender, EventArgs e)
        {

        }

        private void txtGrupKodu_Leave(object sender, EventArgs e)
        {
            grupkodukontrol(); // taba basıldığında  kontrol edilecek 
            if(Convert.ToInt16(x2) == 1) // eğer varsa 
            {
                grupbilgisicekme(); // bilgiler çekilip koyulacak 
            }
            else
            {
                txtGrupKodu.Focus(); // yoksa bişey olamayacak
            }
        }

        private void FrmStokKayıtları_FormClosed(object sender, FormClosedEventArgs e)
        {
            FrmStokListesi.stokkodu = ""; // form kapatıldığında stok kodu boş olacak
        }

        private void sbtnKaydet_Click(object sender, EventArgs e)
        {
            stokkartkontrol();
            if( Convert.ToInt16(x1) == 1)
            {
                //güncelleme
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("update TBL_STOKKAYITLARI SET STOK_KODU = '"+txtStokKodu.Text+"' , STOK_ADI = '"+txtStokAdi.Text+"' , GRUP_KODU = '"+txtGrupKodu.Text+"', FIYAT = '"+txtFiyat.Text.Replace(',','.')+"',KDV_ORANI = '"+txtKdvorani.Text.Replace(',','.')+"' WHERE STOK_KODU = '"+txtStokKodu.Text+"' ", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                temizle();
                txtStokKodu.Text = "";

            }
            else
            {
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("insert into TBL_STOKKAYITLARI (STOK_KODU ,STOK_ADI, GRUP_KODU, FIYAT , KDV_ORANI ) values('"+txtStokKodu.Text+"','"+txtStokAdi.Text+"','"+txtGrupKodu.Text+"','"+ txtFiyat.Text.Replace(',', '.') + "','"+ txtKdvorani.Text.Replace(',', '.') + "')", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                temizle();
                txtStokKodu.Text = "";
                
            }
        }

        private void sbtnSil_Click(object sender, EventArgs e)
        {
            stokkartkontrol();
            if(Convert.ToInt16(x1) == 1)
            {
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand(" delete TBL_STOKKAYITLARI WHERE STOK_KODU = '"+txtStokKodu.Text+"' ", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                temizle();
                txtStokKodu.Text = "";
            }
            else
            {
                MessageBox.Show("BOYLE BIR STOK KAYDI YOKTUR !!!");
            }
        }

        private void FrmStokKayıtları_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape) {
                this.Hide();
            }
            if(e.KeyCode == Keys.Enter)
            {
                sbtnKaydet.PerformClick();
            }
        }
    }
}
