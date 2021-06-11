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
    public partial class KelolaDataHadiah : Form
    {
        public KelolaDataHadiah()
        {
            InitializeComponent();
            string query = "SELECT TOP 1 Kode_Hadiah FROM Hadiah ORDER BY Kode_Hadiah DESC";

            txtID.Text = autogenerateID("HDH", query);
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
            txtJumlah.Clear();
            txtPoin.Clear();

            string query = "SELECT TOP 1 Kode_Hadiah FROM Hadiah ORDER BY Kode_Hadiah DESC";

            txtID.Text = autogenerateID("HDH", query);
            txtID.Enabled = false;
        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtPoin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)))
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
                epWarning.SetError(txtID, "ID Hadiah wajib diisi!");
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
                epWarning.SetError(txtNama, "Nama Hadiah wajib diisi!");
                epWrong.SetError(txtNama, "");
            }
            else
            {
                epWarning.SetError(txtNama, "");
                epWrong.SetError(txtNama, "");
            }
        }

        private void KelolaDataHadiah_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokoSakuraDataSet.Hadiah' table. You can move, or remove it, as needed.
            this.hadiahTableAdapter.Fill(this.tokoSakuraDataSet.Hadiah);

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

        private void txtPoin_Leave(object sender, EventArgs e)
        {
            if (txtPoin.Text == "")
            {
                epWarning.SetError(txtPoin, "Poin wajib diisi!");
                epWrong.SetError(txtPoin, "");
            }
            else
            {
                epWarning.SetError(txtPoin, "");
                epWrong.SetError(txtPoin, "");
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtJumlah.Text == "" || txtPoin.Text == "")
            {
                MessageBox.Show
                  ("Seluruh data wajib diisi!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring =
             "integrated security=true; data source=.; initial catalog=TokoSakura";
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand insert = new SqlCommand("sp_InputHadiah", connection);
                insert.CommandType = CommandType.StoredProcedure;
                insert.Parameters.AddWithValue("Kode_Hadiah", txtID.Text);
                insert.Parameters.AddWithValue("Nama", txtNama.Text);
                insert.Parameters.AddWithValue("Jumlah", txtJumlah.Text);
                insert.Parameters.AddWithValue("Poin", txtPoin.Text);

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
                cmd.CommandText = "sp_CariHadiah";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Kode_Hadiah", txtID.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                txtNama.Text = dt.Rows[0]["Nama"].ToString();
                txtJumlah.Text = dt.Rows[0]["Jumlah"].ToString();
                txtPoin.Text = dt.Rows[0]["Poin"].ToString();

                txtID.ReadOnly = true;
                txtNama.Enabled = true;
                txtJumlah.Enabled = true;
                txtPoin.Enabled = true;
                con.Close();
            }
            catch
            {

                MessageBox.Show
                  ("Data Tidak Ditemukan!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            clear();
            txtID.Enabled = true;
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtJumlah.Text == "" || txtPoin.Text == "")
            {
                MessageBox.Show
                  ("Seluruh data wajib diisi!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring =
             "integrated security=true; data source=.; initial catalog=TokoSakura";
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand update = new SqlCommand("sp_UpdateHadiah", connection);
                update.CommandType = CommandType.StoredProcedure;
                update.Parameters.AddWithValue("Kode_Hadiah", txtID.Text);
                update.Parameters.AddWithValue("Nama", txtNama.Text);
                update.Parameters.AddWithValue("Jumlah", txtJumlah.Text);
                update.Parameters.AddWithValue("Poin", txtPoin.Text);

                try
                {
                    connection.Open();
                    update.ExecuteNonQuery();
                    MessageBox.Show("Data updated succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to updated: " + ex.Message);
                }
            }
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtNama.Text == "" || txtJumlah.Text == "" || txtPoin.Text == "")
            {
                MessageBox.Show
                  ("Seluruh data wajib diisi!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring =
             "integrated security=true; data source=.; initial catalog=TokoSakura";
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand delete = new SqlCommand("sp_DeleteHadiah", connection);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("Kode_Hadiah", txtID.Text);


                try
                {
                    connection.Open();
                    delete.ExecuteNonQuery();
                    MessageBox.Show("Data deleted succesfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to deleted: " + ex.Message);
                }
            }
        }
    }
}
