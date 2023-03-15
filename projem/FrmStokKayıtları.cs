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
    public partial class FrmStokKayıtları : Form
    {
        public FrmStokKayıtları()
        {
            InitializeComponent();
        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void sbtnStokListesi_Click(object sender, EventArgs e)
        {
            FrmStokListesi frm = new FrmStokListesi();
            frm.Show();
        }

        private void sbtnGrupKodListesi_Click(object sender, EventArgs e)
        {
            FrmStokGrupKodlari frm = new FrmStokGrupKodlari();
            frm.Show();
        }
    }
}
