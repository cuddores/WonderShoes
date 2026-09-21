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
            this.Factory_Name_Label = new System.Windows.Forms.Label();
            this.Category_Label = new System.Windows.Forms.Label();
            this.Stock_Label = new System.Windows.Forms.Label();
            this.Composition_Label = new System.Windows.Forms.Label();
            this.Price_Label = new System.Windows.Forms.Label();
            this.Shoes_Image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Shoes_Image)).BeginInit();
            this.SuspendLayout();
            // 
            // Factory_Name_Label
            // 
            this.Factory_Name_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Factory_Name_Label.Location = new System.Drawing.Point(256, 6);
            this.Factory_Name_Label.Name = "Factory_Name_Label";
            this.Factory_Name_Label.Size = new System.Drawing.Size(685, 42);
            this.Factory_Name_Label.TabIndex = 0;
            this.Factory_Name_Label.Text = "Производство | Наименование";
            this.Factory_Name_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Category_Label
            // 
            this.Category_Label.AutoSize = true;
            this.Category_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Category_Label.Location = new System.Drawing.Point(200, 48);
            this.Category_Label.Name = "Category_Label";
            this.Category_Label.Size = new System.Drawing.Size(90, 21);
            this.Category_Label.TabIndex = 1;
            this.Category_Label.Text = "Категория";
            // 
            // Stock_Label
            // 
            this.Stock_Label.AutoSize = true;
            this.Stock_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Stock_Label.Location = new System.Drawing.Point(200, 79);
            this.Stock_Label.Name = "Stock_Label";
            this.Stock_Label.Size = new System.Drawing.Size(98, 21);
            this.Stock_Label.TabIndex = 2;
            this.Stock_Label.Text = "Количество";
            // 
            // Composition_Label
            // 
            this.Composition_Label.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Composition_Label.Location = new System.Drawing.Point(200, 110);
            this.Composition_Label.Name = "Composition_Label";
            this.Composition_Label.Size = new System.Drawing.Size(634, 56);
            this.Composition_Label.TabIndex = 3;
            this.Composition_Label.Text = "Состав";
            // 
            // Price_Label
            // 
            this.Price_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Price_Label.Location = new System.Drawing.Point(836, 69);
            this.Price_Label.Name = "Price_Label";
            this.Price_Label.Size = new System.Drawing.Size(208, 22);
            this.Price_Label.TabIndex = 4;
            this.Price_Label.Text = "Цена";
            this.Price_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Shoes_Image
            // 
            this.Shoes_Image.Image = global::WonderShoes.Properties.Resources.picture;
            this.Shoes_Image.Location = new System.Drawing.Point(9, 27);
            this.Shoes_Image.Name = "Shoes_Image";
            this.Shoes_Image.Size = new System.Drawing.Size(152, 124);
            this.Shoes_Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Shoes_Image.TabIndex = 5;
            this.Shoes_Image.TabStop = false;
            // 
            // ShoesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(246)))), ((int)(((byte)(231)))));
            this.Controls.Add(this.Shoes_Image);
            this.Controls.Add(this.Price_Label);
            this.Controls.Add(this.Composition_Label);
            this.Controls.Add(this.Stock_Label);
            this.Controls.Add(this.Category_Label);
            this.Controls.Add(this.Factory_Name_Label);
            this.Name = "ShoesUserControl";
            this.Size = new System.Drawing.Size(1055, 179);
            ((System.ComponentModel.ISupportInitialize)(this.Shoes_Image)).EndInit();
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
    }
}
