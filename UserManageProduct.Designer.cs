namespace FInal_Project
{
    partial class UserManageProduct
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
            this.ProductGridView = new System.Windows.Forms.DataGridView();
            this.Product_Id_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Product_Name_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entering_Date_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Expiring_Date_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy_Column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mENUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cHANGEPASSWORDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uPDATEINFOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductGridView
            // 
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product_Id_Column,
            this.Product_Name_Column,
            this.Description_Column,
            this.Entering_Date_Column,
            this.Expiring_Date_Column,
            this.Stock_Column,
            this.Price_Column,
            this.Buy_Column});
            this.ProductGridView.Location = new System.Drawing.Point(101, 233);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.RowHeadersWidth = 82;
            this.ProductGridView.RowTemplate.Height = 33;
            this.ProductGridView.Size = new System.Drawing.Size(1682, 403);
            this.ProductGridView.TabIndex = 0;
            // 
            // Product_Id_Column
            // 
            this.Product_Id_Column.HeaderText = "Product ID";
            this.Product_Id_Column.MinimumWidth = 10;
            this.Product_Id_Column.Name = "Product_Id_Column";
            this.Product_Id_Column.Width = 200;
            // 
            // Product_Name_Column
            // 
            this.Product_Name_Column.HeaderText = "Product Name";
            this.Product_Name_Column.MinimumWidth = 10;
            this.Product_Name_Column.Name = "Product_Name_Column";
            this.Product_Name_Column.Width = 200;
            // 
            // Description_Column
            // 
            this.Description_Column.HeaderText = "Description";
            this.Description_Column.MinimumWidth = 10;
            this.Description_Column.Name = "Description_Column";
            this.Description_Column.Width = 200;
            // 
            // Entering_Date_Column
            // 
            this.Entering_Date_Column.HeaderText = "Entering Date";
            this.Entering_Date_Column.MinimumWidth = 10;
            this.Entering_Date_Column.Name = "Entering_Date_Column";
            this.Entering_Date_Column.Width = 200;
            // 
            // Expiring_Date_Column
            // 
            this.Expiring_Date_Column.HeaderText = "Expiring Column";
            this.Expiring_Date_Column.MinimumWidth = 10;
            this.Expiring_Date_Column.Name = "Expiring_Date_Column";
            this.Expiring_Date_Column.Width = 200;
            // 
            // Stock_Column
            // 
            this.Stock_Column.HeaderText = "Stock";
            this.Stock_Column.MinimumWidth = 10;
            this.Stock_Column.Name = "Stock_Column";
            this.Stock_Column.Width = 200;
            // 
            // Price_Column
            // 
            this.Price_Column.HeaderText = "Price";
            this.Price_Column.MinimumWidth = 10;
            this.Price_Column.Name = "Price_Column";
            this.Price_Column.Width = 200;
            // 
            // Buy_Column
            // 
            this.Buy_Column.HeaderText = "Buy";
            this.Buy_Column.MinimumWidth = 10;
            this.Buy_Column.Name = "Buy_Column";
            this.Buy_Column.Width = 200;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mENUToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1881, 42);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mENUToolStripMenuItem
            // 
            this.mENUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cHANGEPASSWORDToolStripMenuItem,
            this.uPDATEINFOToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.mENUToolStripMenuItem.Name = "mENUToolStripMenuItem";
            this.mENUToolStripMenuItem.Size = new System.Drawing.Size(97, 38);
            this.mENUToolStripMenuItem.Text = "Menu";
            // 
            // cHANGEPASSWORDToolStripMenuItem
            // 
            this.cHANGEPASSWORDToolStripMenuItem.Name = "cHANGEPASSWORDToolStripMenuItem";
            this.cHANGEPASSWORDToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.cHANGEPASSWORDToolStripMenuItem.Text = "Change Password";
            this.cHANGEPASSWORDToolStripMenuItem.Click += new System.EventHandler(this.cHANGEPASSWORDToolStripMenuItem_Click);
            // 
            // uPDATEINFOToolStripMenuItem
            // 
            this.uPDATEINFOToolStripMenuItem.Name = "uPDATEINFOToolStripMenuItem";
            this.uPDATEINFOToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.uPDATEINFOToolStripMenuItem.Text = "Update Info";
            this.uPDATEINFOToolStripMenuItem.Click += new System.EventHandler(this.uPDATEINFOToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // UserManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1881, 825);
            this.Controls.Add(this.ProductGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "UserManageProduct";
            this.Text = "UserManageProduct";
            this.Load += new System.EventHandler(this.UserManageProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ProductGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Id_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product_Name_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entering_Date_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expiring_Date_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Column;
        private System.Windows.Forms.DataGridViewButtonColumn Buy_Column;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mENUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cHANGEPASSWORDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uPDATEINFOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
    }
}