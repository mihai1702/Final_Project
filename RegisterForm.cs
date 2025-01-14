using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace FInal_Project
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void Register_Btn_Click(object sender, EventArgs e)
        {
            using (ProductDbContext db = new ProductDbContext())
            {
                Account account = new Account();
                DbSet<Account> accounts = db.Accounts;

                SHA256 sHA256 = SHA256.Create();
                byte[] input = Encoding.UTF8.GetBytes(Password_maskedTxt.Text);
                byte[] hash = sHA256.ComputeHash(input);
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sb.Append(b.ToString("x2")); // se transforma fiecare bit in hexa pe 2 caractere - "x2"
                }
                string password = sb.ToString();

                sHA256 = SHA256.Create();
                input = Encoding.UTF8.GetBytes(ConfirmPassword_maskedTxt.Text);
                hash = sHA256.ComputeHash(input);
                StringBuilder sbb = new StringBuilder();
                foreach (byte b in hash)
                {
                    sbb.Append(b.ToString("x2")); // se transforma fiecare bit in hexa pe 2 caractere - "x2"
                }
                string confirm_password = sbb.ToString();

                string isUsername=Username_txtBox.Text;
                foreach(Account acc in accounts)
                {
                    if(acc.Username==isUsername)
                    {
                        MessageBox.Show("The username already exists. Please enter a different username!");
                        return;
                    }
                }
                if(password == confirm_password)
                {
                    account.Password = password;
                    account.Username = Username_txtBox.Text;
                    account.FirstName = FirstName_txtBox.Text;
                    account.LastName = LastName_txtBox.Text;
                    db.Accounts.Add(account);
                    db.SaveChanges();
                    MessageBox.Show("You're all set! Your account has been created successfully.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Oops! The passwords don’t match. Please try again!");
                }
                
            }
            
        }
    }
}
