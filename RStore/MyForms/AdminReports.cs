using RStore.DataContext;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RStore.MyForms
{
    public partial class AdminReports : Form
    {
        public AdminReports()
        {
            InitializeComponent();
            AllReports();
        }
        public void AllReports()
        {


            using (RStoreDataContext context = new RStoreDataContext())
            {
                var products = context.Products.Join(
                    context.Logs,
                    product => product.Id,
                    log => log.Product.Id,
                    (product, log) => new
                    {
                        product.Id,
                        product.Name,
                        UserName = product.User.Name,
                        UserPhoneNumber = product.User.PhoneNumber,
                        product.Price,
                        product.Count,
                        product.BoughtCount,
                        product.Status,
                        product.UserId,
                        CategoryName = product.Category.Name,
                        Description = log.Description,
                        LogStatus = log.Status,
                        ModifiedDate = log.ModifiedDate
                    }).ToList();
                dgv_AdminReports.DataSource = products;
            }
        }
        public void NameSearch(string name)
        {
            using (RStoreDataContext context = new RStoreDataContext())
            {
                var products = context.Products.Join(
                    context.Logs,
                    product => product.Id,
                    log => log.Product.Id,
                    (product, log) => new
                    {
                        product.Id,
                        product.Name,
                        UserName = product.User.Name,
                        UserPhoneNumber = product.User.PhoneNumber,
                        product.Price,
                        product.Count,
                        product.BoughtCount,
                        product.Status,
                        product.UserId,
                        CategoryName = product.Category.Name,
                        Description = log.Description,
                        LogStatus = log.Status,
                        ModifiedDate = log.ModifiedDate
                    }).Where(c=>c.Name.Contains(name)).ToList();
                dgv_AdminReports.DataSource = products;
            }
        }
        public void SearchForCategoryName (string category)
        {
            using (RStoreDataContext context = new RStoreDataContext())
            {
                var products = context.Products.Join(
                    context.Logs,
                    product => product.Id,
                    log => log.Product.Id,
                    (product, log) => new
                    {
                        product.Id,
                        product.Name,
                        UserName = product.User.Name,
                        UserPhoneNumber = product.User.PhoneNumber,
                        product.Price,
                        product.Count,
                        product.BoughtCount,
                        product.Status,
                        product.UserId,
                        CategoryName = product.Category.Name,
                        Description = log.Description,
                        LogStatus = log.Status,
                        ModifiedDate = log.ModifiedDate
                    }).Where(c => c.CategoryName.Contains(category)).ToList();
                dgv_AdminReports.DataSource = products;
            }
        }
        public void SearchForStatus(string status)
        {
            using (RStoreDataContext context = new RStoreDataContext())
            {
                var products = context.Products.Join(
                    context.Logs,
                    product => product.Id,
                    log => log.Product.Id,
                    (product, log) => new
                    {
                        product.Id,
                        product.Name,
                        UserName = product.User.Name,
                        UserPhoneNumber = product.User.PhoneNumber,
                        product.Price,
                        product.Count,
                        product.BoughtCount,
                        product.Status,
                        product.UserId,
                        CategoryName = product.Category.Name,
                        Description = log.Description,
                        LogStatus = log.Status,
                        ModifiedDate = log.ModifiedDate
                    }).Where(c => c.LogStatus.Contains(status)).ToList();
                dgv_AdminReports.DataSource = products;
            }
        }
        public void SearchForUserName(string username)
        {
            using (RStoreDataContext context = new RStoreDataContext())
            {
                var products = context.Products.Join(
                    context.Logs,
                    product => product.Id,
                    log => log.Product.Id,
                    (product, log) => new
                    {
                        product.Id,
                        product.Name,
                        UserName = product.User.Name,
                        UserPhoneNumber = product.User.PhoneNumber,
                        product.Price,
                        product.Count,
                        product.BoughtCount,
                        product.Status,
                        product.UserId,
                        CategoryName = product.Category.Name,
                        Description = log.Description,
                        LogStatus = log.Status,
                        ModifiedDate = log.ModifiedDate
                    }).Where(c => c.UserName.Contains(username)).ToList();
                dgv_AdminReports.DataSource = products;
            }
        }
        public void SearchForPrice(double price)
        {
            using (RStoreDataContext context = new RStoreDataContext())
            {
                var products = context.Products.Join(
                    context.Logs,
                    product => product.Id,
                    log => log.Product.Id,
                    (product, log) => new
                    {
                        product.Id,
                        product.Name,
                        UserName = product.User.Name,
                        UserPhoneNumber = product.User.PhoneNumber,
                        product.Price,
                        product.Count,
                        product.BoughtCount,
                        product.Status,
                        product.UserId,
                        CategoryName = product.Category.Name,
                        Description = log.Description,
                        LogStatus = log.Status,
                        ModifiedDate = log.ModifiedDate
                    }).Where(c => c.Price==price).ToList();
                dgv_AdminReports.DataSource = products;
            }
        }
        public void SearchForCount(int count)
        {
            using (RStoreDataContext context = new RStoreDataContext())
            {
                var products = context.Products.Join(
                    context.Logs,
                    product => product.Id,
                    log => log.Product.Id,
                    (product, log) => new
                    {
                        product.Id,
                        product.Name,
                        UserName = product.User.Name,
                        UserPhoneNumber = product.User.PhoneNumber,
                        product.Price,
                        product.Count,
                        product.BoughtCount,
                        product.Status,
                        product.UserId,
                        CategoryName = product.Category.Name,
                        Description = log.Description,
                        LogStatus = log.Status,
                        ModifiedDate = log.ModifiedDate
                    }).Where(c => c.Count == count).ToList();
                dgv_AdminReports.DataSource = products;
            }
        }
        public void SearchForBoughtCount(int bouhgtcount)
        {
            using (RStoreDataContext context = new RStoreDataContext())
            {
                var products = context.Products.Join(
                    context.Logs,
                    product => product.Id,
                    log => log.Product.Id,
                    (product, log) => new
                    {
                        product.Id,
                        product.Name,
                        UserName = product.User.Name,
                        UserPhoneNumber = product.User.PhoneNumber,
                        product.Price,
                        product.Count,
                        product.BoughtCount,
                        product.Status,
                        product.UserId,
                        CategoryName = product.Category.Name,
                        Description = log.Description,
                        LogStatus = log.Status,
                        ModifiedDate = log.ModifiedDate
                    }).Where(c => c.BoughtCount == bouhgtcount).ToList();
               
                dgv_AdminReports.DataSource = products;
            }
        }
        private void btn_AllReport_Click(object sender, EventArgs e)
        {
            AllReports();
        }

        private void txb_SearchProductName_TextChanged(object sender, EventArgs e)
        {
            NameSearch(txb_SearchProductName.Text);
        }

        private void txb_SearchCategoryName_TextChanged(object sender, EventArgs e)
        {
            SearchForCategoryName(txb_SearchCategoryName.Text);
        }

        private void txb_StatusSearch_TextChanged(object sender, EventArgs e)
        {
            SearchForStatus(txb_StatusSearch.Text);
        }

        private void txb_SearchUserName_TextChanged(object sender, EventArgs e)
        {
            SearchForUserName(txb_SearchUserName.Text);
        }

        private void txb_PriceSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txb_PriceSearch.Text != "")
                {
                    SearchForPrice(Convert.ToDouble(txb_PriceSearch.Text));
                }
                else
                {
                    AllReports();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please add number");
            }
        }

        private void txb_SearchCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txb_SearchCount.Text != "")
                {
                    SearchForCount(Convert.ToInt32(txb_SearchCount.Text));
                }
                else
                {
                    AllReports();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please add number");
            }
        }

        private void txb_SearchBoughtCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txb_SearchBoughtCount.Text != "")
                {
                    SearchForBoughtCount(Convert.ToInt32(txb_SearchBoughtCount.Text));
                }
                else
                {
                    AllReports();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please add number");
            }
        }
    }
    
}
