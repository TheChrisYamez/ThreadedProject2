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
namespace ProductSupplierManager
{
    public partial class frmProductSupplierManager : Form
    {
        public Supplier supplier;

        public frmProductSupplierManager()
        {
            InitializeComponent();
        }

        private void frmProductSupplierManager_Load(object sender, EventArgs e)
        {

            //    this.Text = "Modify Customer";
            //    this.DisplayCustomer();
            //}
            //}
            //private void DisplayCustomer()
            //{
            //    txtName.Text = customer.Name;
            //    txtAddress.Text = customer.Address;
            //    txtCity.Text = customer.City;
            //    cboStates.SelectedValue = customer.State;
            //    txtZipCode.Text = customer.ZipCode;
            //}

            //private void PutCustomerData(Customer customer)
            //{
            //    customer.Name = txtName.Text;
            //    customer.Address = txtAddress.Text;
            //    customer.City = txtCity.Text;
            //    customer.State = cboStates.SelectedValue.ToString();
            //    customer.ZipCode = txtZipCode.Text;
            //}


        }
    }
}

