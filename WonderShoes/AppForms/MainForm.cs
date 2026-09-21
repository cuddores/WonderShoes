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
        public MainForm()
        {
            InitializeComponent();
        }

        private void ShowProducts()
        {
            List<Products> products = Program.context.Products.OrderBy(p => p.Product_Name).ToList();

            foreach (Products prod in products)
            {
                Shoes_List.Controls.Add(new ShoesUserControl(prod));
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            ShowProducts();

            if (_users == null)
            {
                Login_Role_Label.Text = "Гость";
                Add_Shoes_Btn.Visible = false;
            }
        }

        public void SetCurrentUser(Users users)
        {
            _users = users;

            string role;
            switch (_users.Id_Role)
            {
                case 1: role = "Администратор"; break;
                case 2: role = "Менеджер"; break;
                default: role = "Пользователь"; break;
            }

            Login_Role_Label.Text = $"@{_users.Login} | {role}";
            Login_Role_Label.Visible = true;

            Add_Shoes_Btn.Visible = _users.Id_Role == 1;
        }

    }
}
