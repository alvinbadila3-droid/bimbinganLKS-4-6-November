namespace POS_Kasir_Supermarket
{
    partial class product
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
            System.Windows.Forms.Label kodeProductLabel;
            System.Windows.Forms.Label namaProductLabel;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label kategoriProductLabel;
            System.Windows.Forms.Label stokProductLabel;
            System.Windows.Forms.Label hargaProductLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(product));
            this.dB_POS_SupermarketDataSet = new POS_Kasir_Supermarket.DB_POS_SupermarketDataSet();
            this.tbl_ProductsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_ProductsTableAdapter = new POS_Kasir_Supermarket.DB_POS_SupermarketDataSetTableAdapters.Tbl_ProductsTableAdapter();
            this.tableAdapterManager = new POS_Kasir_Supermarket.DB_POS_SupermarketDataSetTableAdapters.TableAdapterManager();
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
            this.txtb_kodeproduk = new System.Windows.Forms.TextBox();
            this.txtb_namaproduct = new System.Windows.Forms.TextBox();
            this.txtb_kategoriid = new System.Windows.Forms.TextBox();
            this.txtb_kategoriproduct = new System.Windows.Forms.TextBox();
            this.txtb_stokproduct = new System.Windows.Forms.TextBox();
            this.txtb_hargaproduct = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tbl_DetailTransactionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_DetailTransactionsTableAdapter = new POS_Kasir_Supermarket.DB_POS_SupermarketDataSetTableAdapters.Tbl_DetailTransactionsTableAdapter();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tbl_CategoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_CategoriesTableAdapter = new POS_Kasir_Supermarket.DB_POS_SupermarketDataSetTableAdapters.Tbl_CategoriesTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            kodeProductLabel = new System.Windows.Forms.Label();
            namaProductLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            kategoriProductLabel = new System.Windows.Forms.Label();
            stokProductLabel = new System.Windows.Forms.Label();
            hargaProductLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_POS_SupermarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProductsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProductsBindingNavigator)).BeginInit();
            this.tbl_ProductsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProductsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DetailTransactionsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CategoriesBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kodeProductLabel
            // 
            kodeProductLabel.AutoSize = true;
            kodeProductLabel.Location = new System.Drawing.Point(17, 41);
            kodeProductLabel.Name = "kodeProductLabel";
            kodeProductLabel.Size = new System.Drawing.Size(91, 16);
            kodeProductLabel.TabIndex = 4;
            kodeProductLabel.Text = "Kode Product:";
            kodeProductLabel.Click += new System.EventHandler(this.kodeProductLabel_Click);
            // 
            // namaProductLabel
            // 
            namaProductLabel.AutoSize = true;
            namaProductLabel.Location = new System.Drawing.Point(17, 66);
            namaProductLabel.Name = "namaProductLabel";
            namaProductLabel.Size = new System.Drawing.Size(96, 16);
            namaProductLabel.TabIndex = 6;
            namaProductLabel.Text = "Nama Product:";
            namaProductLabel.Click += new System.EventHandler(this.namaProductLabel_Click);
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Location = new System.Drawing.Point(17, 94);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(79, 16);
            categoryIDLabel.TabIndex = 8;
            categoryIDLabel.Text = "category ID:";
            categoryIDLabel.Click += new System.EventHandler(this.categoryIDLabel_Click);
            // 
            // kategoriProductLabel
            // 
            kategoriProductLabel.AutoSize = true;
            kategoriProductLabel.Location = new System.Drawing.Point(17, 122);
            kategoriProductLabel.Name = "kategoriProductLabel";
            kategoriProductLabel.Size = new System.Drawing.Size(109, 16);
            kategoriProductLabel.TabIndex = 10;
            kategoriProductLabel.Text = "Kategori Product:";
            kategoriProductLabel.Click += new System.EventHandler(this.kategoriProductLabel_Click);
            // 
            // stokProductLabel
            // 
            stokProductLabel.AutoSize = true;
            stokProductLabel.Location = new System.Drawing.Point(17, 150);
            stokProductLabel.Name = "stokProductLabel";
            stokProductLabel.Size = new System.Drawing.Size(86, 16);
            stokProductLabel.TabIndex = 12;
            stokProductLabel.Text = "Stok Product:";
            stokProductLabel.Click += new System.EventHandler(this.stokProductLabel_Click);
            // 
            // hargaProductLabel
            // 
            hargaProductLabel.AutoSize = true;
            hargaProductLabel.Location = new System.Drawing.Point(16, 178);
            hargaProductLabel.Name = "hargaProductLabel";
            hargaProductLabel.Size = new System.Drawing.Size(97, 16);
            hargaProductLabel.TabIndex = 14;
            hargaProductLabel.Text = "Harga Product:";
            hargaProductLabel.Click += new System.EventHandler(this.hargaProductLabel_Click);
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
            this.tableAdapterManager.Tbl_TransactionsTableAdapter = null;
            this.tableAdapterManager.Tbl_UsersTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = POS_Kasir_Supermarket.DB_POS_SupermarketDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
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
            this.tbl_ProductsBindingNavigator.Size = new System.Drawing.Size(820, 27);
            this.tbl_ProductsBindingNavigator.TabIndex = 0;
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.tbl_ProductsDataGridView.Location = new System.Drawing.Point(8, 264);
            this.tbl_ProductsDataGridView.Name = "tbl_ProductsDataGridView";
            this.tbl_ProductsDataGridView.RowHeadersWidth = 51;
            this.tbl_ProductsDataGridView.RowTemplate.Height = 24;
            this.tbl_ProductsDataGridView.Size = new System.Drawing.Size(800, 188);
            this.tbl_ProductsDataGridView.TabIndex = 1;
            this.tbl_ProductsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_ProductsDataGridView_CellContentClick);
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
            // txtb_kodeproduk
            // 
            this.txtb_kodeproduk.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProductsBindingSource, "KodeProduct", true));
            this.txtb_kodeproduk.Location = new System.Drawing.Point(132, 35);
            this.txtb_kodeproduk.Name = "txtb_kodeproduk";
            this.txtb_kodeproduk.Size = new System.Drawing.Size(100, 22);
            this.txtb_kodeproduk.TabIndex = 5;
            this.txtb_kodeproduk.TextChanged += new System.EventHandler(this.kodeProductTextBox_TextChanged);
            // 
            // txtb_namaproduct
            // 
            this.txtb_namaproduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProductsBindingSource, "NamaProduct", true));
            this.txtb_namaproduct.Location = new System.Drawing.Point(132, 63);
            this.txtb_namaproduct.Name = "txtb_namaproduct";
            this.txtb_namaproduct.Size = new System.Drawing.Size(100, 22);
            this.txtb_namaproduct.TabIndex = 7;
            this.txtb_namaproduct.TextChanged += new System.EventHandler(this.namaProductTextBox_TextChanged);
            // 
            // txtb_kategoriid
            // 
            this.txtb_kategoriid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProductsBindingSource, "categoryID", true));
            this.txtb_kategoriid.Location = new System.Drawing.Point(132, 91);
            this.txtb_kategoriid.Name = "txtb_kategoriid";
            this.txtb_kategoriid.Size = new System.Drawing.Size(100, 22);
            this.txtb_kategoriid.TabIndex = 9;
            this.txtb_kategoriid.TextChanged += new System.EventHandler(this.categoryIDTextBox_TextChanged);
            // 
            // txtb_kategoriproduct
            // 
            this.txtb_kategoriproduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProductsBindingSource, "KategoriProduct", true));
            this.txtb_kategoriproduct.Location = new System.Drawing.Point(132, 119);
            this.txtb_kategoriproduct.Name = "txtb_kategoriproduct";
            this.txtb_kategoriproduct.Size = new System.Drawing.Size(100, 22);
            this.txtb_kategoriproduct.TabIndex = 11;
            this.txtb_kategoriproduct.TextChanged += new System.EventHandler(this.kategoriProductTextBox_TextChanged);
            // 
            // txtb_stokproduct
            // 
            this.txtb_stokproduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProductsBindingSource, "StokProduct", true));
            this.txtb_stokproduct.Location = new System.Drawing.Point(132, 147);
            this.txtb_stokproduct.Name = "txtb_stokproduct";
            this.txtb_stokproduct.Size = new System.Drawing.Size(100, 22);
            this.txtb_stokproduct.TabIndex = 13;
            this.txtb_stokproduct.TextChanged += new System.EventHandler(this.stokProductTextBox_TextChanged);
            // 
            // txtb_hargaproduct
            // 
            this.txtb_hargaproduct.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_ProductsBindingSource, "HargaProduct", true));
            this.txtb_hargaproduct.Location = new System.Drawing.Point(132, 175);
            this.txtb_hargaproduct.Name = "txtb_hargaproduct";
            this.txtb_hargaproduct.Size = new System.Drawing.Size(100, 22);
            this.txtb_hargaproduct.TabIndex = 15;
            this.txtb_hargaproduct.TextChanged += new System.EventHandler(this.hargaProductTextBox_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Location = new System.Drawing.Point(295, 139);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 51);
            this.button1.TabIndex = 16;
            this.button1.Text = "tambahkan";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button2.Location = new System.Drawing.Point(450, 139);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 51);
            this.button2.TabIndex = 17;
            this.button2.Text = "ubah";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button3.Location = new System.Drawing.Point(605, 140);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 50);
            this.button3.TabIndex = 18;
            this.button3.Text = "hapus";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tbl_DetailTransactionsBindingSource
            // 
            this.tbl_DetailTransactionsBindingSource.DataMember = "Tbl_DetailTransactions";
            this.tbl_DetailTransactionsBindingSource.DataSource = this.dB_POS_SupermarketDataSet;
            // 
            // tbl_DetailTransactionsTableAdapter
            // 
            this.tbl_DetailTransactionsTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_CategoriesBindingSource
            // 
            this.tbl_CategoriesBindingSource.DataMember = "Tbl_Categories";
            this.tbl_CategoriesBindingSource.DataSource = this.dB_POS_SupermarketDataSet;
            // 
            // tbl_CategoriesTableAdapter
            // 
            this.tbl_CategoriesTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(kodeProductLabel);
            this.groupBox1.Controls.Add(this.txtb_kodeproduk);
            this.groupBox1.Controls.Add(namaProductLabel);
            this.groupBox1.Controls.Add(this.txtb_namaproduct);
            this.groupBox1.Controls.Add(categoryIDLabel);
            this.groupBox1.Controls.Add(this.txtb_kategoriid);
            this.groupBox1.Controls.Add(kategoriProductLabel);
            this.groupBox1.Controls.Add(this.txtb_kategoriproduct);
            this.groupBox1.Controls.Add(stokProductLabel);
            this.groupBox1.Controls.Add(this.txtb_stokproduct);
            this.groupBox1.Controls.Add(hargaProductLabel);
            this.groupBox1.Controls.Add(this.txtb_hargaproduct);
            this.groupBox1.Location = new System.Drawing.Point(13, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 228);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button4.Location = new System.Drawing.Point(719, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 51);
            this.button4.TabIndex = 20;
            this.button4.Text = "kembali";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 525);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbl_ProductsDataGridView);
            this.Controls.Add(this.tbl_ProductsBindingNavigator);
            this.Name = "product";
            this.Text = "product";
            this.Load += new System.EventHandler(this.product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_POS_SupermarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProductsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProductsBindingNavigator)).EndInit();
            this.tbl_ProductsBindingNavigator.ResumeLayout(false);
            this.tbl_ProductsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_ProductsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_DetailTransactionsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_CategoriesBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView tbl_ProductsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox txtb_kodeproduk;
        private System.Windows.Forms.TextBox txtb_namaproduct;
        private System.Windows.Forms.TextBox txtb_kategoriid;
        private System.Windows.Forms.TextBox txtb_kategoriproduct;
        private System.Windows.Forms.TextBox txtb_stokproduct;
        private System.Windows.Forms.TextBox txtb_hargaproduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource tbl_DetailTransactionsBindingSource;
        private DB_POS_SupermarketDataSetTableAdapters.Tbl_DetailTransactionsTableAdapter tbl_DetailTransactionsTableAdapter;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.BindingSource tbl_CategoriesBindingSource;
        private DB_POS_SupermarketDataSetTableAdapters.Tbl_CategoriesTableAdapter tbl_CategoriesTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
    }
}