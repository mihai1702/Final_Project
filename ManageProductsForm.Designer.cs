namespace FInal_Project
{
    partial class ManageProductsForm
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
            this.ProductsGrid = new System.Windows.Forms.DataGridView();
            this.IDProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnteringDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellProductColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existingProducsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellsHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchProductBox = new System.Windows.Forms.TextBox();
            this.SearchProductButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.ChangeLanguageComboBox = new System.Windows.Forms.ComboBox();
            this.ChangeLanguageLabel = new System.Windows.Forms.Label();
            this.ChooseCategoryLabel = new System.Windows.Forms.Label();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductsGrid
            // 
            this.ProductsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDProductColumn,
            this.ProductColumn,
            this.ProductDescription,
            this.EnteringDateColumn,
            this.ExpDateColumn,
            this.StockColumn,
            this.PriceColumn,
            this.SellProductColumn});
            this.ProductsGrid.Location = new System.Drawing.Point(137, 266);
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.RowHeadersWidth = 82;
            this.ProductsGrid.RowTemplate.Height = 33;
            this.ProductsGrid.Size = new System.Drawing.Size(1120, 242);
            this.ProductsGrid.TabIndex = 0;
            this.ProductsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGrid_CellContentClick);
            this.ProductsGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGrid_CellDoubleClick);
            // 
            // IDProductColumn
            // 
            this.IDProductColumn.HeaderText = "Product ID";
            this.IDProductColumn.MinimumWidth = 10;
            this.IDProductColumn.Name = "IDProductColumn";
            this.IDProductColumn.ReadOnly = true;
            this.IDProductColumn.Width = 45;
            // 
            // ProductColumn
            // 
            this.ProductColumn.HeaderText = "Products";
            this.ProductColumn.MinimumWidth = 10;
            this.ProductColumn.Name = "ProductColumn";
            this.ProductColumn.ReadOnly = true;
            this.ProductColumn.Width = 200;
            // 
            // ProductDescription
            // 
            this.ProductDescription.HeaderText = "Description";
            this.ProductDescription.MinimumWidth = 10;
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.ReadOnly = true;
            this.ProductDescription.Width = 200;
            // 
            // EnteringDateColumn
            // 
            this.EnteringDateColumn.HeaderText = "Entering Date";
            this.EnteringDateColumn.MinimumWidth = 10;
            this.EnteringDateColumn.Name = "EnteringDateColumn";
            this.EnteringDateColumn.ReadOnly = true;
            this.EnteringDateColumn.Width = 200;
            // 
            // ExpDateColumn
            // 
            this.ExpDateColumn.HeaderText = "Expiring Date";
            this.ExpDateColumn.MinimumWidth = 10;
            this.ExpDateColumn.Name = "ExpDateColumn";
            this.ExpDateColumn.ReadOnly = true;
            this.ExpDateColumn.Width = 200;
            // 
            // StockColumn
            // 
            this.StockColumn.HeaderText = "Stock";
            this.StockColumn.MinimumWidth = 10;
            this.StockColumn.Name = "StockColumn";
            this.StockColumn.ReadOnly = true;
            this.StockColumn.Width = 45;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.MinimumWidth = 10;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Width = 45;
            // 
            // SellProductColumn
            // 
            this.SellProductColumn.HeaderText = "Sell Product";
            this.SellProductColumn.MinimumWidth = 10;
            this.SellProductColumn.Name = "SellProductColumn";
            this.SellProductColumn.Text = "Sell";
            this.SellProductColumn.UseColumnTextForButtonValue = true;
            this.SellProductColumn.Width = 200;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.manageUsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1374, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProductToolStripMenuItem,
            this.sellsHistoryToolStripMenuItem,
            this.addCategoryToolStripMenuItem,
            this.deleteCategoryToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(97, 36);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProductToolStripMenuItem,
            this.existingProducsToolStripMenuItem});
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(320, 44);
            this.addProductToolStripMenuItem.Text = "Add Product";
            // 
            // newProductToolStripMenuItem
            // 
            this.newProductToolStripMenuItem.Name = "newProductToolStripMenuItem";
            this.newProductToolStripMenuItem.Size = new System.Drawing.Size(317, 44);
            this.newProductToolStripMenuItem.Text = "New Product";
            this.newProductToolStripMenuItem.Click += new System.EventHandler(this.newProductToolStripMenuItem_Click);
            // 
            // existingProducsToolStripMenuItem
            // 
            this.existingProducsToolStripMenuItem.Name = "existingProducsToolStripMenuItem";
            this.existingProducsToolStripMenuItem.Size = new System.Drawing.Size(317, 44);
            this.existingProducsToolStripMenuItem.Text = "Existing Product";
            this.existingProducsToolStripMenuItem.Click += new System.EventHandler(this.existingProducsToolStripMenuItem_Click);
            // 
            // sellsHistoryToolStripMenuItem
            // 
            this.sellsHistoryToolStripMenuItem.Name = "sellsHistoryToolStripMenuItem";
            this.sellsHistoryToolStripMenuItem.Size = new System.Drawing.Size(320, 44);
            this.sellsHistoryToolStripMenuItem.Text = "Sells History";
            this.sellsHistoryToolStripMenuItem.Click += new System.EventHandler(this.sellsHistoryToolStripMenuItem_Click);
            // 
            // addCategoryToolStripMenuItem
            // 
            this.addCategoryToolStripMenuItem.Name = "addCategoryToolStripMenuItem";
            this.addCategoryToolStripMenuItem.Size = new System.Drawing.Size(320, 44);
            this.addCategoryToolStripMenuItem.Text = "Add Category";
            this.addCategoryToolStripMenuItem.Click += new System.EventHandler(this.addCategoryToolStripMenuItem_Click);
            // 
            // deleteCategoryToolStripMenuItem
            // 
            this.deleteCategoryToolStripMenuItem.Name = "deleteCategoryToolStripMenuItem";
            this.deleteCategoryToolStripMenuItem.Size = new System.Drawing.Size(320, 44);
            this.deleteCategoryToolStripMenuItem.Text = "Delete Category";
            this.deleteCategoryToolStripMenuItem.Click += new System.EventHandler(this.deleteCategoryToolStripMenuItem_Click);
            // 
            // manageUsersToolStripMenuItem
            // 
            this.manageUsersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserToolStripMenuItem,
            this.deleteAccountToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.updateInfoToolStripMenuItem});
            this.manageUsersToolStripMenuItem.Name = "manageUsersToolStripMenuItem";
            this.manageUsersToolStripMenuItem.Size = new System.Drawing.Size(185, 38);
            this.manageUsersToolStripMenuItem.Text = "Manage Users";
            // 
            // SearchProductBox
            // 
            this.SearchProductBox.Location = new System.Drawing.Point(861, 219);
            this.SearchProductBox.Name = "SearchProductBox";
            this.SearchProductBox.Size = new System.Drawing.Size(179, 31);
            this.SearchProductBox.TabIndex = 2;
            this.SearchProductBox.TextChanged += new System.EventHandler(this.SearchProductButton_Click);
            // 
            // SearchProductButton
            // 
            this.SearchProductButton.Location = new System.Drawing.Point(1046, 209);
            this.SearchProductButton.Name = "SearchProductButton";
            this.SearchProductButton.Size = new System.Drawing.Size(103, 41);
            this.SearchProductButton.TabIndex = 3;
            this.SearchProductButton.Text = "Search";
            this.SearchProductButton.UseVisualStyleBackColor = true;
            this.SearchProductButton.Click += new System.EventHandler(this.SearchProductButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(230, 204);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(103, 41);
            this.RefreshButton.TabIndex = 4;
            this.RefreshButton.Text = "Refresh";
            this.RefreshButton.UseVisualStyleBackColor = true;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(339, 209);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(179, 33);
            this.CategoryComboBox.TabIndex = 5;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // ChangeLanguageComboBox
            // 
            this.ChangeLanguageComboBox.FormattingEnabled = true;
            this.ChangeLanguageComboBox.Items.AddRange(new object[] {
            "en",
            "ro"});
            this.ChangeLanguageComboBox.Location = new System.Drawing.Point(1241, 52);
            this.ChangeLanguageComboBox.Name = "ChangeLanguageComboBox";
            this.ChangeLanguageComboBox.Size = new System.Drawing.Size(121, 33);
            this.ChangeLanguageComboBox.TabIndex = 6;
            this.ChangeLanguageComboBox.SelectedIndexChanged += new System.EventHandler(this.ChangeLanguageComboBox_SelectedIndexChanged);
            // 
            // ChangeLanguageLabel
            // 
            this.ChangeLanguageLabel.AutoSize = true;
            this.ChangeLanguageLabel.Location = new System.Drawing.Point(1041, 55);
            this.ChangeLanguageLabel.Name = "ChangeLanguageLabel";
            this.ChangeLanguageLabel.Size = new System.Drawing.Size(189, 25);
            this.ChangeLanguageLabel.TabIndex = 7;
            this.ChangeLanguageLabel.Text = "Change Language";
            // 
            // ChooseCategoryLabel
            // 
            this.ChooseCategoryLabel.AutoSize = true;
            this.ChooseCategoryLabel.Location = new System.Drawing.Point(339, 178);
            this.ChooseCategoryLabel.Name = "ChooseCategoryLabel";
            this.ChooseCategoryLabel.Size = new System.Drawing.Size(179, 25);
            this.ChooseCategoryLabel.TabIndex = 8;
            this.ChooseCategoryLabel.Text = "Choose Category";
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAdminToolStripMenuItem,
            this.newUserToolStripMenuItem});
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.addUserToolStripMenuItem.Text = "Add Account";
            // 
            // deleteAccountToolStripMenuItem
            // 
            this.deleteAccountToolStripMenuItem.Name = "deleteAccountToolStripMenuItem";
            this.deleteAccountToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.deleteAccountToolStripMenuItem.Text = "Delete Account";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            // 
            // updateInfoToolStripMenuItem
            // 
            this.updateInfoToolStripMenuItem.Name = "updateInfoToolStripMenuItem";
            this.updateInfoToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.updateInfoToolStripMenuItem.Text = "Update Info";
            // 
            // newAdminToolStripMenuItem
            // 
            this.newAdminToolStripMenuItem.Name = "newAdminToolStripMenuItem";
            this.newAdminToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.newAdminToolStripMenuItem.Text = "New Admin";
            this.newAdminToolStripMenuItem.Click += new System.EventHandler(this.newAdminToolStripMenuItem_Click);
            // 
            // newUserToolStripMenuItem
            // 
            this.newUserToolStripMenuItem.Name = "newUserToolStripMenuItem";
            this.newUserToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.newUserToolStripMenuItem.Text = "New User";
            this.newUserToolStripMenuItem.Click += new System.EventHandler(this.newUserToolStripMenuItem_Click);
            // 
            // ManageProductsForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1374, 629);
            this.Controls.Add(this.ChooseCategoryLabel);
            this.Controls.Add(this.ChangeLanguageLabel);
            this.Controls.Add(this.ChangeLanguageComboBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.SearchProductButton);
            this.Controls.Add(this.SearchProductBox);
            this.Controls.Add(this.ProductsGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManageProductsForm";
            this.Text = "ManageProductsForm";
            this.Load += new System.EventHandler(this.ManageProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existingProducsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sellsHistoryToolStripMenuItem;
        private System.Windows.Forms.TextBox SearchProductBox;
        private System.Windows.Forms.Button SearchProductButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.ComboBox ChangeLanguageComboBox;
        private System.Windows.Forms.Label ChangeLanguageLabel;
        private System.Windows.Forms.Label ChooseCategoryLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnteringDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.DataGridViewButtonColumn SellProductColumn;
        private System.Windows.Forms.ToolStripMenuItem addCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateInfoToolStripMenuItem;
    }
}