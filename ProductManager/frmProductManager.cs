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

namespace ProductManager
{
    public partial class frmProductManager : Form
    {
        public frmProductManager()
        {
            InitializeComponent();
        }

        List<Product> products; // list of all products
        List<Supplier> suppliers; // list of all suppliers
        List<ProductSupplier> productsuppliers; // list of all productsuppliers
        const int EDIT_BUTTON_INDX = 3; // column in the grid that contains Edit buttons
        Product oldProduct;



        Product oldProducts; // to preserve data before update

       
        private void frmProductManager_Load(object sender, EventArgs e)
        {
            DataTable SupplierData(string selectStatement)
            {
                string constr = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(selectStatement))
                    {
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            cmd.Connection = con;
                            DataTable dt = new DataTable();
                            sda.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            try
            {
                productsuppliers = ProductSupplierDB.GetAllProductSuppliers();
                suppliers = SupplierDB.GetAllSuppliers();
                products = ProductDB.GetAllProducts();
                productDataGridView.DataSource = products; // bind the grid view to the products list
                prodNameComboBox.DataSource = products;
                supplierDataGridView.DataSource = suppliers;
                productSupplierDataGridView.DataSource = productsuppliers;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading customers data: " + ex.Message,
                    ex.GetType().ToString());
            }
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == EDIT_BUTTON_INDX)
            {
                oldProduct = products[e.RowIndex].CopyProduct(); // make a  separate copy before update
                FrmUpdate updateForm = new FrmUpdate();
                updateForm.product = products[e.RowIndex]; // "pass" current customer to the form
                updateForm.oldProduct = oldProduct;        // same for the original customer data
                DialogResult result = updateForm.ShowDialog(); // display modal second form
                if (result == DialogResult.OK) // update accepted
                {
                    // refresh the grid view
                    CurrencyManager cm = (CurrencyManager)productDataGridView.BindingContext[products];
                    cm.Refresh();
                }
                else // update cancelled
                {
                    products[e.RowIndex] = oldProduct; // revert to the old values
                }
            }
        }
    }
}
