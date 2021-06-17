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
    public partial class KelolaSupplier : Form
    {
        public string GetConnectionDB()
        {
            //sekar
            string ConnectionString = @"Integrated Security=true; Data Source=LAPTOP-2F1SV60V\MSSQLSERVER01; Initial Catalog=TokoSakura";
            // salma
            //string connectionString = "integrated security = true; data source =.; initial catalog = TokoSakura";
            return ConnectionString;
        }

        public KelolaSupplier()
        {
            InitializeComponent();
            string query = "SELECT TOP 1 Kode_Supplier FROM Supplier ORDER BY Kode_Supplier DESC";

            txtID.Text = autogenerateID("SPL", query);
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
            txtNoTelp.Clear();
            txtAlamat.Clear();
            string query = "SELECT TOP 1 Kode_Supplier FROM Supplier ORDER BY Kode_Supplier DESC";
            txtID.Text = autogenerateID("SPL", query);
            txtID.Enabled = false;
        }

        private void txtNoTelp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) || (txtNoTelp.Text.Length >= 13 && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
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
                epWarning.SetError(txtID, "ID Supplier wajib diisi!");
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
                epWarning.SetError(txtNama, "Nama Supplier wajib diisi!");
                epWrong.SetError(txtNama, "");
            }
            else
            {
                epWarning.SetError(txtNama, "");
                epWrong.SetError(txtNama, "");
            }
        }

        private void txtNoTelp_Leave(object sender, EventArgs e)
        {
            if (txtNoTelp.Text == "")
            {
                epWarning.SetError(txtNoTelp, "Nomor telepon wajib diisi!");
                epWrong.SetError(txtNoTelp, "");
            }
            else
            {
                epWarning.SetError(txtNoTelp, "");
                epWrong.SetError(txtNoTelp, "");
            }
        }

        private void txtAlamat_Leave(object sender, EventArgs e)
        {
            if (txtAlamat.Text == "")
            {
                epWarning.SetError(txtAlamat, "Alamat wajib diisi!");
                epWrong.SetError(txtAlamat, "");
            }
            else
            {
                epWarning.SetError(txtAlamat, "");
                epWrong.SetError(txtAlamat, "");
            }
        }

        private void KelolaSupplier_Load(object sender, EventArgs e)
        {
            btnCari.Enabled = false;
            btnUbah.Enabled = false;
            btnHapus.Enabled = false;
            // TODO: This line of code loads data into the 'tokoSakuraDataSet1.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter1.Fill(this.tokoSakuraDataSet1.Supplier);
            //salma
            //this.supplierTableAdapter.Fill(this.tokoSakuraDataSet.Supplier);
        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtNoTelp.Text == "" || txtAlamat.Text == "")
            {
                MessageBox.Show
                  ("Seluruh data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring = GetConnectionDB();
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand insert = new SqlCommand("sp_InputSupplier", connection);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("Kode_Supplier", txtID.Text);
                insert.Parameters.AddWithValue("Nama_Supplier", txtNama.Text);
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
                    MessageBox.Show("Gagal menyimpan data, error : " + ex.Message);
                }
            }
        }

        private void btnCari_Click_1(object sender, EventArgs e)
        {
            try
            {
                string connectionString = GetConnectionDB();
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "sp_CariSupplier";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Kode_Supplier", txtID.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                txtNama.Text = dt.Rows[0]["Nama_Supplier"].ToString();
                txtAlamat.Text = dt.Rows[0]["Alamat"].ToString();
                txtNoTelp.Text = dt.Rows[0]["No_Telepon"].ToString();
                txtID.Enabled = false;
                txtNama.Enabled = false;
                txtAlamat.Enabled = true;
                txtNoTelp.Enabled = true;
                btnCari.Enabled = false;
                con.Close();
            }
            catch
            {
                MessageBox.Show("Data Tidak Ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnUbah_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtAlamat.Text == "" || txtNoTelp.Text == "")
            {
                MessageBox.Show
                  ("Seluruh data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring = GetConnectionDB();
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand update = new SqlCommand("sp_UpdateSupplier", connection);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("Kode_Supplier", txtID.Text);
                update.Parameters.AddWithValue("Alamat", txtAlamat.Text);
                update.Parameters.AddWithValue("No_Telepon", txtNoTelp.Text);
                try
                {
                    connection.Open();
                    update.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil diupdate", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal update data, error : " + ex.Message);
                }
            }
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtAlamat.Text == "" || txtNoTelp.Text == "")
            {
                MessageBox.Show
                  ("Seluruh data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring = GetConnectionDB();
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand delete = new SqlCommand("sp_DeleteSupplier", connection);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("Kode_Supplier", txtID.Text);


                try
                {
                    connection.Open();
                    delete.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
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
