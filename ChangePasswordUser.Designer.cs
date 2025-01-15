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
            this.OldPasswordLabel = new System.Windows.Forms.Label();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.OldPasswordTxt = new System.Windows.Forms.TextBox();
            this.NewPasswordTxtBox = new System.Windows.Forms.TextBox();
            this.ChangePasswordBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OldPasswordLabel
            // 
            this.OldPasswordLabel.AutoSize = true;
            this.OldPasswordLabel.Location = new System.Drawing.Point(24, 65);
            this.OldPasswordLabel.Name = "OldPasswordLabel";
            this.OldPasswordLabel.Size = new System.Drawing.Size(208, 25);
            this.OldPasswordLabel.TabIndex = 1;
            this.OldPasswordLabel.Text = "Enter Old Password:";
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Location = new System.Drawing.Point(24, 161);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(223, 25);
            this.NewPasswordLabel.TabIndex = 2;
            this.NewPasswordLabel.Text = "Enter New Password: ";
            // 
            // OldPasswordTxt
            // 
            this.OldPasswordTxt.Location = new System.Drawing.Point(289, 65);
            this.OldPasswordTxt.Name = "OldPasswordTxt";
            this.OldPasswordTxt.Size = new System.Drawing.Size(332, 31);
            this.OldPasswordTxt.TabIndex = 4;
            // 
            // NewPasswordTxtBox
            // 
            this.NewPasswordTxtBox.Location = new System.Drawing.Point(289, 161);
            this.NewPasswordTxtBox.Name = "NewPasswordTxtBox";
            this.NewPasswordTxtBox.Size = new System.Drawing.Size(332, 31);
            this.NewPasswordTxtBox.TabIndex = 5;
            // 
            // ChangePasswordBtn
            // 
            this.ChangePasswordBtn.Location = new System.Drawing.Point(174, 283);
            this.ChangePasswordBtn.Name = "ChangePasswordBtn";
            this.ChangePasswordBtn.Size = new System.Drawing.Size(279, 65);
            this.ChangePasswordBtn.TabIndex = 6;
            this.ChangePasswordBtn.Text = "Change Password";
            this.ChangePasswordBtn.UseVisualStyleBackColor = true;
            this.ChangePasswordBtn.Click += new System.EventHandler(this.ChangePasswordBtn_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "en",
            "ro"});
            this.comboBox1.Location = new System.Drawing.Point(543, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 33);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Change Language";
            // 
            // ChangePasswordUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 456);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ChangePasswordBtn);
            this.Controls.Add(this.NewPasswordTxtBox);
            this.Controls.Add(this.OldPasswordTxt);
            this.Controls.Add(this.NewPasswordLabel);
            this.Controls.Add(this.OldPasswordLabel);
            this.Name = "ChangePasswordUser";
            this.Text = "ChangePasswordUser";
            this.Load += new System.EventHandler(this.ChangePasswordUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label OldPasswordLabel;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.TextBox OldPasswordTxt;
        private System.Windows.Forms.TextBox NewPasswordTxtBox;
        private System.Windows.Forms.Button ChangePasswordBtn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}