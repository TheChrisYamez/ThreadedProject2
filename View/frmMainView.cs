
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

        ///resolves issues with double buffering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParams = base.CreateParams;
                handleParams.ExStyle |= 0x02000000;
                return handleParams;
            }

        }

        private void InitializeMenuForms(Form form)
        {
            form.TopLevel = false;
            pnlForms.Controls.Add(form);

            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
        }


        private void btnPackages_Click(object sender, EventArgs e)
        {
            UpdateSelectedButtonBackground((Control)sender);
            OpenForm(PackageManager);
        }


        private void btnProducts_Click(object sender, EventArgs e)
        {
            UpdateSelectedButtonBackground((Control)sender);
            OpenForm(ProductManager);
        }


        private void MinimizeApplicationWindow()
        {
            this.Visible = false;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(1000);
            this.WindowState = FormWindowState.Minimized;
        }

        private void RestoreApplicationWindow()
        {
            this.WindowState = FormWindowState.Normal;
            this.Visible = true;
            notifyIcon1.Visible = false;
            this.Show();
        }
        private void UpdateSelectedButtonBackground(Control button)
        {
            this.SuspendLayout();
            foreach (Control btn in tlpMenu.Controls)
                if (btn is FlatButton)
                    btn.BackColor = Color.FromArgb(36, 36, 68);

            button.BackColor = Color.FromArgb(0, 0, 10);
            this.ResumeLayout();
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            UpdateSelectedButtonBackground((Control)sender);
            OpenForm(SupplierManager);
        }

        public void OpenForm(Form form)
        {
            foreach (Form activeForm in pnlForms.Controls)
            {
                activeForm.Hide();
            }

            form.Show();

        }

        private void frmMainView_Load(object sender, EventArgs e)
        {

            InitializeMenuForms(PackageManager);
            InitializeMenuForms(ProductManager);
            InitializeMenuForms(SupplierManager);

            OpenForm(PackageManager);
            UpdateSelectedButtonBackground(btnPackages);
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            PackageManager.Dispose();
            SupplierManager.Dispose();
            ProductManager.Dispose();
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            MinimizeApplicationWindow();

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            RestoreApplicationWindow();
        }


        private void tlpTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            IsMouseDown = true;
            yOffset = (this.Location.Y - Cursor.Position.Y);
            xOffset = (this.Location.X - Cursor.Position.X);

        }

        private void tlpTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            IsMouseDown = false;
        }

        private void tlpTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsMouseDown)
            {
                var x = xOffset + Cursor.Position.X;
                var y = yOffset + Cursor.Position.Y;
                Point newPoint = new Point(x, y);
                this.Location = newPoint;
            }
        }

        private void pnlForms_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
