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
using ProductSupplierManager;

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
        readonly BindingList<Package> PackageIds = new BindingList<Package>();


        /// <summary>
        /// the list of products attached to a package
        /// </summary>
        readonly BindingList<Product> Products = new BindingList<Product>();

        public frmPackageManager()
        {
            InitializeComponent();

            
        }

        #region Methods
        private void DisplayPackageProducts(int packageID)
        {
            if (!Object.Equals(Products, null))
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
            if (!Object.Equals(Package, null) && packageId == Package.PackageId)
                return false;

            //get the package data
            Package = PackageDB.GetPackageById(packageId);

            //Update package fields
            tbxPackageId.Text = Package.PackageId.ToString();

            tbxPkgCommission.Text =
                (Package.PkgAgencyCommission.HasValue) ?
                Decimal.Round((decimal)Package.PkgAgencyCommission, 2).ToString() : String.Empty;

            tbxPkgPrice.Text = Decimal.Round(Package.PkgBasePrice, 2).ToString();
            tbxPkgDesc.Text = Package.PkgDesc.ToString();
            tbxPkgName.Text = Package.PkgName.ToString();

            tbxPkgEndDate.CustomFormat = Object.Equals(Package.PkgEndDate, null) ? " " : "dd/MM/yyyy";
            tbxPkgEndDate.Text = Package.PkgStartDate.ToString();

            tbxPkgStartDate.CustomFormat = Object.Equals(Package.PkgStartDate, null) ? " " : "dd/MM/yyyy";
            tbxPkgStartDate.Text = Package.PkgStartDate.ToString();

            return true;
        }

        private void DisplayPackageIds()
        {
            if (PackageIds.Count > 0)
                PackageIds.Clear();

            //add to binding list
            foreach (Package package in PackageDB.GetPartialPackage())
                PackageIds.Add(package);
        }

        #endregion Methods  

        #region Events

        private void frmPackageManager_Load(object sender, EventArgs e)
        {
            //bind combo box to package id's
            cmbPackageIds.DataSource = PackageIds;
            cmbPackageIds.DisplayMember = nameof(Package.PkgName);
            cmbPackageIds.ValueMember = nameof(Package.PackageId);

            //Bind the datagrid to the list containing all relavent products
            dtgProducts.DataSource = Products;

            DisplayPackageIds();

            if (Int32.TryParse(cmbPackageIds.Text, out int id))
            {
                DisplayPackage(id);
                DisplayPackageProducts(id);
            }
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
        private void cmbPackageIds_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (Object.Equals((sender as ComboBox).SelectedItem, null))
                return;

            Package package = (Package)(sender as ComboBox).SelectedItem;

            //update the form fields
            DisplayPackage(package.PackageId);
            DisplayPackageProducts(package.PackageId);
        }
        #endregion Events

        private void btnAddRemovePackage_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRemoveProduct_Click(object sender, EventArgs e)
        {
            if (MdiParent.Controls.Count < 1)
                return;

            Form formToRemove = null;

            foreach (Form form in MdiParent.Controls)
                formToRemove = form;

            Parent.Controls.Remove(formToRemove);

            Parent.Controls.Add(new frmProductSupplierManager());
        }
    }
}
