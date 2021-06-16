namespace TokoSakura
{
    partial class KelolaJenisBarang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelolaJenisBarang));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodeJenisBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaJenisBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detailJenisBarangDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenisBarangBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tokoSakuraDataSet1 = new TokoSakura.TokoSakuraDataSet1();
            this.jenisBarangBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tokoSakuraDataSet = new TokoSakura.TokoSakuraDataSet();
            this.jenisBarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.cbDetail = new System.Windows.Forms.ComboBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.jenisBarangTableAdapter = new TokoSakura.TokoSakuraDataSetTableAdapters.JenisBarangTableAdapter();
            this.jenisBarangTableAdapter1 = new TokoSakura.TokoSakuraDataSet1TableAdapters.JenisBarangTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisBarangBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSakuraDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisBarangBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSakuraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisBarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeJenisBarangDataGridViewTextBoxColumn,
            this.namaJenisBarangDataGridViewTextBoxColumn,
            this.detailJenisBarangDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.jenisBarangBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(42, 126);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(447, 329);
            this.dataGridView1.TabIndex = 1;
            // 
            // kodeJenisBarangDataGridViewTextBoxColumn
            // 
            this.kodeJenisBarangDataGridViewTextBoxColumn.DataPropertyName = "Kode_Jenis_Barang";
            this.kodeJenisBarangDataGridViewTextBoxColumn.HeaderText = "Kode Jenis Barang";
            this.kodeJenisBarangDataGridViewTextBoxColumn.Name = "kodeJenisBarangDataGridViewTextBoxColumn";
            this.kodeJenisBarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaJenisBarangDataGridViewTextBoxColumn
            // 
            this.namaJenisBarangDataGridViewTextBoxColumn.DataPropertyName = "Nama_Jenis_Barang";
            this.namaJenisBarangDataGridViewTextBoxColumn.HeaderText = "Nama Jenis Barang";
            this.namaJenisBarangDataGridViewTextBoxColumn.Name = "namaJenisBarangDataGridViewTextBoxColumn";
            this.namaJenisBarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detailJenisBarangDataGridViewTextBoxColumn
            // 
            this.detailJenisBarangDataGridViewTextBoxColumn.DataPropertyName = "Detail_Jenis_Barang";
            this.detailJenisBarangDataGridViewTextBoxColumn.HeaderText = "Detail Jenis Barang";
            this.detailJenisBarangDataGridViewTextBoxColumn.Name = "detailJenisBarangDataGridViewTextBoxColumn";
            this.detailJenisBarangDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jenisBarangBindingSource2
            // 
            this.jenisBarangBindingSource2.DataMember = "JenisBarang";
            this.jenisBarangBindingSource2.DataSource = this.tokoSakuraDataSet1;
            // 
            // tokoSakuraDataSet1
            // 
            this.tokoSakuraDataSet1.DataSetName = "TokoSakuraDataSet1";
            this.tokoSakuraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jenisBarangBindingSource1
            // 
            this.jenisBarangBindingSource1.DataMember = "JenisBarang";
            this.jenisBarangBindingSource1.DataSource = this.tokoSakuraDataSet;
            // 
            // tokoSakuraDataSet
            // 
            this.tokoSakuraDataSet.DataSetName = "TokoSakuraDataSet";
            this.tokoSakuraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jenisBarangBindingSource
            // 
            this.jenisBarangBindingSource.DataMember = "JenisBarang";
            this.jenisBarangBindingSource.DataSource = this.tokoSakuraDataSet;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.MistyRose;
            this.btnHapus.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHapus.Location = new System.Drawing.Point(919, 415);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(110, 40);
            this.btnHapus.TabIndex = 10;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.MistyRose;
            this.btnUbah.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUbah.Location = new System.Drawing.Point(804, 415);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(110, 40);
            this.btnUbah.TabIndex = 9;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.MistyRose;
            this.btnSimpan.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSimpan.Location = new System.Drawing.Point(574, 415);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(110, 40);
            this.btnSimpan.TabIndex = 8;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.MistyRose;
            this.btnCari.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCari.Location = new System.Drawing.Point(689, 415);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(110, 40);
            this.btnCari.TabIndex = 7;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(568, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 25);
            this.label3.TabIndex = 18;
            this.label3.Text = "Nama Jenis Barang";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(568, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(211, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Detail Jenis Barang";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(570, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID Jenis Barang";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(780, 197);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(249, 30);
            this.txtNama.TabIndex = 14;
            this.txtNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNama_KeyPress);
            this.txtNama.Leave += new System.EventHandler(this.txtNama_Leave);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(780, 143);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(191, 30);
            this.txtID.TabIndex = 13;
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // cbDetail
            // 
            this.cbDetail.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDetail.FormattingEnabled = true;
            this.cbDetail.Items.AddRange(new object[] {
            "Skincare",
            "Makeup",
            "Alat Makeup"});
            this.cbDetail.Location = new System.Drawing.Point(780, 251);
            this.cbDetail.Margin = new System.Windows.Forms.Padding(4);
            this.cbDetail.Name = "cbDetail";
            this.cbDetail.Size = new System.Drawing.Size(249, 31);
            this.cbDetail.TabIndex = 20;
            this.cbDetail.Leave += new System.EventHandler(this.cbDetail_Leave);
            // 
            // epWarning
            // 
            this.epWarning.ContainerControl = this;
            this.epWarning.Icon = ((System.Drawing.Icon)(resources.GetObject("epWarning.Icon")));
            // 
            // epWrong
            // 
            this.epWrong.ContainerControl = this;
            this.epWrong.Icon = ((System.Drawing.Icon)(resources.GetObject("epWrong.Icon")));
            // 
            // jenisBarangTableAdapter
            // 
            this.jenisBarangTableAdapter.ClearBeforeFill = true;
            // 
            // jenisBarangTableAdapter1
            // 
            this.jenisBarangTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(979, 144);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 30);
            this.button1.TabIndex = 21;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KelolaJenisBarang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbDetail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KelolaJenisBarang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelola Jenis Barang";
            this.Load += new System.EventHandler(this.KelolaJenisBarang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisBarangBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSakuraDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisBarangBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSakuraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jenisBarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ComboBox cbDetail;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private TokoSakuraDataSet tokoSakuraDataSet;
        private System.Windows.Forms.BindingSource jenisBarangBindingSource;
        private TokoSakuraDataSetTableAdapters.JenisBarangTableAdapter jenisBarangTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeJenisBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaJenisBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detailJenisBarangDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource jenisBarangBindingSource1;
        private TokoSakuraDataSet1 tokoSakuraDataSet1;
        private System.Windows.Forms.BindingSource jenisBarangBindingSource2;
        private TokoSakuraDataSet1TableAdapters.JenisBarangTableAdapter jenisBarangTableAdapter1;
        private System.Windows.Forms.Button button1;
    }
}