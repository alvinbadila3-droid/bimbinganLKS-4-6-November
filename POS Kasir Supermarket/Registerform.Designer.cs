namespace POS_Kasir_Supermarket
{
    partial class Registerform
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
            System.Windows.Forms.Label namaUserLabel;
            System.Windows.Forms.Label usernameLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registerform));
            this.dB_POS_SupermarketDataSet = new POS_Kasir_Supermarket.DB_POS_SupermarketDataSet();
            this.tbl_UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_UsersTableAdapter = new POS_Kasir_Supermarket.DB_POS_SupermarketDataSetTableAdapters.Tbl_UsersTableAdapter();
            this.tableAdapterManager = new POS_Kasir_Supermarket.DB_POS_SupermarketDataSetTableAdapters.TableAdapterManager();
            this.tbl_UsersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tbl_UsersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txt_namauser = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.txt_confirmpassword = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            namaUserLabel = new System.Windows.Forms.Label();
            usernameLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dB_POS_SupermarketDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_UsersBindingNavigator)).BeginInit();
            this.tbl_UsersBindingNavigator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // namaUserLabel
            // 
            namaUserLabel.AutoSize = true;
            namaUserLabel.Location = new System.Drawing.Point(48, 107);
            namaUserLabel.Name = "namaUserLabel";
            namaUserLabel.Size = new System.Drawing.Size(79, 16);
            namaUserLabel.TabIndex = 3;
            namaUserLabel.Text = "Nama User:";
            namaUserLabel.Click += new System.EventHandler(this.namaUserLabel_Click);
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new System.Drawing.Point(48, 151);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new System.Drawing.Size(73, 16);
            usernameLabel.TabIndex = 5;
            usernameLabel.Text = "Username:";
            usernameLabel.Click += new System.EventHandler(this.usernameLabel_Click);
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(51, 195);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(70, 16);
            passwordLabel.TabIndex = 7;
            passwordLabel.Text = "Password:";
            passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(48, 237);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(119, 16);
            label1.TabIndex = 14;
            label1.Text = " confirm Password:";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dB_POS_SupermarketDataSet
            // 
            this.dB_POS_SupermarketDataSet.DataSetName = "DB_POS_SupermarketDataSet";
            this.dB_POS_SupermarketDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_UsersBindingSource
            // 
            this.tbl_UsersBindingSource.DataMember = "Tbl_Users";
            this.tbl_UsersBindingSource.DataSource = this.dB_POS_SupermarketDataSet;
            // 
            // tbl_UsersTableAdapter
            // 
            this.tbl_UsersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Tbl_CategoriesTableAdapter = null;
            this.tableAdapterManager.Tbl_DetailTransactionsTableAdapter = null;
            this.tableAdapterManager.Tbl_ProductsTableAdapter = null;
            this.tableAdapterManager.Tbl_TransactionsTableAdapter = null;
            this.tableAdapterManager.Tbl_UsersTableAdapter = this.tbl_UsersTableAdapter;
            this.tableAdapterManager.UpdateOrder = POS_Kasir_Supermarket.DB_POS_SupermarketDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_UsersBindingNavigator
            // 
            this.tbl_UsersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tbl_UsersBindingNavigator.BindingSource = this.tbl_UsersBindingSource;
            this.tbl_UsersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tbl_UsersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tbl_UsersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tbl_UsersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tbl_UsersBindingNavigatorSaveItem});
            this.tbl_UsersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tbl_UsersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tbl_UsersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tbl_UsersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tbl_UsersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tbl_UsersBindingNavigator.Name = "tbl_UsersBindingNavigator";
            this.tbl_UsersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tbl_UsersBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.tbl_UsersBindingNavigator.TabIndex = 0;
            this.tbl_UsersBindingNavigator.Text = "bindingNavigator1";
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
            // tbl_UsersBindingNavigatorSaveItem
            // 
            this.tbl_UsersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbl_UsersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tbl_UsersBindingNavigatorSaveItem.Image")));
            this.tbl_UsersBindingNavigatorSaveItem.Name = "tbl_UsersBindingNavigatorSaveItem";
            this.tbl_UsersBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.tbl_UsersBindingNavigatorSaveItem.Text = "Save Data";
            this.tbl_UsersBindingNavigatorSaveItem.Click += new System.EventHandler(this.tbl_UsersBindingNavigatorSaveItem_Click);
            // 
            // txt_namauser
            // 
            this.txt_namauser.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_UsersBindingSource, "NamaUser", true));
            this.txt_namauser.Location = new System.Drawing.Point(51, 126);
            this.txt_namauser.Name = "txt_namauser";
            this.txt_namauser.Size = new System.Drawing.Size(149, 22);
            this.txt_namauser.TabIndex = 4;
            this.txt_namauser.TextChanged += new System.EventHandler(this.namaUserTextBox_TextChanged);
            // 
            // txt_username
            // 
            this.txt_username.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_UsersBindingSource, "Username", true));
            this.txt_username.Location = new System.Drawing.Point(51, 170);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(177, 22);
            this.txt_username.TabIndex = 6;
            this.txt_username.TextChanged += new System.EventHandler(this.usernameTextBox_TextChanged);
            // 
            // txt_password
            // 
            this.txt_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_UsersBindingSource, "Password", true));
            this.txt_password.Location = new System.Drawing.Point(51, 212);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(193, 22);
            this.txt_password.TabIndex = 8;
            this.txt_password.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(51, 307);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(99, 34);
            this.btn_register.TabIndex = 13;
            this.btn_register.Text = "register";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_confirmpassword
            // 
            this.txt_confirmpassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tbl_UsersBindingSource, "Password", true));
            this.txt_confirmpassword.Location = new System.Drawing.Point(51, 253);
            this.txt_confirmpassword.Name = "txt_confirmpassword";
            this.txt_confirmpassword.Size = new System.Drawing.Size(193, 22);
            this.txt_confirmpassword.TabIndex = 15;
            this.txt_confirmpassword.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_confirmpassword);
            this.groupBox1.Controls.Add(label1);
            this.groupBox1.Controls.Add(this.btn_register);
            this.groupBox1.Controls.Add(namaUserLabel);
            this.groupBox1.Controls.Add(this.txt_namauser);
            this.groupBox1.Controls.Add(usernameLabel);
            this.groupBox1.Controls.Add(this.txt_username);
            this.groupBox1.Controls.Add(passwordLabel);
            this.groupBox1.Controls.Add(this.txt_password);
            this.groupBox1.Location = new System.Drawing.Point(483, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 447);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 28);
            this.label6.TabIndex = 17;
            this.label6.Text = "POS_Supermarket";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(208, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "kembali";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Registerform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbl_UsersBindingNavigator);
            this.Name = "Registerform";
            this.Text = "Registerform";
            this.Load += new System.EventHandler(this.Registerform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dB_POS_SupermarketDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_UsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_UsersBindingNavigator)).EndInit();
            this.tbl_UsersBindingNavigator.ResumeLayout(false);
            this.tbl_UsersBindingNavigator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB_POS_SupermarketDataSet dB_POS_SupermarketDataSet;
        private System.Windows.Forms.BindingSource tbl_UsersBindingSource;
        private DB_POS_SupermarketDataSetTableAdapters.Tbl_UsersTableAdapter tbl_UsersTableAdapter;
        private DB_POS_SupermarketDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tbl_UsersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tbl_UsersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txt_namauser;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox txt_confirmpassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}