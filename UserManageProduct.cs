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
    public partial class UserManageProduct : Form
    {
        public UserManageProduct()
        {
            InitializeComponent();
            LoadProductsAsync();
        }

        public async Task LoadProductsAsync()
        {
            await Task.Run(() =>
            {
                using (ProductDbContext db = new ProductDbContext())
                {
                    try
                    {
                        db.Database.Connection.Open();
                        Console.WriteLine("Conexiune reusita");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                    DbSet<Product> products = db.Products;

                    ProductGridView.Invoke(new Action(() =>
                    {
                        ProductGridView.Rows.Clear();
                        foreach (Product product in products)
                        {
                            ProductGridView.Rows.Add(
                                product.ProductID,
                                product.ProductName,
                                product.ProductDescription,
                                product.EnteringDate,
                                product.ExpDate,
                                product.Stock,
                                product.Price
                            );
                        }
                    }));
                }
            });
        }
        private void UserManageProduct_Load(object sender, EventArgs e)
        {

        }

        private void cHANGEPASSWORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordUser changePasswordUser = new ChangePasswordUser();
            changePasswordUser.Show();
        }

        private void uPDATEINFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateInfoUser updateInfoUser = new UpdateInfoUser();
            updateInfoUser.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
