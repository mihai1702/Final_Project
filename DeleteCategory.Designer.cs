namespace FInal_Project
{
    partial class DeleteCategory
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
            this.DeleteCategoryTextBox = new System.Windows.Forms.TextBox();
            this.DeleteCategoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteCategoryTextBox
            // 
            this.DeleteCategoryTextBox.Location = new System.Drawing.Point(304, 146);
            this.DeleteCategoryTextBox.Name = "DeleteCategoryTextBox";
            this.DeleteCategoryTextBox.Size = new System.Drawing.Size(179, 31);
            this.DeleteCategoryTextBox.TabIndex = 0;
            // 
            // DeleteCategoryButton
            // 
            this.DeleteCategoryButton.Location = new System.Drawing.Point(304, 221);
            this.DeleteCategoryButton.Name = "DeleteCategoryButton";
            this.DeleteCategoryButton.Size = new System.Drawing.Size(179, 55);
            this.DeleteCategoryButton.TabIndex = 1;
            this.DeleteCategoryButton.Text = "Delete Category";
            this.DeleteCategoryButton.UseVisualStyleBackColor = true;
            this.DeleteCategoryButton.Click += new System.EventHandler(this.DeleteCategoryButton_Click);
            // 
            // DeleteCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteCategoryButton);
            this.Controls.Add(this.DeleteCategoryTextBox);
            this.Name = "DeleteCategory";
            this.Text = "DeleteCategory";
            this.Load += new System.EventHandler(this.DeleteCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DeleteCategoryTextBox;
        private System.Windows.Forms.Button DeleteCategoryButton;
    }
}