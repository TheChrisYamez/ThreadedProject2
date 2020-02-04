using System;
using System.Collections.Generic;
using System.ComponentModel;
using DBConnector;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManager
{
    public partial class FrmUpdate : Form
    {
        public Product product; // current product
        public Product oldProduct; // original product data
        public FrmUpdate()
        {
            InitializeComponent();
        }

        private void FrmUpdate_Load(object sender, EventArgs e)
        {
            // bind the controls to the product object
            productBindingSource.Clear();
            productBindingSource.Add(product); // bind to the current product
        }
    }
}
