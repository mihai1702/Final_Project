namespace FInal_Project
{
    partial class AddNewAccount
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
            this.NewUsernameLabel = new System.Windows.Forms.Label();
            this.NewFirstNameLabel = new System.Windows.Forms.Label();
            this.NewLastNameLabel = new System.Windows.Forms.Label();
            this.NewAccountPasswordLabel = new System.Windows.Forms.Label();
            this.NewAccountConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.NewUsernameTxt = new System.Windows.Forms.TextBox();
            this.NewFirstNameTxt = new System.Windows.Forms.TextBox();
            this.NewLastNameTxt = new System.Windows.Forms.TextBox();
            this.NewAccountPasswordTxt = new System.Windows.Forms.TextBox();
            this.NewAccountConfirmPasswordTxt = new System.Windows.Forms.TextBox();
            this.AddAccountBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewUsernameLabel
            // 
            this.NewUsernameLabel.AutoSize = true;
            this.NewUsernameLabel.Location = new System.Drawing.Point(33, 78);
            this.NewUsernameLabel.Name = "NewUsernameLabel";
            this.NewUsernameLabel.Size = new System.Drawing.Size(179, 25);
            this.NewUsernameLabel.TabIndex = 0;
            this.NewUsernameLabel.Text = "Enter Username: ";
            // 
            // NewFirstNameLabel
            // 
            this.NewFirstNameLabel.AutoSize = true;
            this.NewFirstNameLabel.Location = new System.Drawing.Point(33, 177);
            this.NewFirstNameLabel.Name = "NewFirstNameLabel";
            this.NewFirstNameLabel.Size = new System.Drawing.Size(179, 25);
            this.NewFirstNameLabel.TabIndex = 1;
            this.NewFirstNameLabel.Text = "Enter Frist Name:";
            // 
            // NewLastNameLabel
            // 
            this.NewLastNameLabel.AutoSize = true;
            this.NewLastNameLabel.Location = new System.Drawing.Point(33, 272);
            this.NewLastNameLabel.Name = "NewLastNameLabel";
            this.NewLastNameLabel.Size = new System.Drawing.Size(178, 25);
            this.NewLastNameLabel.TabIndex = 2;
            this.NewLastNameLabel.Text = "Enter Last Name:";
            // 
            // NewAccountPasswordLabel
            // 
            this.NewAccountPasswordLabel.AutoSize = true;
            this.NewAccountPasswordLabel.Location = new System.Drawing.Point(33, 358);
            this.NewAccountPasswordLabel.Name = "NewAccountPasswordLabel";
            this.NewAccountPasswordLabel.Size = new System.Drawing.Size(175, 25);
            this.NewAccountPasswordLabel.TabIndex = 3;
            this.NewAccountPasswordLabel.Text = "Enter Password: ";
            // 
            // NewAccountConfirmPasswordLabel
            // 
            this.NewAccountConfirmPasswordLabel.AutoSize = true;
            this.NewAccountConfirmPasswordLabel.Location = new System.Drawing.Point(33, 441);
            this.NewAccountConfirmPasswordLabel.Name = "NewAccountConfirmPasswordLabel";
            this.NewAccountConfirmPasswordLabel.Size = new System.Drawing.Size(192, 25);
            this.NewAccountConfirmPasswordLabel.TabIndex = 4;
            this.NewAccountConfirmPasswordLabel.Text = "Confirm Password:";
            // 
            // NewUsernameTxt
            // 
            this.NewUsernameTxt.Location = new System.Drawing.Point(253, 78);
            this.NewUsernameTxt.Name = "NewUsernameTxt";
            this.NewUsernameTxt.Size = new System.Drawing.Size(469, 31);
            this.NewUsernameTxt.TabIndex = 5;
            // 
            // NewFirstNameTxt
            // 
            this.NewFirstNameTxt.Location = new System.Drawing.Point(253, 177);
            this.NewFirstNameTxt.Name = "NewFirstNameTxt";
            this.NewFirstNameTxt.Size = new System.Drawing.Size(469, 31);
            this.NewFirstNameTxt.TabIndex = 6;
            // 
            // NewLastNameTxt
            // 
            this.NewLastNameTxt.Location = new System.Drawing.Point(253, 272);
            this.NewLastNameTxt.Name = "NewLastNameTxt";
            this.NewLastNameTxt.Size = new System.Drawing.Size(469, 31);
            this.NewLastNameTxt.TabIndex = 7;
            // 
            // NewAccountPasswordTxt
            // 
            this.NewAccountPasswordTxt.Location = new System.Drawing.Point(253, 358);
            this.NewAccountPasswordTxt.Name = "NewAccountPasswordTxt";
            this.NewAccountPasswordTxt.Size = new System.Drawing.Size(469, 31);
            this.NewAccountPasswordTxt.TabIndex = 8;
            // 
            // NewAccountConfirmPasswordTxt
            // 
            this.NewAccountConfirmPasswordTxt.Location = new System.Drawing.Point(253, 441);
            this.NewAccountConfirmPasswordTxt.Name = "NewAccountConfirmPasswordTxt";
            this.NewAccountConfirmPasswordTxt.Size = new System.Drawing.Size(469, 31);
            this.NewAccountConfirmPasswordTxt.TabIndex = 9;
            // 
            // AddAccountBtn
            // 
            this.AddAccountBtn.Location = new System.Drawing.Point(209, 525);
            this.AddAccountBtn.Name = "AddAccountBtn";
            this.AddAccountBtn.Size = new System.Drawing.Size(344, 76);
            this.AddAccountBtn.TabIndex = 10;
            this.AddAccountBtn.Text = "Create Account";
            this.AddAccountBtn.UseVisualStyleBackColor = true;
            this.AddAccountBtn.Click += new System.EventHandler(this.AddAccountBtn_Click);
            // 
            // AddNewAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 645);
            this.Controls.Add(this.AddAccountBtn);
            this.Controls.Add(this.NewAccountConfirmPasswordTxt);
            this.Controls.Add(this.NewAccountPasswordTxt);
            this.Controls.Add(this.NewLastNameTxt);
            this.Controls.Add(this.NewFirstNameTxt);
            this.Controls.Add(this.NewUsernameTxt);
            this.Controls.Add(this.NewAccountConfirmPasswordLabel);
            this.Controls.Add(this.NewAccountPasswordLabel);
            this.Controls.Add(this.NewLastNameLabel);
            this.Controls.Add(this.NewFirstNameLabel);
            this.Controls.Add(this.NewUsernameLabel);
            this.Name = "AddNewAccount";
            this.Text = "AddNewAccount";
            this.Load += new System.EventHandler(this.AddNewAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewUsernameLabel;
        private System.Windows.Forms.Label NewFirstNameLabel;
        private System.Windows.Forms.Label NewLastNameLabel;
        private System.Windows.Forms.Label NewAccountPasswordLabel;
        private System.Windows.Forms.Label NewAccountConfirmPasswordLabel;
        private System.Windows.Forms.TextBox NewUsernameTxt;
        private System.Windows.Forms.TextBox NewFirstNameTxt;
        private System.Windows.Forms.TextBox NewLastNameTxt;
        private System.Windows.Forms.TextBox NewAccountPasswordTxt;
        private System.Windows.Forms.TextBox NewAccountConfirmPasswordTxt;
        private System.Windows.Forms.Button AddAccountBtn;
    }
}