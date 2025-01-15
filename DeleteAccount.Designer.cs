namespace FInal_Project
{
    partial class DeleteAccount
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
            this.DeleteUsernameLabel = new System.Windows.Forms.Label();
            this.DeleteAccountTxt = new System.Windows.Forms.TextBox();
            this.DeleteAccountBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeleteUsernameLabel
            // 
            this.DeleteUsernameLabel.AutoSize = true;
            this.DeleteUsernameLabel.Location = new System.Drawing.Point(46, 98);
            this.DeleteUsernameLabel.Name = "DeleteUsernameLabel";
            this.DeleteUsernameLabel.Size = new System.Drawing.Size(179, 25);
            this.DeleteUsernameLabel.TabIndex = 0;
            this.DeleteUsernameLabel.Text = "Enter Username: ";
            // 
            // DeleteAccountTxt
            // 
            this.DeleteAccountTxt.Location = new System.Drawing.Point(248, 98);
            this.DeleteAccountTxt.Name = "DeleteAccountTxt";
            this.DeleteAccountTxt.Size = new System.Drawing.Size(479, 31);
            this.DeleteAccountTxt.TabIndex = 1;
            // 
            // DeleteAccountBtn
            // 
            this.DeleteAccountBtn.Location = new System.Drawing.Point(171, 238);
            this.DeleteAccountBtn.Name = "DeleteAccountBtn";
            this.DeleteAccountBtn.Size = new System.Drawing.Size(402, 56);
            this.DeleteAccountBtn.TabIndex = 2;
            this.DeleteAccountBtn.Text = "Delete Account";
            this.DeleteAccountBtn.UseVisualStyleBackColor = true;
            this.DeleteAccountBtn.Click += new System.EventHandler(this.DeleteAccountBtn_Click);
            // 
            // DeleteAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteAccountBtn);
            this.Controls.Add(this.DeleteAccountTxt);
            this.Controls.Add(this.DeleteUsernameLabel);
            this.Name = "DeleteAccount";
            this.Text = "DeleteAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DeleteUsernameLabel;
        private System.Windows.Forms.TextBox DeleteAccountTxt;
        private System.Windows.Forms.Button DeleteAccountBtn;
    }
}