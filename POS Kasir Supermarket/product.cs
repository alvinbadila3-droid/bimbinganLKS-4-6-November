using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Kasir_Supermarket
{
    public partial class product : Form
    {
        public product()
        {
            InitializeComponent();
            LoadAutoCompletecategoryID();
        }
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-5IT2GKKE\\MSSQLSERVER02;Initial Catalog=DB_POS_Supermarket;Integrated Security=True");
        private void product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_POS_SupermarketDataSet.Tbl_Categories' table. You can move, or remove it, as needed.
            this.tbl_CategoriesTableAdapter.Fill(this.dB_POS_SupermarketDataSet.Tbl_Categories);
            // TODO: This line of code loads data into the 'dB_POS_SupermarketDataSet.Tbl_DetailTransactions' table. You can move, or remove it, as needed.
            this.tbl_DetailTransactionsTableAdapter.Fill(this.dB_POS_SupermarketDataSet.Tbl_DetailTransactions);
            // TODO: This line of code loads data into the 'dB_POS_SupermarketDataSet.Tbl_Products' table. You can move, or remove it, as needed.
            this.tbl_ProductsTableAdapter.Fill(this.dB_POS_SupermarketDataSet.Tbl_Products);

        }
        private void LoadAutoCompletecategoryID()
        {
            AutoCompleteStringCollection sumberID = new AutoCompleteStringCollection();

            string quary = "select DISTINCT CategoryID from Tbl_Categories";
            try
            {
                connect.Open();
                using (SqlCommand cmd = new SqlCommand(quary, connect))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read()) 
                        {
                            if (reader["CategoryID"] != DBNull.Value)
                            {
                                sumberID.Add(reader["CategoryID"].ToString());
                            }
                        }
                    }
                }
                txtb_kategoriid.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtb_kategoriid.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtb_kategoriid.AutoCompleteCustomSource = sumberID;
            }
            catch (Exception ex )
            {
                MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            finally { connect.Close(); }
        }

        private void tbl_ProductsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_ProductsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_POS_SupermarketDataSet);

        }
        public bool emptyFields()
        {
            if (txtb_kodeproduk.Text == "" || txtb_namaproduct.Text == "" || txtb_kategoriid.Text == "" || txtb_kategoriproduct.Text == "" || txtb_stokproduct.Text == "" || txtb_hargaproduct.Text == "")
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Semua Kolom Harus Di Isi", "Error Message", MessageBoxButtons.OK);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string insert = "insert into Tbl_Products (KodeProduct,NamaProduct,categoryID,KategoriProduct,StokProduct,HargaProduct)" + "values (@KP,@NP,@CI,@CP,@SP,@HP)";
                        using (SqlCommand cmd = new SqlCommand(insert, connect))
                        {
                            cmd.Parameters.AddWithValue("@KP", txtb_kodeproduk.Text.Trim());
                            cmd.Parameters.AddWithValue("@NP", txtb_namaproduct.Text.Trim());
                            cmd.Parameters.AddWithValue("@CI", txtb_kategoriid.Text.Trim());
                            cmd.Parameters.AddWithValue("@CP", txtb_kategoriproduct.Text.Trim());
                            cmd.Parameters.AddWithValue("@SP", txtb_stokproduct.Text.Trim());
                            cmd.Parameters.AddWithValue("@HP", txtb_hargaproduct.Text.Trim());
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("menambahkan product Sukses!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }


                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            string kodeProduk = txtb_kodeproduk.Text.Trim();

            // Validasi jika textbox kosong
            if (string.IsNullOrEmpty(kodeProduk))
            {
                MessageBox.Show("Silakan masukkan Kode Produk yang ingin dihapus.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Tampilkan pesan konfirmasi
            DialogResult dialogResult = MessageBox.Show(
                $"Apakah Anda yakin ingin menghapus produk dengan Kode Produk: {kodeProduk}?",
                "Konfirmasi Hapus",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (dialogResult == DialogResult.Yes)
            {
                
                string query = "DELETE FROM [dbo].[Tbl_Products] WHERE [KodeProduct] = @KodeProduct";

                try
                {

                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                      
                        cmd.Parameters.AddWithValue("@KodeProduct", kodeProduk);

                        connect.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data produk berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            
                            txtb_kodeproduk.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Data tidak ditemukan. Pastikan Kode Produk yang dimasukkan benar.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan pada database: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void tbl_ProductsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Semua kolom harus diisi.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!int.TryParse(txtb_stokproduct.Text.Trim(), out int stock))
            {
                MessageBox.Show("Stock harus berupa angka.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!decimal.TryParse(txtb_hargaproduct.Text.Trim(), out decimal price))
            {
                MessageBox.Show("Price harus berupa angka.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult check = MessageBox.Show(
               "Apakah anda yakin untuk memperbarui Product ID: " + txtb_namaproduct.Text.Trim() + "?",
               "Confirmation Message",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question
           );

            if (check != DialogResult.Yes)
                return;
            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();
                    string updatedata = "UPDATE Tbl_Products set NamaProduct=@NP,categoryID=@CI,KategoriProduct=@CP,StokProduct=@SP,HargaProduct=@HB Where KodeProduct =@KP";
                    using (SqlCommand cmd = new SqlCommand(updatedata, connect))
                    {
                        cmd.Parameters.AddWithValue("@KP", txtb_kodeproduk.Text.Trim());
                        cmd.Parameters.AddWithValue("@NP", txtb_namaproduct.Text.Trim());
                        cmd.Parameters.AddWithValue("@CI", txtb_kategoriid.Text.Trim());
                        cmd.Parameters.AddWithValue("@CP", txtb_kategoriproduct.Text.Trim());
                        cmd.Parameters.AddWithValue("@SP", stock);
                        cmd.Parameters.AddWithValue("@HB", price);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("memperbarui product Sukses!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                finally { connect.Close(); }
            }
        }

        private void kodeProductLabel_Click(object sender, EventArgs e)
        {

        }

        private void kodeProductTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void namaProductLabel_Click(object sender, EventArgs e)
        {

        }

        private void namaProductTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoryIDLabel_Click(object sender, EventArgs e)
        {

        }

        private void categoryIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void kategoriProductLabel_Click(object sender, EventArgs e)
        {

        }

        private void kategoriProductTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stokProductLabel_Click(object sender, EventArgs e)
        {

        }

        private void stokProductTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hargaProductLabel_Click(object sender, EventArgs e)
        {

        }

        private void hargaProductTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void categoryIDListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void categoryIDLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            KasirDasbord kasirDasbord = new KasirDasbord();
            kasirDasbord.Show();
            this.Hide();
        }
    }
}
