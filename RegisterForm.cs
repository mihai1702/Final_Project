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
                account.Username = Username_txtBox.Text;
                account.FirstName = FirstName_txtBox.Text;
                account.LastName= LastName_txtBox.Text;
                string password = Password_maskedTxt.Text;
                string confirm_password=ConfirmPassword_maskedTxt.Text;
                if(password == confirm_password)
                {
                    account.Password = password;
                }
                else
                {
                    MessageBox.Show("Oops! The passwords don’t match. Please try again!");
                }
                db.Accounts.Add(account);
                db.SaveChanges();
            }
        }
    }
}
