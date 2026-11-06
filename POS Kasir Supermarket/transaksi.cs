using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace POS_Kasir_Supermarket
{
    public partial class transaksi : Form
    {
        public transaksi()
        {
            InitializeComponent();
            SetupKeranjang();
            LoadAutoCompleteKodeProduct();
            CariDanTampilkanProduk();
        }
        private void CetakStrukPDF(int invoiceNumber, string namaKasir, decimal subtotalBelanja, decimal nominalDiskon, decimal totalBayarFinal, decimal uangBayar, decimal kembalian)
        {
            
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF File (*.pdf)|*.pdf";
            saveFileDialog.FileName = $"Struk_INV_{invoiceNumber}.pdf";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                Rectangle pageSize = new Rectangle(226f, 600f);
                Document doc = new Document(pageSize, 10f, 10f, 10f, 10f); // Margin kiri, kanan, atas, bawah (10pt)

                try
                {
                    PdfWriter.GetInstance(doc, new FileStream(saveFileDialog.FileName, FileMode.Create));
                    doc.Open();

                    
                    Font fontTitle = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 11);
                    Font fontSub = FontFactory.GetFont(FontFactory.HELVETICA, 8);
                    Font fontBody = FontFactory.GetFont(FontFactory.HELVETICA, 8);
                    Font fontBold = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 8);

                    
                    Paragraph header = new Paragraph("TelkoMarket\n", fontTitle) { Alignment = Element.ALIGN_CENTER };
                    doc.Add(header);

                    Paragraph alamat = new Paragraph("Jl. Raya pegangsaan No. 12, Purbalingga\nTelp: (0281) 123456\n-----------------------------------------------\n", fontSub) { Alignment = Element.ALIGN_CENTER };
                    doc.Add(alamat);

                    
                    Paragraph info = new Paragraph
                    {
                        Font = fontSub
                    };
                    info.Add($"No. Invoice : {invoiceNumber}\n");
                    info.Add($"Tanggal     : {DateTime.Now:dd/MM/yyyy HH:mm}\n");
                    info.Add($"Kasir       : {namaKasir}\n");
                    info.Add("-----------------------------------------------\n");
                    doc.Add(info);

                    
                    PdfPTable table = new PdfPTable(3);
                    table.WidthPercentage = 100;
                    table.SetWidths(new float[] { 45f, 20f, 35f }); // Rasio lebar kolom: Nama(45%), Qty(20%), Total(35%)

                    foreach (DataRow row in dtKeranjang.Rows)
                    {
                        string namaItem = row["NamaProduct"].ToString();
                        decimal qty = Convert.ToDecimal(row["JumlahProduct"]);
                        decimal subtotalItem = Convert.ToDecimal(row["TotalHargaFinal"]);

                        PdfPCell cellNama = new PdfPCell(new Phrase(namaItem, fontBody)) { Border = Rectangle.NO_BORDER };
                        PdfPCell cellQty = new PdfPCell(new Phrase($"{qty:N0}x", fontBody)) { Border = Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_CENTER };
                        PdfPCell cellSubtotal = new PdfPCell(new Phrase($"Rp {subtotalItem:N0}", fontBody)) { Border = Rectangle.NO_BORDER, HorizontalAlignment = Element.ALIGN_RIGHT };

                        table.AddCell(cellNama);
                        table.AddCell(cellQty);
                        table.AddCell(cellSubtotal);
                    }
                    doc.Add(table);

                    
                    doc.Add(new Paragraph("-----------------------------------------------\n", fontSub));

                    Paragraph summary = new Paragraph
                    {
                        Font = fontBody
                    };
                    summary.Add($"Subtotal Total : Rp {subtotalBelanja:N0}\n");
                    summary.Add($"Diskon         : Rp {nominalDiskon:N0}\n");
                    summary.Add($"Total Akhir    : Rp {totalBayarFinal:N0}\n");
                    summary.Add($"Uang Bayar     : Rp {uangBayar:N0}\n");
                    summary.Add($"Kembalian      : Rp {kembalian:N0}\n");
                    summary.Add("-----------------------------------------------\n");
                    doc.Add(summary);

                    
                    Paragraph footer = new Paragraph("Terima Kasih Atas Kunjungan Anda!\nBarang yang sudah dibeli\ntidak dapat ditukarkan kembali.", fontSub) { Alignment = Element.ALIGN_CENTER };
                    doc.Add(footer);

                    doc.Close();

                    MessageBox.Show("Struk transaksi berhasil disimpan sebagai PDF!", "Sukses Cetak", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Gagal membuat PDF Struk: " + ex.Message, "Error PDF", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void LoadAutoCompleteKodeProduct()
        {
            AutoCompleteStringCollection sumberKode = new AutoCompleteStringCollection();

            
            string query = "SELECT DISTINCT KodeProduct FROM Tbl_Products";

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-5IT2GKKE\MSSQLSERVER02;Initial Catalog=DB_POS_Supermarket;Integrated Security=True"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            
                            while (reader.Read())
                            {
                                if (reader["KodeProduct"] != DBNull.Value)
                                {
                                    sumberKode.Add(reader["KodeProduct"].ToString());
                                }
                            }
                        }
                    }
                }

               
                txtKodeProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtKodeProduct.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtKodeProduct.AutoCompleteCustomSource = sumberKode;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat daftar produk dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void CariDanTampilkanProduk()
        {
           
            if (string.IsNullOrWhiteSpace(txtKodeProduct.Text) || !int.TryParse(txtKodeProduct.Text, out int kodeProduct))
            {
                txt_namaproduk.Clear();
                txt_hargaproduct.Clear();
                return;
            }

            string query = "SELECT NamaProduct, HargaProduct FROM Tbl_Products WHERE KodeProduct = @KodeProduct";

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-5IT2GKKE\MSSQLSERVER02;Initial Catalog=DB_POS_Supermarket;Integrated Security=True"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@KodeProduct", kodeProduct);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               
                               txt_namaproduk.Text = reader["NamaProduct"].ToString();

                                decimal harga = Convert.ToDecimal(reader["HargaProduct"]);
                                txt_hargaproduct.Text = harga.ToString("N0"); 
                            }
                            else
                            {
                                
                               txt_namaproduk.Text = "Produk Tidak Ditemukan";
                                txt_hargaproduct.Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
               
               txt_namaproduk.Clear();
               txt_hargaproduct.Clear();
            }
        }
        
        private DataTable dtKeranjang = new DataTable();
        private void SetupKeranjang()
        {
            
            dtKeranjang.Columns.Add("KodeProduct", typeof(int));
            dtKeranjang.Columns.Add("NamaProduct", typeof(string));
            dtKeranjang.Columns.Add("HargaProduct", typeof(decimal));  
            dtKeranjang.Columns.Add("JumlahProduct", typeof(decimal)); 
            dtKeranjang.Columns.Add("TotalHargaFinal", typeof(decimal));
            dtKeranjang.Columns.Add("TotalHargasetelahDiscount", typeof(decimal));
          

            dgvKeranjang.DataSource = dtKeranjang;

            
            dgvKeranjang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            txtJumlah.Text = "1";
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
       
        private void btnTambah_Click(object sender, EventArgs e)
        {
            TambahKeKeranjang();
        }

        
        private void txtKodeProduct_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                TambahKeKeranjang();
                e.SuppressKeyPress = true; 
            }
        }

        private void TambahKeKeranjang()
        {
            if (string.IsNullOrWhiteSpace(txtKodeProduct.Text))
            {
                MessageBox.Show("Silakan masukkan atau scan Kode Produk!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKodeProduct.Focus();
                return;
            }

            if (!int.TryParse(txtKodeProduct.Text, out int kodeProduct))
            {
                MessageBox.Show("Kode Produk harus berupa angka!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtJumlah.Text, out decimal qty) || qty <= 0)
            {
                MessageBox.Show("Jumlah produk harus lebih besar dari 0!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string namaProduct = "";
            decimal hargaProduct = 0;
            bool produkDitemukan = false;

           
            string queryCari = "SELECT NamaProduct, HargaProduct FROM Tbl_Products WHERE KodeProduct = @KodeProduct";

            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-5IT2GKKE\MSSQLSERVER02;Initial Catalog=DB_POS_Supermarket;Integrated Security=True"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(queryCari, conn))
                    {
                        cmd.Parameters.AddWithValue("@KodeProduct", kodeProduct);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                               
                                namaProduct = reader["NamaProduct"].ToString();
                                hargaProduct = Convert.ToDecimal(reader["HargaProduct"]);
                                produkDitemukan = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal mengambil data produk dari database: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            if (!produkDitemukan)
            {
                MessageBox.Show($"Produk dengan Kode [{kodeProduct}] tidak ditemukan di database!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKodeProduct.SelectAll();
                txtKodeProduct.Focus();
                return;
            }

            
            bool isExist = false;
            foreach (DataRow row in dtKeranjang.Rows)
            {
                if (Convert.ToInt32(row["KodeProduct"]) == kodeProduct)
                {
                   
                    decimal qtyLama = Convert.ToDecimal(row["JumlahProduct"]);
                    decimal qtyBaru = qtyLama + qty;
                  

                   

                    row["JumlahProduct"] = qtyBaru;
                    row["TotalHargaFinal"] = qtyBaru * hargaProduct;

                    decimal subtotalBelanja = Convert.ToDecimal(row["TotalHargaFinal"]);
                    decimal persentaseDiskon = 0;

                    if (subtotalBelanja > 200000)
                    {
                        persentaseDiskon = 0.10m; 
                    }
                    else if (subtotalBelanja > 100000)
                    {
                        persentaseDiskon = 0.05m;
                    }

                    decimal nominalDiskon = subtotalBelanja * persentaseDiskon;
                    row["TotalHargasetelahDiscount"] = subtotalBelanja - nominalDiskon;
                    isExist = true;
                    break;
                }
            }

           
            if (!isExist)
            {
                decimal totalHargaFinal = qty * hargaProduct;

                decimal subtotalBelanja = totalHargaFinal;
                decimal persentaseDiskon = 0;

                if (subtotalBelanja > 200000)
                {
                    persentaseDiskon = 0.0010m; 
                }
                else if (subtotalBelanja > 100000)
                {
                    persentaseDiskon = 0.0005m; 
                }

                decimal nominalDiskon = subtotalBelanja * persentaseDiskon;
                decimal TotalHargasetelahDiscount= subtotalBelanja - nominalDiskon;
                isExist = true;
               

                dtKeranjang.Rows.Add(kodeProduct, namaProduct, hargaProduct, qty, totalHargaFinal, TotalHargasetelahDiscount );
            }

            
            HitungGrandTotal();

            txtKodeProduct.Clear();
            txtJumlah.Text = "1";
            txtKodeProduct.Focus();
        }
        private void txtKodeProduct_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(txtKodeProduct.Text, out int kodeProduct))
            {
                string query = "SELECT NamaProduct, HargaProduct FROM Tbl_Produk WHERE KodeProduct = @KodeProduct";

                using (SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-5IT2GKKE\MSSQLSERVER02;Initial Catalog=DB_POS_Supermarket;Integrated Security=True"))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@KodeProduct", kodeProduct);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                
                               txt_namaproduk.Text = reader["NamaProduct"].ToString();
                                txt_hargaproduct.Text = Convert.ToDecimal(reader["HargaProduct"]).ToString("N0");
                            }
                            else
                            {
                                txt_namaproduk.Text = "Produk Tidak Ditemukan";
                                txt_hargaproduct.Text = "0";
                            }
                        }
                    }
                }
            }
        }
        private void HitungGrandTotal()
        {
            decimal subtotalBelanja = 0;
            foreach (DataRow row in dtKeranjang.Rows)
            {
                subtotalBelanja += Convert.ToDecimal(row["TotalHargaFinal"]);
            }

           
            decimal persentaseDiskon = 0;

            if (subtotalBelanja > 200000)
            {
                persentaseDiskon = 0.10m; 
            }
            else if (subtotalBelanja > 100000)
            {
                persentaseDiskon = 0.05m; 
            }

            
            decimal nominalDiskon = subtotalBelanja * persentaseDiskon;
            decimal totalBayarFinal = subtotalBelanja - nominalDiskon;

            
            lblSubtotal.Text = string.Format("Rp {0:N0}", subtotalBelanja);
            lblDiskon.Text = string.Format("{0}% (Rp {1:N0})", persentaseDiskon * 100, nominalDiskon);
            lblTotalBayar.Text = string.Format("Rp {0:N0}", totalBayarFinal);
        }



        private void button1_Click(object sender, EventArgs e)
        {
           
            if (dtKeranjang.Rows.Count == 0)
            {
                MessageBox.Show("Keranjang belanja masih kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            decimal subtotalBelanja = 0;
            foreach (DataRow row in dtKeranjang.Rows)
            {
                subtotalBelanja += Convert.ToDecimal(row["TotalHargaFinal"]);
            }

            
            decimal persentaseDiskon = 0;
            if (subtotalBelanja > 200000)
            {
                persentaseDiskon = 0.10m;
            }
            else if (subtotalBelanja > 100000)
            {
                persentaseDiskon = 0.05m;
            }

            decimal nominalDiskon = subtotalBelanja * persentaseDiskon;
            decimal totalBayarSetelahDiscount = subtotalBelanja - nominalDiskon;

            
            if (decimal.TryParse(txtUangBayar.Text, out decimal uangBayar))
            {
                if (uangBayar < totalBayarSetelahDiscount)
                {
                    MessageBox.Show($"Uang bayar kurang! Total belanja: Rp {totalBayarSetelahDiscount:N0}", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtUangBayar.Focus();
                    return;
                }

                decimal kembalian = uangBayar - totalBayarSetelahDiscount;

                int invoiceNumber = int.Parse(DateTime.Now.ToString("MMddHHmm"));
                int userID = 1;
                string namaKasir = "Budi (Kasir 1)";
                string connectionString = @"Data Source=LAPTOP-5IT2GKKE\MSSQLSERVER02;Initial Catalog=DB_POS_Supermarket;Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                       
                        foreach (DataRow row in dtKeranjang.Rows)
                        {
                            int kodeCek = Convert.ToInt32(row["KodeProduct"]);
                            decimal qtyBeli = Convert.ToDecimal(row["JumlahProduct"]);

                            
                            string queryCekStok = "SELECT StokProduct FROM Tbl_Products WHERE KodeProduct = @KodeProduct";
                            using (SqlCommand cmdCek = new SqlCommand(queryCekStok, conn, transaction))
                            {
                                cmdCek.Parameters.AddWithValue("@KodeProduct", kodeCek);
                                object stokDb = cmdCek.ExecuteScalar();

                                if (stokDb != null && stokDb != DBNull.Value)
                                {
                                    decimal sisaStok = Convert.ToDecimal(stokDb);
                                    if (sisaStok < qtyBeli)
                                    {
                                        transaction.Rollback();
                                        MessageBox.Show($"Stok produk [{row["NamaProduct"]}] tidak mencukupi!\nSisa stok di database: {sisaStok}",
                                                        "Stok Tidak Cukup", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        return;
                                    }
                                }
                            }
                        }

                        string queryInsert = @"INSERT INTO Tbl_Transactions 
                           (InvoiceNumber, UserID, NamaKasir, KodeProduct, JumlahProduct, HargaProduct, TotalTransaction, Transactiondate) 
                           VALUES 
                           (@InvoiceNumber, @UserID, @NamaKasir, @KodeProduct, @JumlahProduct, @HargaProduct, @TotalTransaction, @Transactiondate)";

                        
                        string queryUpdateStok = @"UPDATE Tbl_Products 
                                       SET StokProduct = StokProduct - @JumlahProduct 
                                       WHERE KodeProduct = @KodeProduct";

                        foreach (DataRow row in dtKeranjang.Rows)
                        {
                            int kodeProd = Convert.ToInt32(row["KodeProduct"]);
                            decimal qtyProd = Convert.ToDecimal(row["JumlahProduct"]);

                            // 1. Simpan Transaksi Ke Tbl_Transactions
                            using (SqlCommand cmdInsert = new SqlCommand(queryInsert, conn, transaction))
                            {
                                cmdInsert.Parameters.AddWithValue("@InvoiceNumber", invoiceNumber);
                                cmdInsert.Parameters.AddWithValue("@UserID", userID);
                                cmdInsert.Parameters.AddWithValue("@NamaKasir", namaKasir);
                                cmdInsert.Parameters.AddWithValue("@KodeProduct", kodeProd);
                                cmdInsert.Parameters.AddWithValue("@JumlahProduct", qtyProd);
                                cmdInsert.Parameters.AddWithValue("@HargaProduct", Convert.ToDecimal(row["HargaProduct"]));
                                cmdInsert.Parameters.AddWithValue("@TotalTransaction", totalBayarSetelahDiscount);
                                cmdInsert.Parameters.AddWithValue("@Transactiondate", DateTime.Now);

                                cmdInsert.ExecuteNonQuery();
                            }

                            
                            using (SqlCommand cmdStok = new SqlCommand(queryUpdateStok, conn, transaction))
                            {
                                cmdStok.Parameters.AddWithValue("@JumlahProduct", qtyProd);
                                cmdStok.Parameters.AddWithValue("@KodeProduct", kodeProd);

                                cmdStok.ExecuteNonQuery();
                            }
                        }

                        transaction.Commit();

                        DialogResult result = MessageBox.Show(
                            $"Transaksi Berhasil Disimpan!\n\nKembalian: Rp {kembalian:N0}\n\nApakah ingin cetak Struk PDF?",
                            "Transaksi Sukses",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question
                        );

                        if (result == DialogResult.Yes)
                        {
                            CetakStrukPDF(invoiceNumber, namaKasir, subtotalBelanja, nominalDiskon, totalBayarSetelahDiscount, uangBayar, kembalian);
                        }

                        ResetForm();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Gagal menyimpan transaksi: " + ex.Message, "Error Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nominal uang bayar tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUangBayar.Focus();
            }
        }
        private void ResetForm()
        {
            
            if (dtKeranjang != null)
            {
                dtKeranjang.Rows.Clear();
            }

            
            if (lblSubtotal != null) lblSubtotal.Text = "Rp 0";
            if (lblDiskon != null) lblDiskon.Text = "0% (Rp 0)";
            if (lblTotalBayar != null) lblTotalBayar.Text = "Rp 0";

          
            if (txtUangBayar != null) txtUangBayar.Clear();
            if (lblKembalian != null)
            {
                lblKembalian.Text = "Rp 0";
                lblKembalian.ForeColor = System.Drawing.Color.Black;
            }

           
            if (txtKodeProduct != null) txtKodeProduct.Clear();
            if (txt_namaproduk != null) txt_namaproduk.Clear();
            if (txt_hargaproduct != null) txt_hargaproduct.Clear();
            if (txtJumlah != null) txtJumlah.Text = "1";

           
            if (txtKodeProduct != null) txtKodeProduct.Focus();
        }

        private void dgvKeranjang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void transaksi_Load(object sender, EventArgs e)
        {

        }
        private void HitungKembalian()
        {
            
            decimal subtotalBelanja = 0;
            foreach (DataRow row in dtKeranjang.Rows)
            {
                subtotalBelanja += Convert.ToDecimal(row["TotalHargaFinal"]);
            }

           
            decimal persentaseDiskon = 0;
            if (subtotalBelanja > 200000) persentaseDiskon = 0.10m;
            else if (subtotalBelanja > 100000) persentaseDiskon = 0.05m;

            decimal totalBayarFinal = subtotalBelanja - (subtotalBelanja * persentaseDiskon);

            
            if (decimal.TryParse(txtUangBayar.Text, out decimal uangBayar))
            {
                decimal kembalian = uangBayar - totalBayarFinal;

                if (kembalian >= 0)
                {
                    lblKembalian.Text = string.Format("Rp {0:N0}", kembalian);
                    lblKembalian.ForeColor = System.Drawing.Color.Green; 
                }
                else
                {
                    
                    lblKembalian.Text = string.Format("Kurang Rp {0:N0}", Math.Abs(kembalian));
                    lblKembalian.ForeColor = System.Drawing.Color.Red; 
                }
            }
            else
            {
                lblKembalian.Text = "Rp 0";
            }
        }

        private void lblKembalian_Click(object sender, EventArgs e)
        {

        }

        private void txt_namaproduk_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            KasirDasbord kasirDasbord = new KasirDasbord();
            kasirDasbord.Show();
            this.Hide();
        }

        private void txtUangBayar_TextChanged(object sender, EventArgs e)
        {
            HitungKembalian();
        }
    }
}