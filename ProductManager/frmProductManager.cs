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

<<<<<<< Updated upstream
        private void frmProductManager_Load(object sender, EventArgs e)
        {
=======
        private DataTable SupplierData(string selectStatement)
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
        private void frmProductManager_Load(object sender, EventArgs e)
        {
            
>>>>>>> Stashed changes
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
