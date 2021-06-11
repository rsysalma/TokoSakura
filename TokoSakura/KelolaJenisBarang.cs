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
        public KelolaJenisBarang()
        {
            InitializeComponent();
            string query = "SELECT TOP 1 Kode_Jenis_Barang FROM JenisBarang ORDER BY Kode_Jenis_Barang DESC";

            txtID.Text = autogenerateID("JBG", query);
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
            

            string query = "SELECT TOP 1 Kode_Jenis_Barang FROM JenisBarang ORDER BY Kode_Jenis_Barang DESC";

            txtID.Text = autogenerateID("JBG", query);
            txtID.Enabled = false;
        }

        private void KelolaJenisBarang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tokoSakuraDataSet.JenisBarang' table. You can move, or remove it, as needed.
            this.jenisBarangTableAdapter.Fill(this.tokoSakuraDataSet.JenisBarang);

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
                  ("Seluruh data wajib diisi!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring =
             "integrated security=true; data source=.; initial catalog=TokoSakura";
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
                cmd.CommandText = "sp_CariJenisBarang";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Kode_Jenis_Barang", txtID.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                txtNama.Text = dt.Rows[0]["Nama_Jenis_Barang"].ToString();
                cbDetail.Text = dt.Rows[0]["Detail_Jenis_Barang"].ToString();

                txtID.ReadOnly = true;
                txtNama.Enabled = true;

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
            if (txtID.Text == "" || txtNama.Text == "" || cbDetail.Text == "")
            {
                MessageBox.Show
                  ("Seluruh data wajib diisi!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring =
             "integrated security=true; data source=.; initial catalog=TokoSakura";
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
            if (txtID.Text == "" || txtNama.Text == "" || cbDetail.Text == "")
            {
                MessageBox.Show
                  ("Seluruh data wajib diisi!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string connectionstring =
               "integrated security=true; data source=.; initial catalog=TokoSakura";
                SqlConnection connection = new SqlConnection(connectionstring);

                SqlCommand delete = new SqlCommand("sp_DeleteJenisBarang", connection);
                delete.CommandType = CommandType.StoredProcedure;
                delete.Parameters.AddWithValue("Kode_Jenis_Barang", txtID.Text);


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
    }
}
