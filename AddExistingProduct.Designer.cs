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
            ((System.ComponentModel.ISupportInitialize)(this.AddExistingProductUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // AddExistingProductButton
            // 
            this.AddExistingProductButton.Location = new System.Drawing.Point(339, 243);
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
            // AddExistingProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}