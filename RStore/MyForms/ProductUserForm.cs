using RStore.DAL;
using RStore.DataContext;
using RStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RStore.MyForms
{
    public partial class ProductUserForm : Form
    {
        MyDatabase myDatabase = new MyDatabase();
        
        public ProductUserForm()
        {
            InitializeComponent();
            GetAllUserProduct(MyDatabase.userId);



            SetCategory();
        }
        CrudDb crud = new CrudDb();
        private void btn_Add_Click(object sender, EventArgs e)
        {
            
            Product product = new Product()
            {
                Name = txb_AddName.Text,
                Price = Convert.ToDouble(txb_AddPrice.Text),
                CategoryId=Convert.ToInt32(cmb_CategoryAdd.Text.Split('-')[0]),
                UserId=MyDatabase.userId,
                Count=Convert.ToInt32(txb_AddCount.Text),
                BoughtCount=0,
                Status="Active"
            };
            Logs logs = new Logs()
            {
                Status = "Active",
                Id = product.Id,
                ModifiedDate = DateTime.Now

            };
            crud.AddProduct(product,logs);
            MessageBox.Show("Product Added");
            GetAllUserProduct(MyDatabase.userId);

        }
        
        
        public void SetCategory()
        {
            using (RStoreDataContext rStore = new RStoreDataContext())
            {
                foreach (Category category in rStore.Categories.ToList())
                {
                    cmb_CategoryAdd.Items.Add(category.Id + "-" + category.Name);
                    cmb_CategoryUpdate.Items.Add(category.Id + "-" + category.Name);
                }
            }
        }

        public void GetAllUserProduct(int id)
        {
            using(RStoreDataContext context=new RStoreDataContext())
            {

                
                                var products = context.Products.Join(
                                    context.Logs,
                                    product => product.Id,
                                    log => log.Product.Id,
                                    (product, log) => new
                                    {
                                        product.Id,
                                        product.Name,
                                        product.Price,
                                        product.Count,
                                        product.BoughtCount,
                                        product.Status,
                                        product.UserId,
                                        CategoryName = product.Category.Name,
                                        Description = log.Description,
                                        LogStatus = log.Status,
                                        ModifiedDate = log.ModifiedDate
                                    }).Where(x => x.UserId == id).Where(x => x.Status == "Active").ToList();

                                
                                dgv_UserProducts.DataSource = products;
                                
            }
        }

        private void btn_AllProducts_Click(object sender, EventArgs e)
        {
            GetAllUserProduct(MyDatabase.userId);
        }

        private void dgv_UserProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = 0;

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
            
           
        }
        public void SearchForName(string key,int id)
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
                                        product.Price,
                                        product.Count,
                                        product.BoughtCount,
                                        product.Status,
                                        product.UserId,
                                        CategoryName = product.Category.Name,
                                        Description = log.Description,
                                        LogStatus = log.Status,
                                        ModifiedDate = log.ModifiedDate
                                    }).Where(x => x.Name.Contains(key)).Where(x => x.UserId == id).Where(x => x.Status == "Active").ToList();


                dgv_UserProducts.DataSource = products;

               
            }
        }
        public void SearchForCategoryName(string key, int id)
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
                                        product.Price,
                                        product.Count,
                                        product.BoughtCount,
                                        product.Status,
                                        product.UserId,
                                        CategoryName = product.Category.Name,
                                        Description = log.Description,
                                        LogStatus = log.Status,
                                        ModifiedDate = log.ModifiedDate
                                    }).Where(x => x.CategoryName.Contains(key)).Where(x => x.UserId == id).Where(x => x.Status == "Active").ToList();


                dgv_UserProducts.DataSource = products;
                
            }
        }
        public void SearchForPrice(double price, int id)
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
                                        product.Price,
                                        product.Count,
                                        product.BoughtCount,
                                        product.Status,
                                        product.UserId,
                                        CategoryName = product.Category.Name,
                                        Description = log.Description,
                                        LogStatus = log.Status,
                                        ModifiedDate = log.ModifiedDate
                                    }).Where(x => x.Price == price).Where(x => x.UserId == id).Where(x => x.Status == "Active").ToList();


                dgv_UserProducts.DataSource = products;

            }
           
        }
        public void SearchForCount(int count, int id)
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
                                        product.Price,
                                        product.Count,
                                        product.BoughtCount,
                                        product.Status,
                                        product.UserId,
                                        CategoryName = product.Category.Name,
                                        Description = log.Description,
                                        LogStatus = log.Status,
                                        ModifiedDate = log.ModifiedDate
                                    }).Where(x => x.Count == count).Where(x => x.UserId == id).Where(x => x.Status == "Active").ToList();


                dgv_UserProducts.DataSource = products;

            }
            
        }
        public void SearchForBoughtCount(int boughtcount, int id)
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
                                        product.Price,
                                        product.Count,
                                        product.BoughtCount,
                                        product.Status,
                                        product.UserId,
                                        CategoryName = product.Category.Name,
                                        Description = log.Description,
                                        LogStatus = log.Status,
                                        ModifiedDate = log.ModifiedDate
                                    }).Where(x => x.BoughtCount == boughtcount).Where(x => x.UserId == id).Where(x => x.Status == "Active").ToList();


                dgv_UserProducts.DataSource = products;

            }
            
        }
        

        private void txb_NameSearch_TextChanged(object sender, EventArgs e)
        {
            SearchForName(txb_NameSearch.Text, MyDatabase.userId);
        }

        private void txb_PriceSearch_TextChanged(object sender, EventArgs e)
        {



            try
            {
                if (txb_PriceSearch.Text != "")
                {
                    double _price = Convert.ToDouble(txb_PriceSearch.Text);
                    SearchForPrice(_price, MyDatabase.userId);
                }
                else
                {
                    GetAllUserProduct(MyDatabase.userId);
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
                    int _count = Convert.ToInt32(txb_CountSearch.Text);
                    SearchForCount(_count, MyDatabase.userId);

                }
                else
                {
                    GetAllUserProduct(MyDatabase.userId);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please add number");
            }
            
        }

        private void txb_CategorySearch_TextChanged(object sender, EventArgs e)
        {
            SearchForCategoryName(txb_CategorySearch.Text, MyDatabase.userId);
        }

        private void txb_SearchBoughtCount_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txb_SearchBoughtCount.Text != "")
                {
                    int _boughtcount = Convert.ToInt32(txb_SearchBoughtCount.Text);
                    SearchForBoughtCount(_boughtcount, MyDatabase.userId);
                }
                else
                {
                    GetAllUserProduct(MyDatabase.userId);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please add number");
            }
            
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgv_UserProducts.CurrentRow.Cells[0].Value);
            DialogResult result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using(RStoreDataContext context =new RStoreDataContext())
                {
                    var product = context.Products.FirstOrDefault(x => x.Id == id);
                    product.Status = "Deleted";
                    context.SaveChanges();
                    GetAllUserProduct(MyDatabase.userId);


                }
            }
            else
            {
                GetAllUserProduct(MyDatabase.userId);
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgv_UserProducts.CurrentRow.Cells[0].Value);
            using(RStoreDataContext context =new RStoreDataContext())
            {
                var products = context.Products.FirstOrDefault(x => x.Id == id);
                if(txb_NameUpdate.Text!= "")
                {
                    products.Name = txb_NameUpdate.Text.ToString();
                }

                if(txb_PriceUpdate.Text != "")
                {
                    products.Price = Convert.ToInt32(txb_PriceUpdate.Text);
                }

                if (txb_CountUpdate.Text != "")
                {
                    products.Count = Convert.ToInt32(txb_CountUpdate.Text);
                }

                if (cmb_CategoryUpdate.Text != "")
                {
                  
                   products.CategoryId = Convert.ToInt32(cmb_CategoryUpdate.Text.Split('-')[0]);
                }
                context.SaveChanges();
                GetAllUserProduct(MyDatabase.userId);
            }
        }

        
    }
}
