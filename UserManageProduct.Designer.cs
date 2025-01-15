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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UserProductComboBox = new System.Windows.Forms.ComboBox();
            this.UserRefreshBtn = new System.Windows.Forms.Button();
            this.UserSearchProductBtn = new System.Windows.Forms.Button();
            this.UserSearchProductTxt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ProductID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnteringDate_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpiringDate_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy_Column = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ChLangUserManageLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductGridView
            // 
            this.ProductGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID_Column,
            this.ProductName_Column,
            this.ProductDescription_Column,
            this.EnteringDate_Column,
            this.ExpiringDate_Column,
            this.Stock_Column,
            this.Price_Column,
            this.Buy_Column});
            this.ProductGridView.Location = new System.Drawing.Point(134, 233);
            this.ProductGridView.Name = "ProductGridView";
            this.ProductGridView.RowHeadersWidth = 82;
            this.ProductGridView.RowTemplate.Height = 33;
            this.ProductGridView.Size = new System.Drawing.Size(1079, 200);
            this.ProductGridView.TabIndex = 0;
            this.ProductGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridView_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.updateInfoToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(97, 36);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click_1);
            // 
            // updateInfoToolStripMenuItem
            // 
            this.updateInfoToolStripMenuItem.Name = "updateInfoToolStripMenuItem";
            this.updateInfoToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.updateInfoToolStripMenuItem.Text = "Update Info";
            this.updateInfoToolStripMenuItem.Click += new System.EventHandler(this.updateInfoToolStripMenuItem_Click_1);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click_1);
            // 
            // UserProductComboBox
            // 
            this.UserProductComboBox.FormattingEnabled = true;
            this.UserProductComboBox.Location = new System.Drawing.Point(230, 186);
            this.UserProductComboBox.Name = "UserProductComboBox";
            this.UserProductComboBox.Size = new System.Drawing.Size(281, 33);
            this.UserProductComboBox.TabIndex = 2;
            this.UserProductComboBox.SelectedIndexChanged += new System.EventHandler(this.UserProductComboBox_SelectedIndexChanged);
            // 
            // UserRefreshBtn
            // 
            this.UserRefreshBtn.Location = new System.Drawing.Point(78, 175);
            this.UserRefreshBtn.Name = "UserRefreshBtn";
            this.UserRefreshBtn.Size = new System.Drawing.Size(146, 52);
            this.UserRefreshBtn.TabIndex = 3;
            this.UserRefreshBtn.Text = "Refresh";
            this.UserRefreshBtn.UseVisualStyleBackColor = true;
            this.UserRefreshBtn.Click += new System.EventHandler(this.UserRefreshBtn_Click);
            // 
            // UserSearchProductBtn
            // 
            this.UserSearchProductBtn.Location = new System.Drawing.Point(1110, 169);
            this.UserSearchProductBtn.Name = "UserSearchProductBtn";
            this.UserSearchProductBtn.Size = new System.Drawing.Size(139, 52);
            this.UserSearchProductBtn.TabIndex = 4;
            this.UserSearchProductBtn.Text = "Search";
            this.UserSearchProductBtn.UseVisualStyleBackColor = true;
            this.UserSearchProductBtn.Click += new System.EventHandler(this.UserSearchProductBtn_Click);
            // 
            // UserSearchProductTxt
            // 
            this.UserSearchProductTxt.Location = new System.Drawing.Point(823, 180);
            this.UserSearchProductTxt.Name = "UserSearchProductTxt";
            this.UserSearchProductTxt.Size = new System.Drawing.Size(281, 31);
            this.UserSearchProductTxt.TabIndex = 5;
            this.UserSearchProductTxt.TextChanged += new System.EventHandler(this.UserSearchProductBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "en",
            "ro"});
            this.comboBox1.Location = new System.Drawing.Point(1210, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ProductID_Column
            // 
            this.ProductID_Column.HeaderText = "Product ID";
            this.ProductID_Column.MinimumWidth = 10;
            this.ProductID_Column.Name = "ProductID_Column";
            this.ProductID_Column.ReadOnly = true;
            this.ProductID_Column.Width = 45;
            // 
            // ProductName_Column
            // 
            this.ProductName_Column.HeaderText = "Product Name";
            this.ProductName_Column.MinimumWidth = 10;
            this.ProductName_Column.Name = "ProductName_Column";
            this.ProductName_Column.ReadOnly = true;
            this.ProductName_Column.Width = 200;
            // 
            // ProductDescription_Column
            // 
            this.ProductDescription_Column.HeaderText = "Product Description";
            this.ProductDescription_Column.MinimumWidth = 10;
            this.ProductDescription_Column.Name = "ProductDescription_Column";
            this.ProductDescription_Column.ReadOnly = true;
            this.ProductDescription_Column.Width = 200;
            // 
            // EnteringDate_Column
            // 
            this.EnteringDate_Column.HeaderText = "Entering Date";
            this.EnteringDate_Column.MinimumWidth = 10;
            this.EnteringDate_Column.Name = "EnteringDate_Column";
            this.EnteringDate_Column.ReadOnly = true;
            this.EnteringDate_Column.Width = 200;
            // 
            // ExpiringDate_Column
            // 
            this.ExpiringDate_Column.HeaderText = "Expiring Date";
            this.ExpiringDate_Column.MinimumWidth = 10;
            this.ExpiringDate_Column.Name = "ExpiringDate_Column";
            this.ExpiringDate_Column.ReadOnly = true;
            this.ExpiringDate_Column.Width = 200;
            // 
            // Stock_Column
            // 
            this.Stock_Column.HeaderText = "Stock";
            this.Stock_Column.MinimumWidth = 10;
            this.Stock_Column.Name = "Stock_Column";
            this.Stock_Column.ReadOnly = true;
            this.Stock_Column.Width = 45;
            // 
            // Price_Column
            // 
            this.Price_Column.HeaderText = "Price";
            this.Price_Column.MinimumWidth = 10;
            this.Price_Column.Name = "Price_Column";
            this.Price_Column.ReadOnly = true;
            this.Price_Column.Width = 45;
            // 
            // Buy_Column
            // 
            this.Buy_Column.HeaderText = "Buy";
            this.Buy_Column.MinimumWidth = 10;
            this.Buy_Column.Name = "Buy_Column";
            this.Buy_Column.ReadOnly = true;
            this.Buy_Column.Text = "Buy";
            this.Buy_Column.UseColumnTextForButtonValue = true;
            this.Buy_Column.Width = 60;
            // 
            // ChLangUserManageLabel
            // 
            this.ChLangUserManageLabel.AutoSize = true;
            this.ChLangUserManageLabel.Location = new System.Drawing.Point(1015, 58);
            this.ChLangUserManageLabel.Name = "ChLangUserManageLabel";
            this.ChLangUserManageLabel.Size = new System.Drawing.Size(189, 25);
            this.ChLangUserManageLabel.TabIndex = 7;
            this.ChLangUserManageLabel.Text = "Change Language";
            // 
            // UserManageProduct
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1354, 628);
            this.Controls.Add(this.ChLangUserManageLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.UserSearchProductTxt);
            this.Controls.Add(this.UserSearchProductBtn);
            this.Controls.Add(this.UserRefreshBtn);
            this.Controls.Add(this.UserProductComboBox);
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ComboBox UserProductComboBox;
        private System.Windows.Forms.Button UserRefreshBtn;
        private System.Windows.Forms.Button UserSearchProductBtn;
        private System.Windows.Forms.TextBox UserSearchProductTxt;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnteringDate_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpiringDate_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Column;
        private System.Windows.Forms.DataGridViewButtonColumn Buy_Column;
        private System.Windows.Forms.Label ChLangUserManageLabel;
    }
}