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
    public partial class FrmStokListesi : Form
    {
        public static string stokkodu;
        SqlConnection conn = new SqlConnection("Data Source=HALIL;Initial Catalog=ERP;Integrated Security=True");
        public FrmStokListesi()
        {
            InitializeComponent();
        }

        void arama()
        {
            //  datagrid içinde arama yapma fonksiyonu
            conn.Open();
            DataTable dt = new DataTable();
            SqlCommand sorgu1 = new SqlCommand("select * from TBL_STOKKAYITLARI where STOK_KODU like '%"+txtStokKodu.Text+"%' and STOK_ADI like '%"+txtStokAdi.Text+"%' and GRUP_KODU like '%"+TxtGrupKodu.Text+"%'", conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sorgu1);
            sqlDataAdapter.Fill(dt);
            gridControl1.DataSource = dt;
            
            conn.Close();
        }
        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmStokListesi_Load(object sender, EventArgs e)
        {
            //ilk açıldığında bütün veriler gözükür
            gridView1.OptionsBehavior.Editable = false;
            arama();
        }

        private void txtStokKodu_TextChanged(object sender, EventArgs e)
        {
            arama();  // istediğimiz verileri yazdıktan sonra ona göre tekrar aratılır
        }

        private void txtStokAdi_TextChanged(object sender, EventArgs e)
        {
            arama(); // istediğimiz verileri yazdıktan sonra ona göre tekrar aratılır
        }

        private void TxtGrupKodu_TextChanged(object sender, EventArgs e)
        {
            arama(); // istediğimiz verileri yazdıktan sonra ona göre tekrar aratılır
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            // tıkladığımız satırdaki veriyi
            DataRow data = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if(stokkodu == "kayit")
            {
                stokkodu = data["STOK_KODU"].ToString();
                this.Hide();
                FrmStokKayıtları frm = new FrmStokKayıtları();
                frm.Activate();
            }
            if(stokkodu == "sipariskayit")
            {
                stokkodu = data["STOK_KODU"].ToString();
                FrmSiparisler.siparisx = "stok";
                this.Hide();    
                FrmSiparisler frm = new FrmSiparisler();
                frm.Activate();
            }
            if(stokkodu == "isemri")
            {
                stokkodu = data["STOK_KODU"].ToString();
                FrmIsEmri.isemrix = "stok";
                this.Hide();
                FrmIsEmri frm = new FrmIsEmri();
                frm.Activate();
            }
            if(stokkodu == "stokhareket")
            {
                stokkodu = data["STOK_KODU"].ToString();
                FrmStokHareketleri.stokhareketx = "stok";
                this.Hide();
                FrmStokHareketleri frm = new FrmStokHareketleri();
                frm.Activate();
            }
        }

        private void FrmStokListesi_FormClosed(object sender, FormClosedEventArgs e)
        {
            //kapattığımızda tekrar sıfırlansın
            stokkodu = "";
        }
    }
}
