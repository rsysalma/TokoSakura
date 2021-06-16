namespace TokoSakura
{
    partial class KelolaKaryawan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelolaKaryawan));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtAlamat = new System.Windows.Forms.TextBox();
            this.txtNoTelp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tokoSakuraDataSet1 = new TokoSakura.TokoSakuraDataSet1();
            this.karyawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.karyawanTableAdapter = new TokoSakura.TokoSakuraDataSet1TableAdapters.KaryawanTableAdapter();
            this.kodeKaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kodeGolonganKaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaKaryawanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggalLahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noTeleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.golonganKaryawanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.golonganKaryawanTableAdapter = new TokoSakura.TokoSakuraDataSet1TableAdapters.GolonganKaryawanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSakuraDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.golonganKaryawanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeKaryawanDataGridViewTextBoxColumn,
            this.kodeGolonganKaryawanDataGridViewTextBoxColumn,
            this.namaKaryawanDataGridViewTextBoxColumn,
            this.tanggalLahirDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.noTeleponDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.karyawanBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(42, 137);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(465, 319);
            this.dataGridView1.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(575, 244);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 39;
            this.label4.Text = "Alamat";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(575, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 37;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(575, 212);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tgl Lahir";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(575, 147);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "ID Karyawan";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(782, 177);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(249, 30);
            this.txtNama.TabIndex = 34;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(782, 144);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(191, 30);
            this.txtID.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(782, 210);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(249, 30);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // txtAlamat
            // 
            this.txtAlamat.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlamat.Location = new System.Drawing.Point(782, 243);
            this.txtAlamat.Margin = new System.Windows.Forms.Padding(4);
            this.txtAlamat.Name = "txtAlamat";
            this.txtAlamat.Size = new System.Drawing.Size(249, 30);
            this.txtAlamat.TabIndex = 41;
            // 
            // txtNoTelp
            // 
            this.txtNoTelp.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoTelp.Location = new System.Drawing.Point(782, 276);
            this.txtNoTelp.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.Size = new System.Drawing.Size(249, 30);
            this.txtNoTelp.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(575, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "No Telp";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(575, 315);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "Golongan";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.golonganKaryawanBindingSource;
            this.comboBox1.DisplayMember = "Nama_Golongan_Karyawan";
            this.comboBox1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(782, 309);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(249, 31);
            this.comboBox1.TabIndex = 45;
            this.comboBox1.ValueMember = "Kode_Golongan_Karyawan";
            // 
            // tokoSakuraDataSet1
            // 
            this.tokoSakuraDataSet1.DataSetName = "TokoSakuraDataSet1";
            this.tokoSakuraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // karyawanBindingSource
            // 
            this.karyawanBindingSource.DataMember = "Karyawan";
            this.karyawanBindingSource.DataSource = this.tokoSakuraDataSet1;
            // 
            // karyawanTableAdapter
            // 
            this.karyawanTableAdapter.ClearBeforeFill = true;
            // 
            // kodeKaryawanDataGridViewTextBoxColumn
            // 
            this.kodeKaryawanDataGridViewTextBoxColumn.DataPropertyName = "Kode_Karyawan";
            this.kodeKaryawanDataGridViewTextBoxColumn.HeaderText = "Kode Karyawan";
            this.kodeKaryawanDataGridViewTextBoxColumn.Name = "kodeKaryawanDataGridViewTextBoxColumn";
            this.kodeKaryawanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kodeGolonganKaryawanDataGridViewTextBoxColumn
            // 
            this.kodeGolonganKaryawanDataGridViewTextBoxColumn.DataPropertyName = "Kode_Golongan_Karyawan";
            this.kodeGolonganKaryawanDataGridViewTextBoxColumn.HeaderText = "Kode Golongan Karyawan";
            this.kodeGolonganKaryawanDataGridViewTextBoxColumn.Name = "kodeGolonganKaryawanDataGridViewTextBoxColumn";
            this.kodeGolonganKaryawanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaKaryawanDataGridViewTextBoxColumn
            // 
            this.namaKaryawanDataGridViewTextBoxColumn.DataPropertyName = "Nama_Karyawan";
            this.namaKaryawanDataGridViewTextBoxColumn.HeaderText = "Nama Karyawan";
            this.namaKaryawanDataGridViewTextBoxColumn.Name = "namaKaryawanDataGridViewTextBoxColumn";
            this.namaKaryawanDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tanggalLahirDataGridViewTextBoxColumn
            // 
            this.tanggalLahirDataGridViewTextBoxColumn.DataPropertyName = "Tanggal_Lahir";
            this.tanggalLahirDataGridViewTextBoxColumn.HeaderText = "Tanggal Lahir";
            this.tanggalLahirDataGridViewTextBoxColumn.Name = "tanggalLahirDataGridViewTextBoxColumn";
            this.tanggalLahirDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "Alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noTeleponDataGridViewTextBoxColumn
            // 
            this.noTeleponDataGridViewTextBoxColumn.DataPropertyName = "No_Telepon";
            this.noTeleponDataGridViewTextBoxColumn.HeaderText = "No Telepon";
            this.noTeleponDataGridViewTextBoxColumn.Name = "noTeleponDataGridViewTextBoxColumn";
            this.noTeleponDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.MistyRose;
            this.btnHapus.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHapus.Location = new System.Drawing.Point(921, 416);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(110, 40);
            this.btnHapus.TabIndex = 49;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.MistyRose;
            this.btnUbah.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUbah.Location = new System.Drawing.Point(806, 416);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(110, 40);
            this.btnUbah.TabIndex = 48;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.MistyRose;
            this.btnSimpan.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSimpan.Location = new System.Drawing.Point(576, 416);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(110, 40);
            this.btnSimpan.TabIndex = 47;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.MistyRose;
            this.btnCari.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCari.Location = new System.Drawing.Point(691, 416);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(110, 40);
            this.btnCari.TabIndex = 46;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(981, 144);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 30);
            this.button1.TabIndex = 50;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // golonganKaryawanBindingSource
            // 
            this.golonganKaryawanBindingSource.DataMember = "GolonganKaryawan";
            this.golonganKaryawanBindingSource.DataSource = this.tokoSakuraDataSet1;
            // 
            // golonganKaryawanTableAdapter
            // 
            this.golonganKaryawanTableAdapter.ClearBeforeFill = true;
            // 
            // KelolaKaryawan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNoTelp);
            this.Controls.Add(this.txtAlamat);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.dataGridView1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KelolaKaryawan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelola Karyawan";
            this.Load += new System.EventHandler(this.KelolaKaryawan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSakuraDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.karyawanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.golonganKaryawanBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtAlamat;
        private System.Windows.Forms.TextBox txtNoTelp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private TokoSakuraDataSet1 tokoSakuraDataSet1;
        private System.Windows.Forms.BindingSource karyawanBindingSource;
        private TokoSakuraDataSet1TableAdapters.KaryawanTableAdapter karyawanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeKaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeGolonganKaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaKaryawanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggalLahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noTeleponDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource golonganKaryawanBindingSource;
        private TokoSakuraDataSet1TableAdapters.GolonganKaryawanTableAdapter golonganKaryawanTableAdapter;
    }
}