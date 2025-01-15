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
    public partial class DeleteCategory : Form
    {
        public DeleteCategory()
        {
            InitializeComponent();
            this.FormClosing += new FormClosingEventHandler(DeleteCategoryFormClosing);
        }
        private void DeleteCategoryFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["ManageProductsForm"].Show();
        }

        private void DeleteCategoryButton_Click(object sender, EventArgs e)
        {
            bool gasit=false;
            string deleteCategoryString=DeleteCategoryTextBox.Text;
            using (ProductDbContext db = new ProductDbContext()) 
            { 
                DbSet<Category> categories = db.Categories;
                foreach (Category category in categories) 
                {
                    if (category.categoryName.Equals(deleteCategoryString))
                    {
                        gasit = true;
                        db.Categories.Remove(category);
                        MessageBox.Show("Category deleted successfully");
                        this.FormClosing += new FormClosingEventHandler(DeleteCategoryFormClosing);
                    }
                }
                db.SaveChanges();
                if (gasit == false)
                {
                    MessageBox.Show("Category not found");
                }
            }
        }
    }
}
