namespace POS_Kasir_Supermarket
{
    partial class KasirDasbord
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasirDasbord));
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbl_UsersTableAdapter1 = new POS_Kasir_Supermarket.DB_POS_SupermarketDataSetTableAdapters.Tbl_UsersTableAdapter();
            this.Btn_transaksi = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.dB_POS_SupermarketDataSet = new POS_Kasir_Supermarket.DB_POS_SupermarketDataSet();
            this.tbl_ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ProductsTableAdapter = new POS_Kasir_Supermarket.DB_POS_SupermarketDataSetTableAdapters.Tbl_ProductsTableAdapter();
            this.tableAdapterManager = new POS_Kasir_Supermarket.DB_POS_SupermarketDataSetTableAdapters.TableAdapterManager();
            this.tbl_TransactionsTableAdapter = new POS_Kasir_Supermarket.DB_POS_SupermarketDataSetTableAdapters.Tbl_TransactionsTableAdapter();
            this.tbl_ProductsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tbl_ProductsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tbl_ProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_TransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_TransactionsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dB_POS_SupermarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProductsBindingNavigator)).BeginInit();
            this.tbl_ProductsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_TransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_TransactionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(37, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 78);
            this.button1.TabIndex = 0;
            this.button1.Text = "PRODUK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbl_UsersTableAdapter1
            // 
            this.tbl_UsersTableAdapter1.ClearBeforeFill = true;
            // 
            // Btn_transaksi
            // 
            this.Btn_transaksi.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Btn_transaksi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_transaksi.Location = new System.Drawing.Point(37, 197);
            this.Btn_transaksi.Name = "Btn_transaksi";
            this.Btn_transaksi.Size = new System.Drawing.Size(164, 88);
            this.Btn_transaksi.TabIndex = 2;
            this.Btn_transaksi.Text = "TRANSAKSI";
            this.Btn_transaksi.UseVisualStyleBackColor = false;
            this.Btn_transaksi.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Btn_transaksi);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 449);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(37, 335);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 88);
            this.button2.TabIndex = 3;
            this.button2.Text = "LOG OUT";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // dB_POS_SupermarketDataSet
            // 
            this.dB_POS_SupermarketDataSet.DataSetName = "DB_POS_SupermarketDataSet";
            this.dB_POS_SupermarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_ProductsBindingSource
            // 
            this.tbl_ProductsBindingSource.DataMember = "Tbl_Products";
            this.tbl_ProductsBindingSource.DataSource = this.dB_POS_SupermarketDataSet;
            // 
            // tbl_ProductsTableAdapter
            // 
            this.tbl_ProductsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tbl_CategoriesTableAdapter = null;
            this.tableAdapterManager.Tbl_DetailTransactionsTableAdapter = null;
            this.tableAdapterManager.Tbl_ProductsTableAdapter = this.tbl_ProductsTableAdapter;
            this.tableAdapterManager.Tbl_TransactionsTableAdapter = this.tbl_TransactionsTableAdapter;
            this.tableAdapterManager.Tbl_UsersTableAdapter = this.tbl_UsersTableAdapter1;
            this.tableAdapterManager.UpdateOrder = POS_Kasir_Supermarket.DB_POS_SupermarketDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_TransactionsTableAdapter
            // 
            this.tbl_TransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_ProductsBindingNavigator
            // 
            this.tbl_ProductsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_ProductsBindingNavigator.BindingSource = this.tbl_ProductsBindingSource;
            this.tbl_ProductsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_ProductsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_ProductsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbl_ProductsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tbl_ProductsBindingNavigatorSaveItem});
            this.tbl_ProductsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_ProductsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_ProductsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_ProductsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_ProductsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_ProductsBindingNavigator.Name = "tbl_ProductsBindingNavigator";
            this.tbl_ProductsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_ProductsBindingNavigator.Size = new System.Drawing.Size(808, 27);
            this.tbl_ProductsBindingNavigator.TabIndex = 5;
            this.tbl_ProductsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // tbl_ProductsBindingNavigatorSaveItem
            // 
            this.tbl_ProductsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_ProductsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_ProductsBindingNavigatorSaveItem.Image")));
            this.tbl_ProductsBindingNavigatorSaveItem.Name = "tbl_ProductsBindingNavigatorSaveItem";
            this.tbl_ProductsBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tbl_ProductsBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_ProductsBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_ProductsBindingNavigatorSaveItem_Click);
            // 
            // tbl_ProductsDataGridView
            // 
            this.tbl_ProductsDataGridView.AutoGenerateColumns = false;
            this.tbl_ProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_ProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.tbl_ProductsDataGridView.DataSource = this.tbl_ProductsBindingSource;
            this.tbl_ProductsDataGridView.Location = new System.Drawing.Point(259, 45);
            this.tbl_ProductsDataGridView.Name = "tbl_ProductsDataGridView";
            this.tbl_ProductsDataGridView.RowHeadersWidth = 51;
            this.tbl_ProductsDataGridView.RowTemplate.Height = 24;
            this.tbl_ProductsDataGridView.Size = new System.Drawing.Size(537, 181);
            this.tbl_ProductsDataGridView.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "KodeProduct";
            this.dataGridViewTextBoxColumn2.HeaderText = "KodeProduct";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NamaProduct";
            this.dataGridViewTextBoxColumn3.HeaderText = "NamaProduct";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "categoryID";
            this.dataGridViewTextBoxColumn4.HeaderText = "categoryID";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "KategoriProduct";
            this.dataGridViewTextBoxColumn5.HeaderText = "KategoriProduct";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "StokProduct";
            this.dataGridViewTextBoxColumn6.HeaderText = "StokProduct";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "HargaProduct";
            this.dataGridViewTextBoxColumn7.HeaderText = "HargaProduct";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // tbl_TransactionsBindingSource
            // 
            this.tbl_TransactionsBindingSource.DataMember = "Tbl_Transactions";
            this.tbl_TransactionsBindingSource.DataSource = this.dB_POS_SupermarketDataSet;
            // 
            // tbl_TransactionsDataGridView
            // 
            this.tbl_TransactionsDataGridView.AutoGenerateColumns = false;
            this.tbl_TransactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_TransactionsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13});
            this.tbl_TransactionsDataGridView.DataSource = this.tbl_TransactionsBindingSource;
            this.tbl_TransactionsDataGridView.Location = new System.Drawing.Point(259, 263);
            this.tbl_TransactionsDataGridView.Name = "tbl_TransactionsDataGridView";
            this.tbl_TransactionsDataGridView.RowHeadersWidth = 51;
            this.tbl_TransactionsDataGridView.RowTemplate.Height = 24;
            this.tbl_TransactionsDataGridView.Size = new System.Drawing.Size(537, 171);
            this.tbl_TransactionsDataGridView.TabIndex = 5;
            this.tbl_TransactionsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_TransactionsDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "TransactionID";
            this.dataGridViewTextBoxColumn8.HeaderText = "TransactionID";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "InvoiceNumber";
            this.dataGridViewTextBoxColumn9.HeaderText = "InvoiceNumber";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "UserID";
            this.dataGridViewTextBoxColumn10.HeaderText = "UserID";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "NamaKasir";
            this.dataGridViewTextBoxColumn11.HeaderText = "NamaKasir";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "TotalTransaction";
            this.dataGridViewTextBoxColumn12.HeaderText = "TotalTransaction";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Transactiondate";
            this.dataGridViewTextBoxColumn13.HeaderText = "Transactiondate";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // KasirDasbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 529);
            this.Controls.Add(this.tbl_TransactionsDataGridView);
            this.Controls.Add(this.tbl_ProductsDataGridView);
            this.Controls.Add(this.tbl_ProductsBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "KasirDasbord";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.KasirDasbord_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dB_POS_SupermarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProductsBindingNavigator)).EndInit();
            this.tbl_ProductsBindingNavigator.ResumeLayout(false);
            this.tbl_ProductsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_TransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_TransactionsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private DB_POS_SupermarketDataSetTableAdapters.Tbl_UsersTableAdapter tbl_UsersTableAdapter1;
        private System.Windows.Forms.Button Btn_transaksi;
        private System.Windows.Forms.GroupBox groupBox1;
        private DB_POS_SupermarketDataSet dB_POS_SupermarketDataSet;
        private System.Windows.Forms.BindingSource tbl_ProductsBindingSource;
        private DB_POS_SupermarketDataSetTableAdapters.Tbl_ProductsTableAdapter tbl_ProductsTableAdapter;
        private DB_POS_SupermarketDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_ProductsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton tbl_ProductsBindingNavigatorSaveItem;
        private DB_POS_SupermarketDataSetTableAdapters.Tbl_TransactionsTableAdapter tbl_TransactionsTableAdapter;
        private System.Windows.Forms.DataGridView tbl_ProductsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.BindingSource tbl_TransactionsBindingSource;
        private System.Windows.Forms.DataGridView tbl_TransactionsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.Button button2;
    }
}