using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInal_Project
{
    public partial class UpdateInfoUser : Form
    {
        public UpdateInfoUser()
        {
            InitializeComponent();
        }

        private void UpdateInfoUser_Load(object sender, EventArgs e)
        {
            
        }

        private void UpdateInfoBtn_Click(object sender, EventArgs e)
        {
            string user = UsernameUpdateInfoTxt.Text;
            SHA256 sHA256 = SHA256.Create();
            byte[] input = Encoding.UTF8.GetBytes(PasswordUpdateInfoTxt.Text);
            byte[] hash = sHA256.ComputeHash(input);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hash)
            {
                sb.Append(b.ToString("x2")); // se transforma fiecare bit in hexa pe 2 caractere - "x2"
            }
            string pass = sb.ToString();
            string newFirstName = NewFirstNameTxt.Text;
            string newLastName = NewLastNameTxt.Text;
            using (ProductDbContext db = new ProductDbContext())
            {
                DbSet<Account> accounts = db.Accounts;
                foreach (Account account in accounts)
                {
                    if (account.Username == user)
                    {
                        if (account.Password == pass)
                        {
                            if (!string.IsNullOrEmpty(newFirstName))
                                account.FirstName = newFirstName;
                            if (!string.IsNullOrEmpty(newLastName))
                                account.LastName = newLastName;
                            MessageBox.Show("Info updated successfully!");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Oops! Incorrect username os password! Please try again!");
                            UsernameUpdateInfoTxt.Text = "";
                            PasswordUpdateInfoTxt.Text = "";
                            NewFirstNameTxt.Text = "";
                            NewLastNameTxt.Text = "";
                        }
                    }
                }
                db.SaveChanges();
            }
        }
    }
}
