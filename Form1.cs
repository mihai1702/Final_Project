using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FInal_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ManageProductsForm manageProducts=new ManageProductsForm();
            manageProducts.Show();
        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salut");
        }

        private void ChooseLanguageBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(ChooseLanguageBox.Text);
            ApplyTranslation();
        }
        private void ApplyTranslation()
        {
            PasswordLabel.Text = Languages.Strings.PasswordLabel;
            InfoRegLabel.Text = Languages.Strings.InfoRegLabel;
            RegisterLabel.Text = Languages.Strings.RegisterLabel;
        }
    }
}
