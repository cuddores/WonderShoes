using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WonderShoes.AppForms;
using WonderShoes.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WonderShoes.CustomUserControl
{
    public partial class ShoesUserControl : UserControl
    {
        private Products _products;
        private int currentProductId;

        public ShoesUserControl(Products products)
        {
            InitializeComponent();
            _products = products;
            SetInfo();
            LoadSizes();
        }

        private void SetInfo()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectPath = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            string imagePath = Path.Combine(projectPath, "Resources", _products.Image.Trim());

            if (File.Exists(imagePath))
            {
                Shoes_Image.Image = Image.FromFile(imagePath);
            }
            Factory_Name_Label.Text = $"{_products.Factories.Factory_Name} | {_products.Product_Name}";
            Category_Label.Text = $"Категория: {_products.Categories.Category_Name}";
            Stock_Label.Text = $"Количество: {_products.Product_Stock.Sum(s => s.Quantity).ToString()}" ;
            Composition_Label.Text = $"Состав: {_products.Composition}";
            Price_Label.Text = $"Цена: {_products.Price.ToString():F2} руб.";
        }

        private void LoadSizes()
        {
            var sizes = _products.Product_Stock
                .Where(s => s.Quantity > 0)
                .Select(s => s.Size.ToString())
                .Distinct()
                .ToList();

            comboBox_Size.DataSource = sizes;
            AddToCart_Btn.Enabled = sizes.Count > 0;
            comboBox_Size.SelectedIndex = -1;
        }

        private void AddToCart_Btn_Click(object sender, EventArgs e)
        {
            if (comboBox_Size.SelectedItem == null)
            {
                MessageBox.Show("Выберите размер", "Корзина", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
        }

    }
}
