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
    public partial class KelolaGolonganKaryawan : Form
    {
        public KelolaGolonganKaryawan()
        {
            InitializeComponent();
        }

        private void KelolaGolonganKaryawan_Load(object sender, EventArgs e)
        {
            //sekar
            this.golonganKaryawanTableAdapter.Fill(this.tokoSakuraDataSet1.GolonganKaryawan);
            // button cari, ubah dan unable, karna ketika load data akan menampilkan id otomatis untuk simpan data
            btnCari.Enabled = false;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            // id otomatis
            idOtomatis();
            txtID.Enabled = false;
        }

        // mendapatkan string data sql server
        public string GetConnectionDB()
        {
            // sekar
            string ConnectionString = @"Integrated Security=true; Data Source=LAPTOP-2F1SV60V\MSSQLSERVER01; Initial Catalog=TokoSakura";
            // salma
            //string connectionString = "integrated security = true; data source =.; initial catalog = TokoSakura";
            return ConnectionString;
        }
        // medapatkan angka pada id otomatis
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
        // membuat id otomatis
        private void idOtomatis()
        {
            string query = "SELECT TOP 1 Kode_Golongan_Karyawan FROM GolonganKaryawan ORDER BY Kode_Golongan_Karyawan DESC";
            txtID.Text = autogenerateID("GLK", query);
        }
        // validasi hanya huruf pada nama
        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        // validasi hanya angka pada gaji
        private void txtGaji_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        // clear textbox
        private void clear()
        {
            txtID.Clear();
            idOtomatis();
            txtID.Enabled = false;
            txtNama.Clear();
            txtGaji.Clear();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtGaji.Text == "")
            {
                MessageBox.Show ("Seluruh data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring = GetConnectionDB();
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand insert = new SqlCommand("sp_InputGolonganKaryawan", connection);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("Kode_Golongan_Karyawan", txtID.Text);
                insert.Parameters.AddWithValue("Nama_Golongan_Karyawan", txtNama.Text);
                insert.Parameters.AddWithValue("Gaji", txtGaji.Text);
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
                cmd.CommandText = "sp_CariGolonganKaryawan";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Kode_Golongan_Karyawan", txtID.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                txtNama.Text = dt.Rows[0]["Nama_Golongan_Karyawan"].ToString();
                txtGaji.Text = dt.Rows[0]["Gaji"].ToString();
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
            if (txtID.Text == "" || txtNama.Text == "" || txtGaji.Text == "")
            {
                MessageBox.Show("Seluruh data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring = GetConnectionDB();
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand insert = new SqlCommand("sp_UpdateGolonganKaryawan", connection);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("Kode_Golongan_Karyawan", txtID.Text);
                insert.Parameters.AddWithValue("Nama_Golongan_Karyawan", txtNama.Text);
                insert.Parameters.AddWithValue("Gaji", txtGaji.Text);
                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    btnSimpan.Enabled = true;
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
            if (txtID.Text == "" || txtNama.Text == "" || txtGaji.Text == "")
            {
                MessageBox.Show("Seluruh data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring = GetConnectionDB();
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand insert = new SqlCommand("sp_DeleteGolonganKaryawan", connection);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("Kode_Golongan_Karyawan", txtID.Text);
                try
                {
                    connection.Open();
                    insert.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                    btnSimpan.Enabled = true;
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
            txtID.Text = "";
            txtID.Enabled = true;
            btnSimpan.Enabled = false;
            btnCari.Enabled = true;
            btnUbah.Enabled = true;
            btnHapus.Enabled = true;
        }
    }
}
