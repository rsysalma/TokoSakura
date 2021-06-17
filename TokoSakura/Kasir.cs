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
    public partial class Kasir : Form
    {
        public Kasir()
        {
            InitializeComponent();
        }

        private void btnMember_Click(object sender, EventArgs e)
        {
            KelolaMember kelolaMember = new KelolaMember();
            kelolaMember.Show();
        }

        private void btnPenjualan_Click(object sender, EventArgs e)
        {
            PenjualanBarang penjualanBarang = new PenjualanBarang();
            penjualanBarang.Show();
        }

        private void btnBuatMember_Click(object sender, EventArgs e)
        {
            PembuatanMember pembuatanMember = new PembuatanMember();
            pembuatanMember.Show();
        }

        private void btnGolMember_Click(object sender, EventArgs e)
        {
            KelolaJenisMember kelolaJenisMember = new KelolaJenisMember();
            kelolaJenisMember.Show();
        }

        private void btnDataHadiah_Click(object sender, EventArgs e)
        {
            KelolaDataHadiah kelolaDataHadiah = new KelolaDataHadiah();
            kelolaDataHadiah.Show();
        }

        private void btnTukarHadiah_Click(object sender, EventArgs e)
        {
            PenukaranHadiah penukaranHadiah = new PenukaranHadiah();
            penukaranHadiah.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FormMenu formMenu = new FormMenu();
            formMenu.Show();
            this.Hide();
        }
    }
}
