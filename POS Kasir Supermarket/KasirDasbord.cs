using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Kasir_Supermarket
{
    public partial class KasirDasbord : Form
    {
        public KasirDasbord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            product productform = new product();
            productform.Show();
            this.Hide();


        }

        private void KasirDasbord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_POS_SupermarketDataSet.Tbl_Transactions' table. You can move, or remove it, as needed.
            this.tbl_TransactionsTableAdapter.Fill(this.dB_POS_SupermarketDataSet.Tbl_Transactions);
            // TODO: This line of code loads data into the 'dB_POS_SupermarketDataSet.Tbl_Products' table. You can move, or remove it, as needed.
            this.tbl_ProductsTableAdapter.Fill(this.dB_POS_SupermarketDataSet.Tbl_Products);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            transaksi transaksiform = new transaksi();
            transaksiform.Show();
            this.Hide();
        }

        private void tbl_ProductsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_ProductsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_POS_SupermarketDataSet);

        }

        private void tbl_TransactionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
