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
    public partial class FrmStokGrupKodlari : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=HALIL;Initial Catalog=ERP;Integrated Security=True");
        public FrmStokGrupKodlari()
        {
            InitializeComponent();
        }
        void grupkodulisteleme()
        {
            //  datagrid içinde arama yapma fonksiyonu
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("select * from TBL_GRUPKOD", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sorgu1);
            sqlDataAdapter.Fill(dt);
            gridControl1.DataSource = dt;

            conn.Close();
        }
        string x2 = "0";
        void grupkodukontrol()
        {
            //grup kodu var mı yok mu bakıyoruz.
            //varsa x2 ye eşitliyoruz.
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("select COUNT(*) from TBL_GRUPKOD WHERE GRUP_KODU = '" + txtGrupKodu.Text + "'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                x2 = dr[0].ToString();
            }

            conn.Close();
        }
        void grupkodubilgisicekme()
        {
            
            conn.Open();
            SqlCommand sorgu1 = new SqlCommand("SELECT GRUP_ADI FROM TBL_GRUPKOD WHERE GRUP_KODU = '" + txtGrupKodu.Text + "'", conn);
            SqlDataReader dr = sorgu1.ExecuteReader();
            while (dr.Read())
            {
                txtGrupAdi.Text = dr[0].ToString();
            }

            conn.Close();
        }
        private void FrmStokGrupKodlari_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            grupkodulisteleme();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void gridView1_Click(object sender, EventArgs e)
        {
            DataRow datarow = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtGrupKodu.Text = datarow["GRUP_KODU"].ToString();
            txtGrupAdi.Text = datarow["GRUP_ADI"].ToString();
        }

        private void txtGrupKodu_Leave(object sender, EventArgs e)
        {
            grupkodukontrol();
            if(Convert.ToInt16(x2) == 1)
            {
                grupkodubilgisicekme();
            }
            else
            {
                txtGrupAdi.Text = "";
            }
        }
        void temizle()
        {
            txtGrupAdi.Text = "";
            txtGrupKodu.Text = "";
        }
        private void sbtnKaydet_Click(object sender, EventArgs e)
        {
            grupkodukontrol();
            if(Convert.ToInt16(x2) == 1)
            {
                //güncelleme yapılacak
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("update TBL_GRUPKOD SET GRUP_ADI = '" + txtGrupAdi.Text + "' where GRUP_KODU = '" + txtGrupKodu.Text + "' ", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                temizle();
                grupkodulisteleme();
            }
            else
            {
                // yeni kayıt eklenecek
                conn.Open();
                SqlCommand sorgu1 = new SqlCommand("insert into TBL_GRUPKOD (GRUP_KODU , GRUP_ADI ) values('"+txtGrupKodu.Text+"','"+txtGrupAdi.Text+"')", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                temizle();
                grupkodulisteleme();
            }
        }

        private void SbtnSil_Click(object sender, EventArgs e)
        {
            grupkodukontrol();
            if(Convert.ToInt16(x2) == 1     /*txtGrupKodu.Text == ""*/)
            {
                conn.Open();
                SqlCommand sorgu2 = new SqlCommand("DELETE TBL_GRUPKOD WHERE GRUP_KODU = '" + txtGrupKodu.Text + "'", conn);
                sorgu2.ExecuteNonQuery();
                conn.Close();
                temizle();
                grupkodulisteleme();
            }
            else
            {
               /* conn.Open();
                SqlCommand sorgu1 = new SqlCommand("delete TBL_GRUPKOD WHERE GRUP_KODU = '" + txtGrupKodu.Text + "'", conn);
                sorgu1.ExecuteNonQuery();
                conn.Close();
                temizle();*/
            }

        }

        private void FrmStokGrupKodlari_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }
    }
}
