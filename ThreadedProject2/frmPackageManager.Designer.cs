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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgNameLabel;
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productExtendedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxPackageDetails = new System.Windows.Forms.GroupBox();
            this.dtgProducts = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSupplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbProductList = new System.Windows.Forms.ComboBox();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.tbxPkgCommission = new System.Windows.Forms.TextBox();
            this.dtpPkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.tbxPkgName = new System.Windows.Forms.TextBox();
            this.tbxPkgDesc = new System.Windows.Forms.TextBox();
            this.tbxPkgPrice = new System.Windows.Forms.TextBox();
            this.cmbPackageIds = new System.Windows.Forms.ComboBox();
            this.btnAddRemovePackage = new System.Windows.Forms.Button();
            this.lblNameCharCount = new System.Windows.Forms.Label();
            this.lblDescCharCount = new System.Windows.Forms.Label();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnClearEndDate = new System.Windows.Forms.Button();
            this.btnClearStartDate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productExtendedBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.gbxPackageDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DBConnector.Product);
            // 
            // productExtendedBindingSource
            // 
            this.productExtendedBindingSource.DataSource = typeof(DBConnector.ProductExtended);
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(DBConnector.Package);
            // 
            // gbxPackageDetails
            // 
            this.gbxPackageDetails.Controls.Add(this.panel7);
            this.gbxPackageDetails.Controls.Add(this.panel5);
            this.gbxPackageDetails.Controls.Add(this.panel4);
            this.gbxPackageDetails.Controls.Add(this.panel3);
            this.gbxPackageDetails.Controls.Add(this.dtgProducts);
            this.gbxPackageDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxPackageDetails.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPackageDetails.Location = new System.Drawing.Point(0, 0);
            this.gbxPackageDetails.Name = "gbxPackageDetails";
            this.gbxPackageDetails.Padding = new System.Windows.Forms.Padding(5);
            this.gbxPackageDetails.Size = new System.Drawing.Size(941, 604);
            this.gbxPackageDetails.TabIndex = 61;
            this.gbxPackageDetails.TabStop = false;
            this.gbxPackageDetails.Text = "Package";
            // 
            // dtgProducts
            // 
            this.dtgProducts.AllowUserToAddRows = false;
            this.dtgProducts.AllowUserToDeleteRows = false;
            this.dtgProducts.AllowUserToOrderColumns = true;
            this.dtgProducts.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
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
            this.prodNameDataGridViewTextBoxColumn,
            this.SupplierName,
            this.productSupplierIdDataGridViewTextBoxColumn});
            this.dtgProducts.DataSource = this.productExtendedBindingSource;
            this.dtgProducts.Location = new System.Drawing.Point(9, 388);
            this.dtgProducts.Margin = new System.Windows.Forms.Padding(0);
            this.dtgProducts.MultiSelect = false;
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.ReadOnly = true;
            this.dtgProducts.RowHeadersWidth = 51;
            this.dtgProducts.RowTemplate.Height = 24;
            this.dtgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProducts.Size = new System.Drawing.Size(921, 208);
            this.dtgProducts.TabIndex = 58;
            this.dtgProducts.TabStop = false;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.productIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "Product";
            this.prodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            this.prodNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SupplierName
            // 
            this.SupplierName.DataPropertyName = "SupplierName";
            this.SupplierName.HeaderText = "Supplier";
            this.SupplierName.MinimumWidth = 6;
            this.SupplierName.Name = "SupplierName";
            this.SupplierName.ReadOnly = true;
            // 
            // productSupplierIdDataGridViewTextBoxColumn
            // 
            this.productSupplierIdDataGridViewTextBoxColumn.DataPropertyName = "ProductSupplierId";
            this.productSupplierIdDataGridViewTextBoxColumn.HeaderText = "ProductSupplierId";
            this.productSupplierIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productSupplierIdDataGridViewTextBoxColumn.Name = "productSupplierIdDataGridViewTextBoxColumn";
            this.productSupplierIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.productSupplierIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // cmbProductList
            // 
            this.cmbProductList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbProductList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductList.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.cmbProductList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductList.FormattingEnabled = true;
            this.cmbProductList.Location = new System.Drawing.Point(85, 0);
            this.cmbProductList.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProductList.Name = "cmbProductList";
            this.cmbProductList.Size = new System.Drawing.Size(281, 33);
            this.cmbProductList.Sorted = true;
            this.cmbProductList.TabIndex = 61;
            this.cmbProductList.TabStop = false;
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSuppliers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSuppliers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(85, 52);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(281, 32);
            this.cmbSuppliers.Sorted = true;
            this.cmbSuppliers.TabIndex = 62;
            this.cmbSuppliers.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(-2, 52);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 24);
            label2.TabIndex = 72;
            label2.Text = "Supplier";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(2, 4);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 24);
            label1.TabIndex = 71;
            label1.Text = "Product";
            // 
            // tbxPkgCommission
            // 
            this.tbxPkgCommission.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPkgCommission.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.tbxPkgCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgCommission.Location = new System.Drawing.Point(3, 30);
            this.tbxPkgCommission.Name = "tbxPkgCommission";
            this.tbxPkgCommission.Size = new System.Drawing.Size(416, 30);
            this.tbxPkgCommission.TabIndex = 48;
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(3, 3);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(117, 24);
            pkgAgencyCommissionLabel.TabIndex = 58;
            pkgAgencyCommissionLabel.Text = "Commission";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgStartDateLabel.Location = new System.Drawing.Point(3, 63);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(98, 24);
            pkgStartDateLabel.TabIndex = 66;
            pkgStartDateLabel.Text = "Start Date";
            // 
            // dtpPkgStartDate
            // 
            this.dtpPkgStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPkgStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.dtpPkgStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPkgStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPkgStartDate.Location = new System.Drawing.Point(0, 90);
            this.dtpPkgStartDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpPkgStartDate.MinDate = new System.DateTime(2000, 2, 5, 0, 0, 0, 0);
            this.dtpPkgStartDate.Name = "dtpPkgStartDate";
            this.dtpPkgStartDate.Size = new System.Drawing.Size(419, 30);
            this.dtpPkgStartDate.TabIndex = 49;
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgEndDateLabel.Location = new System.Drawing.Point(3, 123);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(89, 24);
            pkgEndDateLabel.TabIndex = 64;
            pkgEndDateLabel.Text = "End Date";
            // 
            // dtpPkgEndDate
            // 
            this.dtpPkgEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpPkgEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.dtpPkgEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPkgEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPkgEndDate.Location = new System.Drawing.Point(0, 150);
            this.dtpPkgEndDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpPkgEndDate.MinDate = new System.DateTime(2000, 2, 5, 0, 0, 0, 0);
            this.dtpPkgEndDate.Name = "dtpPkgEndDate";
            this.dtpPkgEndDate.Size = new System.Drawing.Size(419, 30);
            this.dtpPkgEndDate.TabIndex = 50;
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgDescLabel.Location = new System.Drawing.Point(3, 116);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(110, 24);
            pkgDescLabel.TabIndex = 62;
            pkgDescLabel.Text = "Description";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgBasePriceLabel.Location = new System.Drawing.Point(3, 176);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(52, 24);
            pkgBasePriceLabel.TabIndex = 60;
            pkgBasePriceLabel.Text = "Price";
            // 
            // tbxPkgName
            // 
            this.tbxPkgName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPkgName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.tbxPkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgName.Location = new System.Drawing.Point(3, 83);
            this.tbxPkgName.Name = "tbxPkgName";
            this.tbxPkgName.Size = new System.Drawing.Size(246, 30);
            this.tbxPkgName.TabIndex = 45;
            // 
            // tbxPkgDesc
            // 
            this.tbxPkgDesc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPkgDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.tbxPkgDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgDesc.Location = new System.Drawing.Point(3, 143);
            this.tbxPkgDesc.Name = "tbxPkgDesc";
            this.tbxPkgDesc.Size = new System.Drawing.Size(246, 30);
            this.tbxPkgDesc.TabIndex = 46;
            // 
            // tbxPkgPrice
            // 
            this.tbxPkgPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxPkgPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.tbxPkgPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgPrice.Location = new System.Drawing.Point(3, 203);
            this.tbxPkgPrice.Name = "tbxPkgPrice";
            this.tbxPkgPrice.Size = new System.Drawing.Size(246, 30);
            this.tbxPkgPrice.TabIndex = 47;
            // 
            // cmbPackageIds
            // 
            this.cmbPackageIds.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbPackageIds.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPackageIds.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPackageIds.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.cmbPackageIds.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPackageIds.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbPackageIds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPackageIds.FormattingEnabled = true;
            this.cmbPackageIds.Location = new System.Drawing.Point(3, 3);
            this.cmbPackageIds.Name = "cmbPackageIds";
            this.cmbPackageIds.Size = new System.Drawing.Size(246, 33);
            this.cmbPackageIds.TabIndex = 42;
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgNameLabel.Location = new System.Drawing.Point(3, 56);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(62, 24);
            pkgNameLabel.TabIndex = 68;
            pkgNameLabel.Text = "Name";
            // 
            // btnAddRemovePackage
            // 
            this.btnAddRemovePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRemovePackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRemovePackage.Location = new System.Drawing.Point(8, 5);
            this.btnAddRemovePackage.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRemovePackage.Name = "btnAddRemovePackage";
            this.btnAddRemovePackage.Size = new System.Drawing.Size(95, 35);
            this.btnAddRemovePackage.TabIndex = 55;
            this.btnAddRemovePackage.TabStop = false;
            this.btnAddRemovePackage.Text = "New";
            this.btnAddRemovePackage.UseVisualStyleBackColor = true;
            // 
            // lblNameCharCount
            // 
            this.lblNameCharCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblNameCharCount.AutoSize = true;
            this.lblNameCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCharCount.ForeColor = System.Drawing.Color.Gray;
            this.lblNameCharCount.Location = new System.Drawing.Point(193, 59);
            this.lblNameCharCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblNameCharCount.Name = "lblNameCharCount";
            this.lblNameCharCount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblNameCharCount.Size = new System.Drawing.Size(56, 17);
            this.lblNameCharCount.TabIndex = 72;
            this.lblNameCharCount.Text = "label1";
            this.lblNameCharCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescCharCount
            // 
            this.lblDescCharCount.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblDescCharCount.AutoSize = true;
            this.lblDescCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCharCount.ForeColor = System.Drawing.Color.Gray;
            this.lblDescCharCount.Location = new System.Drawing.Point(193, 119);
            this.lblDescCharCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescCharCount.Name = "lblDescCharCount";
            this.lblDescCharCount.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblDescCharCount.Size = new System.Drawing.Size(56, 17);
            this.lblDescCharCount.TabIndex = 73;
            this.lblDescCharCount.Text = "label2";
            this.lblDescCharCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPackageName
            // 
            this.lblPackageName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPackageName.AutoEllipsis = true;
            this.lblPackageName.AutoSize = true;
            this.lblPackageName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.lblPackageName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageName.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblPackageName.Location = new System.Drawing.Point(64, 9);
            this.lblPackageName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(180, 31);
            this.lblPackageName.TabIndex = 63;
            this.lblPackageName.Text = "ProductName";
            this.lblPackageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.Location = new System.Drawing.Point(4, 60);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(98, 35);
            this.btnRemoveProduct.TabIndex = 60;
            this.btnRemoveProduct.TabStop = false;
            this.btnRemoveProduct.Text = "Remove";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(0, 60);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(95, 35);
            this.btnAddProduct.TabIndex = 59;
            this.btnAddProduct.TabStop = false;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnClearEndDate
            // 
            this.btnClearEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEndDate.Location = new System.Drawing.Point(2, 149);
            this.btnClearEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearEndDate.Name = "btnClearEndDate";
            this.btnClearEndDate.Size = new System.Drawing.Size(124, 31);
            this.btnClearEndDate.TabIndex = 70;
            this.btnClearEndDate.TabStop = false;
            this.btnClearEndDate.Text = "Clear";
            this.btnClearEndDate.UseVisualStyleBackColor = true;
            // 
            // btnClearStartDate
            // 
            this.btnClearStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearStartDate.Location = new System.Drawing.Point(2, 90);
            this.btnClearStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearStartDate.Name = "btnClearStartDate";
            this.btnClearStartDate.Size = new System.Drawing.Size(124, 30);
            this.btnClearStartDate.TabIndex = 57;
            this.btnClearStartDate.TabStop = false;
            this.btnClearStartDate.Text = "Clear";
            this.btnClearStartDate.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(pkgAgencyCommissionLabel);
            this.panel1.Controls.Add(this.tbxPkgCommission);
            this.panel1.Controls.Add(pkgStartDateLabel);
            this.panel1.Controls.Add(this.dtpPkgStartDate);
            this.panel1.Controls.Add(pkgEndDateLabel);
            this.panel1.Controls.Add(this.dtpPkgEndDate);
            this.panel1.Location = new System.Drawing.Point(3, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(419, 192);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.btnClearStartDate);
            this.panel2.Controls.Add(this.btnClearEndDate);
            this.panel2.Location = new System.Drawing.Point(425, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(128, 192);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(label1);
            this.panel3.Controls.Add(this.cmbSuppliers);
            this.panel3.Controls.Add(this.cmbProductList);
            this.panel3.Controls.Add(label2);
            this.panel3.Location = new System.Drawing.Point(9, 286);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(368, 99);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel4.Controls.Add(pkgDescLabel);
            this.panel4.Controls.Add(this.lblDescCharCount);
            this.panel4.Controls.Add(this.lblNameCharCount);
            this.panel4.Controls.Add(this.cmbPackageIds);
            this.panel4.Controls.Add(pkgBasePriceLabel);
            this.panel4.Controls.Add(pkgNameLabel);
            this.panel4.Controls.Add(this.tbxPkgName);
            this.panel4.Controls.Add(this.tbxPkgPrice);
            this.panel4.Controls.Add(this.tbxPkgDesc);
            this.panel4.Location = new System.Drawing.Point(9, 30);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(249, 250);
            this.panel4.TabIndex = 64;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.btnAddRemovePackage);
            this.panel5.Location = new System.Drawing.Point(264, 30);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(108, 250);
            this.panel5.TabIndex = 65;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel6.Controls.Add(this.lblPackageName);
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(553, 54);
            this.panel6.TabIndex = 66;
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Controls.Add(this.panel6);
            this.panel7.Controls.Add(this.panel1);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Location = new System.Drawing.Point(380, 30);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(553, 354);
            this.panel7.TabIndex = 67;
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel8.Controls.Add(this.btnAddProduct);
            this.panel8.Location = new System.Drawing.Point(3, 256);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(101, 95);
            this.panel8.TabIndex = 67;
            // 
            // panel9
            // 
            this.panel9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel9.Controls.Add(this.btnRemoveProduct);
            this.panel9.Location = new System.Drawing.Point(448, 256);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(105, 95);
            this.panel9.TabIndex = 68;
            // 
            // frmPackageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 604);
            this.Controls.Add(this.gbxPackageDetails);
            this.Name = "frmPackageManager";
            this.Text = "Package Manager";
            this.Load += new System.EventHandler(this.frmPackageManager_Load);
            this.VisibleChanged += new System.EventHandler(this.frmPackageManager_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productExtendedBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.gbxPackageDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productExtendedBindingSource;
        private System.Windows.Forms.GroupBox gbxPackageDetails;
        private System.Windows.Forms.DataGridView dtgProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSupplierIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbProductList;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.TextBox tbxPkgCommission;
        private System.Windows.Forms.DateTimePicker dtpPkgStartDate;
        private System.Windows.Forms.DateTimePicker dtpPkgEndDate;
        private System.Windows.Forms.TextBox tbxPkgName;
        private System.Windows.Forms.TextBox tbxPkgDesc;
        private System.Windows.Forms.TextBox tbxPkgPrice;
        private System.Windows.Forms.ComboBox cmbPackageIds;
        private System.Windows.Forms.Button btnClearStartDate;
        private System.Windows.Forms.Button btnClearEndDate;
        private System.Windows.Forms.Button btnAddRemovePackage;
        private System.Windows.Forms.Label lblNameCharCount;
        private System.Windows.Forms.Label lblDescCharCount;
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
    }
}

