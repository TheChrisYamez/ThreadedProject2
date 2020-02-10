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
        ProductSupplier

        List<>
        public frmProductSupplierManager()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                productSuppliers = ProductSupplierDB.GetAllProductSuppliers();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
