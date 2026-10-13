namespace WonderShoes.CustomUserControl
{
    partial class CartUserControl
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
            this.Shoes_Image = new System.Windows.Forms.PictureBox();
            this.PriceCart_Label = new System.Windows.Forms.Label();
            this.Shoes_Type_Label = new System.Windows.Forms.Label();
            this.wonderShoesDataSet = new WonderShoes.WonderShoes_KornDataSet();
            this.product_Size_RangeTableAdapter = new WonderShoes.WonderShoes_KornDataSetTableAdapters.Product_Size_RangeTableAdapter();
            this.tableAdapterManager = new WonderShoes.WonderShoes_KornDataSetTableAdapters.TableAdapterManager();
            this.productSizeRangeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.QuantityShoes = new System.Windows.Forms.NumericUpDown();
            this.Cost_Label = new System.Windows.Forms.Label();
            this.ShoesSize = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Shoes_Image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wonderShoesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSizeRangeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityShoes)).BeginInit();
            this.SuspendLayout();
            // 
            // Shoes_Image
            // 
            this.Shoes_Image.Image = global::WonderShoes.Properties.Resources.picture;
            this.Shoes_Image.Location = new System.Drawing.Point(9, 34);
            this.Shoes_Image.Name = "Shoes_Image";
            this.Shoes_Image.Size = new System.Drawing.Size(171, 127);
            this.Shoes_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Shoes_Image.TabIndex = 13;
            this.Shoes_Image.TabStop = false;
            // 
            // PriceCart_Label
            // 
            this.PriceCart_Label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceCart_Label.Location = new System.Drawing.Point(186, 138);
            this.PriceCart_Label.Name = "PriceCart_Label";
            this.PriceCart_Label.Size = new System.Drawing.Size(178, 22);
            this.PriceCart_Label.TabIndex = 12;
            this.PriceCart_Label.Text = "Цена";
            this.PriceCart_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Shoes_Type_Label
            // 
            this.Shoes_Type_Label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Shoes_Type_Label.Location = new System.Drawing.Point(186, 34);
            this.Shoes_Type_Label.Name = "Shoes_Type_Label";
            this.Shoes_Type_Label.Size = new System.Drawing.Size(263, 26);
            this.Shoes_Type_Label.TabIndex = 8;
            this.Shoes_Type_Label.Text = "Вид обуви";
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
            // productSizeRangeBindingSource
            // 
            this.productSizeRangeBindingSource.DataMember = "Product_Size_Range";
            this.productSizeRangeBindingSource.DataSource = this.wonderShoesDataSet;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(186, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 26);
            this.label1.TabIndex = 16;
            this.label1.Text = "Наименование";
            // 
            // QuantityShoes
            // 
            this.QuantityShoes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuantityShoes.Location = new System.Drawing.Point(779, 79);
            this.QuantityShoes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityShoes.Name = "QuantityShoes";
            this.QuantityShoes.Size = new System.Drawing.Size(64, 31);
            this.QuantityShoes.TabIndex = 17;
            this.QuantityShoes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QuantityShoes.ValueChanged += new System.EventHandler(this.QuantityShoes_ValueChanged);
            // 
            // Cost_Label
            // 
            this.Cost_Label.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Cost_Label.Location = new System.Drawing.Point(578, 162);
            this.Cost_Label.Name = "Cost_Label";
            this.Cost_Label.Size = new System.Drawing.Size(289, 22);
            this.Cost_Label.TabIndex = 18;
            this.Cost_Label.Text = "Стоимость";
            this.Cost_Label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ShoesSize
            // 
            this.ShoesSize.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShoesSize.Location = new System.Drawing.Point(186, 111);
            this.ShoesSize.Name = "ShoesSize";
            this.ShoesSize.Size = new System.Drawing.Size(211, 23);
            this.ShoesSize.TabIndex = 19;
            this.ShoesSize.Text = "Размер";
            // 
            // CartUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(246)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.ShoesSize);
            this.Controls.Add(this.Cost_Label);
            this.Controls.Add(this.QuantityShoes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Shoes_Image);
            this.Controls.Add(this.PriceCart_Label);
            this.Controls.Add(this.Shoes_Type_Label);
            this.Name = "CartUserControl";
            this.Size = new System.Drawing.Size(880, 197);
            ((System.ComponentModel.ISupportInitialize)(this.Shoes_Image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wonderShoesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSizeRangeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuantityShoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Shoes_Image;
        private System.Windows.Forms.Label PriceCart_Label;
        private System.Windows.Forms.Label Shoes_Type_Label;
        private WonderShoes_KornDataSet wonderShoesDataSet;
        private WonderShoes_KornDataSetTableAdapters.Product_Size_RangeTableAdapter product_Size_RangeTableAdapter;
        private WonderShoes_KornDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource productSizeRangeBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown QuantityShoes;
        private System.Windows.Forms.Label Cost_Label;
        private System.Windows.Forms.Label ShoesSize;
    }
}
