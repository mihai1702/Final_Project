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
    public partial class AddCategoryForm : Form
    {
        public AddCategoryForm()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(AddCategoryFormClosing);
        }
        private void AddCategoryFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["ManageProductsForm"].Show();
        }

        private void AddCategoryButton_Click(object sender, EventArgs e)
        {
            using (ProductDbContext db = new ProductDbContext())
            {
                DbSet<Category> categories = db.Categories;
                Category category = new Category();
                category.categoryName = AddCategoryTextBox.Text;
                db.Categories.Add(category);
                db.SaveChanges();
                MessageBox.Show("Categorie adaugata cu succces");
                AddCategoryTextBox.Text = "";
            }
        }
    }
}
