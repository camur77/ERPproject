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

        private void sbtnIsEmriListesi_Click(object sender, EventArgs e)
        {
            FrmIsEmriListesi frm = new FrmIsEmriListesi();
            frm.Show();
        }

        private void sbtnSiparisListesi_Click(object sender, EventArgs e)
        {
            FrmIsEmriSiparisleri frm = new FrmIsEmriSiparisleri();
            frm.Show();
        }

        private void FrmIsEmri_Load(object sender, EventArgs e)
        {

        }
    }
}
