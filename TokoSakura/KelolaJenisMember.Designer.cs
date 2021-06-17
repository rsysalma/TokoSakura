namespace TokoSakura
{
    partial class KelolaJenisMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelolaJenisMember));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodeGolonganMemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaGolonganMemberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.golonganMemberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tokoSakuraDataSet1 = new TokoSakura.TokoSakuraDataSet1();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.tokoSakuraDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.golonganMemberTableAdapter = new TokoSakura.TokoSakuraDataSet1TableAdapters.GolonganMemberTableAdapter();
            this.txtPoin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.golonganMemberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSakuraDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSakuraDataSet1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeGolonganMemberDataGridViewTextBoxColumn,
            this.namaGolonganMemberDataGridViewTextBoxColumn,
            this.hargaDataGridViewTextBoxColumn,
            this.poinDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.golonganMemberBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(45, 129);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(465, 325);
            this.dataGridView1.TabIndex = 2;
            // 
            // kodeGolonganMemberDataGridViewTextBoxColumn
            // 
            this.kodeGolonganMemberDataGridViewTextBoxColumn.DataPropertyName = "Kode_Golongan_Member";
            this.kodeGolonganMemberDataGridViewTextBoxColumn.HeaderText = "Kode Golongan Member";
            this.kodeGolonganMemberDataGridViewTextBoxColumn.Name = "kodeGolonganMemberDataGridViewTextBoxColumn";
            this.kodeGolonganMemberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaGolonganMemberDataGridViewTextBoxColumn
            // 
            this.namaGolonganMemberDataGridViewTextBoxColumn.DataPropertyName = "Nama_Golongan_Member";
            this.namaGolonganMemberDataGridViewTextBoxColumn.HeaderText = "Nama Golongan Member";
            this.namaGolonganMemberDataGridViewTextBoxColumn.Name = "namaGolonganMemberDataGridViewTextBoxColumn";
            this.namaGolonganMemberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hargaDataGridViewTextBoxColumn
            // 
            this.hargaDataGridViewTextBoxColumn.DataPropertyName = "Harga";
            this.hargaDataGridViewTextBoxColumn.HeaderText = "Harga";
            this.hargaDataGridViewTextBoxColumn.Name = "hargaDataGridViewTextBoxColumn";
            this.hargaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poinDataGridViewTextBoxColumn
            // 
            this.poinDataGridViewTextBoxColumn.DataPropertyName = "Poin";
            this.poinDataGridViewTextBoxColumn.HeaderText = "Poin";
            this.poinDataGridViewTextBoxColumn.Name = "poinDataGridViewTextBoxColumn";
            this.poinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // golonganMemberBindingSource
            // 
            this.golonganMemberBindingSource.DataMember = "GolonganMember";
            this.golonganMemberBindingSource.DataSource = this.tokoSakuraDataSet1;
            // 
            // tokoSakuraDataSet1
            // 
            this.tokoSakuraDataSet1.DataSetName = "TokoSakuraDataSet1";
            this.tokoSakuraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(569, 195);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(569, 248);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Harga";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(569, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID Jenis Member";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(779, 192);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(249, 30);
            this.txtNama.TabIndex = 26;
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(779, 142);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(191, 30);
            this.txtID.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(569, 294);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 31;
            this.label4.Text = "Poin";
            // 
            // txtHarga
            // 
            this.txtHarga.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHarga.Location = new System.Drawing.Point(779, 245);
            this.txtHarga.Margin = new System.Windows.Forms.Padding(4);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(249, 30);
            this.txtHarga.TabIndex = 32;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(978, 142);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 30);
            this.button1.TabIndex = 33;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.MistyRose;
            this.btnHapus.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHapus.Location = new System.Drawing.Point(918, 414);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(110, 40);
            this.btnHapus.TabIndex = 37;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.MistyRose;
            this.btnUbah.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUbah.Location = new System.Drawing.Point(803, 414);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(110, 40);
            this.btnUbah.TabIndex = 36;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.MistyRose;
            this.btnSimpan.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSimpan.Location = new System.Drawing.Point(573, 414);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(110, 40);
            this.btnSimpan.TabIndex = 35;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.MistyRose;
            this.btnCari.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCari.Location = new System.Drawing.Point(688, 414);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(110, 40);
            this.btnCari.TabIndex = 34;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // tokoSakuraDataSet1BindingSource
            // 
            this.tokoSakuraDataSet1BindingSource.DataSource = this.tokoSakuraDataSet1;
            this.tokoSakuraDataSet1BindingSource.Position = 0;
            // 
            // golonganMemberTableAdapter
            // 
            this.golonganMemberTableAdapter.ClearBeforeFill = true;
            // 
            // txtPoin
            // 
            this.txtPoin.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoin.Location = new System.Drawing.Point(779, 289);
            this.txtPoin.Margin = new System.Windows.Forms.Padding(4);
            this.txtPoin.Name = "txtPoin";
            this.txtPoin.Size = new System.Drawing.Size(249, 30);
            this.txtPoin.TabIndex = 38;
            // 
            // KelolaJenisMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 553);
            this.Controls.Add(this.txtPoin);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.btnUbah);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtHarga);
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
            this.Name = "KelolaJenisMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelola Jenis Member";
            this.Load += new System.EventHandler(this.KelolaJenisMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.golonganMemberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSakuraDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSakuraDataSet1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.BindingSource tokoSakuraDataSet1BindingSource;
        private TokoSakuraDataSet1 tokoSakuraDataSet1;
        private System.Windows.Forms.BindingSource golonganMemberBindingSource;
        private TokoSakuraDataSet1TableAdapters.GolonganMemberTableAdapter golonganMemberTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeGolonganMemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaGolonganMemberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poinDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtPoin;
    }
}