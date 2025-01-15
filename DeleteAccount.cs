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
    public partial class DeleteAccount : Form
    {
        public DeleteAccount()
        {
            InitializeComponent();
        }

        private void DeleteAccountBtn_Click(object sender, EventArgs e)
        {
            string toDelete= DeleteAccountTxt.Text;
            int gasit = 0;
            using(ProductDbContext db = new ProductDbContext())
            {
                DbSet<Account> accounts = db.Accounts;
                foreach(Account account in accounts)
                {
                    if(account.Username == toDelete)
                    {
                        gasit = 1;
                        db.Accounts.Remove(account);
                        MessageBox.Show("Account deleted successfully!");
                        this.Close();
                    }
                }
                db.SaveChanges();
                if(gasit ==0)
                {
                    MessageBox.Show("Oops! This Username doesn't exist!");
                }
            }
        }
    }
}
