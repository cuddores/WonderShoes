namespace WonderShoes.AppForms
{
    partial class RegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label Guest_Btn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.Authorization_Label = new System.Windows.Forms.Label();
            this.wonderShoesDataSet = new WonderShoes.WonderShoesDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new WonderShoes.WonderShoesDataSetTableAdapters.UsersTableAdapter();
            this.tableAdapterManager = new WonderShoes.WonderShoesDataSetTableAdapters.TableAdapterManager();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.Authorization_Btn = new System.Windows.Forms.Button();
            loginLabel = new System.Windows.Forms.Label();
            Guest_Btn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wonderShoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            loginLabel.Location = new System.Drawing.Point(15, 120);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(71, 26);
            loginLabel.TabIndex = 10;
            loginLabel.Text = "Логин:";
            // 
            // Guest_Btn
            // 
            Guest_Btn.AutoSize = true;
            Guest_Btn.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            Guest_Btn.Location = new System.Drawing.Point(176, 228);
            Guest_Btn.Name = "Guest_Btn";
            Guest_Btn.Size = new System.Drawing.Size(122, 21);
            Guest_Btn.TabIndex = 13;
            Guest_Btn.Text = "Войти как гость";
            Guest_Btn.Click += new System.EventHandler(this.Guest_Btn_Click);
            // 
            // Authorization_Label
            // 
            this.Authorization_Label.AutoSize = true;
            this.Authorization_Label.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authorization_Label.Location = new System.Drawing.Point(130, 23);
            this.Authorization_Label.Name = "Authorization_Label";
            this.Authorization_Label.Size = new System.Drawing.Size(214, 33);
            this.Authorization_Label.TabIndex = 0;
            this.Authorization_Label.Text = "Войти в профиль";
            // 
            // wonderShoesDataSet
            // 
            this.wonderShoesDataSet.DataSetName = "WonderShoesDataSet";
            this.wonderShoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.wonderShoesDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.FactoriesTableAdapter = null;
            this.tableAdapterManager.Order_ItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.Product_Size_RangeTableAdapter = null;
            this.tableAdapterManager.Product_StockTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SubcategoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WonderShoes.WonderShoesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = this.usersTableAdapter;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTextBox.Location = new System.Drawing.Point(88, 117);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(356, 33);
            this.loginTextBox.TabIndex = 11;
            // 
            // Authorization_Btn
            // 
            this.Authorization_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.Authorization_Btn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Authorization_Btn.Location = new System.Drawing.Point(76, 185);
            this.Authorization_Btn.Name = "Authorization_Btn";
            this.Authorization_Btn.Size = new System.Drawing.Size(322, 40);
            this.Authorization_Btn.TabIndex = 12;
            this.Authorization_Btn.Text = "Войти";
            this.Authorization_Btn.UseVisualStyleBackColor = false;
            this.Authorization_Btn.Click += new System.EventHandler(this.Authorization_Btn_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(477, 306);
            this.Controls.Add(Guest_Btn);
            this.Controls.Add(this.Authorization_Btn);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.Authorization_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Форма авторизации";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wonderShoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Authorization_Label;
        private WonderShoesDataSet wonderShoesDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private WonderShoesDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private WonderShoesDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Button Authorization_Btn;
    }
}