namespace TokoSakura
{
    partial class Gudang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gudang));
            this.btnBarang = new System.Windows.Forms.Button();
            this.btnJenisBarang = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnPembelian = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBarang
            // 
            this.btnBarang.BackColor = System.Drawing.Color.MistyRose;
            this.btnBarang.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarang.ForeColor = System.Drawing.Color.IndianRed;
            this.btnBarang.Location = new System.Drawing.Point(136, 181);
            this.btnBarang.Name = "btnBarang";
            this.btnBarang.Size = new System.Drawing.Size(230, 42);
            this.btnBarang.TabIndex = 3;
            this.btnBarang.Text = "Kelola Barang";
            this.btnBarang.UseVisualStyleBackColor = false;
            // 
            // btnJenisBarang
            // 
            this.btnJenisBarang.BackColor = System.Drawing.Color.MistyRose;
            this.btnJenisBarang.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJenisBarang.ForeColor = System.Drawing.Color.IndianRed;
            this.btnJenisBarang.Location = new System.Drawing.Point(136, 263);
            this.btnJenisBarang.Name = "btnJenisBarang";
            this.btnJenisBarang.Size = new System.Drawing.Size(230, 42);
            this.btnJenisBarang.TabIndex = 4;
            this.btnJenisBarang.Text = "Kelola Jenis Barang";
            this.btnJenisBarang.UseVisualStyleBackColor = false;
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.Color.MistyRose;
            this.btnSupplier.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.ForeColor = System.Drawing.Color.IndianRed;
            this.btnSupplier.Location = new System.Drawing.Point(423, 263);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(230, 42);
            this.btnSupplier.TabIndex = 5;
            this.btnSupplier.Text = "Kelola Supplier";
            this.btnSupplier.UseVisualStyleBackColor = false;
            // 
            // btnPembelian
            // 
            this.btnPembelian.BackColor = System.Drawing.Color.MistyRose;
            this.btnPembelian.Font = new System.Drawing.Font("Cooper Black", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPembelian.ForeColor = System.Drawing.Color.IndianRed;
            this.btnPembelian.Location = new System.Drawing.Point(423, 181);
            this.btnPembelian.Name = "btnPembelian";
            this.btnPembelian.Size = new System.Drawing.Size(230, 42);
            this.btnPembelian.TabIndex = 6;
            this.btnPembelian.Text = "Pembelian Barang";
            this.btnPembelian.UseVisualStyleBackColor = false;
            // 
            // Gudang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPembelian);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnJenisBarang);
            this.Controls.Add(this.btnBarang);
            this.DoubleBuffered = true;
            this.Name = "Gudang";
            this.Text = "Staff Gudang";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBarang;
        private System.Windows.Forms.Button btnJenisBarang;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnPembelian;
    }
}