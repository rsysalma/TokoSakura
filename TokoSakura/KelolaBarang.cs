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
    public partial class KelolaBarang : Form
    {
        public string GetConnectionDB()
        {
            // sekar
            string ConnectionString = @"Integrated Security=true; Data Source=LAPTOP-2F1SV60V\MSSQLSERVER01; Initial Catalog=TokoSakura";
            // salma
            //string connectionString = "integrated security = true; data source =.; initial catalog = TokoSakura";
            return ConnectionString;
        }

        public KelolaBarang()
        {
            InitializeComponent();
            string query = "SELECT TOP 1 Kode_Barang FROM Barang ORDER BY Kode_Barang DESC";

            txtID.Text = autogenerateID("BRG", query);
            txtID.Enabled = false;
        }

        private void KelolaBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokoSakuraDataSet1.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter1.Fill(this.tokoSakuraDataSet1.Supplier);
            // TODO: This line of code loads data into the 'tokoSakuraDataSet1.JenisBarang' table. You can move, or remove it, as needed.
            this.jenisBarangTableAdapter1.Fill(this.tokoSakuraDataSet1.JenisBarang);
            //sekar
            this.barangTableAdapter1.Fill(this.tokoSakuraDataSet1.Barang);
            // salma
            //this.barangTableAdapter.Fill(this.tokoSakuraDataSet.Barang);
            //this.supplierTableAdapter.Fill(this.tokoSakuraDataSet.Supplier);
            //this.jenisBarangTableAdapter.Fill(this.tokoSakuraDataSet.JenisBarang);
            // sekar


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
            txtDeskripsi.Clear();
            txtHarga.Clear();
            txtJumlah.Clear();


            string query = "SELECT TOP 1 Kode_Barang FROM Barang ORDER BY Kode_Barang DESC";

            txtID.Text = autogenerateID("BRG", query);
            txtID.Enabled = false;
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                epWarning.SetError(txtID, "ID Barang wajib diisi!");
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
                epWarning.SetError(txtNama, "Nama Barang wajib diisi!");
                epWrong.SetError(txtNama, "");
            }
            else
            {
                epWarning.SetError(txtNama, "");
                epWrong.SetError(txtNama, "");
            }
        }

        private void txtJumlah_Leave(object sender, EventArgs e)
        {
            if (txtJumlah.Text == "")
            {
                epWarning.SetError(txtJumlah, "Jumlah wajib diisi!");
                epWrong.SetError(txtJumlah, "");
            }
            else
            {
                epWarning.SetError(txtJumlah, "");
                epWrong.SetError(txtJumlah, "");
            }
        }

        private void txtHarga_Leave(object sender, EventArgs e)
        {
            if (txtHarga.Text == "")
            {
                epWarning.SetError(txtHarga, "Harga wajib diisi!");
                epWrong.SetError(txtHarga, "");
            }
            else
            {
                epWarning.SetError(txtHarga, "");
                epWrong.SetError(txtHarga, "");
            }
        }

        private void txtDeskripsi_Leave(object sender, EventArgs e)
        {
            if (txtDeskripsi.Text == "")
            {
                epWarning.SetError(txtDeskripsi, "Deskripsi wajib diisi!");
                epWrong.SetError(txtDeskripsi, "");
            }
            else
            {
                epWarning.SetError(txtDeskripsi, "");
                epWrong.SetError(txtDeskripsi, "");
            }
        }

        private void cbJenis_Leave(object sender, EventArgs e)
        {
            if (cbJenis.Text == "")
            {
                epWarning.SetError(cbJenis, "Jenis Barang wajib diisi!");
                epWrong.SetError(cbJenis, "");
            }
            else
            {
                epWarning.SetError(cbJenis, "");
                epWrong.SetError(cbJenis, "");
            }
        }

        private void cbSupplier_Leave(object sender, EventArgs e)
        {
            if (cbSupplier.Text == "")
            {
                epWarning.SetError(cbSupplier, "Supplier Barang wajib diisi!");
                epWrong.SetError(cbSupplier, "");
            }
            else
            {
                epWarning.SetError(cbSupplier, "");
                epWrong.SetError(cbSupplier, "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSimpan_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtJumlah.Text == "" || txtHarga.Text == "" || txtDeskripsi.Text == "")
            {
                MessageBox.Show
                  ("Seluruh data wajib diisi!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring = GetConnectionDB();
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand insert = new SqlCommand("sp_InputBarang", connection);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("Kode_Barang", txtID.Text);
                insert.Parameters.AddWithValue("Nama_Barang", txtNama.Text);
                insert.Parameters.AddWithValue("Kode_Jenis_Barang", cbJenis.SelectedValue.ToString());
                insert.Parameters.AddWithValue("Kode_Supplier", cbSupplier.SelectedValue.ToString());
                insert.Parameters.AddWithValue("Jumlah", txtJumlah.Text);
                insert.Parameters.AddWithValue("Harga", txtHarga.Text);
                insert.Parameters.AddWithValue("Deskripsi", txtDeskripsi.Text);
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
                cmd.CommandText = "sp_CariBarang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Kode_Barang", txtID.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                txtNama.Text = dt.Rows[0]["Nama_Barang"].ToString();
                cbJenis.Text = dt.Rows[0]["Kode_Jenis_Barang"].ToString();
                cbSupplier.Text = dt.Rows[0]["Kode_Supplier"].ToString();
                txtJumlah.Text = dt.Rows[0]["Jumlah"].ToString();
                txtHarga.Text = dt.Rows[0]["Harga"].ToString();
                txtDeskripsi.Text = dt.Rows[0]["Deskripsi"].ToString();
                con.Close();
            }
            catch
            {
                MessageBox.Show
                  ("Data Tidak Ditemukan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnUbah_Click_1(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtJumlah.Text == "" || txtHarga.Text == "" || txtDeskripsi.Text == "")
            {
                MessageBox.Show
                  ("Seluruh data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring = GetConnectionDB();
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand update = new SqlCommand("sp_UpdateBarang", connection);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("Kode_Barang", txtID.Text);
                update.Parameters.AddWithValue("Nama_Barang", txtNama.Text);
                update.Parameters.AddWithValue("Kode_Jenis_Barang", cbJenis.Text);
                update.Parameters.AddWithValue("Kode_Supplier", cbSupplier.Text);
                update.Parameters.AddWithValue("Jumlah", txtJumlah.Text);
                update.Parameters.AddWithValue("Harga", txtHarga.Text);
                update.Parameters.AddWithValue("Deskripsi", txtDeskripsi.Text);
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
            if (txtID.Text == "" || txtNama.Text == "" || txtJumlah.Text == "" || txtHarga.Text == "" || txtDeskripsi.Text == "")
            {
                MessageBox.Show
                  ("Seluruh data wajib diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring = GetConnectionDB();
                SqlConnection connection = new SqlConnection(connectionstring);
                SqlCommand delete = new SqlCommand("sp_DeleteBarang", connection);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("Kode_Barang", txtID.Text);
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
    }
}
