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
        public KelolaSupplier()
        {
            InitializeComponent();
            string query = "SELECT TOP 1 Kode_Supplier FROM Supplier ORDER BY Kode_Supplier DESC";

            txtID.Text = autogenerateID("SPL", query);
            txtID.Enabled = false;
        }

        public string autogenerateID(string firstText, string query)
        {
            string connectionString = "integrated security = true; data source =.; initial catalog = TokoSakura";
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtNoTelp.Text == "" || txtAlamat.Text == "")
            {
                MessageBox.Show
                  ("Seluruh data wajib diisi!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring =
             "integrated security=true; data source=.; initial catalog=TokoSakura";
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
                    MessageBox.Show("Data saved succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to saved: " + ex.Message);
                }
            }
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            clear();
            txtID.Enabled = true;
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {

                string connectionString = "integrated security = true; data source =.; initial catalog = TokoSakura";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = "sp_CariSupplier";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Kode_Supplier", txtID.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                txtNama.Text = dt.Rows[0]["Nama_Supplier"].ToString();
                txtAlamat.Text = dt.Rows[0]["Alamat"].ToString();
                txtNoTelp.Text = dt.Rows[0]["No_Telepon"].ToString();

                txtID.ReadOnly = true;
                txtNama.Enabled = true;
                txtAlamat.Enabled = true;
                txtNoTelp.Enabled = true;
                con.Close();
            }
            catch
            {

                MessageBox.Show
                  ("Data Tidak Ditemukan!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtAlamat.Text == "" || txtNoTelp.Text == "")
            {
                MessageBox.Show
                  ("Seluruh data wajib diisi!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring =
             "integrated security=true; data source=.; initial catalog=TokoSakura";
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand update = new SqlCommand("sp_UpdateSupplier", connection);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("Kode_Supplier", txtID.Text);
                update.Parameters.AddWithValue("Nama_Supplier", txtNama.Text);
                update.Parameters.AddWithValue("Alamat", txtAlamat.Text);
                update.Parameters.AddWithValue("No_Telepon", txtNoTelp.Text);

                try
                {
                    connection.Open();
                    update.ExecuteNonQuery();
                    MessageBox.Show("Data updated succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to saved: " + ex.Message);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtAlamat.Text == "" || txtNoTelp.Text == "")
            {
                MessageBox.Show
                  ("Seluruh data wajib diisi!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring =
             "integrated security=true; data source=.; initial catalog=TokoSakura";
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand delete = new SqlCommand("sp_DeleteSupplier", connection);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("Kode_Supplier", txtID.Text);


                try
                {
                    connection.Open();
                    delete.ExecuteNonQuery();
                    MessageBox.Show("Data deleted succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to saved: " + ex.Message);
                }
            }
        }

        private void KelolaSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokoSakuraDataSet.Supplier' table. You can move, or remove it, as needed.
            this.supplierTableAdapter.Fill(this.tokoSakuraDataSet.Supplier);

        }
    }
}
