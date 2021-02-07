using RStore.DAL;
using RStore.DataContext;
using RStore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RStore.MyForms
{
    public partial class AllProductsForm : Form
    {
        public AllProductsForm()
        {
            InitializeComponent();
            
            GetAllCategory();
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            using(RStoreDataContext context=new RStoreDataContext())
            {
                int id = Convert.ToInt32(dgv_AllProductView.CurrentRow.Cells[10].Value);
                if (MyDatabase.userId != id)
                {
                    Button button = new Button();
                    button.Text = "Buy";
                    button.Location = new Point(32, 13);
                    button.Size = new Size(75, 23);
                    Controls.Add(button);

                    button.Click += new EventHandler(button_Click);
                }
            }
            
        }
        private void button_Click(object sender, EventArgs e)
        {
            int _count = Convert.ToInt32(dgv_AllProductView.CurrentRow.Cells[6].Value);
            _count--;
            int _boughtcount = Convert.ToInt32(dgv_AllProductView.CurrentRow.Cells[7].Value);
            _boughtcount++;
            Product product = new Product()
            {
                Id = Convert.ToInt32(dgv_AllProductView.CurrentRow.Cells[0].Value),
                Name = dgv_AllProductView.CurrentRow.Cells[1].Value.ToString(),
                Price = Convert.ToDouble(dgv_AllProductView.CurrentRow.Cells[2].Value),
                Count = _count,
                BoughtCount = _boughtcount,
                UserId = Convert.ToInt32(dgv_AllProductView.CurrentRow.Cells[10].Value),
                CategoryId = Convert.ToInt32(dgv_AllProductView.CurrentRow.Cells[9].Value),
                Status = dgv_AllProductView.CurrentRow.Cells[8].Value.ToString()
            };
            using(RStoreDataContext context=new RStoreDataContext())
            {
                context.Products.AddOrUpdate(product);
                context.SaveChanges();
                MessageBox.Show("Thanks");
                
                GetAllProduct();
            }
        }
       public void GetAllProduct()
        {
            using(RStoreDataContext context=new RStoreDataContext())
            {
                var products = context.Products.Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Price,
                    CategoryName = x.Category.Name,
                    UserName = x.User.Name,
                    UserPhoneNumber = x.User.PhoneNumber,
                    x.Count,
                    x.BoughtCount,
                    x.Status,
                    x.CategoryId,
                    x.UserId


                }).Where(x => x.Count > 0).Where(x=>x.Status=="Active").ToList();
                dgv_AllProductView.DataSource = products;
                
            }
        }

        public void GetAllCategory()
        {
            using(RStoreDataContext rStore=new RStoreDataContext())
            {
                var categories = rStore.Categories.ToList();
                cmb_SearchCategory.DisplayMember = "Name";
                cmb_SearchCategory.ValueMember = "Id";
                cmb_SearchCategory.DataSource = categories;
                
                
            }
        }
        public void SearchForCategory(int id)
        {
            using (RStoreDataContext rStore = new RStoreDataContext())
            {


                var products = rStore.Products.
                   Select(x => new
                   {
                       x.Id,
                       x.Name,
                       x.Price,
                       CategoryName = x.Category.Name,
                       UserName = x.User.Name,
                       UserPhoneNumber = x.User.PhoneNumber,
                       x.Count,
                       x.BoughtCount,
                       x.Status,
                       x.CategoryId,
                       x.UserId
                   }).Where(x => x.CategoryId == id).Where(x=>x.Status=="Active").Where(x => x.Count > 0).ToList();
                 
                dgv_AllProductView.DataSource = products;
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
                       x.Price,
                       CategoryName = x.Category.Name,
                       UserName = x.User.Name,
                       UserPhoneNumber = x.User.PhoneNumber,
                       x.Count,
                       x.BoughtCount,
                       x.Status,
                       x.CategoryId,
                       x.UserId
                   }).Where(x => x.Name.Contains(key)).Where(x => x.Status == "Active").Where(x=>x.Count>0).ToList();

                dgv_AllProductView.DataSource = products;
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
                       x.Price,
                       CategoryName = x.Category.Name,
                       UserName = x.User.Name,
                       UserPhoneNumber = x.User.PhoneNumber,
                       x.Count,
                       x.BoughtCount,
                       x.Status,
                       x.CategoryId,
                       x.UserId
                   }).Where(x => x.UserName.Contains(key)).Where(x => x.Count > 0).Where(x=>x.Status=="Active").ToList();

                dgv_AllProductView.DataSource = products;
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
                       x.Price,
                       CategoryName = x.Category.Name,
                       UserName = x.User.Name,
                       UserPhoneNumber = x.User.PhoneNumber,
                       x.Count,
                       x.BoughtCount,
                       x.Status,
                       x.CategoryId,
                       x.UserId
                   }).Where(x => x.Count==count).Where(x => x.Status == "Active").Where(x => x.Count > 0).ToList();

                dgv_AllProductView.DataSource = products;
            }
        }
        public void SearchForPrice(int price)
        {
            using (RStoreDataContext rStore = new RStoreDataContext())
            {


                var products = rStore.Products.
                   Select(x => new
                   {
                       x.Id,
                       x.Name,
                       x.Price,
                       CategoryName = x.Category.Name,
                       UserName = x.User.Name,
                       UserPhoneNumber = x.User.PhoneNumber,
                       x.Count,
                       x.BoughtCount,
                       x.Status,
                       x.CategoryId,
                       x.UserId
                   }).Where(x => x.Price == price).Where(x => x.Status == "Active").Where(x => x.Count > 0).ToList();

                dgv_AllProductView.DataSource = products;
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
                       x.Price,
                       CategoryName = x.Category.Name,
                       UserName = x.User.Name,
                       UserPhoneNumber = x.User.PhoneNumber,
                       x.Count,
                       x.BoughtCount,
                       x.Status,
                       x.CategoryId,
                       x.UserId
                   }).Where(x => x.BoughtCount == boughtcount).Where(x => x.Status == "Active").Where(x => x.Count > 0).ToList();

                dgv_AllProductView.DataSource = products;
            }
        }

        private void cmb_SearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchForCategory(Convert.ToInt32(cmb_SearchCategory.SelectedValue));
        }

        private void txb_SearchPName_TextChanged(object sender, EventArgs e)
        {
            SearchForName(txb_SearchPName.Text);
        }

        private void btn_AllProducts_Click(object sender, EventArgs e)
        {
            GetAllProduct();
        }

        private void txb_SearchUserName_TextChanged(object sender, EventArgs e)
        {
            SearchForUserName(txb_SearchUserName.Text);
        }

        private void txb_SearchPrice_TextChanged(object sender, EventArgs e)
        {
            if(txb_SearchPrice.Text != "")
            {
                SearchForPrice(Convert.ToInt32(txb_SearchPrice.Text));
            }
            else
            {
                GetAllProduct();
            }
        }

        private void txb_SearchCount_TextChanged(object sender, EventArgs e)
        {
            if (txb_SearchCount.Text != "")
            {
                SearchForCount(Convert.ToInt32(txb_SearchCount.Text));
            }
            else
            {
                GetAllProduct();
            }
        }

        private void txb_SearchBoughtCount_TextChanged(object sender, EventArgs e)
        {
            if (txb_SearchBoughtCount.Text != "")
            {
                SearchForBoughtCount(Convert.ToInt32(txb_SearchBoughtCount.Text));
            }
            else
            {
                GetAllProduct();
            }
        }
    }
}
