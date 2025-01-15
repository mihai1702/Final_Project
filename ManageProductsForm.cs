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
    public partial class ManageProductsForm : Form
    {
        public ManageProductsForm()
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

        public void SellProduct(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int productID = Convert.ToInt32(ProductsGrid.Rows[e.RowIndex].Cells["IDProductColumn"].Value);
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
                                MessageBox.Show("Ai vandut cu succes " + Quantity + " bucati");

                                DbSet<sellHistory> sells = db.sellsHistory;
                                sellHistory sell = new sellHistory();
                                sell.ProductID = product.ProductID;
                                sell.ProductName = product.ProductName;
                                sell.Stock = Quantity;
                                db.sellsHistory.Add(sell);

                                try
                                {
                                    string filepath = "sells.xml";
                                    XMLcommands.Class1.SaveToXML(filepath, sell.ProductID, sell.ProductName, sell.Stock);
                                    MessageBox.Show("Produs adăugat!");
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.Message);
                                }


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

        private void ProductsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && ProductsGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                SellProduct(e);
        }
        private void ProductsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SellProduct(e);
        }
        public void LoadProductsAsync()
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

                    
                        ProductsGrid.Rows.Clear();
                        foreach (Product product in products)
                        {
                            ProductsGrid.Rows.Add(
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
        public void LoadProductsBasedOnCategory()
        {
            using (ProductDbContext db = new ProductDbContext())
            {
                DbSet<Product> products = db.Products;
                DbSet<Category> categories = db.Categories;
                ProductsGrid.Rows.Clear();
                    foreach (Category category in categories)
                    {
                        if (CategoryComboBox.Text.Equals(category.categoryName))
                        {
                            foreach (Product product in products)
                            {
                                if (category.categoryID == product.CategoryID)
                                {
                                    ProductsGrid.Rows.Add(
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
                    CategoryComboBox.Invoke(new Action(() =>
                    {
                        DbSet<Category> categories = db.Categories;
                        CategoryComboBox.Items.Clear();
                        foreach (Category category in categories)
                        {
                            CategoryComboBox.Items.Add(
                                category.categoryName
                                );
                        }
                    }));
                }
            });
        }

        private void SearchProductButton_Click(object sender, EventArgs e)
        {
            using (ProductDbContext db = new ProductDbContext())
            {
                DbSet<Product> products = db.Products;
                ProductsGrid.Rows.Clear();
                foreach (Product product in products)
                {
                    if (product.ProductName.ToLower().Contains(SearchProductBox.Text.ToLower()))
                    {
                        ProductsGrid.Rows.Add(
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

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            LoadProductsAsync();
            CategoryComboBox.Text="";
            LoadCategoriesAsync();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductsBasedOnCategory();
        }

        private void newProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewProductForm addNewProductForm = new AddNewProductForm();
            addNewProductForm.Show();
            this.Hide();
        }

        private void existingProducsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddExistingProduct addExistingProductForm = new AddExistingProduct();
            addExistingProductForm.Show();
            this.Hide();
        }

        private void ChangeLanguageComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(ChangeLanguageComboBox.Text);
            ApplyTranslation();
        }
        private void ApplyTranslation()
        {
            RefreshButton.Text = Languages.Strings.RefreshButton;
            ChangeLanguageLabel.Text= Languages.Strings.ChangeLanguageLabel;
            ChooseCategoryLabel.Text= Languages.Strings.ChooseCategoryLabel;
            menuToolStripMenuItem.Text=Languages.Strings.menuToolStripMenuItem;
            addProductToolStripMenuItem.Text = Languages.Strings.addProductToolStripMenuItem;
            sellsHistoryToolStripMenuItem.Text=Languages.Strings.sellsHistoryToolStripMenuItem;
            newProductToolStripMenuItem.Text = Languages.Strings.newProductToolStripMenuItem;
            existingProducsToolStripMenuItem.Text = Languages.Strings.existingProducsToolStripMenuItem;
            SearchProductButton.Text = Languages.Strings.SearchProductButton;
            ProductColumn.HeaderText = Languages.Strings.ProductColumn;
            IDProductColumn.HeaderText= Languages.Strings.IDProductColumn;
            ProductDescription.HeaderText = Languages.Strings.ProductDescription;
            EnteringDateColumn.HeaderText = Languages.Strings.EnteringDateColumn;
            ExpDateColumn.HeaderText=Languages.Strings.ExpDateColumn;
            StockColumn.HeaderText = Languages.Strings.StockColumn;
            PriceColumn.HeaderText = Languages.Strings.PriceColumn;
            SellProductColumn.HeaderText = Languages.Strings.SellProductColumn;
            manageUsersToolStripMenuItem.Text= Languages.Strings.manageUsersToolStripMenuItem;
            addUserToolStripMenuItem.Text = Languages.Strings.addUserToolStripMenuItem;
            newAdminToolStripMenuItem.Text=Languages.Strings.newAdminToolStripMenuItem;
            newUserToolStripMenuItem.Text=Languages.Strings .newUserToolStripMenuItem;
            deleteAccountToolStripMenuItem.Text=Languages.Strings.deleteAccountToolStripMenuItem;
            changePasswordToolStripMenuItem.Text=Languages.Strings.changePasswordToolStripMenuItem;
            updateInfoToolStripMenuItem.Text=Languages.Strings .updateInfoToolStripMenuItem;
            logOutToolStripMenuItem.Text=Languages.Strings.logOutToolStripMenuItem;

        }

        private void sellsHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistoryForm historyForm = new HistoryForm();
            historyForm.Show();
            this.Hide();
        }

        private void addCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCategoryForm addCategoryForm= new AddCategoryForm();
            addCategoryForm.Show();
            this.Hide();
        }

        private void deleteCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCategory deleteCategory = new DeleteCategory();
            deleteCategory.Show();
            this.Hide();
        }

        private void ManageProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void newAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddAccount("Admin");
        }

        private void newUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenAddAccount("User");
        }

        private void OpenAddAccount(string role)
        {
            AddNewAccount addNewAccount = new AddNewAccount(role);
            addNewAccount.Show();
        }


        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteAccount deleteAccount = new DeleteAccount();
            deleteAccount.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordUser changePasswordUser = new ChangePasswordUser();
            changePasswordUser.Show();
        }

        private void updateInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateInfoUser updateInfoUser = new UpdateInfoUser();
            updateInfoUser.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form2 = new Form1();
            form2.Show();
            this.Hide();
        }
    }
}
