namespace WonderShoes.AppForms
{
    partial class UserCart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserCart));
            this.Cart_List = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.App_Name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.factoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wonderShoesDataSet = new WonderShoes.WonderShoes_KornDataSet();
            this.factoriesTableAdapter = new WonderShoes.WonderShoes_KornDataSetTableAdapters.FactoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wonderShoesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Cart_List
            // 
            this.Cart_List.AutoScroll = true;
            this.Cart_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cart_List.Location = new System.Drawing.Point(0, 0);
            this.Cart_List.Name = "Cart_List";
            this.Cart_List.Padding = new System.Windows.Forms.Padding(3);
            this.Cart_List.Size = new System.Drawing.Size(1099, 541);
            this.Cart_List.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.App_Name);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Cart_List);
            this.splitContainer1.Size = new System.Drawing.Size(1099, 646);
            this.splitContainer1.SplitterDistance = 101;
            this.splitContainer1.TabIndex = 2;
            // 
            // App_Name
            // 
            this.App_Name.AutoSize = true;
            this.App_Name.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.App_Name.Location = new System.Drawing.Point(92, 12);
            this.App_Name.Name = "App_Name";
            this.App_Name.Size = new System.Drawing.Size(136, 25);
            this.App_Name.TabIndex = 1;
            this.App_Name.Text = "Чудо Обувь";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WonderShoes.Properties.Resources.Чудо_Обувь;
            this.pictureBox1.Location = new System.Drawing.Point(12, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // factoriesBindingSource
            // 
            this.factoriesBindingSource.DataMember = "Factories";
            this.factoriesBindingSource.DataSource = this.wonderShoesDataSet;
            // 
            // wonderShoesDataSet
            // 
            this.wonderShoesDataSet.DataSetName = "WonderShoesDataSet";
            this.wonderShoesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // factoriesTableAdapter
            // 
            this.factoriesTableAdapter.ClearBeforeFill = true;
            // 
            // UserCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1099, 646);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Корзина заказа";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wonderShoesDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Cart_List;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label App_Name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource factoriesBindingSource;
        private WonderShoes_KornDataSet wonderShoesDataSet;
        private WonderShoes_KornDataSetTableAdapters.FactoriesTableAdapter factoriesTableAdapter;
    }
}