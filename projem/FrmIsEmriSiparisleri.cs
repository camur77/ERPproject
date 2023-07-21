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
    public partial class FrmIsEmriSiparisleri : Form
    {
        public static string kalemid; 
        SqlConnection conn = new SqlConnection("Data Source=HALIL;Initial Catalog=proje;Integrated Security=True");
        public FrmIsEmriSiparisleri()
        {
            InitializeComponent();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DataRow x = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            kalemid = x["SIPKALEM_ID"].ToString();
            FrmIsEmri.isemrix = "siparis";
            this.Hide();
            FrmIsEmri frm = new FrmIsEmri();
            frm.Activate();
        }

        private void FrmIsEmriSiparisleri_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            gridView1.OptionsBehavior.Editable = false;
            conn.Open();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("SELECT SIPARIS_NO, STOK_KODU, STOK_ADI, MIKTAR,SIPKALEM_ID FROM TBL_SIPARISKALEMLERI WHERE STOK_KODU = '"+FrmIsEmri.stokkodu+"' AND URETIMDURUMU = 'K'  ",conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dataTable);
            gridControl1.DataSource = dataTable;
            conn.Close();
        }

        private void FrmIsEmriSiparisleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            kalemid = "";
        }

        private void FrmIsEmriSiparisleri_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Hide();
            }
        }
    }
}
