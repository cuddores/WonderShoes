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
        private Users _user;
        private int currentProductId;
        private Color _baseColor;

        public ShoesUserControl(Products products, Users user)
        {
            InitializeComponent();
            _baseColor = this.BackColor;
            _products = products;
            SetInfo();
            LoadSizes();
            UpdateSizeInfo();
            _user = user;
            ApplyRole();

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
        }

        private void AddToCart_Btn_Click(object sender, EventArgs e)
        {
            if (comboBox_Size.SelectedItem == null)
            {
                MessageBox.Show("Выберите размер", "Корзина", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
        }

        private void comboBox_Size_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSizeInfo();
        }

        private string GetCurrentSize()
        {
            if (comboBox_Size.SelectedItem != null)
                return comboBox_Size.SelectedItem.ToString();

            return comboBox_Size.Items.Count > 0 ? comboBox_Size.Items[0].ToString() : null;
        }

        private void UpdateSizeInfo()
        {
            string selectedSize = GetCurrentSize();

            if (selectedSize == null)
            {
                this.BackColor = _baseColor;
                return;
            }

            int quantity = _products.Product_Stock
                .Where(s => s.Size.ToString() == selectedSize)
                .Sum(s => s.Quantity);

            Stock_Label.Text = $"Количество: {quantity}";

            this.BackColor = quantity <= 3
                ? ColorTranslator.FromHtml("#ff8080")
                : _baseColor;
        }

        private void ApplyRole()
        {
            if (_user == null)
            {
                AddToCart_Btn.Visible = false;
                comboBox_Size.Visible = false;

                int total = _products.Product_Stock.Sum(s => s.Quantity);
                Stock_Label.Text = $"Кол-во: {total}";

                if (total <= 3)
                {
                    this.BackColor = ColorTranslator.FromHtml("#ff8080");
                }
                else
                {
                    this.BackColor = _baseColor;
                }
            }
            else if (_user.Id_Role == 1)
            {
                AddToCart_Btn.Visible = true;
            }
            else if (_user.Id_Role == 2)
            {
                AddToCart_Btn.Visible = true;
            }
            else
            {
                AddToCart_Btn.Visible = true;
            }
        }
    }
}

