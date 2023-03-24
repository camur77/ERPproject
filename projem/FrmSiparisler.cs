using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projem
{
    public partial class FrmSiparisler : Form
    {
        public FrmSiparisler()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void sbtnStokListesi_Click(object sender, EventArgs e)
        {
            FrmSiparisListesi frm = new FrmSiparisListesi();
            frm.Show();
        }
    }
}
