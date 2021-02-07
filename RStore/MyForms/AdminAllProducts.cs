using RStore.DAL;
using RStore.DataContext;
using RStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RStore.MyForms
{
    public partial class AdminAllProducts : Form
    {
        public AdminAllProducts()
        {
            InitializeComponent();
            SetCategory();
            GetAllProducts();
        }

        public void SetCategory()
        {
            using (RStoreDataContext rStore = new RStoreDataContext())
            {
                foreach (Category category in rStore.Categories.ToList())
                {
                    cmb_AddCategory.Items.Add(category.Id + "-" + category.Name);
                    cmb_UpdateCategory.Items.Add(category.Id + "-" + category.Name);
                }
            }
        }


        public void GetAllProducts()
        {
            using(RStoreDataContext context =new RStoreDataContext())
            {
                var products = context.Products.
                   Select(product => new
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
                       CategoryName = product.Category.Name
                   }).Where(x=>x.Status=="Active").ToList();

                dgv_AdminProducts.DataSource = products;
            }
        }
        private void btn_AllProducts_Click(object sender, EventArgs e)
        {
            GetAllProducts();
        }

        private void btn_AdminAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                Name = txb_AddName.Text,
                Price = Convert.ToDouble(txb_AddPrice.Text),
                CategoryId = Convert.ToInt32(cmb_AddCategory.Text.Split('-')[0]),
                UserId =2,
                Count = Convert.ToInt32(txb_AddCount.Text),
                BoughtCount = 0,
                Status = "Active",
                
                
            };
            using(RStoreDataContext context=new RStoreDataContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
                MessageBox.Show("Added");
                GetAllProducts();
            }
        }
        public void SearchForName(string key)
        {
            using (RStoreDataContext rStore = new RStoreDataContext())
            {


                var products = rStore.Products.
                   Select(x => new
                   {
                       x.Id,
                       x.Name,
                       UserName = x.User.Name,
                       UserPhoneNumber = x.User.PhoneNumber,
                       x.Price,
                       x.Count,
                       x.BoughtCount,
                       x.Status,
                       x.UserId,
                       CategoryName = x.Category.Name
                   }).Where(x => x.Name.Contains(key)).Where(x => x.Status == "Active").ToList();

                dgv_AdminProducts.DataSource = products;
            }
        }
        public void SearchForUserName(string key)
        {
            using (RStoreDataContext rStore = new RStoreDataContext())
            {


                var products = rStore.Products.
                   Select(x => new
                   {
                       x.Id,
                       x.Name,
                       UserName = x.User.Name,
                       UserPhoneNumber = x.User.PhoneNumber,
                       x.Price,
                       x.Count,
                       x.BoughtCount,
                       x.Status,
                       x.UserId,
                       CategoryName = x.Category.Name
                   }).Where(x => x.UserName.Contains(key)).Where(x => x.Status == "Active").ToList();

                dgv_AdminProducts.DataSource = products;
            }
        }
        public void SearchForCategory(string key)
        {
            using (RStoreDataContext rStore = new RStoreDataContext())
            {


                var products = rStore.Products.
                   Select(x => new
                   {
                       x.Id,
                       x.Name,
                       UserName = x.User.Name,
                       UserPhoneNumber = x.User.PhoneNumber,
                       x.Price,
                       x.Count,
                       x.BoughtCount,
                       x.Status,
                       x.UserId,
                       CategoryName = x.Category.Name
                   }).Where(x => x.CategoryName.Contains(key)).Where(x => x.Status == "Active").ToList();

                dgv_AdminProducts.DataSource = products;
            }
        }
        public void SearchForPrice(double price)
        {
            using (RStoreDataContext rStore = new RStoreDataContext())
            {


                var products = rStore.Products.
                   Select(x => new
                   {
                       x.Id,
                       x.Name,
                       UserName = x.User.Name,
                       UserPhoneNumber = x.User.PhoneNumber,
                       x.Price,
                       x.Count,
                       x.BoughtCount,
                       x.Status,
                       x.UserId,
                       CategoryName = x.Category.Name
                   }).Where(x => x.Price==price).Where(x => x.Status == "Active").ToList();

                dgv_AdminProducts.DataSource = products;
            }
        }
        public void SearchForCount(int count)
        {
            using (RStoreDataContext rStore = new RStoreDataContext())
            {


                var products = rStore.Products.
                   Select(x => new
                   {
                       x.Id,
                       x.Name,
                       UserName = x.User.Name,
                       UserPhoneNumber = x.User.PhoneNumber,
                       x.Price,
                       x.Count,
                       x.BoughtCount,
                       x.Status,
                       x.UserId,
                       CategoryName = x.Category.Name
                   }).Where(x => x.Count == count).Where(x => x.Status == "Active").ToList();

                dgv_AdminProducts.DataSource = products;
            }
        }
        public void SearchForBoughtCount(int boughtcount)
        {
            using (RStoreDataContext rStore = new RStoreDataContext())
            {


                var products = rStore.Products.
                   Select(x => new
                   {
                       x.Id,
                       x.Name,
                       UserName = x.User.Name,
                       UserPhoneNumber = x.User.PhoneNumber,
                       x.Price,
                       x.Count,
                       x.BoughtCount,
                       x.Status,
                       x.UserId,
                       CategoryName = x.Category.Name
                   }).Where(x => x.BoughtCount == boughtcount).Where(x => x.Status == "Active").ToList();

                dgv_AdminProducts.DataSource = products;
            }
        }
        private void txb_NameSearch_TextChanged(object sender, EventArgs e)
        {
            SearchForName(txb_NameSearch.Text);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SearchForUserName(txb_SearchUserName.Text);
        }

        private void txb_CategorySearch_TextChanged(object sender, EventArgs e)
        {
            SearchForCategory(txb_CategorySearch.Text);
        }

        private void txb_PriceSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txb_PriceSearch.Text != "")
                {
                    double price = Convert.ToDouble(txb_PriceSearch.Text);
                    SearchForPrice(price);
                }
                else
                {
                    GetAllProducts();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please add number");
            }
            
        }

        private void txb_CountSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txb_CountSearch.Text != "")
                {
                    int count = Convert.ToInt32(txb_CountSearch.Text);
                    SearchForCount(count);

                }
                else
                {
                    GetAllProducts();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please add number ");
            }
        }

        private void txb_SearchBoughtCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txb_SearchBoughtCount.Text != "")
                {
                    int boughtcount = Convert.ToInt32(txb_SearchBoughtCount.Text);
                    SearchForBoughtCount(boughtcount);

                }
                else
                {
                    GetAllProducts();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please add number ");
            }
            
        }

        private void dgv_AdminProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgv_AdminProducts.CurrentRow.Cells[0].Value);
            string name;
            using (RStoreDataContext context = new RStoreDataContext())
            {
                var products = context.Products.Where(x => x.Id == id).FirstOrDefault();
                string categoryname = dgv_AdminProducts.CurrentRow.Cells[9].Value.ToString();
                Category category = context.Categories.Where(c => c.Name == categoryname).FirstOrDefault();
                name = category.Name;
                cmb_UpdateCategory.Text = $"{products.CategoryId.ToString()}-{ name}";


            }
           
            txb_UpdateName.Text = dgv_AdminProducts.CurrentRow.Cells[1].Value.ToString();
            txb_UpdatePrice.Text = dgv_AdminProducts.CurrentRow.Cells[4].Value.ToString();
            txb_UpdateCount.Text = dgv_AdminProducts.CurrentRow.Cells[5].Value.ToString();
            /*int id = 0;

            using(RStoreDataContext context=new RStoreDataContext())
            {
                string categoryname = dgv_UserProducts.CurrentRow.Cells[7].Value.ToString();
                 Category category = context.Categories.Where(c => c.Name == categoryname).FirstOrDefault();
                id = category.Id;
            };
            
            txb_NameUpdate.Text = dgv_UserProducts.CurrentRow.Cells[1].Value.ToString();
            txb_PriceUpdate.Text = dgv_UserProducts.CurrentRow.Cells[2].Value.ToString();
            txb_CountUpdate.Text = dgv_UserProducts.CurrentRow.Cells[3].Value.ToString();
            cmb_CategoryUpdate.Text = $"{id}-{dgv_UserProducts.CurrentRow.Cells[7].Value.ToString()}";
            
             */

        }

        private void btn_AdminUpdate_Click(object sender, EventArgs e)
        {
            if (txb_Description.Text != "")
            {
                int id = Convert.ToInt32(dgv_AdminProducts.CurrentRow.Cells[0].Value);

                Logs logs = new Logs()
                {
                    ProductId = Convert.ToInt32(dgv_AdminProducts.CurrentRow.Cells[0].Value),
                    Status = "Updated",
                    Description = txb_Description.Text,
                    ModifiedDate = DateTime.Now
                    
                };
                
                


                using(RStoreDataContext context =new RStoreDataContext())
                {
                    var products = context.Products.Where(x => x.Id == id).FirstOrDefault();
                    products.Name = txb_UpdateName.Text;
                    products.Price = Convert.ToDouble(txb_UpdatePrice.Text);
                    products.Count = Convert.ToInt32(txb_UpdateCount.Text);
                    products.Status = "Active";
                    products.CategoryId = Convert.ToInt32(cmb_UpdateCategory.Text.Split('-')[0]);
                    context.Logs.Add(logs);
                    context.SaveChanges();
                    GetAllProducts();
                    MessageBox.Show("Updated");


                }
            }
            else
            {
                MessageBox.Show("Please add description");
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txb_Description.Text != "")
            {
                int id = Convert.ToInt32(dgv_AdminProducts.CurrentRow.Cells[0].Value);
                DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Logs logs = new Logs()
                    {
                        Status = "Deleted",
                        ProductId = id,
                        Description = txb_Description.Text,
                        ModifiedDate = DateTime.Now

                    };
                    using (RStoreDataContext context = new RStoreDataContext())
                    {
                        context.Logs.Add(logs);
                        var products = context.Products.Where(x => x.Id == id).FirstOrDefault();
                        products.Status = "Deleted";
                        context.SaveChanges();
                        MessageBox.Show("Deleted");
                        GetAllProducts();
                    }
                }
                else
                {
                    GetAllProducts();
                }
            }
            else
            {
                MessageBox.Show("Please add description");
            }
        }

       
    }
}
