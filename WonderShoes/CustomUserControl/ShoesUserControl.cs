using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WonderShoes.Models;
using WonderShoes.AppForms;
using System.Resources;
using System.IO;

namespace WonderShoes.CustomUserControl
{
    public partial class ShoesUserControl : UserControl
    {
        private Products _products;
        public ShoesUserControl(Products products)
        {
            InitializeComponent();
            _products = products;
            SetInfo();
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
    }
}
