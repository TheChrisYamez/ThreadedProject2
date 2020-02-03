using DBConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class frmProductManager : Form
    {
        public frmProductManager()
        {
            InitializeComponent();
        }

        List<Product> products; // list of all customers
        Product oldProducts; // to preserve data before update

        private void frmProductManager_Load(object sender, EventArgs e)
        {
            try
            {
                products = ProductDB.GetAllProducts();
                productDataGridView.DataSource = products; // bind the grid view to the customers list
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading customers data: " + ex.Message,
                    ex.GetType().ToString());
            }
        }
    }
}
