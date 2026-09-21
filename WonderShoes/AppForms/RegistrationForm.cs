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

namespace WonderShoes.AppForms
{
    public partial class RegistrationForm : Form
    {
        bool IsSign = true;
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.wonderShoesDataSet);

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "wonderShoesDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.wonderShoesDataSet.Users);

        }

        private void Authorization_Btn_Click(object sender, EventArgs e)
        {
            string loginInput = loginTextBox.Text;

            if (string.IsNullOrEmpty(loginInput))
            {
                MessageBox.Show("Введите логин", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                List<Users> users = Program.context.Users.ToList();
                Users us = users.FirstOrDefault(p => p.Login == loginInput);
                if (us != null)
                {
                    MainForm mainform = new MainForm();
                    mainform.SetCurrentUser(us);
                    mainform.Owner = this;
                    this.Hide();
                    loginTextBox.Clear();
                    mainform.Show();
                }
                else
                {
                    MessageBox.Show("Неверный логин", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void Guest_Btn_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            mainform.Owner = this;
            this.Hide();
            mainform.Show();
        }
    }
}
