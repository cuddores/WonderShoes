using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WonderShoes.CustomUserControl;
using WonderShoes.Models;

namespace WonderShoes.AppForms
{
    public partial class UserCart : Form
    {
        public UserCart()
        {
            InitializeComponent();
        }

        private void UserCart_Load(object sender, EventArgs e)
        {
            ShowCart();
        }
        private void ShowCart()
        {
            MainForm main = this.Owner as MainForm;
            if (main == null) return;

            Cart_List.Controls.Clear();

            foreach (CartItem item in main.GetCart())
            {
                Cart_List.Controls.Add(new CartUserControl(item));
            }
        }

    }
}
