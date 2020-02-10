﻿
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
        private Package PackageSelected { get; set; }


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

        /// <summary>
        /// The list of suppliers associated to a specific product
        /// </summary>
        BindingList<Supplier> ProductSuppliers = new BindingList<Supplier>();

        /// <summary>
        /// the date time format associated with the data time picker
        /// </summary>
        const string DateTimePickerFormat = "dd/MM/yyyy";

        public frmPackageManager()
        {
            InitializeComponent();
        }

        #region Methods

        /// <summary>
        /// Displays products associated with a package
        /// </summary>
        /// <param name="packageID"></param>
        private void GetBindedPackageProducts(int packageID)
        {
            if (!Object.Equals(PackageProducts, null))
                PackageProducts.Clear();

            //get the products linked to the package
            foreach (Product product in PackageDB.GetPackageProductsById(packageID))
                PackageProducts.Add(product);
        }

        /// <summary>
        /// resolves issues with double buffering and flickering when shwoing the form
        /// <author> From StackOverflow </author>
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
        private void GetBindedProductsAll()
        {
            List<Product> productList = ProductDB.GetAllProducts();

            //clear existing products
            if (Products.Count > 0)
                Products.Clear();

            //get products and add to binding list
            foreach (Product product in productList)
                Products.Add(product);
        }

        /// <summary>
        /// Updates the Package Fields displayed on the form
        /// </summary>
        /// <param name="package"></param>
        private bool DisplayPackage(int packageId)
        {
            //the package displayed is the same as the package selected from the drop down... do not redisplay.
            if (!Object.Equals(PackageSelected, null) && packageId == PackageSelected.PackageId && PackageSelected.PkgName == lblPackageName.Text)
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

            //start date is null, remove format
            if (Object.Equals(PackageSelected.PkgStartDate, null))
                dtpPkgStartDate.CustomFormat = " ";
            else
            {
                dtpPkgStartDate.CustomFormat = DateTimePickerFormat;
                dtpPkgStartDate.Text = PackageSelected.PkgStartDate.ToString();
            }

            //end date is null, remove format
            if (Object.Equals(PackageSelected.PkgEndDate, null))
                dtpPkgEndDate.CustomFormat = " ";
            else
            {
                dtpPkgEndDate.CustomFormat = DateTimePickerFormat;
                dtpPkgEndDate.Text = PackageSelected.PkgEndDate.ToString();
            }

            //update char count labels
            DisplayCharCount(tbxPkgDesc, lblDescCharCount);
            DisplayCharCount(tbxPkgName, lblNameCharCount);

            //If package name is updated, update controls
            if (PackageSelected.PkgName != lblPackageName.Text)
            {
                lblPackageName.Text = PackageSelected.PkgName.ToString();
                GetBindedPackageIds();
            }

            return true;
        }

        /// <summary>
        /// Gets the package id's from the DB
        /// </summary>
        private void GetBindedPackageIds()
        {
            //store the current selected index of combo box
            int selectedIndex = (cmbPackageIds.SelectedIndex < 0) ? 0 : cmbPackageIds.SelectedIndex;

            if (PackageIds.Count > 0)
                PackageIds.Clear();

            //add to binding list
            foreach (Package package in PackageDB.GetPartialPackage())
                PackageIds.Add(package);

            //set combo box back to selected index
            cmbPackageIds.SelectedIndex = selectedIndex;
        }

        /// <summary>
        /// Gets all Suppliers linked to a specified product
        /// </summary>
        /// <param name="productId"></param>
        private void GetBindedProductSuppliers(int? productId)
        {
            if (Object.Equals(productId, null))
                return;

            ProductSuppliers.Clear();

            foreach (Supplier supplier in SupplierDB.GetProductSuppliers((int)productId))
                ProductSuppliers.Add(supplier);
        }


        private void SetPackageName(string packageName)
        {
            //name hasnt changed. return
            if (packageName == PackageSelected.PkgName)
                return;

            PackageIds.Remove(PackageSelected);
            PackageSelected.PkgName = packageName;

            PackageDB.UpdatePackagePropertyById(nameof(Package.PkgName), PackageSelected);
        }


        private void SetEndDate(DateTimePicker dtp, bool removeDate = false)
        {
            if (!removeDate)
            {
                dtp.CustomFormat = DateTimePickerFormat;

                DateTime date = dtp.Value;
                PackageSelected.PkgEndDate = date;

                PackageDB.UpdatePackagePropertyById(nameof(Package.PkgEndDate), PackageSelected);
            }
            else
            {
                //clear end date field and updated db
                PackageSelected.PkgEndDate = null;
                dtp.Value = DateTime.Now.AddDays(1);
                dtp.CustomFormat = " ";
                PackageDB.UpdatePackagePropertyById(nameof(Package.PkgEndDate), PackageSelected);
            }
        }

        /// <summary>
        /// Sets the start date of the package
        /// </summary>
        /// <param name="dateTimePicker"></param>
        /// <param name="removeDate"></param>
        private void SetStartDate(DateTimePicker dateTimePicker, bool removeDate = false)
        {
            //update display date and DB
            if (!removeDate)
            {
                dateTimePicker.CustomFormat = DateTimePickerFormat;

                DateTime date = dateTimePicker.Value;
                PackageSelected.PkgStartDate = date;

                PackageDB.UpdatePackagePropertyById(nameof(Package.PkgStartDate), PackageSelected);

                //enable editing end date;
                dtpPkgEndDate.Enabled = true;
            } else //date field is cleared, display it as such and update DB, also remove end date
            {
                //clear start date field and End Date Field and updated db
                PackageSelected.PkgStartDate = null;
                dateTimePicker.CustomFormat = " ";
                PackageDB.UpdatePackagePropertyById(nameof(Package.PkgStartDate), PackageSelected);

                SetEndDate(dtpPkgEndDate, true);

                //disable editing of end date
                dtpPkgEndDate.Enabled = false;
            }
        }

        /// <summary>
        /// clears the error providor messages from a given control
        /// </summary>
        /// <param name="control"></param>
        private static void ClearControlErrors(Control control)
        {
                PackageValidator.ErrorProvider.SetError(control, String.Empty);
        }


        /// <summary>
        /// validated a input string field and sets the errorprovidor on errors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private static void ValidateString(object sender, CancelEventArgs e)
        {
            int maxCharCount = 50;

            if (!PackageValidator.IsValidString((TextBox)sender, maxCharCount))
                e.Cancel = true;
        }

        private void DisplayCharCount(TextBox tb, Label label)
        {
            label.Text = $"{tb.Text.Length}/50";
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

            cmbSuppliers.DataSource = ProductSuppliers;
            cmbSuppliers.DisplayMember = nameof(Supplier.SupName);
            cmbSuppliers.ValueMember = nameof(Supplier.SupplierID);

            //Bind the datagrid to the list containing all relavent products
            dtgProducts.DataSource = PackageProducts;

            //get product and package data from db
            GetBindedProductsAll();
            GetBindedPackageIds();

            //display package and products
            if (PackageIds.Count > 0)
            {
                DisplayPackage(PackageIds[0].PackageId);
                GetBindedPackageProducts(PackageIds[0].PackageId);
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
            GetBindedPackageProducts(package.PackageId);

        }

        /// <summary>
        /// Event occurs when user presses clear on end date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearEndDate_Click(object sender, EventArgs e)
        {
            SetEndDate((sender as DateTimePicker), true);
        }


        /// <summary>
        /// Event occurs when user presses clear on start date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClearStartDate_Click(object sender, EventArgs e)
        {
            SetStartDate(dtpPkgStartDate, true);
        }



        /// <summary>
        /// Event occurs when form visibility is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmPackageManager_VisibleChanged(object sender, EventArgs e)
        {
            //refresh the Products list when current form is set to VISIBLE
            if (this.Visible)
                GetBindedProductsAll();
        }

        /// <summary>
        /// event occurs when a product is selected from the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetBindedProductSuppliers(((ComboBox)sender).SelectedValue as int?);
        }

        /// <summary>
        /// event occurs when package name is validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPkgName_Validated(object sender, EventArgs e)
        {
            SetPackageName((sender as TextBox).Text);

            DisplayPackage(PackageSelected.PackageId);
        }


        /// <summary>
        /// event occurs when package name is validating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPkgName_Validating(object sender, CancelEventArgs e)
        {
            ValidateString(sender, e);
        }

        /// <summary>
        /// event occurs when description is validating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPkgDesc_Validating(object sender, CancelEventArgs e)
        {
            ValidateString(sender, e);
        }

        /// <summary>
        /// event occurs when descript has been validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPkgDesc_Validated(object sender, EventArgs e)
        {
            string desc = (sender as TextBox).Text;
            PackageSelected.PkgDesc = desc;

            PackageDB.UpdatePackagePropertyById(nameof(Package.PkgDesc), PackageSelected);
        }

        /// <summary>
        /// event occures when price has been validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPkgPrice_Validated(object sender, EventArgs e)
        {
            PackageSelected.PkgBasePrice = Convert.ToDecimal((sender as TextBox).Text);

            PackageDB.UpdatePackagePropertyById(nameof(Package.PkgBasePrice), PackageSelected);
        }
        /// <summary>
        /// event occurs when price is being validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPkgPrice_Validating(object sender, CancelEventArgs e)
        {
            if (!PackageValidator.IsValidMonetaryValue((TextBox)sender))
                e.Cancel = true;

        }

        /// <summary>
        /// Event after validating commission field
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPkgCommission_Validated(object sender, EventArgs e)
        {
            string commission = (sender as TextBox).Text;

            PackageSelected.PkgAgencyCommission = (commission != null) ? Convert.ToDecimal(commission) : (decimal?)null;

            PackageDB.UpdatePackagePropertyById(nameof(Package.PkgAgencyCommission), PackageSelected);
        }

        /// <summary>
        /// event after commission field is validated
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbxPkgCommission_Validating(object sender, CancelEventArgs e)
        {
            if (!PackageValidator.IsValidCommission((TextBox)sender, tbxPkgPrice))
                e.Cancel = true;
        }

        /// <summary>
        /// Event occurs when an end date is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpPkgEndDate_ValueChanged(object sender, EventArgs e)
        {
            bool validDate = PackageValidator.IsValidEndDate((DateTimePicker)sender, dtpPkgStartDate.Value);

            //date not valid, return
            if (!validDate)
                return;
            else //date valid, updated data
                SetEndDate((DateTimePicker)sender);
        }

        /// <summary>
        /// event occurs when a start date is selected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtpPkgStartDate_ValueChanged(object sender, EventArgs e)
        {
            SetStartDate(dtpPkgStartDate, false);
        }

        private void tbxPkgName_TextChanged(object sender, EventArgs e)
        {
            DisplayCharCount((TextBox)sender, lblNameCharCount);
        }

        private void tbxPkgDesc_TextChanged(object sender, EventArgs e)
        {
            DisplayCharCount((TextBox)sender, lblDescCharCount);
        }

        #endregion events

    }
}
