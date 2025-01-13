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
    public partial class ManageProductsForm : Form
    {
        public ManageProductsForm()
        {
            InitializeComponent();
            LoadProductsAsync();
            LoadCategoriesAsync();
        }



        private void ProductsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        //    if (e.RowIndex >= 0 && ProductsGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
        //        SellProduct(e);
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

                    ProductsGrid.Invoke(new Action(() =>
                    {
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
                    }));
                }
            });
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
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductsBasedOnCategory();
        }
    }
}
