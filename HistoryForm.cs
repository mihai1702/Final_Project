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
    public partial class HistoryForm : Form
    {
        public HistoryForm()
        {
            InitializeComponent();
            LoadSellHistory();
            this.FormClosing += new FormClosingEventHandler(HistoryFormClosing);
        }
        private void HistoryFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.OpenForms["ManageProductsForm"].Show();
        }
        public void LoadSellHistory()
        {
            using (ProductDbContext db = new ProductDbContext())
            {
                DbSet<sellHistory> sellshistory = db.sellsHistory;
                sellsHistoryDataGridView.Rows.Clear();
                foreach (sellHistory sellHistory in sellshistory)
                {
                    sellsHistoryDataGridView.Rows.Add(
                        sellHistory.SellID,
                        sellHistory.ProductID,
                        sellHistory.ProductName,
                        sellHistory.Stock
                        );
                }
            }
        }
        private void HistoryForm_Load(object sender, EventArgs e)
        {

        }

        private void sellsHistoryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchSellButton_Click(object sender, EventArgs e)
        {
            using (ProductDbContext db = new ProductDbContext())
            {
                DbSet<sellHistory> sells = db.sellsHistory;
                sellsHistoryDataGridView.Rows.Clear();
                foreach (sellHistory sell in sells)
                {
                    if (sell.ProductName.ToLower().Contains(SearchSellTextBox.Text.ToLower()))
                    {
                        sellsHistoryDataGridView.Rows.Add(
                        sell.SellID,
                        sell.ProductID,
                        sell.ProductName,
                        sell.Stock
                        );
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
            label1.Text = Languages.Strings.ChangeLanguageLabel;
            SearchSellButton.Text=Languages.Strings.SearchProductButton;
            SellIDColumn.HeaderText = Languages.Strings.SellIDColumn;
            ProductIDColumn.HeaderText = Languages.Strings.IDProductColumn;
            ProductNameColumn.HeaderText = Languages.Strings.ProductColumn;
            SellStockColumn.HeaderText = Languages.Strings.SellStockColumn;

        }
    }
}
