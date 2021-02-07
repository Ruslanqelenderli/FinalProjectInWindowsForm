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
    public partial class AdminSelectForm : Form
    {
        public AdminSelectForm()
        {
            InitializeComponent();
        }

       

        private void btn_OperationsByCategory_Click(object sender, EventArgs e)
        {
            OperationsByCategoryForm operationsByCategoryForm = new OperationsByCategoryForm();
            operationsByCategoryForm.ShowDialog();
        }

        private void btn_AllReport_Click(object sender, EventArgs e)
        {
            AdminReports admin = new AdminReports();
            admin.ShowDialog();
        }

        private void btn_AllProductsAdmin_Click(object sender, EventArgs e)
        {
            AdminAllProducts adminAllProducts = new AdminAllProducts();
            adminAllProducts.ShowDialog();
        }
    }
}
