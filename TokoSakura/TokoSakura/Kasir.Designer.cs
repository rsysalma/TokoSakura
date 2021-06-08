namespace TokoSakura
{
    partial class Kasir
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kasir));
            this.btnMember = new System.Windows.Forms.Button();
            this.btnGolMember = new System.Windows.Forms.Button();
            this.btnDataHadiah = new System.Windows.Forms.Button();
            this.btnPenjualan = new System.Windows.Forms.Button();
            this.btnBuatMember = new System.Windows.Forms.Button();
            this.btnTukarHadiah = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMember
            // 
            this.btnMember.BackColor = System.Drawing.Color.MistyRose;
            this.btnMember.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMember.ForeColor = System.Drawing.Color.IndianRed;
            this.btnMember.Location = new System.Drawing.Point(124, 173);
            this.btnMember.Name = "btnMember";
            this.btnMember.Size = new System.Drawing.Size(221, 42);
            this.btnMember.TabIndex = 2;
            this.btnMember.Text = "Kelola Member";
            this.btnMember.UseVisualStyleBackColor = false;
            // 
            // btnGolMember
            // 
            this.btnGolMember.BackColor = System.Drawing.Color.MistyRose;
            this.btnGolMember.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGolMember.ForeColor = System.Drawing.Color.IndianRed;
            this.btnGolMember.Location = new System.Drawing.Point(124, 234);
            this.btnGolMember.Name = "btnGolMember";
            this.btnGolMember.Size = new System.Drawing.Size(221, 44);
            this.btnGolMember.TabIndex = 3;
            this.btnGolMember.Text = "Kelola Gol Member";
            this.btnGolMember.UseVisualStyleBackColor = false;
            // 
            // btnDataHadiah
            // 
            this.btnDataHadiah.BackColor = System.Drawing.Color.MistyRose;
            this.btnDataHadiah.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataHadiah.ForeColor = System.Drawing.Color.IndianRed;
            this.btnDataHadiah.Location = new System.Drawing.Point(124, 299);
            this.btnDataHadiah.Name = "btnDataHadiah";
            this.btnDataHadiah.Size = new System.Drawing.Size(221, 44);
            this.btnDataHadiah.TabIndex = 4;
            this.btnDataHadiah.Text = "Kelola Hadiah";
            this.btnDataHadiah.UseVisualStyleBackColor = false;
            // 
            // btnPenjualan
            // 
            this.btnPenjualan.BackColor = System.Drawing.Color.MistyRose;
            this.btnPenjualan.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPenjualan.ForeColor = System.Drawing.Color.IndianRed;
            this.btnPenjualan.Location = new System.Drawing.Point(421, 173);
            this.btnPenjualan.Name = "btnPenjualan";
            this.btnPenjualan.Size = new System.Drawing.Size(221, 42);
            this.btnPenjualan.TabIndex = 5;
            this.btnPenjualan.Text = "Penjualan Barang";
            this.btnPenjualan.UseVisualStyleBackColor = false;
            // 
            // btnBuatMember
            // 
            this.btnBuatMember.BackColor = System.Drawing.Color.MistyRose;
            this.btnBuatMember.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuatMember.ForeColor = System.Drawing.Color.IndianRed;
            this.btnBuatMember.Location = new System.Drawing.Point(421, 236);
            this.btnBuatMember.Name = "btnBuatMember";
            this.btnBuatMember.Size = new System.Drawing.Size(221, 42);
            this.btnBuatMember.TabIndex = 6;
            this.btnBuatMember.Text = "Buat Member";
            this.btnBuatMember.UseVisualStyleBackColor = false;
            // 
            // btnTukarHadiah
            // 
            this.btnTukarHadiah.BackColor = System.Drawing.Color.MistyRose;
            this.btnTukarHadiah.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTukarHadiah.ForeColor = System.Drawing.Color.IndianRed;
            this.btnTukarHadiah.Location = new System.Drawing.Point(421, 299);
            this.btnTukarHadiah.Name = "btnTukarHadiah";
            this.btnTukarHadiah.Size = new System.Drawing.Size(221, 42);
            this.btnTukarHadiah.TabIndex = 7;
            this.btnTukarHadiah.Text = "Tukar Hadiah";
            this.btnTukarHadiah.UseVisualStyleBackColor = false;
            // 
            // Kasir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTukarHadiah);
            this.Controls.Add(this.btnBuatMember);
            this.Controls.Add(this.btnPenjualan);
            this.Controls.Add(this.btnDataHadiah);
            this.Controls.Add(this.btnGolMember);
            this.Controls.Add(this.btnMember);
            this.DoubleBuffered = true;
            this.Name = "Kasir";
            this.Text = "Kasir";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMember;
        private System.Windows.Forms.Button btnGolMember;
        private System.Windows.Forms.Button btnDataHadiah;
        private System.Windows.Forms.Button btnPenjualan;
        private System.Windows.Forms.Button btnBuatMember;
        private System.Windows.Forms.Button btnTukarHadiah;
    }
}