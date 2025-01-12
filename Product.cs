using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace FInal_Project
{
    [Table("Products")]
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string EnteringDate { get; set; }
        public string ExpDate { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
    }

    public class ProductDbContext : DbContext
    {
        public ProductDbContext() : base("name=MagazinDbContext")
        {
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
