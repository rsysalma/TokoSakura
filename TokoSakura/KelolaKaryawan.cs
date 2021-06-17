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
    public partial class KelolaKaryawan : Form
    {
        public KelolaKaryawan()
        {
            InitializeComponent();
            idOtomatis();
            txtID.Enabled = false;
        }

        private void KelolaKaryawan_Load(object sender, EventArgs e)
        {
            btnCari.Enabled = false;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            //sekar
            this.golonganKaryawanTableAdapter.Fill(this.tokoSakuraDataSet1.GolonganKaryawan);
            this.karyawanTableAdapter.Fill(this.tokoSakuraDataSet1.Karyawan);
        }

        public string GetConnectionDB()
        {
            // sekar
            string ConnectionString = @"Integrated Security=true; Data Source=LAPTOP-2F1SV60V\MSSQLSERVER01; Initial Catalog=TokoSakura";
            // salma
            //string connectionString = "integrated security = true; data source =.; initial catalog = TokoSakura";
            return ConnectionString;
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

        private void idOtomatis()
        {
            string query = "SELECT TOP 1 Kode_Karyawan FROM Karyawan ORDER BY Kode_Karyawan DESC";
            txtID.Text = autogenerateID("KRY", query);
        }

        private void clear()
        {
            txtID.Clear();
            idOtomatis();
            txtID.Enabled = false;
            txtNama.Clear();
            dateTimePicker1.Text = "";
            txtAlamat.Clear();
            txtNoTelp.Clear();
            comboBox1.SelectedValue = -1;
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtAlamat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNoTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || (txtNoTelp.Text.Length >= 13 && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtAlamat.Text == "" || txtNoTelp.Text == "" )
            {
                MessageBox.Show("Seluruh data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring = GetConnectionDB();
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand insert = new SqlCommand("sp_InputKaryawan", connection);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("Kode_Karyawan", txtID.Text);
                insert.Parameters.AddWithValue("Kode_Golongan_Karyawan", comboBox1.SelectedValue.ToString());
                insert.Parameters.AddWithValue("Nama_Karyawan", txtNama.Text);
                insert.Parameters.AddWithValue("Tanggal_Lahir", dateTimePicker1.Text);
                insert.Parameters.AddWithValue("Alamat", txtAlamat.Text);
                insert.Parameters.AddWithValue("No_Telepon", txtNoTelp.Text);
                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil disimpan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal simpan data, error: " + ex.Message);
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
                cmd.CommandText = "sp_CariKaryawan";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Kode_Karyawan", txtID.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                txtNama.Text = dt.Rows[0]["Nama_Karyawan"].ToString();
                dateTimePicker1.Text = dt.Rows[0]["Tanggal_Lahir"].ToString();
                txtAlamat.Text = dt.Rows[0]["Alamat"].ToString();
                txtNoTelp.Text = dt.Rows[0]["No_Telepon"].ToString();
                txtID.Enabled = false;
                btnCari.Enabled = false;
                con.Close();
            }
            catch
            {
                MessageBox.Show
                  ("Data tidak ditemukan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtAlamat.Text == "" || txtNoTelp.Text == "")
            {
                MessageBox.Show("Seluruh data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring = GetConnectionDB();
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand insert = new SqlCommand("sp_UpdateKaryawan", connection);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("Kode_Karyawan", txtID.Text);
                insert.Parameters.AddWithValue("Kode_Golongan_Karyawan", comboBox1.SelectedValue.ToString());
                insert.Parameters.AddWithValue("Alamat", txtAlamat.Text);
                insert.Parameters.AddWithValue("No_Telepon", txtNoTelp.Text);
                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal update data, error: " + ex.Message);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtAlamat.Text == "" || txtNoTelp.Text == "")
            {
                MessageBox.Show("Seluruh data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring = GetConnectionDB();
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand insert = new SqlCommand("sp_DeleteKaryawan", connection);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("Kode_Karyawan", txtID.Text);
                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal hapus data, error: " + ex.Message);
                }
            }
        }
    }
}
