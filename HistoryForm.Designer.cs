namespace FInal_Project
{
    partial class HistoryForm
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
            this.sellsHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.SellIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellStockColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SearchSellTextBox = new System.Windows.Forms.TextBox();
            this.SearchSellButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sellsHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sellsHistoryDataGridView
            // 
            this.sellsHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sellsHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SellIDColumn,
            this.ProductIDColumn,
            this.ProductNameColumn,
            this.SellStockColumn});
            this.sellsHistoryDataGridView.Location = new System.Drawing.Point(198, 148);
            this.sellsHistoryDataGridView.Name = "sellsHistoryDataGridView";
            this.sellsHistoryDataGridView.RowHeadersWidth = 82;
            this.sellsHistoryDataGridView.RowTemplate.Height = 33;
            this.sellsHistoryDataGridView.Size = new System.Drawing.Size(419, 150);
            this.sellsHistoryDataGridView.TabIndex = 0;
            this.sellsHistoryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.sellsHistoryDataGridView_CellContentClick);
            // 
            // SellIDColumn
            // 
            this.SellIDColumn.HeaderText = "SellID";
            this.SellIDColumn.MinimumWidth = 10;
            this.SellIDColumn.Name = "SellIDColumn";
            this.SellIDColumn.ReadOnly = true;
            this.SellIDColumn.Width = 45;
            // 
            // ProductIDColumn
            // 
            this.ProductIDColumn.HeaderText = "Product ID";
            this.ProductIDColumn.MinimumWidth = 10;
            this.ProductIDColumn.Name = "ProductIDColumn";
            this.ProductIDColumn.ReadOnly = true;
            this.ProductIDColumn.Width = 45;
            // 
            // ProductNameColumn
            // 
            this.ProductNameColumn.HeaderText = "Product Name";
            this.ProductNameColumn.MinimumWidth = 10;
            this.ProductNameColumn.Name = "ProductNameColumn";
            this.ProductNameColumn.ReadOnly = true;
            this.ProductNameColumn.Width = 200;
            // 
            // SellStockColumn
            // 
            this.SellStockColumn.HeaderText = "Selled Stock";
            this.SellStockColumn.MinimumWidth = 10;
            this.SellStockColumn.Name = "SellStockColumn";
            this.SellStockColumn.ReadOnly = true;
            this.SellStockColumn.Width = 45;
            // 
            // SearchSellTextBox
            // 
            this.SearchSellTextBox.Location = new System.Drawing.Point(198, 111);
            this.SearchSellTextBox.Name = "SearchSellTextBox";
            this.SearchSellTextBox.Size = new System.Drawing.Size(100, 31);
            this.SearchSellTextBox.TabIndex = 1;
            this.SearchSellTextBox.TextChanged += new System.EventHandler(this.SearchSellButton_Click);
            // 
            // SearchSellButton
            // 
            this.SearchSellButton.Location = new System.Drawing.Point(305, 107);
            this.SearchSellButton.Name = "SearchSellButton";
            this.SearchSellButton.Size = new System.Drawing.Size(98, 34);
            this.SearchSellButton.TabIndex = 2;
            this.SearchSellButton.Text = "Search";
            this.SearchSellButton.UseVisualStyleBackColor = true;
            this.SearchSellButton.Click += new System.EventHandler(this.SearchSellButton_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(841, 450);
            this.Controls.Add(this.SearchSellButton);
            this.Controls.Add(this.SearchSellTextBox);
            this.Controls.Add(this.sellsHistoryDataGridView);
            this.Name = "HistoryForm";
            this.Text = "HistoryForm";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellsHistoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sellsHistoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellStockColumn;
        private System.Windows.Forms.TextBox SearchSellTextBox;
        private System.Windows.Forms.Button SearchSellButton;
    }
}