
using ProductManager;
using SupplierManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadedProject2;

/* Date: Jan 30, 2020
 * Author: Brian Appleton
 * 
 * Thread Project #2
 * 
 * this class is the main entry point to the app and creates the uniform layout and menus for all forms
 *
 *
 */

namespace MainApp
{
    public enum Menu
    {
        Package,
        Product,
        Supplier,
        ProductSupplier
    }
    public partial class frmMainView : Form
    {

        private bool IsMouseDown;
        private int xOffset;
        private int yOffset;


        /// <summary>
        /// Package manager form
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2213:Disposable fields should be disposed", Justification = "<Form remains open until form closes>")]
        public readonly frmPackageManager PackageManager;


        /// <summary>
        /// Product Manager form
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2213:Disposable fields should be disposed", Justification = "<Form remains open until form closes>")]
        public readonly frmProductManager ProductManager;


        /// <summary>
        /// Supplier Manager form
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2213:Disposable fields should be disposed", Justification = "<Form remains open until form closes>")]
        public readonly frmSupplierManager SupplierManager;

        public frmMainView()
        {
            InitializeComponent();

            PackageManager = new frmPackageManager();
            ProductManager = new frmProductManager();
            SupplierManager = new frmSupplierManager();

        }

        private void InitializeMenuForms(Form form)
        {
            form.TopLevel = false;
            pnlForms.Controls.Add(form);

            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
        }

        private void tableLayoutPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            yOffset = (this.Location.Y - Cursor.Position.Y);
            xOffset = (this.Location.X - Cursor.Position.X);

        }

        private void tableLayoutPanel1_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
        }

        private void tableLayoutPanel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                var x = xOffset + Cursor.Position.X;
                var y = yOffset + Cursor.Position.Y;
                Point newPoint = new Point(x, y);
                this.Location = newPoint;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            PackageManager.Dispose();
            SupplierManager.Dispose();
            ProductManager.Dispose();
            Application.Exit();

        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            OpenForm(PackageManager);
        }


        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenForm(ProductManager);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            OpenForm(SupplierManager);
        }

        public void OpenForm(Form form)
        {
            foreach (Form activeForm in pnlForms.Controls)
            {
                activeForm.Hide();
                activeForm.SuspendLayout();
            }

            form.ResumeLayout();
            form.Show();
        }

        private void frmMainView_Load(object sender, EventArgs e)
        {

            InitializeMenuForms(PackageManager);
            InitializeMenuForms(ProductManager);
            InitializeMenuForms(SupplierManager);

            OpenForm(PackageManager);

        }
    }
}
