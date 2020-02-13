﻿using DBConnector;
using ProductSupplierManager;
using ProductManager;
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
        private Supplier supplier; // current customer or null in none selected

        public frmProductManager()
        {
            InitializeComponent();
        }

        List<Product> products; // list of all products
        List<Supplier> suppliers; // list of all suppliers
       // Supplier supplier;
        //List<ProductSupplier> productsuppliers; // list of all productsuppliers
        const int EDIT_BUTTON_INDX = 2; // column in the grid that contains Edit buttons
        Product oldProduct;



        Product oldProducts; // to preserve data before update

       
        private void frmProductManager_Load(object sender, EventArgs e)
        {
            this.Text = "Product Information Page";



            try
            {
                //supplier = SupplierDB.GetSupplier((int)prodNameComboBox.SelectedValue);
               //suppliers = SupplierDB.GetAllSuppliers();
                products = ProductDB.GetAllProducts();
                //supplierDataGridView.DataSource = suppliers;
                //supplierDataGridView.DataSource = supplier;
                productDataGridView.DataSource = products; // bind the grid view to the products list
                prodNameComboBox.DataSource = products;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading Products data: " + ex.Message,
                    ex.GetType().ToString());
            }
        }

        private void productDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void prodNameComboBox_SelectedValueChanged(object sender, EventArgs e)
        {

            ComboBox cmb = (ComboBox)sender;
            if (cmb.SelectedValue == null)
                return;


            suppliers = SupplierDB.GetSupplier((int)cmb.SelectedValue);
            supplierDataGridView.DataSource = suppliers;


        }

        private void prodNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGoToEditSuppliersPage_Click(object sender, EventArgs e)
        {
            frmProductSupplierManager f2 = new frmProductSupplierManager();
            f2.ShowDialog(); // Shows Form2

            //f2.supplier = supplier;
            //DialogResult result = f2.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    supplier = f2.supplier;
            //    this.DisplaySupplier();
            //}
            //else if (result == DialogResult.Retry)
            //{
            //    SupplierDB.GetSingleSupplier(supplier.SupplierID);
            //    if (supplier != null)
            //        this.DisplaySupplier();
            //    else
            //        this.ClearControls();
            //}
        }

        private void productDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnRefreshSuppliers_Click(object sender, EventArgs e)
        {
            //ComboBox cmb = (ComboBox)sender;
            //if (cmb.SelectedValue == null)
            //    return;


            //suppliers = SupplierDB.GetSupplier((int)cmb.SelectedValue);
            //supplierDataGridView.DataSource = suppliers;

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAdd f3 = new frmAdd();
            f3.ShowDialog(); // Shows add form
        }

        private void btnRefreshProducts_Click(object sender, EventArgs e)
        {
            try
            {
                //supplier = SupplierDB.GetSupplier((int)prodNameComboBox.SelectedValue);
                //suppliers = SupplierDB.GetAllSuppliers();
                products = ProductDB.GetAllProducts();
                //supplierDataGridView.DataSource = suppliers;
                //supplierDataGridView.DataSource = supplier;
                productDataGridView.DataSource = products; // bind the grid view to the products list
                prodNameComboBox.DataSource = products;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while loading Products data: " + ex.Message,
                    ex.GetType().ToString());
            }
        }

        private void productBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        //private void DisplaySupplier()
        //{
        //    txtName.Text = customer.Name;
        //    txtAddress.Text = customer.Address;
        //    txtCity.Text = customer.City;
        //    txtState.Text = customer.State;
        //    txtZipCode.Text = customer.ZipCode;
        //    btnModify.Enabled = true;
        //    btnDelete.Enabled = true;
        //}


    }

}
