namespace POS_Kasir_Supermarket
{
    partial class transaksi
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
            this.btnTambah = new System.Windows.Forms.Button();
            this.txtKodeProduct = new System.Windows.Forms.TextBox();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.dgvKeranjang = new System.Windows.Forms.DataGridView();
            this.lblTotalBayar = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.TextBox();
            this.lblDiskon = new System.Windows.Forms.TextBox();
            this.txtUangBayar = new System.Windows.Forms.TextBox();
            this.lblKembalian = new System.Windows.Forms.Label();
            this.txt_hargaproduct = new System.Windows.Forms.TextBox();
            this.txt_namaproduk = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(36, 122);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(113, 23);
            this.btnTambah.TabIndex = 0;
            this.btnTambah.Text = "masukan";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // txtKodeProduct
            // 
            this.txtKodeProduct.Location = new System.Drawing.Point(7, 37);
            this.txtKodeProduct.Name = "txtKodeProduct";
            this.txtKodeProduct.Size = new System.Drawing.Size(169, 22);
            this.txtKodeProduct.TabIndex = 1;
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(5, 82);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(169, 22);
            this.txtJumlah.TabIndex = 2;
            // 
            // dgvKeranjang
            // 
            this.dgvKeranjang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKeranjang.Location = new System.Drawing.Point(200, 36);
            this.dgvKeranjang.Name = "dgvKeranjang";
            this.dgvKeranjang.RowHeadersWidth = 51;
            this.dgvKeranjang.RowTemplate.Height = 24;
            this.dgvKeranjang.Size = new System.Drawing.Size(479, 241);
            this.dgvKeranjang.TabIndex = 3;
            this.dgvKeranjang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKeranjang_CellContentClick);
            // 
            // lblTotalBayar
            // 
            this.lblTotalBayar.AutoSize = true;
            this.lblTotalBayar.Location = new System.Drawing.Point(280, 43);
            this.lblTotalBayar.Name = "lblTotalBayar";
            this.lblTotalBayar.Size = new System.Drawing.Size(14, 16);
            this.lblTotalBayar.TabIndex = 4;
            this.lblTotalBayar.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.Location = new System.Drawing.Point(534, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "bayar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.Location = new System.Drawing.Point(23, 37);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(100, 22);
            this.lblSubtotal.TabIndex = 8;
            // 
            // lblDiskon
            // 
            this.lblDiskon.Location = new System.Drawing.Point(145, 37);
            this.lblDiskon.Name = "lblDiskon";
            this.lblDiskon.Size = new System.Drawing.Size(100, 22);
            this.lblDiskon.TabIndex = 9;
            // 
            // txtUangBayar
            // 
            this.txtUangBayar.Location = new System.Drawing.Point(64, 90);
            this.txtUangBayar.Name = "txtUangBayar";
            this.txtUangBayar.Size = new System.Drawing.Size(100, 22);
            this.txtUangBayar.TabIndex = 10;
            this.txtUangBayar.TextChanged += new System.EventHandler(this.txtUangBayar_TextChanged);
            // 
            // lblKembalian
            // 
            this.lblKembalian.AutoSize = true;
            this.lblKembalian.Location = new System.Drawing.Point(222, 96);
            this.lblKembalian.Name = "lblKembalian";
            this.lblKembalian.Size = new System.Drawing.Size(14, 16);
            this.lblKembalian.TabIndex = 11;
            this.lblKembalian.Text = "0";
            this.lblKembalian.Click += new System.EventHandler(this.lblKembalian_Click);
            // 
            // txt_hargaproduct
            // 
            this.txt_hargaproduct.Location = new System.Drawing.Point(374, 142);
            this.txt_hargaproduct.Name = "txt_hargaproduct";
            this.txt_hargaproduct.Size = new System.Drawing.Size(169, 22);
            this.txt_hargaproduct.TabIndex = 7;
            // 
            // txt_namaproduk
            // 
            this.txt_namaproduk.Location = new System.Drawing.Point(296, 170);
            this.txt_namaproduk.Name = "txt_namaproduk";
            this.txt_namaproduk.Size = new System.Drawing.Size(169, 22);
            this.txt_namaproduk.TabIndex = 6;
            this.txt_namaproduk.TextChanged += new System.EventHandler(this.txt_namaproduk_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnTambah);
            this.groupBox1.Controls.Add(this.txtKodeProduct);
            this.groupBox1.Controls.Add(this.txtJumlah);
            this.groupBox1.Location = new System.Drawing.Point(2, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(182, 175);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Jumlah";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kode Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Subtotal";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblSubtotal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblDiskon);
            this.groupBox2.Controls.Add(this.lblTotalBayar);
            this.groupBox2.Controls.Add(this.lblKembalian);
            this.groupBox2.Controls.Add(this.txtUangBayar);
            this.groupBox2.Location = new System.Drawing.Point(158, 325);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 126);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "Kembalian";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Total harga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Pembayaran";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Discount";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(546, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Kembali";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // transaksi
            // 
            this.ClientSize = new System.Drawing.Size(682, 526);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvKeranjang);
            this.Controls.Add(this.txt_namaproduk);
            this.Controls.Add(this.txt_hargaproduct);
            this.Name = "transaksi";
            this.Load += new System.EventHandler(this.transaksi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKeranjang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_POS_SupermarketDataSet dB_POS_SupermarketDataSet;
        private System.Windows.Forms.BindingSource dBPOSSupermarketDataSetBindingSource;
        private System.Windows.Forms.BindingSource tbl_DetailTransactionsBindingSource;
        private DB_POS_SupermarketDataSetTableAdapters.Tbl_DetailTransactionsTableAdapter tbl_DetailTransactionsTableAdapter;
        private DB_POS_SupermarketDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DB_POS_SupermarketDataSetTableAdapters.Tbl_TransactionsTableAdapter tbl_TransactionsTableAdapter;
        private System.Windows.Forms.BindingSource tbl_TransactionsBindingSource;
        private DB_POS_SupermarketDataSetTableAdapters.Tbl_ProductsTableAdapter tbl_ProductsTableAdapter1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.TextBox txtKodeProduct;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.DataGridView dgvKeranjang;
        private System.Windows.Forms.Label lblTotalBayar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox lblSubtotal;
        private System.Windows.Forms.TextBox lblDiskon;
        private System.Windows.Forms.TextBox txtUangBayar;
        private System.Windows.Forms.Label lblKembalian;
        private System.Windows.Forms.TextBox txt_hargaproduct;
        private System.Windows.Forms.TextBox txt_namaproduk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}