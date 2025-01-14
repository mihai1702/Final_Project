using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInal_Project
{
    [Table("SellingHistory")]
    public class sellHistory
    {
        [Key]
        public int SellID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
    }
}
