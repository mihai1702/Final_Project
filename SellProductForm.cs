using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInal_Project
{
    public partial class SellProductForm : Form
    {
        public int quantity { get; set; }
        public SellProductForm()
        {
            InitializeComponent();
        }

        private void SellButton_Click(object sender, EventArgs e)
        {
            quantity = (int)SellNumericUpDown.Value;
            Console.WriteLine("cantitatea hshs" + " " + quantity);
            this.Close();
        }

        private void SellProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}
