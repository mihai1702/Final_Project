namespace FInal_Project
{
    partial class RegisterForm
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
            this.Reg_Usename_Label = new System.Windows.Forms.Label();
            this.Reg_FirstName_Label = new System.Windows.Forms.Label();
            this.Reg_LastName_Label = new System.Windows.Forms.Label();
            this.Reg_Password_Label = new System.Windows.Forms.Label();
            this.Confirm_Password_Label = new System.Windows.Forms.Label();
            this.Username_txtBox = new System.Windows.Forms.TextBox();
            this.FirstName_txtBox = new System.Windows.Forms.TextBox();
            this.LastName_txtBox = new System.Windows.Forms.TextBox();
            this.Password_maskedTxt = new System.Windows.Forms.MaskedTextBox();
            this.ConfirmPassword_maskedTxt = new System.Windows.Forms.MaskedTextBox();
            this.Register_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Reg_Usename_Label
            // 
            this.Reg_Usename_Label.AutoSize = true;
            this.Reg_Usename_Label.Location = new System.Drawing.Point(39, 41);
            this.Reg_Usename_Label.Name = "Reg_Usename_Label";
            this.Reg_Usename_Label.Size = new System.Drawing.Size(122, 25);
            this.Reg_Usename_Label.TabIndex = 0;
            this.Reg_Usename_Label.Text = "Username: ";
            // 
            // Reg_FirstName_Label
            // 
            this.Reg_FirstName_Label.AutoSize = true;
            this.Reg_FirstName_Label.Location = new System.Drawing.Point(39, 111);
            this.Reg_FirstName_Label.Name = "Reg_FirstName_Label";
            this.Reg_FirstName_Label.Size = new System.Drawing.Size(122, 25);
            this.Reg_FirstName_Label.TabIndex = 1;
            this.Reg_FirstName_Label.Text = "First Name:";
            // 
            // Reg_LastName_Label
            // 
            this.Reg_LastName_Label.AutoSize = true;
            this.Reg_LastName_Label.Location = new System.Drawing.Point(39, 187);
            this.Reg_LastName_Label.Name = "Reg_LastName_Label";
            this.Reg_LastName_Label.Size = new System.Drawing.Size(121, 25);
            this.Reg_LastName_Label.TabIndex = 2;
            this.Reg_LastName_Label.Text = "Last Name:";
            // 
            // Reg_Password_Label
            // 
            this.Reg_Password_Label.AutoSize = true;
            this.Reg_Password_Label.Location = new System.Drawing.Point(39, 266);
            this.Reg_Password_Label.Name = "Reg_Password_Label";
            this.Reg_Password_Label.Size = new System.Drawing.Size(112, 25);
            this.Reg_Password_Label.TabIndex = 3;
            this.Reg_Password_Label.Text = "Password:";
            // 
            // Confirm_Password_Label
            // 
            this.Confirm_Password_Label.AutoSize = true;
            this.Confirm_Password_Label.Location = new System.Drawing.Point(39, 347);
            this.Confirm_Password_Label.Name = "Confirm_Password_Label";
            this.Confirm_Password_Label.Size = new System.Drawing.Size(192, 25);
            this.Confirm_Password_Label.TabIndex = 4;
            this.Confirm_Password_Label.Text = "Confirm Password:";
            // 
            // Username_txtBox
            // 
            this.Username_txtBox.Location = new System.Drawing.Point(168, 41);
            this.Username_txtBox.Name = "Username_txtBox";
            this.Username_txtBox.Size = new System.Drawing.Size(407, 31);
            this.Username_txtBox.TabIndex = 5;
            // 
            // FirstName_txtBox
            // 
            this.FirstName_txtBox.Location = new System.Drawing.Point(168, 111);
            this.FirstName_txtBox.Name = "FirstName_txtBox";
            this.FirstName_txtBox.Size = new System.Drawing.Size(407, 31);
            this.FirstName_txtBox.TabIndex = 6;
            // 
            // LastName_txtBox
            // 
            this.LastName_txtBox.Location = new System.Drawing.Point(168, 187);
            this.LastName_txtBox.Name = "LastName_txtBox";
            this.LastName_txtBox.Size = new System.Drawing.Size(407, 31);
            this.LastName_txtBox.TabIndex = 7;
            // 
            // Password_maskedTxt
            // 
            this.Password_maskedTxt.Location = new System.Drawing.Point(168, 266);
            this.Password_maskedTxt.Name = "Password_maskedTxt";
            this.Password_maskedTxt.PromptChar = '*';
            this.Password_maskedTxt.Size = new System.Drawing.Size(407, 31);
            this.Password_maskedTxt.TabIndex = 8;
            // 
            // ConfirmPassword_maskedTxt
            // 
            this.ConfirmPassword_maskedTxt.Location = new System.Drawing.Point(238, 347);
            this.ConfirmPassword_maskedTxt.Name = "ConfirmPassword_maskedTxt";
            this.ConfirmPassword_maskedTxt.Size = new System.Drawing.Size(337, 31);
            this.ConfirmPassword_maskedTxt.TabIndex = 9;
            // 
            // Register_Btn
            // 
            this.Register_Btn.Location = new System.Drawing.Point(151, 454);
            this.Register_Btn.Name = "Register_Btn";
            this.Register_Btn.Size = new System.Drawing.Size(330, 67);
            this.Register_Btn.TabIndex = 10;
            this.Register_Btn.Text = "REGISTER";
            this.Register_Btn.UseVisualStyleBackColor = true;
            this.Register_Btn.Click += new System.EventHandler(this.Register_Btn_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 605);
            this.Controls.Add(this.Register_Btn);
            this.Controls.Add(this.ConfirmPassword_maskedTxt);
            this.Controls.Add(this.Password_maskedTxt);
            this.Controls.Add(this.LastName_txtBox);
            this.Controls.Add(this.FirstName_txtBox);
            this.Controls.Add(this.Username_txtBox);
            this.Controls.Add(this.Confirm_Password_Label);
            this.Controls.Add(this.Reg_Password_Label);
            this.Controls.Add(this.Reg_LastName_Label);
            this.Controls.Add(this.Reg_FirstName_Label);
            this.Controls.Add(this.Reg_Usename_Label);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Reg_Usename_Label;
        private System.Windows.Forms.Label Reg_FirstName_Label;
        private System.Windows.Forms.Label Reg_LastName_Label;
        private System.Windows.Forms.Label Reg_Password_Label;
        private System.Windows.Forms.Label Confirm_Password_Label;
        private System.Windows.Forms.TextBox Username_txtBox;
        private System.Windows.Forms.TextBox FirstName_txtBox;
        private System.Windows.Forms.TextBox LastName_txtBox;
        private System.Windows.Forms.MaskedTextBox Password_maskedTxt;
        private System.Windows.Forms.MaskedTextBox ConfirmPassword_maskedTxt;
        private System.Windows.Forms.Button Register_Btn;
    }
}