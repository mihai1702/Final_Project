namespace FInal_Project
{
    partial class UpdateInfoUser
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
            this.UsernameUpdateInfoLabel = new System.Windows.Forms.Label();
            this.PasswordUpdateInfoLabel = new System.Windows.Forms.Label();
            this.NewFirstNameLabel = new System.Windows.Forms.Label();
            this.NewLastNameLabel = new System.Windows.Forms.Label();
            this.UsernameUpdateInfoTxt = new System.Windows.Forms.TextBox();
            this.PasswordUpdateInfoTxt = new System.Windows.Forms.TextBox();
            this.NewLastNameTxt = new System.Windows.Forms.TextBox();
            this.NewFirstNameTxt = new System.Windows.Forms.TextBox();
            this.UpdateInfoBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UsernameUpdateInfoLabel
            // 
            this.UsernameUpdateInfoLabel.AutoSize = true;
            this.UsernameUpdateInfoLabel.Location = new System.Drawing.Point(42, 58);
            this.UsernameUpdateInfoLabel.Name = "UsernameUpdateInfoLabel";
            this.UsernameUpdateInfoLabel.Size = new System.Drawing.Size(179, 25);
            this.UsernameUpdateInfoLabel.TabIndex = 0;
            this.UsernameUpdateInfoLabel.Text = "Enter Username: ";
            // 
            // PasswordUpdateInfoLabel
            // 
            this.PasswordUpdateInfoLabel.AutoSize = true;
            this.PasswordUpdateInfoLabel.Location = new System.Drawing.Point(42, 132);
            this.PasswordUpdateInfoLabel.Name = "PasswordUpdateInfoLabel";
            this.PasswordUpdateInfoLabel.Size = new System.Drawing.Size(175, 25);
            this.PasswordUpdateInfoLabel.TabIndex = 1;
            this.PasswordUpdateInfoLabel.Text = "Enter Password: ";
            // 
            // NewFirstNameLabel
            // 
            this.NewFirstNameLabel.AutoSize = true;
            this.NewFirstNameLabel.Location = new System.Drawing.Point(42, 204);
            this.NewFirstNameLabel.Name = "NewFirstNameLabel";
            this.NewFirstNameLabel.Size = new System.Drawing.Size(233, 25);
            this.NewFirstNameLabel.TabIndex = 2;
            this.NewFirstNameLabel.Text = "Enter New First Name: ";
            // 
            // NewLastNameLabel
            // 
            this.NewLastNameLabel.AutoSize = true;
            this.NewLastNameLabel.Location = new System.Drawing.Point(42, 270);
            this.NewLastNameLabel.Name = "NewLastNameLabel";
            this.NewLastNameLabel.Size = new System.Drawing.Size(232, 25);
            this.NewLastNameLabel.TabIndex = 3;
            this.NewLastNameLabel.Text = "Enter New Last Name: ";
            // 
            // UsernameUpdateInfoTxt
            // 
            this.UsernameUpdateInfoTxt.Location = new System.Drawing.Point(227, 58);
            this.UsernameUpdateInfoTxt.Name = "UsernameUpdateInfoTxt";
            this.UsernameUpdateInfoTxt.Size = new System.Drawing.Size(489, 31);
            this.UsernameUpdateInfoTxt.TabIndex = 4;
            // 
            // PasswordUpdateInfoTxt
            // 
            this.PasswordUpdateInfoTxt.Location = new System.Drawing.Point(227, 132);
            this.PasswordUpdateInfoTxt.Name = "PasswordUpdateInfoTxt";
            this.PasswordUpdateInfoTxt.Size = new System.Drawing.Size(489, 31);
            this.PasswordUpdateInfoTxt.TabIndex = 5;
            // 
            // NewLastNameTxt
            // 
            this.NewLastNameTxt.Location = new System.Drawing.Point(308, 270);
            this.NewLastNameTxt.Name = "NewLastNameTxt";
            this.NewLastNameTxt.Size = new System.Drawing.Size(408, 31);
            this.NewLastNameTxt.TabIndex = 6;
            // 
            // NewFirstNameTxt
            // 
            this.NewFirstNameTxt.Location = new System.Drawing.Point(308, 204);
            this.NewFirstNameTxt.Name = "NewFirstNameTxt";
            this.NewFirstNameTxt.Size = new System.Drawing.Size(408, 31);
            this.NewFirstNameTxt.TabIndex = 7;
            // 
            // UpdateInfoBtn
            // 
            this.UpdateInfoBtn.Location = new System.Drawing.Point(239, 359);
            this.UpdateInfoBtn.Name = "UpdateInfoBtn";
            this.UpdateInfoBtn.Size = new System.Drawing.Size(276, 54);
            this.UpdateInfoBtn.TabIndex = 8;
            this.UpdateInfoBtn.Text = "Update Info";
            this.UpdateInfoBtn.UseVisualStyleBackColor = true;
            this.UpdateInfoBtn.Click += new System.EventHandler(this.UpdateInfoBtn_Click_1);
            // 
            // UpdateInfoUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UpdateInfoBtn);
            this.Controls.Add(this.NewFirstNameTxt);
            this.Controls.Add(this.NewLastNameTxt);
            this.Controls.Add(this.PasswordUpdateInfoTxt);
            this.Controls.Add(this.UsernameUpdateInfoTxt);
            this.Controls.Add(this.NewLastNameLabel);
            this.Controls.Add(this.NewFirstNameLabel);
            this.Controls.Add(this.PasswordUpdateInfoLabel);
            this.Controls.Add(this.UsernameUpdateInfoLabel);
            this.Name = "UpdateInfoUser";
            this.Text = "UpdateInfoUser";
            this.Load += new System.EventHandler(this.UpdateInfoUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UsernameUpdateInfoLabel;
        private System.Windows.Forms.Label PasswordUpdateInfoLabel;
        private System.Windows.Forms.Label NewFirstNameLabel;
        private System.Windows.Forms.Label NewLastNameLabel;
        private System.Windows.Forms.TextBox UsernameUpdateInfoTxt;
        private System.Windows.Forms.TextBox PasswordUpdateInfoTxt;
        private System.Windows.Forms.TextBox NewLastNameTxt;
        private System.Windows.Forms.TextBox NewFirstNameTxt;
        private System.Windows.Forms.Button UpdateInfoBtn;
    }
}