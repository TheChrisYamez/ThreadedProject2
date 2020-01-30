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

            if (Int32.TryParse(cmbPackageIds.Text,out int id))
            {
                Package = PackageDB.GetPackageById(id);
                UpdatePackageFields(Package);
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
            int packageID = (int)(sender as ComboBox).SelectedItem;

            //get the package data
            Package = PackageDB.GetPackageById(packageID);

            //update the form fields
            UpdatePackageFields(Package);
        }

        /// <summary>
        /// Updates the Package Fields displayed on the form
        /// </summary>
        /// <param name="package"></param>
        private bool UpdatePackageFields(Package package)
        {
            if (Object.Equals(package, null))
                return false;

            tbxPkgCommission.Text 
                = (package.PkgAgencyCommission.HasValue) ? Decimal.Round((decimal)package.PkgAgencyCommission,2).ToString() : String.Empty;
            tbxPkgPrice.Text = Decimal.Round(package.PkgBasePrice, 2).ToString();
            tbxPkgDesc.Text = package.PkgDesc.ToString();
            tbxPkgEndDate.Text = package.PkgEndDate.ToString();
            tbxPkgName.Text = package.PkgName.ToString();
            tbxPkgStartDate.Text = package.PkgStartDate.ToString();

            return true;
        }
    }
}
