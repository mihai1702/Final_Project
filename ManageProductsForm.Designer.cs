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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.meniuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produsNouToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.produsExistentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.istoricVanzariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchProductBox = new System.Windows.Forms.TextBox();
            this.SearchProductButton = new System.Windows.Forms.Button();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
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
            this.PriceColumn});
            this.ProductsGrid.Location = new System.Drawing.Point(210, 240);
            this.ProductsGrid.Name = "ProductsGrid";
            this.ProductsGrid.RowHeadersWidth = 82;
            this.ProductsGrid.RowTemplate.Height = 33;
            this.ProductsGrid.Size = new System.Drawing.Size(771, 242);
            this.ProductsGrid.TabIndex = 0;
            this.ProductsGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductsGrid_CellContentClick);
            // 
            // IDProductColumn
            // 
            this.IDProductColumn.HeaderText = "Product ID";
            this.IDProductColumn.MinimumWidth = 10;
            this.IDProductColumn.Name = "IDProductColumn";
            this.IDProductColumn.ReadOnly = true;
            this.IDProductColumn.Width = 200;
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
            this.StockColumn.Width = 200;
            // 
            // PriceColumn
            // 
            this.PriceColumn.HeaderText = "Price";
            this.PriceColumn.MinimumWidth = 10;
            this.PriceColumn.Name = "PriceColumn";
            this.PriceColumn.ReadOnly = true;
            this.PriceColumn.Width = 200;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meniuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1186, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // meniuToolStripMenuItem
            // 
            this.meniuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareProdusToolStripMenuItem,
            this.istoricVanzariToolStripMenuItem});
            this.meniuToolStripMenuItem.Name = "meniuToolStripMenuItem";
            this.meniuToolStripMenuItem.Size = new System.Drawing.Size(103, 36);
            this.meniuToolStripMenuItem.Text = "Meniu";
            // 
            // adaugareProdusToolStripMenuItem
            // 
            this.adaugareProdusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produsNouToolStripMenuItem,
            this.produsExistentToolStripMenuItem});
            this.adaugareProdusToolStripMenuItem.Name = "adaugareProdusToolStripMenuItem";
            this.adaugareProdusToolStripMenuItem.Size = new System.Drawing.Size(329, 44);
            this.adaugareProdusToolStripMenuItem.Text = "Adaugare Produs";
            // 
            // produsNouToolStripMenuItem
            // 
            this.produsNouToolStripMenuItem.Name = "produsNouToolStripMenuItem";
            this.produsNouToolStripMenuItem.Size = new System.Drawing.Size(309, 44);
            this.produsNouToolStripMenuItem.Text = "Produs Nou";
            // 
            // produsExistentToolStripMenuItem
            // 
            this.produsExistentToolStripMenuItem.Name = "produsExistentToolStripMenuItem";
            this.produsExistentToolStripMenuItem.Size = new System.Drawing.Size(309, 44);
            this.produsExistentToolStripMenuItem.Text = "Produs Existent";
            // 
            // istoricVanzariToolStripMenuItem
            // 
            this.istoricVanzariToolStripMenuItem.Name = "istoricVanzariToolStripMenuItem";
            this.istoricVanzariToolStripMenuItem.Size = new System.Drawing.Size(329, 44);
            this.istoricVanzariToolStripMenuItem.Text = "Istoric Vanzari";
            // 
            // SearchProductBox
            // 
            this.SearchProductBox.Location = new System.Drawing.Point(729, 195);
            this.SearchProductBox.Name = "SearchProductBox";
            this.SearchProductBox.Size = new System.Drawing.Size(142, 31);
            this.SearchProductBox.TabIndex = 2;
            this.SearchProductBox.TextChanged += new System.EventHandler(this.SearchProductButton_Click);
            // 
            // SearchProductButton
            // 
            this.SearchProductButton.Location = new System.Drawing.Point(877, 185);
            this.SearchProductButton.Name = "SearchProductButton";
            this.SearchProductButton.Size = new System.Drawing.Size(103, 41);
            this.SearchProductButton.TabIndex = 3;
            this.SearchProductButton.Text = "Search";
            this.SearchProductButton.UseVisualStyleBackColor = true;
            this.SearchProductButton.Click += new System.EventHandler(this.SearchProductButton_Click);
            // 
            // RefreshButton
            // 
            this.RefreshButton.Location = new System.Drawing.Point(210, 185);
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
            this.CategoryComboBox.Location = new System.Drawing.Point(319, 195);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(142, 33);
            this.CategoryComboBox.TabIndex = 5;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // ManageProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 696);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.RefreshButton);
            this.Controls.Add(this.SearchProductButton);
            this.Controls.Add(this.SearchProductBox);
            this.Controls.Add(this.ProductsGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ManageProductsForm";
            this.Text = "ManageProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.ProductsGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductsGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem meniuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareProdusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produsNouToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produsExistentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem istoricVanzariToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnteringDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PriceColumn;
        private System.Windows.Forms.TextBox SearchProductBox;
        private System.Windows.Forms.Button SearchProductButton;
        private System.Windows.Forms.Button RefreshButton;
        private System.Windows.Forms.ComboBox CategoryComboBox;
    }
}