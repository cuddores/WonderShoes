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
using WonderShoes.CustomUserControl;
using System.IO;
using System.Text.RegularExpressions;

namespace WonderShoes.CustomUserControl
{
    public partial class CartUserControl : UserControl
    {
        private CartItem _item;
        private Products _products;
        public CartUserControl()
        {
            InitializeComponent();
        }

        public CartUserControl(CartItem item) : this()
        {
            _item = item;
            QuantityShoes.Value = item.Quantity;
            var quantityS = QuantityShoes.Value;

            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string projectPath = Directory.GetParent(baseDirectory).Parent.Parent.FullName;
            string imagePath = Path.Combine(projectPath, "Resources", item.Product.Image.Trim());

            if (File.Exists(imagePath))
            {
                Shoes_Image.Image = Image.FromFile(imagePath);
            }

            Shoes_Type_Label.Text = item.Product.Categories.Category_Name;
            label1.Text = item.Product.Product_Name;
            ShoesSize.Text = $"Размер: {item.Size}";
            PriceCart_Label.Text = $"Цена: {item.Product.Price} руб.";
            Cost_Label.Text = $"Стоимость: {item.Product.Price * quantityS} руб.";
        }

        private void QuantityShoes_ValueChanged(object sender, EventArgs e)
        {
            if (_item == null) return;

            _item.Quantity = (int)QuantityShoes.Value;
            Cost_Label.Text = $"Стоимость: {_item.Product.Price * QuantityShoes.Value} руб.";
        }
    }
}
