namespace ThreadedProject2
{
    partial class frmPackageManager
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
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label packageIdLabel1;
            this.pnlEntireForm = new System.Windows.Forms.Panel();
            this.pnlProductName = new System.Windows.Forms.Panel();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxProducts = new System.Windows.Forms.GroupBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.dtgProducts = new System.Windows.Forms.DataGridView();
            this.cmbProductList = new System.Windows.Forms.ComboBox();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.gbxPackageDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbxPackageId = new System.Windows.Forms.TextBox();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbxPkgCommission = new System.Windows.Forms.TextBox();
            this.tbxPkgPrice = new System.Windows.Forms.TextBox();
            this.tbxPkgDesc = new System.Windows.Forms.TextBox();
            this.tbxPkgName = new System.Windows.Forms.TextBox();
            this.dtpPkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.btnClearStartDate = new System.Windows.Forms.Button();
            this.btnClearEndDate = new System.Windows.Forms.Button();
            this.lblNameCharCount = new System.Windows.Forms.Label();
            this.lblDescCharCount = new System.Windows.Forms.Label();
            this.gbxLookupPackage = new System.Windows.Forms.GroupBox();
            this.cmbPackageIds = new System.Windows.Forms.ComboBox();
            this.btnAddRemovePackage = new System.Windows.Forms.Button();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            packageIdLabel1 = new System.Windows.Forms.Label();
            this.pnlEntireForm.SuspendLayout();
            this.pnlProductName.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.gbxProducts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            this.gbxPackageDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.gbxLookupPackage.SuspendLayout();
            this.SuspendLayout();
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgEndDateLabel.Location = new System.Drawing.Point(11, 236);
            pkgEndDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(99, 25);
            pkgEndDateLabel.TabIndex = 64;
            pkgEndDateLabel.Text = "End Date:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgStartDateLabel.Location = new System.Drawing.Point(11, 198);
            pkgStartDateLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(105, 25);
            pkgStartDateLabel.TabIndex = 66;
            pkgStartDateLabel.Text = "Start Date:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgNameLabel.Location = new System.Drawing.Point(11, 46);
            pkgNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(70, 25);
            pkgNameLabel.TabIndex = 68;
            pkgNameLabel.Text = "Name:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(11, 160);
            pkgAgencyCommissionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(126, 25);
            pkgAgencyCommissionLabel.TabIndex = 58;
            pkgAgencyCommissionLabel.Text = "Commission:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgDescLabel.Location = new System.Drawing.Point(11, 84);
            pkgDescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(115, 25);
            pkgDescLabel.TabIndex = 62;
            pkgDescLabel.Text = "Description:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgBasePriceLabel.Location = new System.Drawing.Point(11, 122);
            pkgBasePriceLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(62, 25);
            pkgBasePriceLabel.TabIndex = 60;
            pkgBasePriceLabel.Text = "Price:";
            // 
            // packageIdLabel1
            // 
            packageIdLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            packageIdLabel1.AutoSize = true;
            packageIdLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            packageIdLabel1.Location = new System.Drawing.Point(10, 10);
            packageIdLabel1.Name = "packageIdLabel1";
            packageIdLabel1.Size = new System.Drawing.Size(116, 25);
            packageIdLabel1.TabIndex = 70;
            packageIdLabel1.Text = "Package Id:";
            // 
            // pnlEntireForm
            // 
            this.pnlEntireForm.Controls.Add(this.pnlProductName);
            this.pnlEntireForm.Controls.Add(this.gbxProducts);
            this.pnlEntireForm.Controls.Add(this.gbxPackageDetails);
            this.pnlEntireForm.Controls.Add(this.gbxLookupPackage);
            this.pnlEntireForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEntireForm.Location = new System.Drawing.Point(0, 0);
            this.pnlEntireForm.Margin = new System.Windows.Forms.Padding(4);
            this.pnlEntireForm.Name = "pnlEntireForm";
            this.pnlEntireForm.Size = new System.Drawing.Size(998, 532);
            this.pnlEntireForm.TabIndex = 3;
            // 
            // pnlProductName
            // 
            this.pnlProductName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProductName.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlProductName.Controls.Add(this.lblPackageName);
            this.pnlProductName.Location = new System.Drawing.Point(565, 28);
            this.pnlProductName.Name = "pnlProductName";
            this.pnlProductName.Size = new System.Drawing.Size(418, 66);
            this.pnlProductName.TabIndex = 63;
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoEllipsis = true;
            this.lblPackageName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.lblPackageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPackageName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageName.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblPackageName.Location = new System.Drawing.Point(0, 0);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(418, 66);
            this.lblPackageName.TabIndex = 63;
            this.lblPackageName.Text = "ProductName";
            this.lblPackageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DBConnector.Product);
            // 
            // gbxProducts
            // 
            this.gbxProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxProducts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbxProducts.Controls.Add(this.btnAddProduct);
            this.gbxProducts.Controls.Add(this.cmbSuppliers);
            this.gbxProducts.Controls.Add(this.dtgProducts);
            this.gbxProducts.Controls.Add(this.cmbProductList);
            this.gbxProducts.Controls.Add(this.btnRemoveProduct);
            this.gbxProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProducts.Location = new System.Drawing.Point(565, 96);
            this.gbxProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxProducts.Name = "gbxProducts";
            this.gbxProducts.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxProducts.Size = new System.Drawing.Size(418, 423);
            this.gbxProducts.TabIndex = 62;
            this.gbxProducts.TabStop = false;
            this.gbxProducts.Text = "Products";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(270, 35);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(78, 35);
            this.btnAddProduct.TabIndex = 59;
            this.btnAddProduct.TabStop = false;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSuppliers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(12, 76);
            this.cmbSuppliers.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(313, 28);
            this.cmbSuppliers.Sorted = true;
            this.cmbSuppliers.TabIndex = 62;
            this.cmbSuppliers.TabStop = false;
            // 
            // dtgProducts
            // 
            this.dtgProducts.AllowUserToAddRows = false;
            this.dtgProducts.AllowUserToDeleteRows = false;
            this.dtgProducts.AllowUserToOrderColumns = true;
            this.dtgProducts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgProducts.AutoGenerateColumns = false;
            this.dtgProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProducts.BackgroundColor = System.Drawing.Color.White;
            this.dtgProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dtgProducts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn});
            this.dtgProducts.DataSource = this.productBindingSource;
            this.dtgProducts.Location = new System.Drawing.Point(12, 109);
            this.dtgProducts.Margin = new System.Windows.Forms.Padding(0);
            this.dtgProducts.MultiSelect = false;
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.ReadOnly = true;
            this.dtgProducts.RowHeadersWidth = 51;
            this.dtgProducts.RowTemplate.Height = 24;
            this.dtgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProducts.Size = new System.Drawing.Size(402, 261);
            this.dtgProducts.TabIndex = 58;
            this.dtgProducts.TabStop = false;
            // 
            // cmbProductList
            // 
            this.cmbProductList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductList.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.cmbProductList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductList.FormattingEnabled = true;
            this.cmbProductList.Location = new System.Drawing.Point(12, 33);
            this.cmbProductList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbProductList.Name = "cmbProductList";
            this.cmbProductList.Size = new System.Drawing.Size(227, 33);
            this.cmbProductList.Sorted = true;
            this.cmbProductList.TabIndex = 61;
            this.cmbProductList.TabStop = false;
            this.cmbProductList.SelectedIndexChanged += new System.EventHandler(this.cmbProductList_SelectedIndexChanged);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.Location = new System.Drawing.Point(213, 372);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(199, 47);
            this.btnRemoveProduct.TabIndex = 60;
            this.btnRemoveProduct.TabStop = false;
            this.btnRemoveProduct.Text = "Remove Selected";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // gbxPackageDetails
            // 
            this.gbxPackageDetails.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gbxPackageDetails.Controls.Add(this.tableLayoutPanel1);
            this.gbxPackageDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPackageDetails.Location = new System.Drawing.Point(23, 96);
            this.gbxPackageDetails.Margin = new System.Windows.Forms.Padding(4);
            this.gbxPackageDetails.Name = "gbxPackageDetails";
            this.gbxPackageDetails.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.gbxPackageDetails.Size = new System.Drawing.Size(529, 423);
            this.gbxPackageDetails.TabIndex = 60;
            this.gbxPackageDetails.TabStop = false;
            this.gbxPackageDetails.Text = "Package Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(packageIdLabel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxPackageId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(pkgEndDateLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(pkgStartDateLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(pkgAgencyCommissionLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(pkgBasePriceLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(pkgDescLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(pkgNameLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbxPkgCommission, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbxPkgPrice, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbxPkgDesc, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tbxPkgName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpPkgStartDate, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.dtpPkgEndDate, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnClearStartDate, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnClearEndDate, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblNameCharCount, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblDescCharCount, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 25);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(515, 392);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbxPackageId
            // 
            this.tbxPackageId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.tbxPackageId.Enabled = false;
            this.tbxPackageId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPackageId.Location = new System.Drawing.Point(144, 8);
            this.tbxPackageId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxPackageId.Name = "tbxPackageId";
            this.tbxPackageId.ReadOnly = true;
            this.tbxPackageId.Size = new System.Drawing.Size(100, 30);
            this.tbxPackageId.TabIndex = 71;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(DBConnector.Package);
            // 
            // tbxPkgCommission
            // 
            this.tbxPkgCommission.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.tbxPkgCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgCommission.Location = new System.Drawing.Point(145, 158);
            this.tbxPkgCommission.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPkgCommission.Name = "tbxPkgCommission";
            this.tbxPkgCommission.Size = new System.Drawing.Size(177, 30);
            this.tbxPkgCommission.TabIndex = 48;
            this.tbxPkgCommission.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPkgCommission_Validating);
            this.tbxPkgCommission.Validated += new System.EventHandler(this.tbxPkgCommission_Validated);
            // 
            // tbxPkgPrice
            // 
            this.tbxPkgPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.tbxPkgPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgPrice.Location = new System.Drawing.Point(145, 120);
            this.tbxPkgPrice.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPkgPrice.Name = "tbxPkgPrice";
            this.tbxPkgPrice.Size = new System.Drawing.Size(238, 30);
            this.tbxPkgPrice.TabIndex = 47;
            this.tbxPkgPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPkgPrice_Validating);
            this.tbxPkgPrice.Validated += new System.EventHandler(this.tbxPkgPrice_Validated);
            // 
            // tbxPkgDesc
            // 
            this.tbxPkgDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.tbxPkgDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgDesc.Location = new System.Drawing.Point(145, 82);
            this.tbxPkgDesc.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPkgDesc.Name = "tbxPkgDesc";
            this.tbxPkgDesc.Size = new System.Drawing.Size(238, 30);
            this.tbxPkgDesc.TabIndex = 46;
            this.tbxPkgDesc.TextChanged += new System.EventHandler(this.tbxPkgDesc_TextChanged);
            this.tbxPkgDesc.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPkgDesc_Validating);
            this.tbxPkgDesc.Validated += new System.EventHandler(this.tbxPkgDesc_Validated);
            // 
            // tbxPkgName
            // 
            this.tbxPkgName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.tbxPkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgName.Location = new System.Drawing.Point(145, 44);
            this.tbxPkgName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxPkgName.Name = "tbxPkgName";
            this.tbxPkgName.Size = new System.Drawing.Size(238, 30);
            this.tbxPkgName.TabIndex = 45;
            this.tbxPkgName.TextChanged += new System.EventHandler(this.tbxPkgName_TextChanged);
            this.tbxPkgName.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPkgName_Validating);
            this.tbxPkgName.Validated += new System.EventHandler(this.tbxPkgName_Validated);
            // 
            // dtpPkgStartDate
            // 
            this.dtpPkgStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.dtpPkgStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPkgStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPkgStartDate.Location = new System.Drawing.Point(145, 196);
            this.dtpPkgStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPkgStartDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpPkgStartDate.MinDate = new System.DateTime(2000, 2, 5, 0, 0, 0, 0);
            this.dtpPkgStartDate.Name = "dtpPkgStartDate";
            this.dtpPkgStartDate.Size = new System.Drawing.Size(177, 30);
            this.dtpPkgStartDate.TabIndex = 49;
            this.dtpPkgStartDate.ValueChanged += new System.EventHandler(this.dtpPkgStartDate_ValueChanged);
            // 
            // dtpPkgEndDate
            // 
            this.dtpPkgEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.dtpPkgEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPkgEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPkgEndDate.Location = new System.Drawing.Point(145, 234);
            this.dtpPkgEndDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpPkgEndDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpPkgEndDate.MinDate = new System.DateTime(2000, 2, 5, 0, 0, 0, 0);
            this.dtpPkgEndDate.Name = "dtpPkgEndDate";
            this.dtpPkgEndDate.Size = new System.Drawing.Size(177, 30);
            this.dtpPkgEndDate.TabIndex = 50;
            this.dtpPkgEndDate.ValueChanged += new System.EventHandler(this.dtpPkgEndDate_ValueChanged);
            // 
            // btnClearStartDate
            // 
            this.btnClearStartDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearStartDate.Location = new System.Drawing.Point(390, 194);
            this.btnClearStartDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearStartDate.Name = "btnClearStartDate";
            this.btnClearStartDate.Size = new System.Drawing.Size(115, 34);
            this.btnClearStartDate.TabIndex = 57;
            this.btnClearStartDate.TabStop = false;
            this.btnClearStartDate.Text = "Clear Date";
            this.btnClearStartDate.UseVisualStyleBackColor = true;
            this.btnClearStartDate.Click += new System.EventHandler(this.btnClearStartDate_Click);
            // 
            // btnClearEndDate
            // 
            this.btnClearEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEndDate.Location = new System.Drawing.Point(390, 232);
            this.btnClearEndDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearEndDate.Name = "btnClearEndDate";
            this.btnClearEndDate.Size = new System.Drawing.Size(115, 34);
            this.btnClearEndDate.TabIndex = 70;
            this.btnClearEndDate.TabStop = false;
            this.btnClearEndDate.Text = "Clear Date";
            this.btnClearEndDate.UseVisualStyleBackColor = true;
            this.btnClearEndDate.Click += new System.EventHandler(this.btnClearEndDate_Click);
            // 
            // lblNameCharCount
            // 
            this.lblNameCharCount.AutoSize = true;
            this.lblNameCharCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCharCount.ForeColor = System.Drawing.Color.Gray;
            this.lblNameCharCount.Location = new System.Drawing.Point(387, 40);
            this.lblNameCharCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblNameCharCount.Name = "lblNameCharCount";
            this.lblNameCharCount.Size = new System.Drawing.Size(121, 38);
            this.lblNameCharCount.TabIndex = 72;
            this.lblNameCharCount.Text = "label1";
            this.lblNameCharCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescCharCount
            // 
            this.lblDescCharCount.AutoSize = true;
            this.lblDescCharCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCharCount.ForeColor = System.Drawing.Color.Gray;
            this.lblDescCharCount.Location = new System.Drawing.Point(387, 78);
            this.lblDescCharCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescCharCount.Name = "lblDescCharCount";
            this.lblDescCharCount.Size = new System.Drawing.Size(121, 38);
            this.lblDescCharCount.TabIndex = 73;
            this.lblDescCharCount.Text = "label2";
            this.lblDescCharCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gbxLookupPackage
            // 
            this.gbxLookupPackage.Controls.Add(this.cmbPackageIds);
            this.gbxLookupPackage.Controls.Add(this.btnAddRemovePackage);
            this.gbxLookupPackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxLookupPackage.Location = new System.Drawing.Point(23, 15);
            this.gbxLookupPackage.Margin = new System.Windows.Forms.Padding(4);
            this.gbxLookupPackage.Name = "gbxLookupPackage";
            this.gbxLookupPackage.Padding = new System.Windows.Forms.Padding(4);
            this.gbxLookupPackage.Size = new System.Drawing.Size(529, 79);
            this.gbxLookupPackage.TabIndex = 59;
            this.gbxLookupPackage.TabStop = false;
            this.gbxLookupPackage.Text = "Lookup Package";
            // 
            // cmbPackageIds
            // 
            this.cmbPackageIds.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPackageIds.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPackageIds.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.cmbPackageIds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPackageIds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPackageIds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPackageIds.FormattingEnabled = true;
            this.cmbPackageIds.Location = new System.Drawing.Point(21, 31);
            this.cmbPackageIds.Margin = new System.Windows.Forms.Padding(4);
            this.cmbPackageIds.Name = "cmbPackageIds";
            this.cmbPackageIds.Size = new System.Drawing.Size(369, 33);
            this.cmbPackageIds.TabIndex = 42;
            this.cmbPackageIds.SelectedValueChanged += new System.EventHandler(this.cmbPackageIds_SelectedValueChanged);
            // 
            // btnAddRemovePackage
            // 
            this.btnAddRemovePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRemovePackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRemovePackage.Location = new System.Drawing.Point(398, 31);
            this.btnAddRemovePackage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddRemovePackage.Name = "btnAddRemovePackage";
            this.btnAddRemovePackage.Size = new System.Drawing.Size(114, 32);
            this.btnAddRemovePackage.TabIndex = 55;
            this.btnAddRemovePackage.TabStop = false;
            this.btnAddRemovePackage.Text = "New";
            this.btnAddRemovePackage.UseVisualStyleBackColor = true;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.FillWeight = 50F;
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.ToolTipText = "The product id";
            this.productIDDataGridViewTextBoxColumn.Width = 55;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.prodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            this.prodNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.prodNameDataGridViewTextBoxColumn.ToolTipText = "The product name";
            // 
            // frmPackageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 532);
            this.Controls.Add(this.pnlEntireForm);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPackageManager";
            this.Text = "Package Manager";
            this.Load += new System.EventHandler(this.frmPackageManager_Load);
            this.VisibleChanged += new System.EventHandler(this.frmPackageManager_VisibleChanged);
            this.pnlEntireForm.ResumeLayout(false);
            this.pnlProductName.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.gbxProducts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
            this.gbxPackageDetails.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.gbxLookupPackage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
 
        private System.Windows.Forms.Panel pnlEntireForm;
        private System.Windows.Forms.DataGridView dtgProducts;
  
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.GroupBox gbxPackageDetails;
        private System.Windows.Forms.GroupBox gbxLookupPackage;
        private System.Windows.Forms.ComboBox cmbPackageIds;
        private System.Windows.Forms.Button btnAddRemovePackage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbxPkgName;
        private System.Windows.Forms.TextBox tbxPkgDesc;
        private System.Windows.Forms.DateTimePicker dtpPkgEndDate;
        private System.Windows.Forms.DateTimePicker dtpPkgStartDate;
        private System.Windows.Forms.TextBox tbxPkgPrice;
        private System.Windows.Forms.TextBox tbxPkgCommission;
        private System.Windows.Forms.Button btnClearEndDate;
        private System.Windows.Forms.Button btnClearStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox tbxPackageId;
        private System.Windows.Forms.ComboBox cmbProductList;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.GroupBox gbxProducts;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.Panel pnlProductName;
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.Label lblNameCharCount;
        private System.Windows.Forms.Label lblDescCharCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
    }
}

