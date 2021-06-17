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
    public partial class KelolaMember : Form
    {
        public KelolaMember()
        {
            InitializeComponent();
        }

        private void KelolaMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokoSakuraDataSet1.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.tokoSakuraDataSet1.Member);

        }
    }
}
