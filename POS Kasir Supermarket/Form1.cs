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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connect = new SqlConnection("Data Source=LAPTOP-5IT2GKKE\\MSSQLSERVER02;Initial Catalog=DB_POS_Supermarket;Integrated Security=True");

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public bool emptyFields()
        {
            if (txt_username.Text == "" ||txt_password.Text == "")
            {
                return true;
            }

            else
            {
                return false;
            }
        }



        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_masuk_Click(object sender, EventArgs e)
        {
            string username, user_password;
            username = txt_username.Text;
            user_password = txt_password.Text;
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
                        string selectaccount = "SELECT COUNT (*) FROM Tbl_Users where Username=@usern AND Password=@pass AND Status=@Status ";
                        using (SqlCommand cmd = new SqlCommand(selectaccount, connect))
                        {
                            cmd.Parameters.AddWithValue("@usern", txt_username.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", txt_password.Text.Trim());
                            cmd.Parameters.AddWithValue("@Status", "aktif");
                            int rowcount = (int)cmd.ExecuteScalar();
                            if (rowcount > 0)
                            {
                                string selectRole = "select Role From Tbl_Users where Username=@usern AND Password=@pass ";
                                using (SqlCommand getrole = new SqlCommand(selectRole, connect))
                                {
                                    getrole.Parameters.AddWithValue("@usern", txt_username.Text.Trim());
                                    getrole.Parameters.AddWithValue("@pass", txt_password.Text.Trim());
                                    string userrole = getrole.ExecuteScalar() as string;
                                    MessageBox.Show("Login Berhasil", "information message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (userrole == "Admin")
                                    {

                                    }
                                    else if (userrole == "Kasir")
                                    {
                                        KasirDasbord kasirDasbord = new KasirDasbord();
                                        kasirDasbord.Show();
                                        this.Hide();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("username/password salah atau tidak ada persetujuan admin", "Error mesage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }


                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("connetion failed:" + ex, "Error message", MessageBoxButtons.OK, MessageBoxIcon.Error);


                    }
                    finally { connect.Close(); }
                }
            }
        }

        private void lb_register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registerform registerform = new Registerform();
            registerform.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
