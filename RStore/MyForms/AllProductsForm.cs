using RStore.DAL;
using RStore.DataContext;
using RStore.Enums;
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
            GetAllProduct();
            GetAllCategory();
            using (RStoreDataContext context1 = new RStoreDataContext())
            {
                var pr = context1.Products.FirstOrDefault();
                DateTime dateTime = DateTime.Now;
                int date = Convert.ToInt32((dateTime - pr.ExpiredDate).TotalDays);
                if (date == 0)
                {
                    pr.Status = Status.Expired.ToString();
                    context1.SaveChanges();
                }
            }


        }
        public void GetAllProduct()
        {
            using (RStoreDataContext context = new RStoreDataContext())
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


                }).Where(x => x.Count > 0).Where(x => x.Status == Status.Active.ToString()).ToList();
                dgv_AllProductView.DataSource = products;

            }
        }
        public void GetAllCategory()
        {
            using (RStoreDataContext rStore = new RStoreDataContext())
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
                   }).Where(x => x.CategoryId == id).Where(x => x.Status == Status.Active.ToString()).Where(x => x.Count > 0).ToList();

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
                   }).Where(x => x.Name.Contains(key)).Where(x => x.Status == Status.Active.ToString()).Where(x => x.Count > 0).ToList();

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
                   }).Where(x => x.UserName.Contains(key)).Where(x => x.Count > 0).Where(x => x.Status == Status.Active.ToString()).ToList();

                dgv_AllProductView.DataSource = products;
            }
        }
        public void SearchForCount(string count)
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
                   }).Where(x => x.Count.ToString().Contains(count)).Where(x => x.Status == Status.Active.ToString()).Where(x => x.Count > 0).ToList();

                dgv_AllProductView.DataSource = products;
            }
        }
        public void SearchForPrice(string price)
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
                   }).Where(x => x.Price.ToString().Contains(price)).Where(x => x.Status == Status.Active.ToString()).Where(x => x.Count > 0).ToList();

                dgv_AllProductView.DataSource = products;
            }
        }
        public void SearchForBoughtCount(string boughtcount)
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
                   }).Where(x => x.BoughtCount.ToString().Contains(boughtcount)).Where(x => x.Status == Status.Active.ToString()).Where(x => x.Count > 0).ToList();

                dgv_AllProductView.DataSource = products;
            }
        }

        private void btn_AllProducts_Click(object sender, EventArgs e)
        {
            GetAllProduct();
        }

        private void txb_SearchPName_TextChanged(object sender, EventArgs e)
        {
            SearchForName(txb_SearchPName.Text);
        }

        private void cmb_SearchCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SearchForCategory(Convert.ToInt32(cmb_SearchCategory.SelectedValue));
        }

        private void txb_SearchUserName_TextChanged(object sender, EventArgs e)
        {
            SearchForUserName(txb_SearchUserName.Text);
        }

        private void txb_SearchPrice_TextChanged(object sender, EventArgs e)
        {
            SearchForPrice(txb_SearchPrice.Text);
        }

        private void txb_SearchCount_TextChanged(object sender, EventArgs e)
        {

            SearchForCount(txb_SearchCount.Text);
        }

        private void txb_SearchBoughtCount_TextChanged(object sender, EventArgs e)
        {
            SearchForBoughtCount(txb_SearchBoughtCount.Text);

        }
        Button button = new Button();
        private void AllProductsForm_Load(object sender, EventArgs e)
        {



            button.Text = "Buy";
            button.Location = new Point(32, 13);
            button.Size = new Size(75, 23);
            button.Name = "BuyButton";
            Controls.Add(button);
            button.Hide();
            button.Click += new EventHandler(button_Click);
            

        }

       
        private void button_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgv_AllProductView.CurrentRow.Cells[10].Value);
            using (RStoreDataContext context1 = new RStoreDataContext())
            {
                var pr = context1.Products.FirstOrDefault(x => x.Id == id);
                DateTime dateTime = DateTime.Now;
                int date = Convert.ToInt32((dateTime- pr.ExpiredDate).TotalDays);
                if (date == 3)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to buy this product 3 days before the expiration date?", "Buy", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
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

                        context1.Products.AddOrUpdate(product);
                        context1.SaveChanges();
                        MessageBox.Show("Thanks");

                        GetAllProduct();
                    }
                    else
                    {
                        GetAllProduct();
                    }
                }
                else if (date == 2)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to buy this product 2 days before the expiration date?", "Buy", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
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

                        context1.Products.AddOrUpdate(product);
                        context1.SaveChanges();
                        MessageBox.Show("Thanks");

                        GetAllProduct();
                    }
                    else
                    {
                        GetAllProduct();
                    }
                }
                else if (date == 1)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to buy this product 1 days before the expiration date?", "Buy", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
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

                        context1.Products.AddOrUpdate(product);
                        context1.SaveChanges();
                        MessageBox.Show("Thanks");

                        GetAllProduct();
                    }
                    else
                    {
                        GetAllProduct();
                    }
                }
                else 
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

                    context1.Products.AddOrUpdate(product);
                    context1.SaveChanges();
                    MessageBox.Show("Thanks");

                    GetAllProduct();
                }
            }
        }

        private void dgv_AllProductView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(dgv_AllProductView.CurrentRow.Cells[10].Value);


            if (MyDatabase.userId != id)
            {
                button.Show();
            }
            else
            {
                button.Hide();
            }
        }
    }
}
