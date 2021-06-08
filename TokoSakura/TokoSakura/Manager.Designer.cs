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
            this.SuspendLayout();
            // 
            // btnLaporanPenjualan
            // 
            this.btnLaporanPenjualan.BackColor = System.Drawing.Color.MistyRose;
            this.btnLaporanPenjualan.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporanPenjualan.ForeColor = System.Drawing.Color.IndianRed;
            this.btnLaporanPenjualan.Location = new System.Drawing.Point(98, 166);
            this.btnLaporanPenjualan.Name = "btnLaporanPenjualan";
            this.btnLaporanPenjualan.Size = new System.Drawing.Size(249, 42);
            this.btnLaporanPenjualan.TabIndex = 3;
            this.btnLaporanPenjualan.Text = "Laporan Penjualan";
            this.btnLaporanPenjualan.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.IndianRed;
            this.button1.Location = new System.Drawing.Point(416, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 42);
            this.button1.TabIndex = 4;
            this.button1.Text = "Laporan Pembelian";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnKaryawan
            // 
            this.btnKaryawan.BackColor = System.Drawing.Color.MistyRose;
            this.btnKaryawan.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaryawan.ForeColor = System.Drawing.Color.IndianRed;
            this.btnKaryawan.Location = new System.Drawing.Point(98, 227);
            this.btnKaryawan.Name = "btnKaryawan";
            this.btnKaryawan.Size = new System.Drawing.Size(249, 42);
            this.btnKaryawan.TabIndex = 5;
            this.btnKaryawan.Text = "Kelola Karyawan";
            this.btnKaryawan.UseVisualStyleBackColor = false;
            // 
            // btnGolKaryawan
            // 
            this.btnGolKaryawan.BackColor = System.Drawing.Color.MistyRose;
            this.btnGolKaryawan.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGolKaryawan.ForeColor = System.Drawing.Color.IndianRed;
            this.btnGolKaryawan.Location = new System.Drawing.Point(98, 292);
            this.btnGolKaryawan.Name = "btnGolKaryawan";
            this.btnGolKaryawan.Size = new System.Drawing.Size(249, 42);
            this.btnGolKaryawan.TabIndex = 6;
            this.btnGolKaryawan.Text = "Kelola Gol Karyawan";
            this.btnGolKaryawan.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.IndianRed;
            this.button2.Location = new System.Drawing.Point(416, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 42);
            this.button2.TabIndex = 7;
            this.button2.Text = "Laporan Barang Kosong";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.IndianRed;
            this.button3.Location = new System.Drawing.Point(416, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(272, 42);
            this.button3.TabIndex = 8;
            this.button3.Text = "Laporan Laba Bersih";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGolKaryawan);
            this.Controls.Add(this.btnKaryawan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnLaporanPenjualan);
            this.DoubleBuffered = true;
            this.Name = "Manager";
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
    }
}