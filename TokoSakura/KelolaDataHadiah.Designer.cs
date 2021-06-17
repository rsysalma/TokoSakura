namespace TokoSakura
{
    partial class KelolaDataHadiah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelolaDataHadiah));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.kodeHadiahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.poinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hadiahBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tokoSakuraDataSet1 = new TokoSakura.TokoSakuraDataSet1();
            this.hadiahBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tokoSakuraDataSet = new TokoSakura.TokoSakuraDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPoin = new System.Windows.Forms.TextBox();
            this.epWarning = new System.Windows.Forms.ErrorProvider(this.components);
            this.epWrong = new System.Windows.Forms.ErrorProvider(this.components);
            this.hadiahTableAdapter = new TokoSakura.TokoSakuraDataSetTableAdapters.HadiahTableAdapter();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnUbah = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnCari = new System.Windows.Forms.Button();
            this.hadiahTableAdapter1 = new TokoSakura.TokoSakuraDataSet1TableAdapters.HadiahTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.hadiahBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hadiahBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hadiahBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSakuraDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hadiahBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSakuraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hadiahBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hadiahBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kodeHadiahDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.jumlahDataGridViewTextBoxColumn,
            this.poinDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.hadiahBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(43, 131);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(450, 317);
            this.dataGridView1.TabIndex = 2;
            // 
            // kodeHadiahDataGridViewTextBoxColumn
            // 
            this.kodeHadiahDataGridViewTextBoxColumn.DataPropertyName = "Kode_Hadiah";
            this.kodeHadiahDataGridViewTextBoxColumn.HeaderText = "Kode Hadiah";
            this.kodeHadiahDataGridViewTextBoxColumn.Name = "kodeHadiahDataGridViewTextBoxColumn";
            this.kodeHadiahDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "Nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            this.namaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jumlahDataGridViewTextBoxColumn
            // 
            this.jumlahDataGridViewTextBoxColumn.DataPropertyName = "Jumlah";
            this.jumlahDataGridViewTextBoxColumn.HeaderText = "Jumlah";
            this.jumlahDataGridViewTextBoxColumn.Name = "jumlahDataGridViewTextBoxColumn";
            this.jumlahDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // poinDataGridViewTextBoxColumn
            // 
            this.poinDataGridViewTextBoxColumn.DataPropertyName = "Poin";
            this.poinDataGridViewTextBoxColumn.HeaderText = "Poin";
            this.poinDataGridViewTextBoxColumn.Name = "poinDataGridViewTextBoxColumn";
            this.poinDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hadiahBindingSource1
            // 
            this.hadiahBindingSource1.DataMember = "Hadiah";
            this.hadiahBindingSource1.DataSource = this.tokoSakuraDataSet1;
            // 
            // tokoSakuraDataSet1
            // 
            this.tokoSakuraDataSet1.DataSetName = "TokoSakuraDataSet1";
            this.tokoSakuraDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hadiahBindingSource
            // 
            this.hadiahBindingSource.DataMember = "Hadiah";
            this.hadiahBindingSource.DataSource = this.tokoSakuraDataSet;
            // 
            // tokoSakuraDataSet
            // 
            this.tokoSakuraDataSet.DataSetName = "TokoSakuraDataSet";
            this.tokoSakuraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(568, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 29;
            this.label3.Text = "Nama";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(568, 236);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "Jumlah";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(568, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID Hadiah";
            // 
            // txtNama
            // 
            this.txtNama.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNama.Location = new System.Drawing.Point(780, 182);
            this.txtNama.Margin = new System.Windows.Forms.Padding(4);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(249, 30);
            this.txtNama.TabIndex = 26;
            this.txtNama.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNama_KeyPress);
            this.txtNama.Leave += new System.EventHandler(this.txtNama_Leave);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(780, 131);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(191, 30);
            this.txtID.TabIndex = 25;
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // txtJumlah
            // 
            this.txtJumlah.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJumlah.Location = new System.Drawing.Point(780, 233);
            this.txtJumlah.Margin = new System.Windows.Forms.Padding(4);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(249, 30);
            this.txtJumlah.TabIndex = 31;
            this.txtJumlah.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtJumlah_KeyPress);
            this.txtJumlah.Leave += new System.EventHandler(this.txtJumlah_Leave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(568, 287);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Poin";
            // 
            // txtPoin
            // 
            this.txtPoin.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoin.Location = new System.Drawing.Point(780, 284);
            this.txtPoin.Margin = new System.Windows.Forms.Padding(4);
            this.txtPoin.Name = "txtPoin";
            this.txtPoin.Size = new System.Drawing.Size(249, 30);
            this.txtPoin.TabIndex = 33;
            this.txtPoin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPoin_KeyPress);
            this.txtPoin.Leave += new System.EventHandler(this.txtPoin_Leave);
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
            // hadiahTableAdapter
            // 
            this.hadiahTableAdapter.ClearBeforeFill = true;
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.MistyRose;
            this.btnHapus.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHapus.Location = new System.Drawing.Point(919, 408);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(4);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(110, 40);
            this.btnHapus.TabIndex = 37;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click_1);
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.MistyRose;
            this.btnUbah.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUbah.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnUbah.Location = new System.Drawing.Point(802, 408);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(4);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(110, 40);
            this.btnUbah.TabIndex = 36;
            this.btnUbah.Text = "Ubah";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click_1);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.MistyRose;
            this.btnSimpan.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnSimpan.Location = new System.Drawing.Point(572, 408);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(110, 40);
            this.btnSimpan.TabIndex = 35;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click_1);
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.MistyRose;
            this.btnCari.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCari.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCari.Location = new System.Drawing.Point(687, 408);
            this.btnCari.Margin = new System.Windows.Forms.Padding(4);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(110, 40);
            this.btnCari.TabIndex = 34;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click_1);
            // 
            // hadiahTableAdapter1
            // 
            this.hadiahTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(979, 131);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 30);
            this.button1.TabIndex = 38;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hadiahBindingSource2
            // 
            this.hadiahBindingSource2.DataMember = "Hadiah";
            this.hadiahBindingSource2.DataSource = this.tokoSakuraDataSet1;
            // 
            // hadiahBindingSource3
            // 
            this.hadiahBindingSource3.DataMember = "Hadiah";
            this.hadiahBindingSource3.DataSource = this.tokoSakuraDataSet1;
            // 
            // KelolaDataHadiah
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
            this.Controls.Add(this.txtPoin);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtJumlah);
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
            this.Name = "KelolaDataHadiah";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelola Data Hadiah";
            this.Load += new System.EventHandler(this.KelolaDataHadiah_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hadiahBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSakuraDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hadiahBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tokoSakuraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epWrong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hadiahBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hadiahBindingSource3)).EndInit();
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
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPoin;
        private System.Windows.Forms.ErrorProvider epWarning;
        private System.Windows.Forms.ErrorProvider epWrong;
        private TokoSakuraDataSet tokoSakuraDataSet;
        private System.Windows.Forms.BindingSource hadiahBindingSource;
        private TokoSakuraDataSetTableAdapters.HadiahTableAdapter hadiahTableAdapter;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnCari;
        private TokoSakuraDataSet1 tokoSakuraDataSet1;
        private System.Windows.Forms.BindingSource hadiahBindingSource1;
        private TokoSakuraDataSet1TableAdapters.HadiahTableAdapter hadiahTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kodeHadiahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn poinDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource hadiahBindingSource2;
        private System.Windows.Forms.BindingSource hadiahBindingSource3;
    }
}