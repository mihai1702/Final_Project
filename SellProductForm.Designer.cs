namespace FInal_Project
{
    partial class SellProductForm
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
            this.SellNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.SellButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SellNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // SellNumericUpDown
            // 
            this.SellNumericUpDown.Location = new System.Drawing.Point(311, 125);
            this.SellNumericUpDown.Name = "SellNumericUpDown";
            this.SellNumericUpDown.Size = new System.Drawing.Size(120, 31);
            this.SellNumericUpDown.TabIndex = 0;
            // 
            // SellButton
            // 
            this.SellButton.Location = new System.Drawing.Point(311, 214);
            this.SellButton.Name = "SellButton";
            this.SellButton.Size = new System.Drawing.Size(118, 52);
            this.SellButton.TabIndex = 1;
            this.SellButton.Text = "Sell";
            this.SellButton.UseVisualStyleBackColor = true;
            this.SellButton.Click += new System.EventHandler(this.SellButton_Click);
            // 
            // SellProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SellButton);
            this.Controls.Add(this.SellNumericUpDown);
            this.Name = "SellProductForm";
            this.Text = "SellProductForm";
            this.Load += new System.EventHandler(this.SellProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SellNumericUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown SellNumericUpDown;
        private System.Windows.Forms.Button SellButton;
    }
}