using System;
using DBConnector;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProject2
{
    public partial class frmPackageManager : Form
    {
        BindingList<int> PackageIds;
        Package Package;
        BindingList<Product> Products;

        public frmPackageManager()
        {
            InitializeComponent();

        }

        private void frmPackageManager_Load(object sender, EventArgs e)
        {
            //gets the package id's
            PackageIds = PackageDB.GetPackageIds();

            //bind a combo box to a list containing the package id's
            cmbPackageIds.DataSource = PackageIds;

            //Bind the datagrid to the list containing all relavent products
            dtgProducts.DataSource = Products;

            if (Int32.TryParse(cmbPackageIds.Text,out int id))
            {
                UpdatePackageFields(id);
            }
        }

        /// <summary>
        /// An event that occurs when the user selects a package ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPackageIds_Click(object sender, EventArgs e)
        {
            PackageIds = PackageDB.GetPackageIds();
        }

        /// <summary>
        /// An event that occurs when the user selected a package id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPackageIds_SelectedValueChanged(object sender, EventArgs e)
        {
            int packageId = (int)(sender as ComboBox).SelectedItem;

            //update the form fields
            UpdatePackageFields(packageId);
            UpdatePackageProductsData(packageId);
        }

        private void UpdatePackageProductsData(int packageID)
        {
            if (!Object.Equals(Products,null))
                Products.Clear();

            //get the products linked to the package
            Products = PackageDB.GetPackageProductsById(packageID);
            dtgProducts.DataSource = Products;
        }

        /// <summary>
        /// Updates the Package Fields displayed on the form
        /// </summary>
        /// <param name="package"></param>
        private bool UpdatePackageFields(int packageId)
        {
            //get the package data
            Package = PackageDB.GetPackageById(packageId);

            //Update package fields
            tbxPkgCommission.Text = 
                (Package.PkgAgencyCommission.HasValue) ? 
                Decimal.Round((decimal)Package.PkgAgencyCommission,2).ToString() : String.Empty;

            tbxPkgPrice.Text = Decimal.Round(Package.PkgBasePrice, 2).ToString();
            tbxPkgDesc.Text = Package.PkgDesc.ToString();
            tbxPkgEndDate.Text = Package.PkgEndDate.ToString();
            tbxPkgName.Text = Package.PkgName.ToString();
            tbxPkgStartDate.Text = Package.PkgStartDate.ToString();


            return true;
        }
    }
}
