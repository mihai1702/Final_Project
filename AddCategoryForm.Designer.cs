namespace FInal_Project
{
    partial class AddCategoryForm
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
            this.AddCategoryButton = new System.Windows.Forms.Button();
            this.AddCategoryLabel = new System.Windows.Forms.Label();
            this.AddCategoryTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddCategoryButton
            // 
            this.AddCategoryButton.Location = new System.Drawing.Point(304, 257);
            this.AddCategoryButton.Name = "AddCategoryButton";
            this.AddCategoryButton.Size = new System.Drawing.Size(171, 64);
            this.AddCategoryButton.TabIndex = 0;
            this.AddCategoryButton.Text = "Add Cateogry";
            this.AddCategoryButton.UseVisualStyleBackColor = true;
            this.AddCategoryButton.Click += new System.EventHandler(this.AddCategoryButton_Click);
            // 
            // AddCategoryLabel
            // 
            this.AddCategoryLabel.AutoSize = true;
            this.AddCategoryLabel.Location = new System.Drawing.Point(228, 170);
            this.AddCategoryLabel.Name = "AddCategoryLabel";
            this.AddCategoryLabel.Size = new System.Drawing.Size(143, 25);
            this.AddCategoryLabel.TabIndex = 1;
            this.AddCategoryLabel.Text = "Add Category";
            // 
            // AddCategoryTextBox
            // 
            this.AddCategoryTextBox.Location = new System.Drawing.Point(420, 164);
            this.AddCategoryTextBox.Name = "AddCategoryTextBox";
            this.AddCategoryTextBox.Size = new System.Drawing.Size(129, 31);
            this.AddCategoryTextBox.TabIndex = 2;
            // 
            // AddCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddCategoryTextBox);
            this.Controls.Add(this.AddCategoryLabel);
            this.Controls.Add(this.AddCategoryButton);
            this.Name = "AddCategoryForm";
            this.Text = "AddCategoryForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddCategoryButton;
        private System.Windows.Forms.Label AddCategoryLabel;
        private System.Windows.Forms.TextBox AddCategoryTextBox;
    }
}