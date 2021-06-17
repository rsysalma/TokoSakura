using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoSakura
{
    public partial class PembelianBarang : Form
    {
        public PembelianBarang()
        {
            InitializeComponent();
        }

        private void PembelianBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokoSakuraDataSet1.Pembelian' table. You can move, or remove it, as needed.
            this.pembelianTableAdapter.Fill(this.tokoSakuraDataSet1.Pembelian);

        }
    }
}
