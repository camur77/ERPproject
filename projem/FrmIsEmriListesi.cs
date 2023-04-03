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
   
    public partial class FrmIsEmriListesi : Form
    {
        public static string isemrino;
        SqlConnection conn = new SqlConnection("Data Source=HALIL;Initial Catalog=ERP;Integrated Security=True");
        public FrmIsEmriListesi()
        {
            InitializeComponent();
        }

        void arama()
        {
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select ISEMRI_NUMARASI, STOK_KODU, STOK_ADI,SIPARIS_NO FROM TBL_ISEMRI WHERE ISEMRI_NUMARASI LIKE '%"+txtIsEmriNumarasi.Text+"%' AND STOK_KODU LIKE '%"+txtStokKodu.Text+"%' AND STOK_ADI LIKE '%"+txtStokAdi.Text+"%' AND SIPARIS_NO LIKE '%"+txtSiparisNumarasi.Text +"%' ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            gridControl1.DataSource = dt;
            conn.Close();
        }

        private void FrmIsEmriListesi_Load(object sender, EventArgs e)
        {
            gridView1.OptionsBehavior.Editable = false;
            arama();
        }

        private void gridControl1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(isemrino == "isemrikayit")
            {
                isemrino = x["ISEMRI_NUMARASI"].ToString();
                FrmIsEmri.isemrix = "isemri";
                this.Hide();
                FrmIsEmri frmIsEmri = new FrmIsEmri();
                frmIsEmri.Activate();
            }
        }

        private void FrmIsEmriListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            isemrino = "";

        }

        private void txtIsEmriNumarasi_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtStokKodu_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtSiparisNumarasi_TextChanged(object sender, EventArgs e)
        {
            arama();
        }

        private void txtStokAdi_TextChanged(object sender, EventArgs e)
        {
            arama();
        }
    }
}
