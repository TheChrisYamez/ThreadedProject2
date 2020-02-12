using DBConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductSupplierManager
{
    public partial class frmProductSupplierManager : Form
    {
        List<ProductSupplier> productSuppliers;
        Product product;

        public frmProductSupplierManager()
        {
            InitializeComponent();

            product = ProductDB.GetProductById(1);
            lblProductName.Text = product.ProdName;

        }

        public frmProductSupplierManager(Product product)
        {
            InitializeComponent();

            product = ProductDB.GetProduct(1);
            this.product = product;
            lblProductName.Text = product.ProdName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                productSuppliers = ProductSupplierDB.GetAllProductSuppliers();
                ProductSupplierDataGrid.DataSource = productSuppliers;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error while loading Product Supplier Data: " + ex.Message,
                    ex.GetType().ToString());
            }
        }

        private void ProductSupplierDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
