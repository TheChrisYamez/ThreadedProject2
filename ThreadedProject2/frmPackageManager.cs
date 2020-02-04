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
        Package PackageSelected;


        /// <summary>
        /// the binded list of package id's
        /// </summary>
        readonly BindingList<Package> PackageIds = new BindingList<Package>();


        /// <summary>
        /// the list of products attached to a package
        /// </summary>
        readonly BindingList<Product> PackageProducts = new BindingList<Product>();

        /// <summary>
        /// the list of products in the database
        /// </summary>
        readonly BindingList<Product> Products = new BindingList<Product>();

        string DateTimePickerFormat = "dd/MM/yyyy";

        public frmPackageManager()
        {
            InitializeComponent();

         
        }

        private void PopulateProducts()
        {
            if (Products.Count > 0)
                Products.Clear();

            //add to binding list
            foreach (Product product in ProductDB.GetProducts())
                Products.Add(product);
        }

        #region Methods
        private void DisplayPackageProducts(int packageID)
        {
            if (!Object.Equals(PackageProducts, null))
                PackageProducts.Clear();

            //get the products linked to the package
            foreach (Product product in PackageDB.GetPackageProductsById(packageID))
                PackageProducts.Add(product);
        }

        /// <summary>
        /// Updates the Package Fields displayed on the form
        /// </summary>
        /// <param name="package"></param>
        private bool DisplayPackage(int packageId)
        {
            if (!Object.Equals(PackageSelected, null) && packageId == PackageSelected.PackageId)
                return false;

            //get the package data
            PackageSelected = PackageDB.GetPackageById(packageId);

            //Update package fields
            tbxPackageId.Text = PackageSelected.PackageId.ToString();

            tbxPkgCommission.Text =
                (PackageSelected.PkgAgencyCommission.HasValue) ?
                Decimal.Round((decimal)PackageSelected.PkgAgencyCommission, 2).ToString() : String.Empty;

            tbxPkgPrice.Text = Decimal.Round(PackageSelected.PkgBasePrice, 2).ToString();
            tbxPkgDesc.Text = PackageSelected.PkgDesc.ToString();
            tbxPkgName.Text = PackageSelected.PkgName.ToString();

            dtpPkgEndDate.CustomFormat = Object.Equals(PackageSelected.PkgEndDate, null) ? " " : DateTimePickerFormat;
            dtpPkgEndDate.Text = PackageSelected.PkgStartDate.ToString();

            dtpPkgStartDate.CustomFormat = Object.Equals(PackageSelected.PkgStartDate, null) ? " " : DateTimePickerFormat;
            dtpPkgStartDate.Text = PackageSelected.PkgStartDate.ToString();

            return true;
        }

        private void PopulatePackageIds()
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

            //bind combo box to product names
            cmbProductList.DataSource = Products;
            cmbProductList.DisplayMember = nameof(Product.ProdName);
            cmbProductList.ValueMember = nameof(Product.ProductID);


            //Bind the datagrid to the list containing all relavent products
            dtgProducts.DataSource = PackageProducts;

            PopulateProducts();
            PopulatePackageIds();

            if (PackageIds.Count > 0)
            {
                DisplayPackage(PackageIds[0].PackageId);
                DisplayPackageProducts(PackageIds[0].PackageId);
            }
        }


        /// <summary>
        /// An event that occurs when the user clicks on the package lookup combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPackageIds_Click(object sender, EventArgs e)
        {
            PopulatePackageIds();
        }


        private void cmbProductList_Click(object sender, EventArgs e)
        {
            PopulateProducts();
        }

        private void cmbPackageIds_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Object.Equals((sender as ComboBox).SelectedItem, null))
                return;

            Package package = (Package)(sender as ComboBox).SelectedItem;

            //update the form fields
            DisplayPackage(package.PackageId);
            DisplayPackageProducts(package.PackageId);
        
        }
        #endregion events

        private void btnClearEndDate_Click(object sender, EventArgs e)
        {
            PackageSelected.PkgEndDate = null;
            dtpPkgEndDate.CustomFormat = " ";
            PackageDB.UpdatePackagePropertyById(nameof(Package.PkgEndDate), PackageSelected);
        }

        private void btnClearStartDate_Click(object sender, EventArgs e)
        {
            PackageSelected.PkgStartDate = null;
            dtpPkgStartDate.CustomFormat = " ";
            PackageDB.UpdatePackagePropertyById(nameof(Package.PkgStartDate), PackageSelected);
        }

        private void tbxPkgCommission_Leave(object sender, EventArgs e)
        {
            string commission = (sender as TextBox).Text;
            PackageSelected.PkgAgencyCommission = (commission != null) ? Convert.ToDecimal(commission) : (decimal?)null;

            PackageDB.UpdatePackagePropertyById(nameof(Package.PkgAgencyCommission), PackageSelected);
        }

        private void tbxPkgPrice_Leave(object sender, EventArgs e)
        {
            string price = (sender as TextBox).Text;
            PackageSelected.PkgBasePrice = Convert.ToDecimal(price);

            PackageDB.UpdatePackagePropertyById(nameof(Package.PkgBasePrice), PackageSelected);
        }

        private void tbxPkgDesc_Leave(object sender, EventArgs e)
        {
            string desc = (sender as TextBox).Text;
            PackageSelected.PkgDesc = desc;

            PackageDB.UpdatePackagePropertyById(nameof(Package.PkgDesc), PackageSelected);
        }

        private void tbxPkgName_Leave(object sender, EventArgs e)
        {
            string name = (sender as TextBox).Text;
            PackageSelected.PkgName = name;

            PackageDB.UpdatePackagePropertyById(nameof(Package.PkgName), PackageSelected);
        }

        private void dtpPkgStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpPkgStartDate.CustomFormat = DateTimePickerFormat;

            PackageDB.UpdatePackagePropertyById(nameof(Package.PkgName), PackageSelected);
        }

        private void dtpPkgEndDate_ValueChanged(object sender, EventArgs e)
        {
            dtpPkgEndDate.CustomFormat = DateTimePickerFormat;
        }
    }
}
