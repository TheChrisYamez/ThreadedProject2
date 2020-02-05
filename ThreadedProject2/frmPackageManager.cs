
using DBConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace ThreadedProject2
{
    public partial class frmPackageManager : Form
    {
        /// <summary>
        /// The currently selected package
        /// </summary>
        private Package PackageSelected;


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
        BindingList<Product> Products = new BindingList<Product>();

        /// <summary>
        /// the list of products in the database
        /// </summary>
        BindingList<Product> ProductSuppliers = new BindingList<Product>();


        private string DateTimePickerFormat = "dd/MM/yyyy";

        public frmPackageManager()
        {
            InitializeComponent();
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
        /// resolves issues with double buffering and flickering when shwoing the form
        /// </summary>
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }

        }


        /// <summary>
        /// Get the products for the package from the DB
        /// </summary>
        private void GetProducts()
        {
            List<Product> productList = ProductDB.GetAllProducts();

            if (Products.Count > 0)
                Products.Clear();

            foreach (Product product in productList)
                Products.Add(product);
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

            //Update non-nullable properties
            tbxPackageId.Text = PackageSelected.PackageId.ToString();
            tbxPkgName.Text = PackageSelected.PkgName.ToString();
            tbxPkgPrice.Text = Decimal.Round(PackageSelected.PkgBasePrice, 2).ToString();

            //Update nullable properties
            tbxPkgCommission.Text =
                (PackageSelected.PkgAgencyCommission.HasValue) ?
                Decimal.Round((decimal)PackageSelected.PkgAgencyCommission, 2).ToString() : String.Empty;

            tbxPkgDesc.Text = PackageSelected.PkgDesc.ToString();

            if (Object.Equals(PackageSelected.PkgEndDate, null))
                dtpPkgEndDate.CustomFormat = " ";
            else
            {
                dtpPkgEndDate.CustomFormat = DateTimePickerFormat;
                dtpPkgEndDate.Text = PackageSelected.PkgEndDate.ToString();
            }

            if (Object.Equals(PackageSelected.PkgStartDate, null))
                dtpPkgStartDate.CustomFormat = " ";
            else
            {
                dtpPkgStartDate.CustomFormat = DateTimePickerFormat;
                dtpPkgStartDate.Text = PackageSelected.PkgStartDate.ToString();
            }

            return true;
        }

        /// <summary>
        /// Gets the package id's from the DB
        /// </summary>
        private void GetPackageIds()
        {
            if (PackageIds.Count > 0)
                PackageIds.Clear();

            //add to binding list
            foreach (Package package in PackageDB.GetPartialPackage())
                PackageIds.Add(package);
        }

        #endregion Methods  

        #region Events

        /// <summary>
        /// Event occurs when form is first loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            //get product and package data from db
            GetProducts();
            GetPackageIds();

            //display package and products
            if (PackageIds.Count > 0)
            {
                DisplayPackage(PackageIds[0].PackageId);
                DisplayPackageProducts(PackageIds[0].PackageId);
            }
        }

        /// <summary>
        /// Event occurs when user selects a package id from the combo box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbPackageIds_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Object.Equals((sender as ComboBox).SelectedItem, null))
                return;

            Package package = (Package)(sender as ComboBox).SelectedItem;

            //Display the package and products
            DisplayPackage(package.PackageId);
            DisplayPackageProducts(package.PackageId);

        }

        /// <summary>
        /// Event occurs when user presses clear on end date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearEndDate_Click(object sender, EventArgs e)
        {
            //clear end date field and updated db
            PackageSelected.PkgEndDate = null;
            dtpPkgEndDate.CustomFormat = " ";
            PackageDB.UpdatePackagePropertyById(nameof(Package.PkgEndDate), PackageSelected);
        }

        /// <summary>
        /// Event occurs when user presses clear on start date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearStartDate_Click(object sender, EventArgs e)
        {
            //clear start date field and updated db
            PackageSelected.PkgStartDate = null;
            dtpPkgStartDate.CustomFormat = " ";
            PackageDB.UpdatePackagePropertyById(nameof(Package.PkgStartDate), PackageSelected);
        }

        private void dtpPkgStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtpPkgStartDate.CustomFormat = DateTimePickerFormat;

            DateTime date = (sender as DateTimePicker).Value;
            PackageSelected.PkgStartDate = date;

            PackageDB.UpdatePackagePropertyById(nameof(Package.PkgStartDate), PackageSelected);
        }

        private void dtpPkgEndDate_ValueChanged(object sender, EventArgs e)
        {
            dtpPkgEndDate.CustomFormat = DateTimePickerFormat;

            DateTime date = (sender as DateTimePicker).Value;
            PackageSelected.PkgEndDate = date;

            PackageDB.UpdatePackagePropertyById(nameof(Package.PkgEndDate), PackageSelected);
        }

        /// <summary>
        /// Event occurs after leaving the text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Event occurs when form visibility is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPackageManager_VisibleChanged(object sender, EventArgs e)
        {
            //check if form is visible and display it
            if (this.Visible)
                GetProducts();
        }


        #endregion events
    }
}
