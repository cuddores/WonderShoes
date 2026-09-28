namespace WonderShoes.AppForms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.Shoes_List = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.comboBox_Filtering = new System.Windows.Forms.ComboBox();
            this.label_Search = new System.Windows.Forms.Label();
            this.label_Filtering = new System.Windows.Forms.Label();
            this.label_Sorting = new System.Windows.Forms.Label();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.comboBox_Sorting = new System.Windows.Forms.ComboBox();
            this.Login_Role_Label = new System.Windows.Forms.Label();
            this.App_Name = new System.Windows.Forms.Label();
            this.Add_Shoes_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.factoriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wonderShoesDataSet = new WonderShoes.WonderShoesDataSet();
            this.factoriesTableAdapter = new WonderShoes.WonderShoesDataSetTableAdapters.FactoriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.factoriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wonderShoesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Shoes_List
            // 
            this.Shoes_List.AutoScroll = true;
            this.Shoes_List.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Shoes_List.Location = new System.Drawing.Point(0, 0);
            this.Shoes_List.Name = "Shoes_List";
            this.Shoes_List.Padding = new System.Windows.Forms.Padding(3);
            this.Shoes_List.Size = new System.Drawing.Size(1099, 541);
            this.Shoes_List.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_Filtering);
            this.splitContainer1.Panel1.Controls.Add(this.label_Search);
            this.splitContainer1.Panel1.Controls.Add(this.label_Filtering);
            this.splitContainer1.Panel1.Controls.Add(this.label_Sorting);
            this.splitContainer1.Panel1.Controls.Add(this.textBox_Search);
            this.splitContainer1.Panel1.Controls.Add(this.comboBox_Sorting);
            this.splitContainer1.Panel1.Controls.Add(this.Login_Role_Label);
            this.splitContainer1.Panel1.Controls.Add(this.Add_Shoes_Btn);
            this.splitContainer1.Panel1.Controls.Add(this.App_Name);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Shoes_List);
            this.splitContainer1.Size = new System.Drawing.Size(1099, 646);
            this.splitContainer1.SplitterDistance = 101;
            this.splitContainer1.TabIndex = 1;
            // 
            // comboBox_Filtering
            // 
            this.comboBox_Filtering.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Filtering.FormattingEnabled = true;
            this.comboBox_Filtering.Location = new System.Drawing.Point(516, 63);
            this.comboBox_Filtering.Name = "comboBox_Filtering";
            this.comboBox_Filtering.Size = new System.Drawing.Size(153, 24);
            this.comboBox_Filtering.TabIndex = 10;
            this.comboBox_Filtering.SelectedIndexChanged += new System.EventHandler(this.comboBox_Filtering_SelectedIndexChanged);
            // 
            // label_Search
            // 
            this.label_Search.AutoSize = true;
            this.label_Search.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Search.Location = new System.Drawing.Point(868, 40);
            this.label_Search.Name = "label_Search";
            this.label_Search.Size = new System.Drawing.Size(53, 17);
            this.label_Search.TabIndex = 9;
            this.label_Search.Text = "Поиск:";
            // 
            // label_Filtering
            // 
            this.label_Filtering.AutoSize = true;
            this.label_Filtering.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Filtering.Location = new System.Drawing.Point(513, 40);
            this.label_Filtering.Name = "label_Filtering";
            this.label_Filtering.Size = new System.Drawing.Size(89, 17);
            this.label_Filtering.TabIndex = 8;
            this.label_Filtering.Text = "Фильтрация:";
            // 
            // label_Sorting
            // 
            this.label_Sorting.AutoSize = true;
            this.label_Sorting.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Sorting.Location = new System.Drawing.Point(672, 40);
            this.label_Sorting.Name = "label_Sorting";
            this.label_Sorting.Size = new System.Drawing.Size(94, 17);
            this.label_Sorting.TabIndex = 7;
            this.label_Sorting.Text = "Сортировка:";
            // 
            // textBox_Search
            // 
            this.textBox_Search.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Search.Location = new System.Drawing.Point(871, 65);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(194, 21);
            this.textBox_Search.TabIndex = 6;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // comboBox_Sorting
            // 
            this.comboBox_Sorting.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_Sorting.FormattingEnabled = true;
            this.comboBox_Sorting.Location = new System.Drawing.Point(675, 63);
            this.comboBox_Sorting.Name = "comboBox_Sorting";
            this.comboBox_Sorting.Size = new System.Drawing.Size(190, 24);
            this.comboBox_Sorting.TabIndex = 5;
            this.comboBox_Sorting.SelectedIndexChanged += new System.EventHandler(this.comboBox_Sorting_SelectedIndexChanged);
            // 
            // Login_Role_Label
            // 
            this.Login_Role_Label.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_Role_Label.Location = new System.Drawing.Point(94, 38);
            this.Login_Role_Label.Name = "Login_Role_Label";
            this.Login_Role_Label.Size = new System.Drawing.Size(286, 23);
            this.Login_Role_Label.TabIndex = 3;
            this.Login_Role_Label.Text = "Логин | Роль";
            this.Login_Role_Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // Add_Shoes_Btn
            // 
            this.Add_Shoes_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(178)))), ((int)(((byte)(175)))));
            this.Add_Shoes_Btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_Shoes_Btn.Location = new System.Drawing.Point(92, 65);
            this.Add_Shoes_Btn.Name = "Add_Shoes_Btn";
            this.Add_Shoes_Btn.Size = new System.Drawing.Size(194, 29);
            this.Add_Shoes_Btn.TabIndex = 2;
            this.Add_Shoes_Btn.Text = "Добавить товар";
            this.Add_Shoes_Btn.UseVisualStyleBackColor = false;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 646);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главная форма";
            this.Load += new System.EventHandler(this.MainForm_Load);
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

        private System.Windows.Forms.FlowLayoutPanel Shoes_List;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label App_Name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Add_Shoes_Btn;
        private System.Windows.Forms.Label Login_Role_Label;
        private System.Windows.Forms.Label label_Search;
        private System.Windows.Forms.Label label_Filtering;
        private System.Windows.Forms.Label label_Sorting;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.ComboBox comboBox_Sorting;
        private WonderShoesDataSet wonderShoesDataSet;
        private WonderShoesDataSetTableAdapters.FactoriesTableAdapter factoriesTableAdapter;
        private System.Windows.Forms.BindingSource factoriesBindingSource;
        private System.Windows.Forms.ComboBox comboBox_Filtering;
    }
}