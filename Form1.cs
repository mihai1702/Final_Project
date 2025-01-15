using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInal_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(LogIn_FormClosing);
        }
        private void LogIn_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void ChooseLanguageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(ChooseLanguageBox.Text);
            ApplyTranslation();
        }
        private void ApplyTranslation()
        {
            PasswordLabel.Text = Languages.Strings.PasswordLabel;
            InfoRegLabel.Text = Languages.Strings.InfoRegLabel;
            RegisterLabel.Text = Languages.Strings.RegisterLabel;
            ChangeLanguageform1Label.Text = Languages.Strings.ChangeLanguageLabel;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            string search = UsernameTextBox.Text;
            bool found = false;
            using (ProductDbContext db = new ProductDbContext())
            {
                DbSet<Account> accounts = db.Accounts;
                foreach (Account account in accounts)
                {
                    if (account.Username == search)
                    {
                        Properties.Settings.Default.SavedUsername = UsernameTextBox.Text;
                        Properties.Settings.Default.Save();
                        found = true;
                        SHA256 sHA256 = SHA256.Create();
                        byte[] input = Encoding.UTF8.GetBytes(PasswordTextBox.Text);
                        byte[] hash = sHA256.ComputeHash(input);
                        StringBuilder sb = new StringBuilder();
                        foreach (byte b in hash)
                        {
                            sb.Append(b.ToString("x2")); // se transforma fiecare bit in hexa pe 2 caractere - "x2"
                        }
                        string pass = sb.ToString();
                        if (pass == account.Password)
                        {
                            if (account.Role == "Admin")
                            {
                                ManageProductsForm manageProductsForm = new ManageProductsForm();
                                manageProductsForm.Show();
                                this.Hide();
                            }
                            if (account.Role == "User")
                            {
                                UserManageProduct userManageProductForm = new UserManageProduct();
                                userManageProductForm.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Oops! Password is incorrect :(");
                        }
                    }
                }
                if (found == false)
                    MessageBox.Show("Oops! Username is incorrect :(");
            }
        }
    }
}
