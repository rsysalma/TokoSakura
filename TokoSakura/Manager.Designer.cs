namespace TokoSakura
{
    partial class Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Manager));
            this.btnLaporanPenjualan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKaryawan = new System.Windows.Forms.Button();
            this.btnGolKaryawan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLaporanPenjualan
            // 
            this.btnLaporanPenjualan.BackColor = System.Drawing.Color.MistyRose;
            this.btnLaporanPenjualan.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporanPenjualan.ForeColor = System.Drawing.Color.IndianRed;
            this.btnLaporanPenjualan.Location = new System.Drawing.Point(143, 204);
            this.btnLaporanPenjualan.Margin = new System.Windows.Forms.Padding(4);
            this.btnLaporanPenjualan.Name = "btnLaporanPenjualan";
            this.btnLaporanPenjualan.Size = new System.Drawing.Size(332, 52);
            this.btnLaporanPenjualan.TabIndex = 3;
            this.btnLaporanPenjualan.Text = "Laporan Penjualan";
            this.btnLaporanPenjualan.UseVisualStyleBackColor = false;
            this.btnLaporanPenjualan.Click += new System.EventHandler(this.btnLaporanPenjualan_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(567, 204);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(363, 52);
            this.button1.TabIndex = 4;
            this.button1.Text = "Laporan Pembelian";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKaryawan
            // 
            this.btnKaryawan.BackColor = System.Drawing.Color.MistyRose;
            this.btnKaryawan.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaryawan.ForeColor = System.Drawing.Color.IndianRed;
            this.btnKaryawan.Location = new System.Drawing.Point(143, 279);
            this.btnKaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaryawan.Name = "btnKaryawan";
            this.btnKaryawan.Size = new System.Drawing.Size(332, 52);
            this.btnKaryawan.TabIndex = 5;
            this.btnKaryawan.Text = "Kelola Karyawan";
            this.btnKaryawan.UseVisualStyleBackColor = false;
            this.btnKaryawan.Click += new System.EventHandler(this.btnKaryawan_Click);
            // 
            // btnGolKaryawan
            // 
            this.btnGolKaryawan.BackColor = System.Drawing.Color.MistyRose;
            this.btnGolKaryawan.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGolKaryawan.ForeColor = System.Drawing.Color.IndianRed;
            this.btnGolKaryawan.Location = new System.Drawing.Point(143, 359);
            this.btnGolKaryawan.Margin = new System.Windows.Forms.Padding(4);
            this.btnGolKaryawan.Name = "btnGolKaryawan";
            this.btnGolKaryawan.Size = new System.Drawing.Size(332, 52);
            this.btnGolKaryawan.TabIndex = 6;
            this.btnGolKaryawan.Text = "Kelola Gol Karyawan";
            this.btnGolKaryawan.UseVisualStyleBackColor = false;
            this.btnGolKaryawan.Click += new System.EventHandler(this.btnGolKaryawan_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(567, 279);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(363, 52);
            this.button2.TabIndex = 7;
            this.button2.Text = "Laporan Barang Kosong";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.IndianRed;
            this.button3.Location = new System.Drawing.Point(567, 359);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(363, 52);
            this.button3.TabIndex = 8;
            this.button3.Text = "Laporan Laba Bersih";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.MistyRose;
            this.btnLogout.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.IndianRed;
            this.btnLogout.Location = new System.Drawing.Point(361, 476);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(307, 52);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "LOGOUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1072, 553);
            this.ControlBox = false;
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGolKaryawan);
            this.Controls.Add(this.btnKaryawan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLaporanPenjualan);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLaporanPenjualan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKaryawan;
        private System.Windows.Forms.Button btnGolKaryawan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnLogout;
    }
}