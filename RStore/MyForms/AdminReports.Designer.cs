namespace RStore.MyForms
{
    partial class AdminReports
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
            this.dgv_AdminReports = new System.Windows.Forms.DataGridView();
            this.txb_SearchProductName = new System.Windows.Forms.TextBox();
            this.txb_SearchCategoryName = new System.Windows.Forms.TextBox();
            this.lbl_Search = new System.Windows.Forms.Label();
            this.lbl_SearchProductName = new System.Windows.Forms.Label();
            this.lbl_SearchCategoryName = new System.Windows.Forms.Label();
            this.lbl_SearchSearch = new System.Windows.Forms.Label();
            this.btn_AllReport = new System.Windows.Forms.Button();
            this.txb_PriceSearch = new System.Windows.Forms.TextBox();
            this.txb_SearchUserName = new System.Windows.Forms.TextBox();
            this.txb_StatusSearch = new System.Windows.Forms.TextBox();
            this.lbl_PriceSearch = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txb_SearchBoughtCount = new System.Windows.Forms.TextBox();
            this.txb_SearchCount = new System.Windows.Forms.TextBox();
            this.lbl_BoughtCountSearch = new System.Windows.Forms.Label();
            this.lbl_CountSearch = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AdminReports)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_AdminReports
            // 
            this.dgv_AdminReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_AdminReports.Location = new System.Drawing.Point(70, 33);
            this.dgv_AdminReports.Name = "dgv_AdminReports";
            this.dgv_AdminReports.Size = new System.Drawing.Size(654, 150);
            this.dgv_AdminReports.TabIndex = 0;
            // 
            // txb_SearchProductName
            // 
            this.txb_SearchProductName.Location = new System.Drawing.Point(53, 260);
            this.txb_SearchProductName.Name = "txb_SearchProductName";
            this.txb_SearchProductName.Size = new System.Drawing.Size(100, 20);
            this.txb_SearchProductName.TabIndex = 1;
            this.txb_SearchProductName.TextChanged += new System.EventHandler(this.txb_SearchProductName_TextChanged);
            // 
            // txb_SearchCategoryName
            // 
            this.txb_SearchCategoryName.Location = new System.Drawing.Point(53, 306);
            this.txb_SearchCategoryName.Name = "txb_SearchCategoryName";
            this.txb_SearchCategoryName.Size = new System.Drawing.Size(100, 20);
            this.txb_SearchCategoryName.TabIndex = 2;
            this.txb_SearchCategoryName.TextChanged += new System.EventHandler(this.txb_SearchCategoryName_TextChanged);
            // 
            // lbl_Search
            // 
            this.lbl_Search.AutoSize = true;
            this.lbl_Search.Location = new System.Drawing.Point(86, 212);
            this.lbl_Search.Name = "lbl_Search";
            this.lbl_Search.Size = new System.Drawing.Size(41, 13);
            this.lbl_Search.TabIndex = 4;
            this.lbl_Search.Text = "Search";
            // 
            // lbl_SearchProductName
            // 
            this.lbl_SearchProductName.AutoSize = true;
            this.lbl_SearchProductName.Location = new System.Drawing.Point(50, 244);
            this.lbl_SearchProductName.Name = "lbl_SearchProductName";
            this.lbl_SearchProductName.Size = new System.Drawing.Size(72, 13);
            this.lbl_SearchProductName.TabIndex = 5;
            this.lbl_SearchProductName.Text = "ProductName";
            // 
            // lbl_SearchCategoryName
            // 
            this.lbl_SearchCategoryName.AutoSize = true;
            this.lbl_SearchCategoryName.Location = new System.Drawing.Point(50, 290);
            this.lbl_SearchCategoryName.Name = "lbl_SearchCategoryName";
            this.lbl_SearchCategoryName.Size = new System.Drawing.Size(80, 13);
            this.lbl_SearchCategoryName.TabIndex = 6;
            this.lbl_SearchCategoryName.Text = "Category Name";
            // 
            // lbl_SearchSearch
            // 
            this.lbl_SearchSearch.AutoSize = true;
            this.lbl_SearchSearch.Location = new System.Drawing.Point(50, 341);
            this.lbl_SearchSearch.Name = "lbl_SearchSearch";
            this.lbl_SearchSearch.Size = new System.Drawing.Size(37, 13);
            this.lbl_SearchSearch.TabIndex = 7;
            this.lbl_SearchSearch.Text = "Status";
            // 
            // btn_AllReport
            // 
            this.btn_AllReport.Location = new System.Drawing.Point(649, 189);
            this.btn_AllReport.Name = "btn_AllReport";
            this.btn_AllReport.Size = new System.Drawing.Size(75, 23);
            this.btn_AllReport.TabIndex = 9;
            this.btn_AllReport.Text = "All Report";
            this.btn_AllReport.UseVisualStyleBackColor = true;
            this.btn_AllReport.Click += new System.EventHandler(this.btn_AllReport_Click);
            // 
            // txb_PriceSearch
            // 
            this.txb_PriceSearch.Location = new System.Drawing.Point(227, 306);
            this.txb_PriceSearch.Name = "txb_PriceSearch";
            this.txb_PriceSearch.Size = new System.Drawing.Size(100, 20);
            this.txb_PriceSearch.TabIndex = 10;
            this.txb_PriceSearch.TextChanged += new System.EventHandler(this.txb_PriceSearch_TextChanged);
            // 
            // txb_SearchUserName
            // 
            this.txb_SearchUserName.Location = new System.Drawing.Point(227, 260);
            this.txb_SearchUserName.Name = "txb_SearchUserName";
            this.txb_SearchUserName.Size = new System.Drawing.Size(100, 20);
            this.txb_SearchUserName.TabIndex = 11;
            this.txb_SearchUserName.TextChanged += new System.EventHandler(this.txb_SearchUserName_TextChanged);
            // 
            // txb_StatusSearch
            // 
            this.txb_StatusSearch.Location = new System.Drawing.Point(53, 357);
            this.txb_StatusSearch.Name = "txb_StatusSearch";
            this.txb_StatusSearch.Size = new System.Drawing.Size(100, 20);
            this.txb_StatusSearch.TabIndex = 12;
            this.txb_StatusSearch.TextChanged += new System.EventHandler(this.txb_StatusSearch_TextChanged);
            // 
            // lbl_PriceSearch
            // 
            this.lbl_PriceSearch.AutoSize = true;
            this.lbl_PriceSearch.Location = new System.Drawing.Point(224, 290);
            this.lbl_PriceSearch.Name = "lbl_PriceSearch";
            this.lbl_PriceSearch.Size = new System.Drawing.Size(31, 13);
            this.lbl_PriceSearch.TabIndex = 13;
            this.lbl_PriceSearch.Text = "Price";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(224, 244);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(57, 13);
            this.lbl_UserName.TabIndex = 14;
            this.lbl_UserName.Text = "UserName";
            // 
            // txb_SearchBoughtCount
            // 
            this.txb_SearchBoughtCount.Location = new System.Drawing.Point(379, 260);
            this.txb_SearchBoughtCount.Name = "txb_SearchBoughtCount";
            this.txb_SearchBoughtCount.Size = new System.Drawing.Size(100, 20);
            this.txb_SearchBoughtCount.TabIndex = 15;
            this.txb_SearchBoughtCount.TextChanged += new System.EventHandler(this.txb_SearchBoughtCount_TextChanged);
            // 
            // txb_SearchCount
            // 
            this.txb_SearchCount.Location = new System.Drawing.Point(227, 357);
            this.txb_SearchCount.Name = "txb_SearchCount";
            this.txb_SearchCount.Size = new System.Drawing.Size(100, 20);
            this.txb_SearchCount.TabIndex = 16;
            this.txb_SearchCount.TextChanged += new System.EventHandler(this.txb_SearchCount_TextChanged);
            // 
            // lbl_BoughtCountSearch
            // 
            this.lbl_BoughtCountSearch.AutoSize = true;
            this.lbl_BoughtCountSearch.Location = new System.Drawing.Point(376, 244);
            this.lbl_BoughtCountSearch.Name = "lbl_BoughtCountSearch";
            this.lbl_BoughtCountSearch.Size = new System.Drawing.Size(69, 13);
            this.lbl_BoughtCountSearch.TabIndex = 17;
            this.lbl_BoughtCountSearch.Text = "BoughtCount";
            // 
            // lbl_CountSearch
            // 
            this.lbl_CountSearch.AutoSize = true;
            this.lbl_CountSearch.Location = new System.Drawing.Point(224, 341);
            this.lbl_CountSearch.Name = "lbl_CountSearch";
            this.lbl_CountSearch.Size = new System.Drawing.Size(35, 13);
            this.lbl_CountSearch.TabIndex = 18;
            this.lbl_CountSearch.Text = "Count";
            // 
            // AdminReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_CountSearch);
            this.Controls.Add(this.lbl_BoughtCountSearch);
            this.Controls.Add(this.txb_SearchCount);
            this.Controls.Add(this.txb_SearchBoughtCount);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.lbl_PriceSearch);
            this.Controls.Add(this.txb_StatusSearch);
            this.Controls.Add(this.txb_SearchUserName);
            this.Controls.Add(this.txb_PriceSearch);
            this.Controls.Add(this.btn_AllReport);
            this.Controls.Add(this.lbl_SearchSearch);
            this.Controls.Add(this.lbl_SearchCategoryName);
            this.Controls.Add(this.lbl_SearchProductName);
            this.Controls.Add(this.lbl_Search);
            this.Controls.Add(this.txb_SearchCategoryName);
            this.Controls.Add(this.txb_SearchProductName);
            this.Controls.Add(this.dgv_AdminReports);
            this.Name = "AdminReports";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_AdminReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_AdminReports;
        private System.Windows.Forms.TextBox txb_SearchProductName;
        private System.Windows.Forms.TextBox txb_SearchCategoryName;
        private System.Windows.Forms.Label lbl_Search;
        private System.Windows.Forms.Label lbl_SearchProductName;
        private System.Windows.Forms.Label lbl_SearchCategoryName;
        private System.Windows.Forms.Label lbl_SearchSearch;
        private System.Windows.Forms.Button btn_AllReport;
        private System.Windows.Forms.TextBox txb_PriceSearch;
        private System.Windows.Forms.TextBox txb_SearchUserName;
        private System.Windows.Forms.TextBox txb_StatusSearch;
        private System.Windows.Forms.Label lbl_PriceSearch;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txb_SearchBoughtCount;
        private System.Windows.Forms.TextBox txb_SearchCount;
        private System.Windows.Forms.Label lbl_BoughtCountSearch;
        private System.Windows.Forms.Label lbl_CountSearch;
    }
}