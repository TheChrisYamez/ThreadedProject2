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
        /// <summary>
        /// The currently selected package
        /// </summary>
        Package Package;

        /// <summary>
        /// the binded list of package id's
        /// </summary>
        readonly BindingList<int> PackageIds = new BindingList<int>();

        /// <summary>
        /// the list of products attached to a package
        /// </summary>
        readonly BindingList<Product> Products = new BindingList<Product>();

        public frmPackageManager()
        {
            InitializeComponent();

        }

        private void frmPackageManager_Load(object sender, EventArgs e)
        {
            //bind combo box to package id's
            cmbPackageIds.DataSource = PackageIds;

            //Bind the datagrid to the list containing all relavent products
            dtgProducts.DataSource = Products;

            DisplayPackageIds();

            if (Int32.TryParse(cmbPackageIds.Text, out int id))
            {
                DisplayPackage(id);
                DisplayPackageProducts(id);
            }
        }
        private void DisplayPackageIds()
        {
            List<int> ids = PackageDB.GetPackageIds();

            //list hasnt changed. return;
            if (PackageIds.SequenceEqual(ids))
                return;

            PackageIds.Clear();

            //add to binding list
            foreach (int id in ids)
                PackageIds.Add(id);    
        }

        /// <summary>
        /// An event that occurs when the user selects a package ID
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPackageIds_Click(object sender, EventArgs e)
        {
            DisplayPackageIds();
        }

        /// <summary>
        /// An event that occurs when the user selected a package id
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPackageIds_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Object.Equals((sender as ComboBox).SelectedItem, null))
                return;

            int packageId = (int)(sender as ComboBox).SelectedItem;

            //update the form fields
            DisplayPackage(packageId);
            DisplayPackageProducts(packageId);
        }

        private void DisplayPackageProducts(int packageID)
        {
            if (!Object.Equals(Products,null))
                Products.Clear();

            //get the products linked to the package
            foreach (Product product in PackageDB.GetPackageProductsById(packageID))
                Products.Add(product);
        }

        /// <summary>
        /// Updates the Package Fields displayed on the form
        /// </summary>
        /// <param name="package"></param>
        private bool DisplayPackage(int packageId)
        {
            if (!Object.Equals(Package,null) && packageId == Package.PackageId)
                return false;

            //get the package data
            Package = PackageDB.GetPackageById(packageId);

            //Update package fields
            tbxPkgCommission.Text = 
                (Package.PkgAgencyCommission.HasValue) ? 
                Decimal.Round((decimal)Package.PkgAgencyCommission,2).ToString() : String.Empty;

            tbxPkgPrice.Text = Decimal.Round(Package.PkgBasePrice, 2).ToString();
            tbxPkgDesc.Text = Package.PkgDesc.ToString();
            tbxPkgName.Text = Package.PkgName.ToString();

            tbxPkgEndDate.CustomFormat = Object.Equals(Package.PkgEndDate, null) ? " " : "dd/mm/yyyy";
            tbxPkgEndDate.Text = Package.PkgStartDate.ToString();

            tbxPkgStartDate.CustomFormat = Object.Equals(Package.PkgStartDate, null) ? " " : "dd/mm/yyyy";
            tbxPkgStartDate.Text = Package.PkgStartDate.ToString();

            return true;
        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void packageBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
