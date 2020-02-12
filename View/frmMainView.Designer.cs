namespace MainApp
{
    partial class frmMainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainView));
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tlpTitleBar = new System.Windows.Forms.TableLayoutPanel();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnMinimize = new MainApp.FlatButton();
            this.btnClose = new MainApp.FlatButton();
            this.btnPackages = new MainApp.FlatButton();
            this.btnSuppliers = new MainApp.FlatButton();
            this.btnProducts = new MainApp.FlatButton();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.tlpMain.SuspendLayout();
            this.tlpTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.AutoSize = true;
            this.tlpMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpMain.Controls.Add(this.btnProducts, 1, 1);
            this.tlpMain.Controls.Add(this.tlpTitleBar, 0, 0);
            this.tlpMain.Controls.Add(this.btnSuppliers, 0, 1);
            this.tlpMain.Controls.Add(this.btnPackages, 2, 1);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tlpMain.RowCount = 2;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.15385F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.84616F));
            this.tlpMain.Size = new System.Drawing.Size(853, 91);
            this.tlpMain.TabIndex = 0;
            // 
            // tlpTitleBar
            // 
            this.tlpTitleBar.AutoSize = true;
            this.tlpTitleBar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpTitleBar.ColumnCount = 3;
            this.tlpMain.SetColumnSpan(this.tlpTitleBar, 3);
            this.tlpTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTitleBar.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpTitleBar.Controls.Add(this.btnMinimize, 0, 0);
            this.tlpTitleBar.Controls.Add(this.btnClose, 0, 0);
            this.tlpTitleBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpTitleBar.Location = new System.Drawing.Point(3, 3);
            this.tlpTitleBar.Name = "tlpTitleBar";
            this.tlpTitleBar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tlpTitleBar.RowCount = 1;
            this.tlpTitleBar.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpTitleBar.Size = new System.Drawing.Size(847, 36);
            this.tlpTitleBar.TabIndex = 2;
            this.tlpTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tlpTitleBar_MouseDown);
            this.tlpTitleBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tlpTitleBar_MouseMove);
            this.tlpTitleBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tlpTitleBar_MouseUp);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Click here to restore the program";
            this.notifyIcon1.BalloonTipTitle = "Package Management System";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Package Management System";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Crimson;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(760, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.OnHoverBackColor = System.Drawing.Color.Pink;
            this.btnMinimize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnMinimize.Size = new System.Drawing.Size(39, 30);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "-";
            this.btnMinimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(805, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.Pink;
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(39, 30);
            this.btnClose.TabIndex = 4;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // btnPackages
            // 
            this.btnPackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(10)))));
            this.btnPackages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPackages.FlatAppearance.BorderSize = 0;
            this.btnPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPackages.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackages.ForeColor = System.Drawing.Color.LightGray;
            this.btnPackages.Location = new System.Drawing.Point(10, 42);
            this.btnPackages.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.btnPackages.Size = new System.Drawing.Size(265, 49);
            this.btnPackages.TabIndex = 0;
            this.btnPackages.Text = "Packages";
            this.btnPackages.UseVisualStyleBackColor = false;
            this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.btnSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.ForeColor = System.Drawing.Color.LightGray;
            this.btnSuppliers.Location = new System.Drawing.Point(579, 42);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.btnSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSuppliers.Size = new System.Drawing.Size(264, 49);
            this.btnSuppliers.TabIndex = 2;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.AutoSize = true;
            this.btnProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.LightGray;
            this.btnProducts.Location = new System.Drawing.Point(295, 42);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.btnProducts.Size = new System.Drawing.Size(264, 49);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // pnlForms
            // 
            this.pnlForms.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlForms.BackColor = System.Drawing.Color.Azure;
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.Location = new System.Drawing.Point(0, 91);
            this.pnlForms.MinimumSize = new System.Drawing.Size(700, 550);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Padding = new System.Windows.Forms.Padding(5);
            this.pnlForms.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlForms.Size = new System.Drawing.Size(853, 559);
            this.pnlForms.TabIndex = 2;
            // 
            // frmMainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(853, 650);
            this.Controls.Add(this.pnlForms);
            this.Controls.Add(this.tlpMain);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(750, 650);
            this.Name = "frmMainView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Package System";
            this.Load += new System.EventHandler(this.frmMainView_Load);
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tlpTitleBar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private FlatButton btnSuppliers;
        private FlatButton btnProducts;
        private FlatButton btnPackages;
        private System.Windows.Forms.TableLayoutPanel tlpTitleBar;
        private FlatButton btnMinimize;
        private FlatButton btnClose;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Panel pnlForms;
    }
}

