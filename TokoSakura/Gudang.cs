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
    public partial class Gudang : Form
    {
        public Gudang()
        {
            InitializeComponent();
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            KelolaBarang kelolaBarang = new KelolaBarang();
            kelolaBarang.Show();
        }

        private void btnPembelian_Click(object sender, EventArgs e)
        {
            PembelianBarang pembelianBarang = new PembelianBarang();
            pembelianBarang.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            KelolaSupplier kelolaSupplier = new KelolaSupplier();
            kelolaSupplier.Show();
        }

        private void btnJenisBarang_Click(object sender, EventArgs e)
        {
            KelolaJenisBarang kelolaJenisBarang = new KelolaJenisBarang();
            kelolaJenisBarang.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
        }
    }
}
