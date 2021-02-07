namespace RStore.MyForms
{
    partial class AdminAllProducts
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
            this.dgv_AdminProducts = new System.Windows.Forms.DataGridView();
            this.btn_AllProducts = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_AdminUpdate = new System.Windows.Forms.Button();
            this.btn_AdminAdd = new System.Windows.Forms.Button();
            this.txb_Description = new System.Windows.Forms.TextBox();
            this.txb_UpdateCount = new System.Windows.Forms.TextBox();
            this.txb_UpdatePrice = new System.Windows.Forms.TextBox();
            this.txb_UpdateName = new System.Windows.Forms.TextBox();
            this.txb_AddCount = new System.Windows.Forms.TextBox();
            this.txb_AddPrice = new System.Windows.Forms.TextBox();
            this.txb_AddName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_AddCategory = new System.Windows.Forms.Label();
            this.lbl_AddCount = new System.Windows.Forms.Label();
            this.lbl_AddPrice = new System.Windows.Forms.Label();
            this.lbl_AddName = new System.Windows.Forms.Label();
            this.cmb_AddCategory = new System.Windows.Forms.ComboBox();
            this.cmb_UpdateCategory = new System.Windows.Forms.ComboBox();
            this.lbl_Update = new System.Windows.Forms.Label();
            this.lbl_Description = new System.Windows.Forms.Label();
            this.lbl_UpdateCategory = new System.Windows.Forms.Label();
            this.lbl_UpdateCount = new System.Windows.Forms.Label();
            this.lbl_UpdatePrice = new System.Windows.Forms.Label();
            this.lbl_UpdateName = new System.Windows.Forms.Label();
            this.lbl_BoughtCountSearch = new System.Windows.Forms.Label();
            this.txb_SearchBoughtCount = new System.Windows.Forms.TextBox();
            this.lbl_CategorySearch = new System.Windows.Forms.Label();
            this.txb_CategorySearch = new System.Windows.Forms.TextBox();
            this.txb_CountSearch = new System.Windows.Forms.TextBox();
            this.txb_PriceSearch = new System.Windows.Forms.TextBox();
            this.lbl_NameSearch = new System.Windows.Forms.Label();
            this.lbl_PriceSearch = new System.Windows.Forms.Label();
            this.lbl_CountSearch = new System.Windows.Forms.Label();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.txb_NameSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_SearchUserName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AdminProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_AdminProducts
            // 
            this.dgv_AdminProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AdminProducts.Location = new System.Drawing.Point(299, 11);
            this.dgv_AdminProducts.Name = "dgv_AdminProducts";
            this.dgv_AdminProducts.Size = new System.Drawing.Size(448, 232);
            this.dgv_AdminProducts.TabIndex = 0;
            this.dgv_AdminProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_AdminProducts_CellClick);
            // 
            // btn_AllProducts
            // 
            this.btn_AllProducts.Location = new System.Drawing.Point(299, 257);
            this.btn_AllProducts.Name = "btn_AllProducts";
            this.btn_AllProducts.Size = new System.Drawing.Size(75, 23);
            this.btn_AllProducts.TabIndex = 1;
            this.btn_AllProducts.Text = "All Products";
            this.btn_AllProducts.UseVisualStyleBackColor = true;
            this.btn_AllProducts.Click += new System.EventHandler(this.btn_AllProducts_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(147, 424);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_AdminUpdate
            // 
            this.btn_AdminUpdate.Location = new System.Drawing.Point(40, 463);
            this.btn_AdminUpdate.Name = "btn_AdminUpdate";
            this.btn_AdminUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_AdminUpdate.TabIndex = 3;
            this.btn_AdminUpdate.Text = "Update";
            this.btn_AdminUpdate.UseVisualStyleBackColor = true;
            this.btn_AdminUpdate.Click += new System.EventHandler(this.btn_AdminUpdate_Click);
            // 
            // btn_AdminAdd
            // 
            this.btn_AdminAdd.Location = new System.Drawing.Point(40, 195);
            this.btn_AdminAdd.Name = "btn_AdminAdd";
            this.btn_AdminAdd.Size = new System.Drawing.Size(75, 23);
            this.btn_AdminAdd.TabIndex = 4;
            this.btn_AdminAdd.Text = "Add";
            this.btn_AdminAdd.UseVisualStyleBackColor = true;
            this.btn_AdminAdd.Click += new System.EventHandler(this.btn_AdminAdd_Click);
            // 
            // txb_Description
            // 
            this.txb_Description.Location = new System.Drawing.Point(136, 398);
            this.txb_Description.Name = "txb_Description";
            this.txb_Description.Size = new System.Drawing.Size(100, 20);
            this.txb_Description.TabIndex = 5;
            // 
            // txb_UpdateCount
            // 
            this.txb_UpdateCount.Location = new System.Drawing.Point(30, 398);
            this.txb_UpdateCount.Name = "txb_UpdateCount";
            this.txb_UpdateCount.Size = new System.Drawing.Size(100, 20);
            this.txb_UpdateCount.TabIndex = 6;
            // 
            // txb_UpdatePrice
            // 
            this.txb_UpdatePrice.Location = new System.Drawing.Point(30, 356);
            this.txb_UpdatePrice.Name = "txb_UpdatePrice";
            this.txb_UpdatePrice.Size = new System.Drawing.Size(100, 20);
            this.txb_UpdatePrice.TabIndex = 7;
            // 
            // txb_UpdateName
            // 
            this.txb_UpdateName.Location = new System.Drawing.Point(30, 320);
            this.txb_UpdateName.Name = "txb_UpdateName";
            this.txb_UpdateName.Size = new System.Drawing.Size(100, 20);
            this.txb_UpdateName.TabIndex = 8;
            // 
            // txb_AddCount
            // 
            this.txb_AddCount.Location = new System.Drawing.Point(30, 129);
            this.txb_AddCount.Name = "txb_AddCount";
            this.txb_AddCount.Size = new System.Drawing.Size(100, 20);
            this.txb_AddCount.TabIndex = 9;
            // 
            // txb_AddPrice
            // 
            this.txb_AddPrice.Location = new System.Drawing.Point(30, 89);
            this.txb_AddPrice.Name = "txb_AddPrice";
            this.txb_AddPrice.Size = new System.Drawing.Size(100, 20);
            this.txb_AddPrice.TabIndex = 10;
            // 
            // txb_AddName
            // 
            this.txb_AddName.Location = new System.Drawing.Point(30, 51);
            this.txb_AddName.Name = "txb_AddName";
            this.txb_AddName.Size = new System.Drawing.Size(100, 20);
            this.txb_AddName.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Add Product";
            // 
            // lbl_AddCategory
            // 
            this.lbl_AddCategory.AutoSize = true;
            this.lbl_AddCategory.Location = new System.Drawing.Point(27, 152);
            this.lbl_AddCategory.Name = "lbl_AddCategory";
            this.lbl_AddCategory.Size = new System.Drawing.Size(49, 13);
            this.lbl_AddCategory.TabIndex = 13;
            this.lbl_AddCategory.Text = "Category";
            // 
            // lbl_AddCount
            // 
            this.lbl_AddCount.AutoSize = true;
            this.lbl_AddCount.Location = new System.Drawing.Point(27, 113);
            this.lbl_AddCount.Name = "lbl_AddCount";
            this.lbl_AddCount.Size = new System.Drawing.Size(35, 13);
            this.lbl_AddCount.TabIndex = 14;
            this.lbl_AddCount.Text = "Count";
            // 
            // lbl_AddPrice
            // 
            this.lbl_AddPrice.AutoSize = true;
            this.lbl_AddPrice.Location = new System.Drawing.Point(27, 74);
            this.lbl_AddPrice.Name = "lbl_AddPrice";
            this.lbl_AddPrice.Size = new System.Drawing.Size(31, 13);
            this.lbl_AddPrice.TabIndex = 15;
            this.lbl_AddPrice.Text = "Price";
            // 
            // lbl_AddName
            // 
            this.lbl_AddName.AutoSize = true;
            this.lbl_AddName.Location = new System.Drawing.Point(27, 35);
            this.lbl_AddName.Name = "lbl_AddName";
            this.lbl_AddName.Size = new System.Drawing.Size(35, 13);
            this.lbl_AddName.TabIndex = 16;
            this.lbl_AddName.Text = "Name";
            // 
            // cmb_AddCategory
            // 
            this.cmb_AddCategory.FormattingEnabled = true;
            this.cmb_AddCategory.Location = new System.Drawing.Point(30, 168);
            this.cmb_AddCategory.Name = "cmb_AddCategory";
            this.cmb_AddCategory.Size = new System.Drawing.Size(100, 21);
            this.cmb_AddCategory.TabIndex = 17;
            // 
            // cmb_UpdateCategory
            // 
            this.cmb_UpdateCategory.FormattingEnabled = true;
            this.cmb_UpdateCategory.Location = new System.Drawing.Point(30, 436);
            this.cmb_UpdateCategory.Name = "cmb_UpdateCategory";
            this.cmb_UpdateCategory.Size = new System.Drawing.Size(100, 21);
            this.cmb_UpdateCategory.TabIndex = 18;
            // 
            // lbl_Update
            // 
            this.lbl_Update.AutoSize = true;
            this.lbl_Update.Location = new System.Drawing.Point(40, 262);
            this.lbl_Update.Name = "lbl_Update";
            this.lbl_Update.Size = new System.Drawing.Size(42, 13);
            this.lbl_Update.TabIndex = 19;
            this.lbl_Update.Text = "Update";
            // 
            // lbl_Description
            // 
            this.lbl_Description.AutoSize = true;
            this.lbl_Description.Location = new System.Drawing.Point(133, 382);
            this.lbl_Description.Name = "lbl_Description";
            this.lbl_Description.Size = new System.Drawing.Size(60, 13);
            this.lbl_Description.TabIndex = 20;
            this.lbl_Description.Text = "Description";
            // 
            // lbl_UpdateCategory
            // 
            this.lbl_UpdateCategory.AutoSize = true;
            this.lbl_UpdateCategory.Location = new System.Drawing.Point(27, 420);
            this.lbl_UpdateCategory.Name = "lbl_UpdateCategory";
            this.lbl_UpdateCategory.Size = new System.Drawing.Size(49, 13);
            this.lbl_UpdateCategory.TabIndex = 21;
            this.lbl_UpdateCategory.Text = "Category";
            // 
            // lbl_UpdateCount
            // 
            this.lbl_UpdateCount.AutoSize = true;
            this.lbl_UpdateCount.Location = new System.Drawing.Point(27, 382);
            this.lbl_UpdateCount.Name = "lbl_UpdateCount";
            this.lbl_UpdateCount.Size = new System.Drawing.Size(35, 13);
            this.lbl_UpdateCount.TabIndex = 22;
            this.lbl_UpdateCount.Text = "Count";
            // 
            // lbl_UpdatePrice
            // 
            this.lbl_UpdatePrice.AutoSize = true;
            this.lbl_UpdatePrice.Location = new System.Drawing.Point(27, 343);
            this.lbl_UpdatePrice.Name = "lbl_UpdatePrice";
            this.lbl_UpdatePrice.Size = new System.Drawing.Size(31, 13);
            this.lbl_UpdatePrice.TabIndex = 23;
            this.lbl_UpdatePrice.Text = "Price";
            // 
            // lbl_UpdateName
            // 
            this.lbl_UpdateName.AutoSize = true;
            this.lbl_UpdateName.Location = new System.Drawing.Point(27, 304);
            this.lbl_UpdateName.Name = "lbl_UpdateName";
            this.lbl_UpdateName.Size = new System.Drawing.Size(35, 13);
            this.lbl_UpdateName.TabIndex = 24;
            this.lbl_UpdateName.Text = "Name";
            // 
            // lbl_BoughtCountSearch
            // 
            this.lbl_BoughtCountSearch.AutoSize = true;
            this.lbl_BoughtCountSearch.Location = new System.Drawing.Point(708, 389);
            this.lbl_BoughtCountSearch.Name = "lbl_BoughtCountSearch";
            this.lbl_BoughtCountSearch.Size = new System.Drawing.Size(72, 13);
            this.lbl_BoughtCountSearch.TabIndex = 48;
            this.lbl_BoughtCountSearch.Text = "Bought Count";
            // 
            // txb_SearchBoughtCount
            // 
            this.txb_SearchBoughtCount.Location = new System.Drawing.Point(711, 405);
            this.txb_SearchBoughtCount.Name = "txb_SearchBoughtCount";
            this.txb_SearchBoughtCount.Size = new System.Drawing.Size(100, 20);
            this.txb_SearchBoughtCount.TabIndex = 47;
            this.txb_SearchBoughtCount.TextChanged += new System.EventHandler(this.txb_SearchBoughtCount_TextChanged);
            // 
            // lbl_CategorySearch
            // 
            this.lbl_CategorySearch.AutoSize = true;
            this.lbl_CategorySearch.Location = new System.Drawing.Point(708, 340);
            this.lbl_CategorySearch.Name = "lbl_CategorySearch";
            this.lbl_CategorySearch.Size = new System.Drawing.Size(49, 13);
            this.lbl_CategorySearch.TabIndex = 46;
            this.lbl_CategorySearch.Text = "Category";
            // 
            // txb_CategorySearch
            // 
            this.txb_CategorySearch.Location = new System.Drawing.Point(711, 356);
            this.txb_CategorySearch.Name = "txb_CategorySearch";
            this.txb_CategorySearch.Size = new System.Drawing.Size(100, 20);
            this.txb_CategorySearch.TabIndex = 45;
            this.txb_CategorySearch.TextChanged += new System.EventHandler(this.txb_CategorySearch_TextChanged);
            // 
            // txb_CountSearch
            // 
            this.txb_CountSearch.Location = new System.Drawing.Point(581, 406);
            this.txb_CountSearch.Name = "txb_CountSearch";
            this.txb_CountSearch.Size = new System.Drawing.Size(100, 20);
            this.txb_CountSearch.TabIndex = 44;
            this.txb_CountSearch.TextChanged += new System.EventHandler(this.txb_CountSearch_TextChanged);
            // 
            // txb_PriceSearch
            // 
            this.txb_PriceSearch.Location = new System.Drawing.Point(581, 356);
            this.txb_PriceSearch.Name = "txb_PriceSearch";
            this.txb_PriceSearch.Size = new System.Drawing.Size(100, 20);
            this.txb_PriceSearch.TabIndex = 43;
            this.txb_PriceSearch.TextChanged += new System.EventHandler(this.txb_PriceSearch_TextChanged);
            // 
            // lbl_NameSearch
            // 
            this.lbl_NameSearch.AutoSize = true;
            this.lbl_NameSearch.Location = new System.Drawing.Point(578, 290);
            this.lbl_NameSearch.Name = "lbl_NameSearch";
            this.lbl_NameSearch.Size = new System.Drawing.Size(35, 13);
            this.lbl_NameSearch.TabIndex = 42;
            this.lbl_NameSearch.Text = "Name";
            // 
            // lbl_PriceSearch
            // 
            this.lbl_PriceSearch.AutoSize = true;
            this.lbl_PriceSearch.Location = new System.Drawing.Point(578, 340);
            this.lbl_PriceSearch.Name = "lbl_PriceSearch";
            this.lbl_PriceSearch.Size = new System.Drawing.Size(31, 13);
            this.lbl_PriceSearch.TabIndex = 41;
            this.lbl_PriceSearch.Text = "Price";
            // 
            // lbl_CountSearch
            // 
            this.lbl_CountSearch.AutoSize = true;
            this.lbl_CountSearch.Location = new System.Drawing.Point(578, 387);
            this.lbl_CountSearch.Name = "lbl_CountSearch";
            this.lbl_CountSearch.Size = new System.Drawing.Size(35, 13);
            this.lbl_CountSearch.TabIndex = 40;
            this.lbl_CountSearch.Text = "Count";
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(609, 262);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(41, 13);
            this.lbl_Search.TabIndex = 39;
            this.lbl_Search.Text = "Search";
            // 
            // txb_NameSearch
            // 
            this.txb_NameSearch.Location = new System.Drawing.Point(581, 306);
            this.txb_NameSearch.Name = "txb_NameSearch";
            this.txb_NameSearch.Size = new System.Drawing.Size(100, 20);
            this.txb_NameSearch.TabIndex = 38;
            this.txb_NameSearch.TextChanged += new System.EventHandler(this.txb_NameSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(708, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "User Name";
            // 
            // txb_SearchUserName
            // 
            this.txb_SearchUserName.Location = new System.Drawing.Point(711, 306);
            this.txb_SearchUserName.Name = "txb_SearchUserName";
            this.txb_SearchUserName.Size = new System.Drawing.Size(100, 20);
            this.txb_SearchUserName.TabIndex = 50;
            this.txb_SearchUserName.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // AdminAllProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 542);
            this.Controls.Add(this.txb_SearchUserName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_BoughtCountSearch);
            this.Controls.Add(this.txb_SearchBoughtCount);
            this.Controls.Add(this.lbl_CategorySearch);
            this.Controls.Add(this.txb_CategorySearch);
            this.Controls.Add(this.txb_CountSearch);
            this.Controls.Add(this.txb_PriceSearch);
            this.Controls.Add(this.lbl_NameSearch);
            this.Controls.Add(this.lbl_PriceSearch);
            this.Controls.Add(this.lbl_CountSearch);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.txb_NameSearch);
            this.Controls.Add(this.lbl_UpdateName);
            this.Controls.Add(this.lbl_UpdatePrice);
            this.Controls.Add(this.lbl_UpdateCount);
            this.Controls.Add(this.lbl_UpdateCategory);
            this.Controls.Add(this.lbl_Description);
            this.Controls.Add(this.lbl_Update);
            this.Controls.Add(this.cmb_UpdateCategory);
            this.Controls.Add(this.cmb_AddCategory);
            this.Controls.Add(this.lbl_AddName);
            this.Controls.Add(this.lbl_AddPrice);
            this.Controls.Add(this.lbl_AddCount);
            this.Controls.Add(this.lbl_AddCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_AddName);
            this.Controls.Add(this.txb_AddPrice);
            this.Controls.Add(this.txb_AddCount);
            this.Controls.Add(this.txb_UpdateName);
            this.Controls.Add(this.txb_UpdatePrice);
            this.Controls.Add(this.txb_UpdateCount);
            this.Controls.Add(this.txb_Description);
            this.Controls.Add(this.btn_AdminAdd);
            this.Controls.Add(this.btn_AdminUpdate);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_AllProducts);
            this.Controls.Add(this.dgv_AdminProducts);
            this.Name = "AdminAllProducts";
            this.Text = "AdminAllProducts";
            
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AdminProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_AdminProducts;
        private System.Windows.Forms.Button btn_AllProducts;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_AdminUpdate;
        private System.Windows.Forms.Button btn_AdminAdd;
        private System.Windows.Forms.TextBox txb_Description;
        private System.Windows.Forms.TextBox txb_UpdateCount;
        private System.Windows.Forms.TextBox txb_UpdatePrice;
        private System.Windows.Forms.TextBox txb_UpdateName;
        private System.Windows.Forms.TextBox txb_AddCount;
        private System.Windows.Forms.TextBox txb_AddPrice;
        private System.Windows.Forms.TextBox txb_AddName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_AddCategory;
        private System.Windows.Forms.Label lbl_AddCount;
        private System.Windows.Forms.Label lbl_AddPrice;
        private System.Windows.Forms.Label lbl_AddName;
        private System.Windows.Forms.ComboBox cmb_AddCategory;
        private System.Windows.Forms.ComboBox cmb_UpdateCategory;
        private System.Windows.Forms.Label lbl_Update;
        private System.Windows.Forms.Label lbl_Description;
        private System.Windows.Forms.Label lbl_UpdateCategory;
        private System.Windows.Forms.Label lbl_UpdateCount;
        private System.Windows.Forms.Label lbl_UpdatePrice;
        private System.Windows.Forms.Label lbl_UpdateName;
        private System.Windows.Forms.Label lbl_BoughtCountSearch;
        private System.Windows.Forms.TextBox txb_SearchBoughtCount;
        private System.Windows.Forms.Label lbl_CategorySearch;
        private System.Windows.Forms.TextBox txb_CategorySearch;
        private System.Windows.Forms.TextBox txb_CountSearch;
        private System.Windows.Forms.TextBox txb_PriceSearch;
        private System.Windows.Forms.Label lbl_NameSearch;
        private System.Windows.Forms.Label lbl_PriceSearch;
        private System.Windows.Forms.Label lbl_CountSearch;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.TextBox txb_NameSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_SearchUserName;
    }
}