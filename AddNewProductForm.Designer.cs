namespace FInal_Project
{
    partial class AddNewProductForm
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
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ExpiringDateLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.StockLabel = new System.Windows.Forms.Label();
            this.EnteringDateLabel = new System.Windows.Forms.Label();
            this.ProductDescriptionLabel = new System.Windows.Forms.Label();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.EnteringTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ExpDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CategoryComboBox = new System.Windows.Forms.ComboBox();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.StockUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.StockUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(218, 73);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(148, 25);
            this.ProductNameLabel.TabIndex = 0;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // ExpiringDateLabel
            // 
            this.ExpiringDateLabel.AutoSize = true;
            this.ExpiringDateLabel.Location = new System.Drawing.Point(218, 194);
            this.ExpiringDateLabel.Name = "ExpiringDateLabel";
            this.ExpiringDateLabel.Size = new System.Drawing.Size(141, 25);
            this.ExpiringDateLabel.TabIndex = 1;
            this.ExpiringDateLabel.Text = "Expiring Date";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(218, 308);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(61, 25);
            this.PriceLabel.TabIndex = 2;
            this.PriceLabel.Text = "Price";
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.Location = new System.Drawing.Point(218, 270);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(66, 25);
            this.StockLabel.TabIndex = 3;
            this.StockLabel.Text = "Stock";
            // 
            // EnteringDateLabel
            // 
            this.EnteringDateLabel.AutoSize = true;
            this.EnteringDateLabel.Location = new System.Drawing.Point(218, 152);
            this.EnteringDateLabel.Name = "EnteringDateLabel";
            this.EnteringDateLabel.Size = new System.Drawing.Size(143, 25);
            this.EnteringDateLabel.TabIndex = 4;
            this.EnteringDateLabel.Text = "Entering Date";
            // 
            // ProductDescriptionLabel
            // 
            this.ProductDescriptionLabel.AutoSize = true;
            this.ProductDescriptionLabel.Location = new System.Drawing.Point(218, 113);
            this.ProductDescriptionLabel.Name = "ProductDescriptionLabel";
            this.ProductDescriptionLabel.Size = new System.Drawing.Size(200, 25);
            this.ProductDescriptionLabel.TabIndex = 5;
            this.ProductDescriptionLabel.Text = "Product Description";
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(218, 233);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(99, 25);
            this.CategoryLabel.TabIndex = 6;
            this.CategoryLabel.Text = "Category";
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(434, 66);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(407, 31);
            this.ProductNameTextBox.TabIndex = 7;
            // 
            // ProductDescriptionTextBox
            // 
            this.ProductDescriptionTextBox.Location = new System.Drawing.Point(434, 106);
            this.ProductDescriptionTextBox.Name = "ProductDescriptionTextBox";
            this.ProductDescriptionTextBox.Size = new System.Drawing.Size(407, 31);
            this.ProductDescriptionTextBox.TabIndex = 8;
            // 
            // EnteringTimeDateTimePicker
            // 
            this.EnteringTimeDateTimePicker.Location = new System.Drawing.Point(434, 145);
            this.EnteringTimeDateTimePicker.Name = "EnteringTimeDateTimePicker";
            this.EnteringTimeDateTimePicker.Size = new System.Drawing.Size(407, 31);
            this.EnteringTimeDateTimePicker.TabIndex = 9;
            // 
            // ExpDateDateTimePicker
            // 
            this.ExpDateDateTimePicker.Location = new System.Drawing.Point(434, 183);
            this.ExpDateDateTimePicker.Name = "ExpDateDateTimePicker";
            this.ExpDateDateTimePicker.Size = new System.Drawing.Size(407, 31);
            this.ExpDateDateTimePicker.TabIndex = 10;
            // 
            // CategoryComboBox
            // 
            this.CategoryComboBox.FormattingEnabled = true;
            this.CategoryComboBox.Location = new System.Drawing.Point(434, 224);
            this.CategoryComboBox.Name = "CategoryComboBox";
            this.CategoryComboBox.Size = new System.Drawing.Size(407, 33);
            this.CategoryComboBox.TabIndex = 11;
            this.CategoryComboBox.SelectedIndexChanged += new System.EventHandler(this.CategoryComboBox_SelectedIndexChanged);
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Location = new System.Drawing.Point(434, 305);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(407, 31);
            this.PriceTextBox.TabIndex = 13;
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(434, 359);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(176, 60);
            this.AddProductButton.TabIndex = 14;
            this.AddProductButton.Text = "Add";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // StockUpDown
            // 
            this.StockUpDown.Location = new System.Drawing.Point(434, 268);
            this.StockUpDown.Name = "StockUpDown";
            this.StockUpDown.Size = new System.Drawing.Size(407, 31);
            this.StockUpDown.TabIndex = 15;
            // 
            // AddNewProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 450);
            this.Controls.Add(this.StockUpDown);
            this.Controls.Add(this.AddProductButton);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.CategoryComboBox);
            this.Controls.Add(this.ExpDateDateTimePicker);
            this.Controls.Add(this.EnteringTimeDateTimePicker);
            this.Controls.Add(this.ProductDescriptionTextBox);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.CategoryLabel);
            this.Controls.Add(this.ProductDescriptionLabel);
            this.Controls.Add(this.EnteringDateLabel);
            this.Controls.Add(this.StockLabel);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.ExpiringDateLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Name = "AddNewProductForm";
            this.Text = "Add New Product";
            this.Load += new System.EventHandler(this.AddNewProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label ExpiringDateLabel;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.Label EnteringDateLabel;
        private System.Windows.Forms.Label ProductDescriptionLabel;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.TextBox ProductDescriptionTextBox;
        private System.Windows.Forms.DateTimePicker EnteringTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker ExpDateDateTimePicker;
        private System.Windows.Forms.ComboBox CategoryComboBox;
        private System.Windows.Forms.TextBox PriceTextBox;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.NumericUpDown StockUpDown;
    }
}