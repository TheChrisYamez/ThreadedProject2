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
    public partial class frmAdd : Form
    {
        Product product;

        public frmAdd()
        {
            InitializeComponent();
        }

        private void prodNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
                    product = new Product();
                    this.PutProductData(product);
                    try
                    {
                        product.ProdName = ProductDB.AddProduct(product).ToString();
                //this.DialogResult = DialogResult.OK;
                this.ClearControls();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }

        private void ClearControls()
        {
            txtAdd.Text = "";
            txtAdd.Focus();
        }

        private void PutProductData(Product product)
        {
            product.ProdName = txtAdd.Text;
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            this.Text = "Add Product";

        }
    }
    }

