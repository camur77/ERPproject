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
    public partial class FrmMusteriKayitlari : Form
    {
        public FrmMusteriKayitlari()
        {
            InitializeComponent();
        }

        private void sbtnStokListesi_Click(object sender, EventArgs e)
        {
            FrmMusteriListesi frm = new FrmMusteriListesi();    
            frm.Show();
        }
    }
}
