using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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
            LoadCategoriesAsync();
            this.FormClosing += new FormClosingEventHandler(ManageProducts_FormClosing);
        }
        private void ManageProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
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

        public async Task LoadCategoriesAsync()
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
                    UserProductComboBox.Invoke(new Action(() =>
                    {
                        DbSet<Category> categories = db.Categories;
                        UserProductComboBox.Items.Clear();
                        foreach (Category category in categories)
                        {
                            UserProductComboBox.Items.Add(
                                category.categoryName
                                );
                        }
                    }));
                }
            });
        }
        private void UserManageProduct_Load(object sender, EventArgs e)
        {

        }

        //private void cHANGEPASSWORDToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    ChangePasswordUser changePasswordUser = new ChangePasswordUser();
        //    changePasswordUser.Show();
        //}

        //private void uPDATEINFOToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    UpdateInfoUser updateInfoUser = new UpdateInfoUser();
        //    updateInfoUser.Show();
        //}

        //private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Form1 form1 = new Form1();
        //    form1.Show();
        //    this.Close();
        //}

        private void changePasswordToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ChangePasswordUser changePasswordUser = new ChangePasswordUser();
            changePasswordUser.Show();
        }

        private void updateInfoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            UpdateInfoUser updateInfoUser = new UpdateInfoUser();
            updateInfoUser.Show();
        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void UserSearchProductBtn_Click(object sender, EventArgs e)
        {
            using (ProductDbContext db = new ProductDbContext())
            {
                DbSet<Product> products = db.Products;
                ProductGridView.Rows.Clear();
                foreach (Product product in products)
                {
                    if (product.ProductName.ToLower().Contains(UserSearchProductTxt.Text.ToLower()))
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
                }

            }
        }

        private void UserRefreshBtn_Click(object sender, EventArgs e)
        {
            LoadProductsAsync();
            UserProductComboBox.Text = "";
            LoadCategoriesAsync();
        }

        private void UserProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductsBasedOnCategory();
        }

        public void LoadProductsBasedOnCategory()
        {
            using (ProductDbContext db = new ProductDbContext())
            {
                DbSet<Product> products = db.Products;
                DbSet<Category> categories = db.Categories;
                ProductGridView.Rows.Clear();
                foreach (Category category in categories)
                {
                    if (UserProductComboBox.Text.Equals(category.categoryName))
                    {
                        foreach (Product product in products)
                        {
                            if (category.categoryID == product.CategoryID)
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
                        }
                    }
                }
            }
        }

        private void ProductGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && ProductGridView.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                SellProduct(e);
            }
        }

        public void SellProduct(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int productID = Convert.ToInt32(ProductGridView.Rows[e.RowIndex].Cells["ProductID_Column"].Value);
                Console.WriteLine(productID);
                using (ProductDbContext db = new ProductDbContext())
                {
                    DbSet<Product> products = db.Products;
                    foreach (Product product in products)
                    {
                        if (Object.Equals(product.ProductID, productID))
                        {
                            SellProductForm SellProductForm = new SellProductForm();
                            SellProductForm.ShowDialog();
                            int Quantity = SellProductForm.quantity;
                            Console.WriteLine("Cantitate: " + Quantity);
                            if (Quantity == 0)
                                return;
                            else if (Quantity > product.Stock)
                            {
                                MessageBox.Show("Stoc insuficient");
                            }
                            else if (Quantity < product.Stock)
                            {
                                product.Stock = product.Stock - Quantity;
                                MessageBox.Show("Ai cumparat cu succes " + Quantity + " bucati");

                                DbSet<sellHistory> sells = db.sellsHistory;
                                sellHistory sell = new sellHistory();
                                sell.ProductID = product.ProductID;
                                sell.ProductName = product.ProductName;
                                sell.Stock = Quantity;
                                db.sellsHistory.Add(sell);


                            }
                            else
                            {
                                db.Products.Remove(product);
                                DbSet<sellHistory> sells = db.sellsHistory;
                                sellHistory sell = new sellHistory();
                                sell.ProductID = product.ProductID;
                                sell.ProductName = product.ProductName;
                                sell.Stock = Quantity;
                                db.sellsHistory.Add(sell);
                                MessageBox.Show("Ai vandut cu succes " + Quantity + " bucati");
                            }
                            db.SaveChanges();
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(comboBox1.Text);
            ApplyTranslation();
        }
        private void ApplyTranslation()
        {
            ChLangUserManageLabel.Text=Languages.Strings.ChangeLanguageLabel;
            menuToolStripMenuItem.Text = Languages.Strings.menuToolStripMenuItem;
            changePasswordToolStripMenuItem.Text=Languages.Strings.changePasswordToolStripMenuItem;
            updateInfoToolStripMenuItem.Text= Languages.Strings.updateInfoToolStripMenuItem;
            logOutToolStripMenuItem.Text=Languages.Strings.logOutToolStripMenuItem;
            UserRefreshBtn.Text=Languages.Strings.RefreshButton;
            UserSearchProductBtn.Text=Languages.Strings.SearchProductButton;
            ProductID_Column.HeaderText = Languages.Strings.IDProductColumn;
            ProductName_Column.HeaderText = Languages.Strings.ProductColumn;
            ProductDescription_Column.HeaderText= Languages.Strings.ProductDescription;
            EnteringDate_Column.HeaderText=Languages.Strings.EnteringDateColumn;
            ExpiringDate_Column.HeaderText = Languages.Strings.ExpDateColumn;
            Stock_Column.HeaderText = Languages.Strings.StockColumn;
            Price_Column.HeaderText = Languages.Strings.PriceColumn;
            Buy_Column.HeaderText = Languages.Strings.BuyColumn;
        }
    }
}
