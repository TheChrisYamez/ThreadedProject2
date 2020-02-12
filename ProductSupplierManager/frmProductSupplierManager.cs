using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public frmProductSupplierManager()
        {
            InitializeComponent();
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
