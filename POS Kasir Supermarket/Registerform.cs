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
    public partial class Registerform : Form
    {
        public Registerform()
        {
            InitializeComponent();
        }
        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-5IT2GKKE\\MSSQLSERVER02;Initial Catalog=DB_POS_Supermarket;Integrated Security=True");

        private void tbl_UsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_UsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_POS_SupermarketDataSet);

        }

        private void Registerform_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_POS_SupermarketDataSet.Tbl_Users' table. You can move, or remove it, as needed.
            this.tbl_UsersTableAdapter.Fill(this.dB_POS_SupermarketDataSet.Tbl_Users);

        }
        public bool emptyFields()
        {
            if (txt_username.Text == "" || txt_password.Text == "" || txt_confirmpassword.Text == "")
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
                        string selectUsername = "select * from Tbl_Users where username =@usern";
                        using (SqlCommand chekUsername = new SqlCommand(selectUsername, connect))
                        {
                            chekUsername.Parameters.AddWithValue("@usern", txt_username.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(chekUsername);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {
                                string usern = txt_username.Text.Substring(0, 1).ToUpper() + txt_username.Text.Substring(1);
                                MessageBox.Show(usern + "sudah di ambil", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (txt_password.Text != txt_password.Text)
                            {
                                MessageBox.Show("Kata sandi tidak cocok.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (txt_password.Text.Length < 8)
                            {
                                MessageBox.Show("Kata sandi tidak valid, minimal diperlukan 8 karakter.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertdata = "insert into Tbl_Users (Username,Password,Role,Status,CreatedAt,NamaUser)" + "values(@usern,@pass,@role,@Status,@CT,@namauser)";

                                using (SqlCommand cmd = new SqlCommand(insertdata, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usern", txt_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", txt_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@role", "Kasir");
                                    cmd.Parameters.AddWithValue("@Status", "aktif");
                                    cmd.Parameters.AddWithValue("CT","");
                                    cmd.Parameters.AddWithValue("@namauser", txt_namauser.Text.Trim());
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("Registered Sukses!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    Form1 loginForm = new Form1();
                                    loginForm.Show();

                                    this.Hide();


                                }

                            }
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

        private void txtb_namauser_TextChanged(object sender, EventArgs e)
        {

        }

        private void roleTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void namaUserLabel_Click(object sender, EventArgs e)
        {

        }

        private void namaUserTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void roleLabel_Click(object sender, EventArgs e)
        {

        }

        private void statusLabel_Click(object sender, EventArgs e)
        {

        }

        private void statusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
