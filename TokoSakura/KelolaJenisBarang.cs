using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TokoSakura
{
    public partial class KelolaJenisBarang : Form
    {
        public string GetConnectionDB()
        {
            //sekar
            string ConnectionString = @"Integrated Security=true; Data Source=LAPTOP-2F1SV60V\MSSQLSERVER01; Initial Catalog=TokoSakura";
            // salma
            //string connectionString = "integrated security = true; data source =.; initial catalog = TokoSakura";
            return ConnectionString;
        }

        public KelolaJenisBarang()
        {
            InitializeComponent();
            string query = "SELECT TOP 1 Kode_Jenis_Barang FROM JenisBarang ORDER BY Kode_Jenis_Barang DESC";
            txtID.Text = autogenerateID("JBG", query);
            txtID.Enabled = false;
        }

        public string autogenerateID(string firstText, string query)
        {
            string connectionString = GetConnectionDB();
            SqlCommand sqlCmd;
            SqlConnection sqlCon;
            string result = "";
            int num = 0;
            try
            {
                sqlCon = new SqlConnection(connectionString);
                sqlCon.Open();
                sqlCmd = new SqlCommand(query, sqlCon);
                SqlDataReader reader = sqlCmd.ExecuteReader();
                if (reader.Read())
                {
                    string last = reader[0].ToString();
                    num = Convert.ToInt32(last.Remove(0, firstText.Length)) + 1;
                }
                else
                {
                    num = 1;
                }
                sqlCon.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            result = firstText + num.ToString().PadLeft(2, '0');
            return result;
        }

        private void clear()
        {
            txtNama.Clear();
            txtID.Clear();
            string query = "SELECT TOP 1 Kode_Jenis_Barang FROM JenisBarang ORDER BY Kode_Jenis_Barang DESC";
            txtID.Text = autogenerateID("JBG", query);
            txtID.Enabled = false;
            cbDetail.SelectedIndex = -1;
        }

        private void KelolaJenisBarang_Load(object sender, EventArgs e)
        {
            btnCari.Enabled = false;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            //sekar
            // TODO: This line of code loads data into the 'tokoSakuraDataSet1.JenisBarang' table. You can move, or remove it, as needed.
            this.jenisBarangTableAdapter1.Fill(this.tokoSakuraDataSet1.JenisBarang);
            // salma
            //this.jenisBarangTableAdapter.Fill(this.tokoSakuraDataSet.JenisBarang);

        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                epWarning.SetError(txtID, "ID Jenis Barang wajib diisi!");
                epWrong.SetError(txtID, "");
            }
            else
            {
                epWarning.SetError(txtID, "");
                epWrong.SetError(txtID, "");
            }
        }

        private void txtNama_Leave(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                epWarning.SetError(txtNama, "Nama Jenis Barang wajib diisi!");
                epWrong.SetError(txtNama, "");
            }
            else
            {
                epWarning.SetError(txtNama, "");
                epWrong.SetError(txtNama, "");
            }
        }

        private void cbDetail_Leave(object sender, EventArgs e)
        {
            if (cbDetail.Text == "")
            {
                epWarning.SetError(cbDetail, "Detail wajib diisi!");
                epWrong.SetError(cbDetail, "");
            }
            else
            {
                epWarning.SetError(cbDetail, "");
                epWrong.SetError(cbDetail, "");
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || cbDetail.Text == "")
            {
                MessageBox.Show
                  ("Seluruh data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring = GetConnectionDB();
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand insert = new SqlCommand("sp_InputJenisBarang", connection);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("Kode_Jenis_Barang", txtID.Text);
                insert.Parameters.AddWithValue("Nama_Jenis_Barang", txtNama.Text);
                insert.Parameters.AddWithValue("Detail_Jenis_Barang", cbDetail.Text);
                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal menyimpan data, error: " + ex.Message);
                }
            }
        }
        
        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = GetConnectionDB();
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "sp_CariJenisBarang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Kode_Jenis_Barang", txtID.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                txtNama.Text = dt.Rows[0]["Nama_Jenis_Barang"].ToString();
                cbDetail.Text = dt.Rows[0]["Detail_Jenis_Barang"].ToString();
                txtID.Enabled = false;
                txtNama.Enabled = true;
                btnCari.Enabled = false;
                con.Close();
            }
            catch
            {
                MessageBox.Show
                  ("Data Tidak Ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || cbDetail.Text == "")
            {
                MessageBox.Show
                  ("Seluruh data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring = GetConnectionDB();
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand update = new SqlCommand("sp_UpdateJenisBarang", connection);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("Kode_Jenis_Barang", txtID.Text);
                update.Parameters.AddWithValue("Nama_Jenis_Barang", txtNama.Text);
                update.Parameters.AddWithValue("Detail_Jenis_Barang", cbDetail.Text);
                try
                {
                    connection.Open();
                    update.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    btnUbah.Enabled = false;
                    btnHapus.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal update data, error : " + ex.Message);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || cbDetail.Text == "")
            {
                MessageBox.Show
                  ("Seluruh data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring = GetConnectionDB();
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand delete = new SqlCommand("sp_DeleteJenisBarang", connection);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("Kode_Jenis_Barang", txtID.Text);
                try
                {
                    connection.Open();
                    delete.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    btnUbah.Enabled = false;
                    btnHapus.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal hapus data, error : " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clear();
            btnSimpan.Enabled = false;
            btnCari.Enabled = true;
            btnUbah.Enabled = true;
            btnHapus.Enabled = true;
            txtID.Text = "";
            txtID.Enabled = true;
        }
    }
}
