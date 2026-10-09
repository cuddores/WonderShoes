namespace WonderShoes.CustomUserControl
{
    partial class ShoesUserControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Factory_Name_Label = new System.Windows.Forms.Label();
            this.Category_Label = new System.Windows.Forms.Label();
            this.Stock_Label = new System.Windows.Forms.Label();
            this.Composition_Label = new System.Windows.Forms.Label();
            this.Price_Label = new System.Windows.Forms.Label();
            this.AddToCart_Btn = new System.Windows.Forms.Button();
            this.Shoes_Image = new System.Windows.Forms.PictureBox();
            this.wonderShoesDataSet = new WonderShoes.WonderShoes_KornDataSet();
            this.product_Size_RangeTableAdapter = new WonderShoes.WonderShoes_KornDataSetTableAdapters.Product_Size_RangeTableAdapter();
            this.tableAdapterManager = new WonderShoes.WonderShoes_KornDataSetTableAdapters.TableAdapterManager();
            this.comboBox_Size = new System.Windows.Forms.ComboBox();
            this.productSizeRangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Shoes_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wonderShoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSizeRangeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Factory_Name_Label
            // 
            this.Factory_Name_Label.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Factory_Name_Label.Location = new System.Drawing.Point(256, 10);
            this.Factory_Name_Label.Name = "Factory_Name_Label";
            this.Factory_Name_Label.Size = new System.Drawing.Size(685, 42);
            this.Factory_Name_Label.TabIndex = 0;
            this.Factory_Name_Label.Text = "Производство | Наименование";
            this.Factory_Name_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Category_Label
            // 
            this.Category_Label.AutoSize = true;
            this.Category_Label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Category_Label.Location = new System.Drawing.Point(186, 51);
            this.Category_Label.Name = "Category_Label";
            this.Category_Label.Size = new System.Drawing.Size(91, 23);
            this.Category_Label.TabIndex = 1;
            this.Category_Label.Text = "Категория";
            // 
            // Stock_Label
            // 
            this.Stock_Label.AutoSize = true;
            this.Stock_Label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stock_Label.Location = new System.Drawing.Point(186, 80);
            this.Stock_Label.Name = "Stock_Label";
            this.Stock_Label.Size = new System.Drawing.Size(102, 23);
            this.Stock_Label.TabIndex = 2;
            this.Stock_Label.Text = "Количество";
            // 
            // Composition_Label
            // 
            this.Composition_Label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Composition_Label.Location = new System.Drawing.Point(186, 109);
            this.Composition_Label.Name = "Composition_Label";
            this.Composition_Label.Size = new System.Drawing.Size(570, 84);
            this.Composition_Label.TabIndex = 3;
            this.Composition_Label.Text = "Состав";
            // 
            // Price_Label
            // 
            this.Price_Label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_Label.Location = new System.Drawing.Point(830, 127);
            this.Price_Label.Name = "Price_Label";
            this.Price_Label.Size = new System.Drawing.Size(208, 22);
            this.Price_Label.TabIndex = 4;
            this.Price_Label.Text = "Цена";
            this.Price_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddToCart_Btn
            // 
            this.AddToCart_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.AddToCart_Btn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddToCart_Btn.Location = new System.Drawing.Point(830, 157);
            this.AddToCart_Btn.Name = "AddToCart_Btn";
            this.AddToCart_Btn.Size = new System.Drawing.Size(204, 31);
            this.AddToCart_Btn.TabIndex = 6;
            this.AddToCart_Btn.Text = "Добавить в корзину";
            this.AddToCart_Btn.UseVisualStyleBackColor = false;
            this.AddToCart_Btn.Click += new System.EventHandler(this.AddToCart_Btn_Click);
            // 
            // Shoes_Image
            // 
            this.Shoes_Image.Image = global::WonderShoes.Properties.Resources.picture;
            this.Shoes_Image.Location = new System.Drawing.Point(9, 31);
            this.Shoes_Image.Name = "Shoes_Image";
            this.Shoes_Image.Size = new System.Drawing.Size(158, 124);
            this.Shoes_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Shoes_Image.TabIndex = 5;
            this.Shoes_Image.TabStop = false;
            // 
            // wonderShoesDataSet
            // 
            this.wonderShoesDataSet.DataSetName = "WonderShoesDataSet";
            this.wonderShoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // product_Size_RangeTableAdapter
            // 
            this.product_Size_RangeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriesTableAdapter = null;
            this.tableAdapterManager.FactoriesTableAdapter = null;
            this.tableAdapterManager.Order_ItemsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.Product_Size_RangeTableAdapter = this.product_Size_RangeTableAdapter;
            this.tableAdapterManager.Product_StockTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = null;
            this.tableAdapterManager.SubcategoriesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WonderShoes.WonderShoes_KornDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // comboBox_Size
            // 
            this.comboBox_Size.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productSizeRangeBindingSource, "Size", true));
            this.comboBox_Size.DataSource = this.productSizeRangeBindingSource;
            this.comboBox_Size.DisplayMember = "Size";
            this.comboBox_Size.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Size.FormattingEnabled = true;
            this.comboBox_Size.Location = new System.Drawing.Point(834, 96);
            this.comboBox_Size.Name = "comboBox_Size";
            this.comboBox_Size.Size = new System.Drawing.Size(63, 23);
            this.comboBox_Size.TabIndex = 7;
            this.comboBox_Size.ValueMember = "Size";
            this.comboBox_Size.SelectedIndexChanged += new System.EventHandler(this.comboBox_Size_SelectedIndexChanged);
            // 
            // productSizeRangeBindingSource
            // 
            this.productSizeRangeBindingSource.DataMember = "Product_Size_Range";
            this.productSizeRangeBindingSource.DataSource = this.wonderShoesDataSet;
            // 
            // ShoesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(246)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.comboBox_Size);
            this.Controls.Add(this.AddToCart_Btn);
            this.Controls.Add(this.Shoes_Image);
            this.Controls.Add(this.Price_Label);
            this.Controls.Add(this.Composition_Label);
            this.Controls.Add(this.Stock_Label);
            this.Controls.Add(this.Category_Label);
            this.Controls.Add(this.Factory_Name_Label);
            this.Name = "ShoesUserControl";
            this.Size = new System.Drawing.Size(1058, 213);
            ((System.ComponentModel.ISupportInitialize)(this.Shoes_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wonderShoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSizeRangeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Factory_Name_Label;
        private System.Windows.Forms.Label Category_Label;
        private System.Windows.Forms.Label Stock_Label;
        private System.Windows.Forms.Label Composition_Label;
        private System.Windows.Forms.Label Price_Label;
        private System.Windows.Forms.PictureBox Shoes_Image;
        private System.Windows.Forms.Button AddToCart_Btn;
        private WonderShoes_KornDataSet wonderShoesDataSet;
        private WonderShoes_KornDataSetTableAdapters.Product_Size_RangeTableAdapter product_Size_RangeTableAdapter;
        private WonderShoes_KornDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox comboBox_Size;
        private System.Windows.Forms.BindingSource productSizeRangeBindingSource;

    }
}
