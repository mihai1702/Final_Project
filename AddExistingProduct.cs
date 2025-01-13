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
    public partial class AddExistingProduct : Form
    {
        public AddExistingProduct()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(AddProductFormClosing);

        }
        private void AddProductFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["ManageProductsForm"].Show();
        }
        private void AddExistingProductButton_Click(object sender, EventArgs e)
        {
            int id = int.Parse(AddExistingProductTextBox.Text);
            int count = (int)AddExistingProductUpDown.Value;
            using (ProductDbContext db = new ProductDbContext())
            {
                DbSet<Product> products = db.Products;
                foreach (Product product in products)
                {
                    if (Object.Equals(product.ProductID, id))
                    {
                        product.Stock = product.Stock + count;
                        MessageBox.Show("Produs adaugat cu succes");
                        db.SaveChanges();
                        this.Close();
                    }
                }

            }
        }
    }
}
