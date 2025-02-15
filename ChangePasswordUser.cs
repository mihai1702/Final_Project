﻿using System;
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
    public partial class ChangePasswordUser : Form
    {

        public ChangePasswordUser()
        {
            InitializeComponent();

        }

        private void ChangePasswordUser_Load(object sender, EventArgs e)
        {

        }

        private void ChangePasswordBtn_Click_1(object sender, EventArgs e)
        {
            SHA256 sHA256 = SHA256.Create();
            byte[] input = Encoding.UTF8.GetBytes(NewPasswordTxtBox.Text);
            byte[] hash = sHA256.ComputeHash(input);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x2")); // se transforma fiecare bit in hexa pe 2 caractere - "x2"
            }
            string newpass = sb.ToString();
            //string user = UsernameChangePasswordTxt.Text;

            sHA256 = SHA256.Create();
            input = Encoding.UTF8.GetBytes(OldPasswordTxt.Text);
            hash = sHA256.ComputeHash(input);
            StringBuilder sbb = new StringBuilder();
            foreach (byte b in hash)
            {
                sbb.Append(b.ToString("x2")); // se transforma fiecare bit in hexa pe 2 caractere - "x2"
            }
            string oldpass = sbb.ToString();

            using (ProductDbContext db = new ProductDbContext())
            {
                DbSet<Account> accounts = db.Accounts;
                foreach (Account account in accounts)
                {
                    if (account.Username == Properties.Settings.Default.SavedUsername)
                    {
                        if (account.Password == oldpass)
                        {
                            account.Password = newpass;
                            MessageBox.Show("Password successfully changed!");
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect old passowrd! Please try again!");
                            OldPasswordTxt.Text = "";
                            NewPasswordTxtBox.Text = "";
                        }

                    }
                }
                db.SaveChanges();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(comboBox1.Text);
            ApplyTranslation();
        }
        private void ApplyTranslation()
        {
            label1.Text = Languages.Strings.ChangeLanguageLabel;
            OldPasswordLabel.Text = Languages.Strings.OldPasswordLabel;
            NewPasswordLabel.Text= Languages.Strings.NewPasswordLabel;
            ChangePasswordBtn.Text = Languages.Strings.ChangePasswordBtn;
        }
    }
}
