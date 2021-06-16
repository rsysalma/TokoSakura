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
    public partial class Manager : Form
    {
        public Manager()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LaporanLabaBersih laporanLabaBersih = new LaporanLabaBersih();
            laporanLabaBersih.Show();
        }

        private void btnGolKaryawan_Click(object sender, EventArgs e)
        {
            KelolaGolonganKaryawan kelolaGolonganKaryawan = new KelolaGolonganKaryawan();
            kelolaGolonganKaryawan.Show();
        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            KelolaKaryawan kelolaKaryawan = new KelolaKaryawan();
            kelolaKaryawan.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LaporanBarangKosong laporanBarangKosong = new LaporanBarangKosong();
            laporanBarangKosong.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LaporanPembelian laporanPembelian = new LaporanPembelian();
            laporanPembelian.Show();
        }

        private void btnLaporanPenjualan_Click(object sender, EventArgs e)
        {
            LaporanPenjualan laporanPenjualan = new LaporanPenjualan();
            laporanPenjualan.Show();
        }
    }
}
