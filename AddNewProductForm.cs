﻿using System;
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
    public partial class AddNewProductForm : Form
    {
        public AddNewProductForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(AddProductFormClosing);
        }
        private void AddProductFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["ManageproductsForm"].Show();
        }

        private void AddProductButton_Click(object sender, EventArgs e)
        {
            int prodID = 0;
            using (ProductDbContext db = new ProductDbContext())
            {
                DbSet<Category> categories = db.Categories;
                foreach (Category cat in categories)
                {
                    if (cat.categoryName.Equals(CategoryComboBox.Text))
                        prodID = cat.categoryID;
                }
            }


            Console.WriteLine("id haha " + prodID);
            Product product = new Product
            {
                ProductName = ProductNameTextBox.Text,
                ProductDescription = ProductDescriptionTextBox.Text,
                EnteringDate = EnteringTimeDateTimePicker.Text,
                ExpDate = ExpDateDateTimePicker.Text,
                Stock = int.Parse(StockUpDown.Text),
                Price = decimal.Parse(PriceTextBox.Text),
                CategoryID = prodID

            };
            using (ProductDbContext db = new ProductDbContext())
            {
                db.Products.Add(product);
                db.SaveChanges();
            }
            ProductNameTextBox.Text = "";
            ProductDescriptionTextBox.Text = "";
            EnteringTimeDateTimePicker.Text = "";
            ExpDateDateTimePicker.Text = "";
            StockUpDown.Text = "";
            PriceTextBox.Text = "";
            CategoryComboBox.Text = " ";
            MessageBox.Show("Produs adaugat cu succes!");
        }

        private void AddNewProductForm_Load(object sender, EventArgs e)
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

                DbSet<Category> categories = db.Categories;
                CategoryComboBox.Items.Clear();
                foreach (Category category in categories)
                {
                    CategoryComboBox.Items.Add(
                        category.categoryName
                        );
                }
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChooseLanguageNewProductComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(ChooseLanguageNewProductComboBox.Text);
            ApplyTranslation();
        }
        private void ApplyTranslation()
        {

            ProductNameLabel.Text = Languages.Strings.ProductNameLabel;
            ProductDescriptionLabel.Text = Languages.Strings.ProductDescriptionLabel;
            EnteringDateLabel.Text = Languages.Strings.EnteringDateLabel;
            ExpiringDateLabel.Text = Languages.Strings.ExpiringDateLabel;
            CategoryLabel.Text = Languages.Strings.CategoryLabel;
            StockLabel.Text = Languages.Strings.StockLabel;
            PriceLabel.Text = Languages.Strings.PriceLabel;
            AddProductButton.Text = Languages.Strings.AddProductButton;
            ChooseLanguageNewProductLabel.Text=Languages.Strings.ChooseLanguageNewProductLabel;
        }
    }
}
