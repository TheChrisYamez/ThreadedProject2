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

namespace View
{
    public partial class MainView : Form
    {
        private bool IsMouseDown = false;
        private int xOffset;
        private int yOffset;

        readonly frmPackageManager PackageManager;
        readonly frmProductManager ProductManager;
        readonly frmSupplierManager SupplierManager;

        public MainView()
        {
            InitializeComponent();
            PackageManager = new frmPackageManager();
            ProductManager = new frmProductManager();
            SupplierManager = new frmSupplierManager();

            ShowNewForm(PackageManager);

        }
        private void ShowNewForm(Form form)
        {
            form.TopLevel = false;
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
            if (pnlForms.Controls.Contains(PackageManager))
                return;

            RemoveExistingForm();
            ShowNewForm(PackageManager);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            if (pnlForms.Controls.Contains(ProductManager))
                return;

            RemoveExistingForm();
            ShowNewForm(ProductManager);
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            if (pnlForms.Controls.Contains(SupplierManager))
                return;

            RemoveExistingForm();
            ShowNewForm(SupplierManager);
        }
    }
}
