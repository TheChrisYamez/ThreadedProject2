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
    public partial class frmMainView : Form
    {
        private bool IsMouseDown = false;
        private int xOffset;
        private int yOffset;

        public readonly frmPackageManager PackageManager;
        public readonly frmProductManager ProductManager;
        public readonly frmSupplierManager SupplierManager;

        public frmMainView()
        {
            InitializeComponent();
            PackageManager = new frmPackageManager();
            ProductManager = new frmProductManager();
            SupplierManager = new frmSupplierManager();


            ShowNewForm(PackageManager);

        }
        private void ShowNewForm(Form form)
        {
            form.MdiParent = this;

            pnlForms.Controls.Add(form);

            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }

        private void RemoveExistingForm()
        {
            if (pnlForms.Controls.Count < 1)
                return;

            Form formToRemove = null;

            foreach (Form form in pnlForms.Controls)
                formToRemove = form;

            pnlForms.Controls.Remove(formToRemove);
        }
        public void ReplaceExistingForm(Form form)
        {
            if (pnlForms.Controls.Contains(form))
                return;

            RemoveExistingForm();
            ShowNewForm(form);
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
            Application.Exit();
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            ReplaceExistingForm(PackageManager);
        }


        private void btnProducts_Click(object sender, EventArgs e)
        {
            ReplaceExistingForm(ProductManager);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            ReplaceExistingForm(SupplierManager);
        }
    }
}
