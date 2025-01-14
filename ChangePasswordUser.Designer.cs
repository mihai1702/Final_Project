namespace FInal_Project
{
    partial class ChangePasswordUser
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
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.ChangePasswordBtn = new System.Windows.Forms.Button();
            this.UsernameChangePasswordLabel = new System.Windows.Forms.Label();
            this.UsernameChangePasswordTxt = new System.Windows.Forms.TextBox();
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.OldPasswordTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Location = new System.Drawing.Point(25, 214);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(217, 25);
            this.NewPasswordLabel.TabIndex = 0;
            this.NewPasswordLabel.Text = "Enter New Password:";
            // 
            // NewPasswordTxtBox
            // 
            this.NewPasswordTxtBox.Location = new System.Drawing.Point(287, 214);
            this.NewPasswordTxtBox.Name = "NewPasswordTxtBox";
            this.NewPasswordTxtBox.Size = new System.Drawing.Size(381, 31);
            this.NewPasswordTxtBox.TabIndex = 1;
            // 
            // ChangePasswordBtn
            // 
            this.ChangePasswordBtn.Location = new System.Drawing.Point(232, 288);
            this.ChangePasswordBtn.Name = "ChangePasswordBtn";
            this.ChangePasswordBtn.Size = new System.Drawing.Size(198, 60);
            this.ChangePasswordBtn.TabIndex = 2;
            this.ChangePasswordBtn.Text = "Change Password";
            this.ChangePasswordBtn.UseVisualStyleBackColor = true;
            this.ChangePasswordBtn.Click += new System.EventHandler(this.ChangePasswordBtn_Click);
            // 
            // UsernameChangePasswordLabel
            // 
            this.UsernameChangePasswordLabel.AutoSize = true;
            this.UsernameChangePasswordLabel.Location = new System.Drawing.Point(25, 49);
            this.UsernameChangePasswordLabel.Name = "UsernameChangePasswordLabel";
            this.UsernameChangePasswordLabel.Size = new System.Drawing.Size(173, 25);
            this.UsernameChangePasswordLabel.TabIndex = 3;
            this.UsernameChangePasswordLabel.Text = "Enter Username:";
            // 
            // UsernameChangePasswordTxt
            // 
            this.UsernameChangePasswordTxt.Location = new System.Drawing.Point(232, 49);
            this.UsernameChangePasswordTxt.Name = "UsernameChangePasswordTxt";
            this.UsernameChangePasswordTxt.Size = new System.Drawing.Size(436, 31);
            this.UsernameChangePasswordTxt.TabIndex = 4;
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Location = new System.Drawing.Point(25, 137);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(208, 25);
            this.OldPasswordLabel.TabIndex = 5;
            this.OldPasswordLabel.Text = "Enter Old Password:";
            // 
            // OldPasswordTxt
            // 
            this.OldPasswordTxt.Location = new System.Drawing.Point(250, 137);
            this.OldPasswordTxt.Name = "OldPasswordTxt";
            this.OldPasswordTxt.Size = new System.Drawing.Size(418, 31);
            this.OldPasswordTxt.TabIndex = 6;
            // 
            // ChangePasswordUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 383);
            this.Controls.Add(this.OldPasswordTxt);
            this.Controls.Add(this.OldPasswordLabel);
            this.Controls.Add(this.UsernameChangePasswordTxt);
            this.Controls.Add(this.UsernameChangePasswordLabel);
            this.Controls.Add(this.ChangePasswordBtn);
            this.Controls.Add(this.NewPasswordTxtBox);
            this.Controls.Add(this.NewPasswordLabel);
            this.Name = "ChangePasswordUser";
            this.Text = "ChangePasswordUser";
            this.Load += new System.EventHandler(this.ChangePasswordUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.TextBox NewPasswordTxtBox;
        private System.Windows.Forms.Button ChangePasswordBtn;
        private System.Windows.Forms.Label UsernameChangePasswordLabel;
        private System.Windows.Forms.TextBox UsernameChangePasswordTxt;
        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.TextBox OldPasswordTxt;
    }
}