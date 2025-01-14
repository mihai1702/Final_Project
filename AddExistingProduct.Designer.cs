namespace FInal_Project
{
    partial class AddExistingProduct
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
            this.AddExistingProductButton = new System.Windows.Forms.Button();
            this.AddExistingProductUpDown = new System.Windows.Forms.NumericUpDown();
            this.AddExistingProductTextBox = new System.Windows.Forms.TextBox();
            this.ProductIDAddExLabel = new System.Windows.Forms.Label();
            this.QuantityAddExLabel = new System.Windows.Forms.Label();
            this.ChangeLanguageAddExComboBox = new System.Windows.Forms.ComboBox();
            this.ChangeLanguageAddExLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AddExistingProductUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AddExistingProductButton
            // 
            this.AddExistingProductButton.Location = new System.Drawing.Point(255, 257);
            this.AddExistingProductButton.Name = "AddExistingProductButton";
            this.AddExistingProductButton.Size = new System.Drawing.Size(144, 51);
            this.AddExistingProductButton.TabIndex = 1;
            this.AddExistingProductButton.Text = "Add";
            this.AddExistingProductButton.UseVisualStyleBackColor = true;
            this.AddExistingProductButton.Click += new System.EventHandler(this.AddExistingProductButton_Click);
            // 
            // AddExistingProductUpDown
            // 
            this.AddExistingProductUpDown.Location = new System.Drawing.Point(330, 197);
            this.AddExistingProductUpDown.Name = "AddExistingProductUpDown";
            this.AddExistingProductUpDown.Size = new System.Drawing.Size(162, 31);
            this.AddExistingProductUpDown.TabIndex = 2;
            // 
            // AddExistingProductTextBox
            // 
            this.AddExistingProductTextBox.Location = new System.Drawing.Point(330, 140);
            this.AddExistingProductTextBox.Name = "AddExistingProductTextBox";
            this.AddExistingProductTextBox.Size = new System.Drawing.Size(162, 31);
            this.AddExistingProductTextBox.TabIndex = 3;
            // 
            // ProductIDAddExLabel
            // 
            this.ProductIDAddExLabel.AutoSize = true;
            this.ProductIDAddExLabel.Location = new System.Drawing.Point(204, 143);
            this.ProductIDAddExLabel.Name = "ProductIDAddExLabel";
            this.ProductIDAddExLabel.Size = new System.Drawing.Size(106, 25);
            this.ProductIDAddExLabel.TabIndex = 4;
            this.ProductIDAddExLabel.Text = "ProductID";
            // 
            // QuantityAddExLabel
            // 
            this.QuantityAddExLabel.AutoSize = true;
            this.QuantityAddExLabel.Location = new System.Drawing.Point(212, 199);
            this.QuantityAddExLabel.Name = "QuantityAddExLabel";
            this.QuantityAddExLabel.Size = new System.Drawing.Size(92, 25);
            this.QuantityAddExLabel.TabIndex = 5;
            this.QuantityAddExLabel.Text = "Quantity";
            // 
            // ChangeLanguageAddExComboBox
            // 
            this.ChangeLanguageAddExComboBox.FormattingEnabled = true;
            this.ChangeLanguageAddExComboBox.Items.AddRange(new object[] {
            "en",
            "ro"});
            this.ChangeLanguageAddExComboBox.Location = new System.Drawing.Point(562, 12);
            this.ChangeLanguageAddExComboBox.Name = "ChangeLanguageAddExComboBox";
            this.ChangeLanguageAddExComboBox.Size = new System.Drawing.Size(121, 33);
            this.ChangeLanguageAddExComboBox.TabIndex = 6;
            this.ChangeLanguageAddExComboBox.SelectedIndexChanged += new System.EventHandler(this.ChangeLanguageAddExComboBox_SelectedIndexChanged);
            // 
            // ChangeLanguageAddExLabel
            // 
            this.ChangeLanguageAddExLabel.AutoSize = true;
            this.ChangeLanguageAddExLabel.Location = new System.Drawing.Point(367, 15);
            this.ChangeLanguageAddExLabel.Name = "ChangeLanguageAddExLabel";
            this.ChangeLanguageAddExLabel.Size = new System.Drawing.Size(189, 25);
            this.ChangeLanguageAddExLabel.TabIndex = 7;
            this.ChangeLanguageAddExLabel.Text = "Change Language";
            // 
            // AddExistingProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 450);
            this.Controls.Add(this.ChangeLanguageAddExLabel);
            this.Controls.Add(this.ChangeLanguageAddExComboBox);
            this.Controls.Add(this.QuantityAddExLabel);
            this.Controls.Add(this.ProductIDAddExLabel);
            this.Controls.Add(this.AddExistingProductTextBox);
            this.Controls.Add(this.AddExistingProductUpDown);
            this.Controls.Add(this.AddExistingProductButton);
            this.Name = "AddExistingProduct";
            this.Text = "Add Existing Product";
            ((System.ComponentModel.ISupportInitialize)(this.AddExistingProductUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button AddExistingProductButton;
        private System.Windows.Forms.NumericUpDown AddExistingProductUpDown;
        private System.Windows.Forms.TextBox AddExistingProductTextBox;
        private System.Windows.Forms.Label ProductIDAddExLabel;
        private System.Windows.Forms.Label QuantityAddExLabel;
        private System.Windows.Forms.ComboBox ChangeLanguageAddExComboBox;
        private System.Windows.Forms.Label ChangeLanguageAddExLabel;
    }
}