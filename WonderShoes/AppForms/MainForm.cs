using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WonderShoes.AppForms;
using WonderShoes.Models;
using WonderShoes.CustomUserControl;

namespace WonderShoes.AppForms
{
    public partial class MainForm : Form
    {
        private Users _users;
        private int currentFactory = 0;
        private int currentSort = 0;
        private string currentSearch = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowProducts()
        {
            Shoes_List.Controls.Clear();

            List<Products> products = Program.context.Products.ToList();

            if (!string.IsNullOrEmpty(currentSearch))
            {
                products = products.Where(p => p.Product_Name.ToLower().Contains(currentSearch)).ToList();
            }

            if (currentSort == 1)
            {
                products = products.OrderBy(p => p.Price).ToList();
            }
            else if (currentSort == 2)
            {
                products = products.OrderByDescending(p => p.Price).ToList();
            }
            else
            {
                products = products.OrderBy(p => p.Product_Name).ToList();
            }

            foreach (Products prod in products)
            {
                if (currentFactory != 0 && prod.Id_Factory != currentFactory)
                {
                    continue;
                }


                Shoes_List.Controls.Add(new ShoesUserControl(prod));
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadFactories();
            LoadSorting();

            ShowProducts();
        }

        public void SetCurrentUser(Users users)
        {
            _users = users;
            string role;

            if (_users == null)
            {
                role = "Гость";
            }
            else
            {
            switch (_users.Id_Role)
            {
                case 1: role = "Администратор"; break;
                case 2: role = "Менеджер"; break;
                    case 3: role = "Пользователь"; break;
                    default: role = "Гость"; break;
                }
            }

            if (role == "Гость")
            {
                Login_Role_Label.Text = "Гость";
                Login_Role_Label.Visible = true;

                comboBox_Filtering.Visible = false;
                label_Filtering.Visible = false;
                comboBox_Sorting.Visible = false;
                label_Sorting.Visible = false;
                label_Search.Visible = false;
                textBox_Search.Visible = false;

                return;
            }

            Login_Role_Label.Text = $"@{_users.Login} | {role}";
            Login_Role_Label.Visible = true;

            comboBox_Filtering.Visible = true;
            label_Filtering.Visible = true;
            comboBox_Sorting.Visible = true;
            label_Sorting.Visible = true;
            label_Search.Visible = true;
            textBox_Search.Visible = true;
        }


        private void LoadFactories()
        {
            var categories = Program.context.Factories.Select(p => new
            {
                Id = p.Id_Factory,
                Name = p.Factory_Name
            }).ToList();

            categories.Insert(0, new { Id = 0, Name = "Все производители" });

           
            comboBox_Filtering.DataSource = categories;
            comboBox_Filtering.DisplayMember = "Name";
            comboBox_Filtering.ValueMember = "Id";
            comboBox_Filtering.SelectedIndex = 0;
        }

        private void comboBox_Filtering_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedFilter = comboBox_Filtering.SelectedItem;

            if (selectedFilter != null)
            {
               
                var idProperty = selectedFilter.GetType().GetProperty("Id");
                if (idProperty != null)
                {
                    currentFactory = (int)idProperty.GetValue(selectedFilter);
                }
                else
                {
                    currentFactory = 0;
                }
            }
            else
            {
                currentFactory = 0;
            }

            ShowProducts();
        }

        private void LoadSorting()
        {
            
            var sortList = new List<string>
            {
                "По наименованию (А-Я)",
                "По цене (сначала дешевые)",
                "По цене (сначала дорогие)"
            };

            comboBox_Sorting.DataSource = sortList;
            comboBox_Sorting.SelectedIndex = 0;
        }
        private void comboBox_Sorting_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentSort = comboBox_Sorting.SelectedIndex;
            ShowProducts();
        }

        private void textBox_Search_TextChanged(object sender, EventArgs e)
        {
            currentSearch = textBox_Search.Text.ToLower(); 
            ShowProducts(); 
        }
    }
}
