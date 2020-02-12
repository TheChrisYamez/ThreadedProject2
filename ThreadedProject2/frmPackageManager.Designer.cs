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
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            this.pnlEntireForm = new System.Windows.Forms.Panel();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cmbProductList = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.cmbSuppliers = new System.Windows.Forms.ComboBox();
            this.dtgProducts = new System.Windows.Forms.DataGridView();
            this.productExtendedBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.gbxPackageDetails = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbxPkgPrice = new System.Windows.Forms.TextBox();
            this.tbxPkgDesc = new System.Windows.Forms.TextBox();
            this.tbxPackageId = new System.Windows.Forms.TextBox();
            this.tbxPkgName = new System.Windows.Forms.TextBox();
            this.lblNameCharCount = new System.Windows.Forms.Label();
            this.lblDescCharCount = new System.Windows.Forms.Label();
            this.cmbPackageIds = new System.Windows.Forms.ComboBox();
            this.btnAddRemovePackage = new System.Windows.Forms.Button();
            this.dtpPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.tbxPkgCommission = new System.Windows.Forms.TextBox();
            this.lblPackageName = new System.Windows.Forms.Label();
            this.btnClearStartDate = new System.Windows.Forms.Button();
            this.btnClearEndDate = new System.Windows.Forms.Button();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSupplierIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            this.pnlEntireForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productExtendedBindingSource)).BeginInit();
            this.gbxPackageDetails.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgNameLabel.Location = new System.Drawing.Point(8, 79);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(64, 25);
            pkgNameLabel.TabIndex = 68;
            pkgNameLabel.Text = "Name";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgDescLabel.Location = new System.Drawing.Point(8, 140);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(109, 25);
            pkgDescLabel.TabIndex = 62;
            pkgDescLabel.Text = "Description";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgBasePriceLabel.Location = new System.Drawing.Point(8, 204);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(56, 25);
            pkgBasePriceLabel.TabIndex = 60;
            pkgBasePriceLabel.Text = "Price";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(7, 294);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 25);
            label1.TabIndex = 71;
            label1.Text = "Product";
            // 
            // label2
            // 
            label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(7, 332);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(84, 25);
            label2.TabIndex = 72;
            label2.Text = "Supplier";
            // 
            // pnlEntireForm
            // 
            this.pnlEntireForm.Controls.Add(this.gbxPackageDetails);
            this.pnlEntireForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEntireForm.Location = new System.Drawing.Point(0, 0);
            this.pnlEntireForm.Name = "pnlEntireForm";
            this.pnlEntireForm.Size = new System.Drawing.Size(832, 643);
            this.pnlEntireForm.TabIndex = 3;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DBConnector.Product);
            // 
            // cmbProductList
            // 
            this.cmbProductList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableLayoutPanel1.SetColumnSpan(this.cmbProductList, 2);
            this.cmbProductList.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.cmbProductList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbProductList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductList.FormattingEnabled = true;
            this.cmbProductList.Location = new System.Drawing.Point(294, 290);
            this.cmbProductList.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProductList.Name = "cmbProductList";
            this.cmbProductList.Size = new System.Drawing.Size(373, 33);
            this.cmbProductList.Sorted = true;
            this.cmbProductList.TabIndex = 61;
            this.cmbProductList.TabStop = false;
            this.cmbProductList.SelectedIndexChanged += new System.EventHandler(this.cmbProductList_SelectedIndexChanged);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(671, 327);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(95, 35);
            this.btnAddProduct.TabIndex = 59;
            this.btnAddProduct.TabStop = false;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // cmbSuppliers
            // 
            this.cmbSuppliers.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSuppliers.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tableLayoutPanel1.SetColumnSpan(this.cmbSuppliers, 2);
            this.cmbSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSuppliers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSuppliers.FormattingEnabled = true;
            this.cmbSuppliers.Location = new System.Drawing.Point(295, 328);
            this.cmbSuppliers.Name = "cmbSuppliers";
            this.cmbSuppliers.Size = new System.Drawing.Size(371, 33);
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
            this.prodNameDataGridViewTextBoxColumn,
            this.SupplierName,
            this.productSupplierIdDataGridViewTextBoxColumn});
            this.tableLayoutPanel1.SetColumnSpan(this.dtgProducts, 4);
            this.dtgProducts.DataSource = this.productExtendedBindingSource;
            this.dtgProducts.Location = new System.Drawing.Point(5, 364);
            this.dtgProducts.Margin = new System.Windows.Forms.Padding(0);
            this.dtgProducts.MultiSelect = false;
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.ReadOnly = true;
            this.dtgProducts.RowHeadersWidth = 51;
            this.dtgProducts.RowTemplate.Height = 24;
            this.dtgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProducts.Size = new System.Drawing.Size(812, 179);
            this.dtgProducts.TabIndex = 58;
            this.dtgProducts.TabStop = false;
            this.dtgProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProducts_CellContentClick);
            // 
            // productExtendedBindingSource
            // 
            this.productExtendedBindingSource.DataSource = typeof(DBConnector.ProductExtended);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.Location = new System.Drawing.Point(671, 545);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(95, 35);
            this.btnRemoveProduct.TabIndex = 60;
            this.btnRemoveProduct.TabStop = false;
            this.btnRemoveProduct.Text = "Remove";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            this.btnRemoveProduct.Click += new System.EventHandler(this.btnRemoveProduct_Click);
            // 
            // gbxPackageDetails
            // 
            this.gbxPackageDetails.Controls.Add(this.tableLayoutPanel1);
            this.gbxPackageDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxPackageDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPackageDetails.Location = new System.Drawing.Point(0, 0);
            this.gbxPackageDetails.Name = "gbxPackageDetails";
            this.gbxPackageDetails.Padding = new System.Windows.Forms.Padding(5);
            this.gbxPackageDetails.Size = new System.Drawing.Size(832, 643);
            this.gbxPackageDetails.TabIndex = 60;
            this.gbxPackageDetails.TabStop = false;
            this.gbxPackageDetails.Text = "Package";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.dtgProducts, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.cmbProductList, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.cmbSuppliers, 1, 10);
            this.tableLayoutPanel1.Controls.Add(label2, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.lblNameCharCount, 1, 3);
            this.tableLayoutPanel1.Controls.Add(label1, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.lblDescCharCount, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbxPkgCommission, 2, 3);
            this.tableLayoutPanel1.Controls.Add(pkgAgencyCommissionLabel, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblPackageName, 2, 0);
            this.tableLayoutPanel1.Controls.Add(pkgStartDateLabel, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpPkgStartDate, 2, 5);
            this.tableLayoutPanel1.Controls.Add(pkgEndDateLabel, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.dtpPkgEndDate, 2, 7);
            this.tableLayoutPanel1.Controls.Add(pkgNameLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(pkgDescLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(pkgBasePriceLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbxPkgName, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbxPkgDesc, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbxPkgPrice, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.cmbPackageIds, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnAddRemovePackage, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbxPackageId, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClearStartDate, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnClearEndDate, 3, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnAddProduct, 3, 10);
            this.tableLayoutPanel1.Controls.Add(this.btnRemoveProduct, 3, 13);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.tableLayoutPanel1.RowCount = 14;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(822, 599);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(DBConnector.Package);
            // 
            // tbxPkgPrice
            // 
            this.tbxPkgPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.tbxPkgPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgPrice.Location = new System.Drawing.Point(8, 232);
            this.tbxPkgPrice.Name = "tbxPkgPrice";
            this.tbxPkgPrice.Size = new System.Drawing.Size(281, 30);
            this.tbxPkgPrice.TabIndex = 47;
            this.tbxPkgPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPkgPrice_Validating);
            this.tbxPkgPrice.Validated += new System.EventHandler(this.tbxPkgPrice_Validated);
            // 
            // tbxPkgDesc
            // 
            this.tbxPkgDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.tbxPkgDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgDesc.Location = new System.Drawing.Point(8, 168);
            this.tbxPkgDesc.Name = "tbxPkgDesc";
            this.tbxPkgDesc.Size = new System.Drawing.Size(281, 30);
            this.tbxPkgDesc.TabIndex = 46;
            this.tbxPkgDesc.TextChanged += new System.EventHandler(this.tbxPkgDesc_TextChanged);
            this.tbxPkgDesc.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPkgDesc_Validating);
            this.tbxPkgDesc.Validated += new System.EventHandler(this.tbxPkgDesc_Validated);
            // 
            // tbxPackageId
            // 
            this.tbxPackageId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.tbxPackageId.Enabled = false;
            this.tbxPackageId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPackageId.Location = new System.Drawing.Point(294, 47);
            this.tbxPackageId.Margin = new System.Windows.Forms.Padding(2);
            this.tbxPackageId.Name = "tbxPackageId";
            this.tbxPackageId.ReadOnly = true;
            this.tbxPackageId.Size = new System.Drawing.Size(86, 30);
            this.tbxPackageId.TabIndex = 71;
            // 
            // tbxPkgName
            // 
            this.tbxPkgName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.tbxPkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgName.Location = new System.Drawing.Point(8, 107);
            this.tbxPkgName.Name = "tbxPkgName";
            this.tbxPkgName.Size = new System.Drawing.Size(281, 30);
            this.tbxPkgName.TabIndex = 45;
            this.tbxPkgName.TextChanged += new System.EventHandler(this.tbxPkgName_TextChanged);
            this.tbxPkgName.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPkgName_Validating);
            this.tbxPkgName.Validated += new System.EventHandler(this.tbxPkgName_Validated);
            // 
            // lblNameCharCount
            // 
            this.lblNameCharCount.AutoSize = true;
            this.lblNameCharCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblNameCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameCharCount.ForeColor = System.Drawing.Color.Gray;
            this.lblNameCharCount.Location = new System.Drawing.Point(322, 104);
            this.lblNameCharCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblNameCharCount.Name = "lblNameCharCount";
            this.lblNameCharCount.Size = new System.Drawing.Size(60, 36);
            this.lblNameCharCount.TabIndex = 72;
            this.lblNameCharCount.Text = "label1";
            this.lblNameCharCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDescCharCount
            // 
            this.lblDescCharCount.AutoSize = true;
            this.lblDescCharCount.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblDescCharCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescCharCount.ForeColor = System.Drawing.Color.Gray;
            this.lblDescCharCount.Location = new System.Drawing.Point(322, 165);
            this.lblDescCharCount.Margin = new System.Windows.Forms.Padding(0);
            this.lblDescCharCount.Name = "lblDescCharCount";
            this.lblDescCharCount.Size = new System.Drawing.Size(60, 39);
            this.lblDescCharCount.TabIndex = 73;
            this.lblDescCharCount.Text = "label2";
            this.lblDescCharCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.cmbPackageIds.Location = new System.Drawing.Point(8, 8);
            this.cmbPackageIds.Name = "cmbPackageIds";
            this.cmbPackageIds.Size = new System.Drawing.Size(278, 33);
            this.cmbPackageIds.TabIndex = 42;
            this.cmbPackageIds.SelectedValueChanged += new System.EventHandler(this.cmbPackageIds_SelectedValueChanged);
            // 
            // btnAddRemovePackage
            // 
            this.btnAddRemovePackage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRemovePackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRemovePackage.Location = new System.Drawing.Point(294, 7);
            this.btnAddRemovePackage.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRemovePackage.Name = "btnAddRemovePackage";
            this.btnAddRemovePackage.Size = new System.Drawing.Size(86, 36);
            this.btnAddRemovePackage.TabIndex = 55;
            this.btnAddRemovePackage.TabStop = false;
            this.btnAddRemovePackage.Text = "New";
            this.btnAddRemovePackage.UseVisualStyleBackColor = true;
            // 
            // dtpPkgEndDate
            // 
            this.dtpPkgEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.dtpPkgEndDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpPkgEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPkgEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPkgEndDate.Location = new System.Drawing.Point(385, 232);
            this.dtpPkgEndDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpPkgEndDate.MinDate = new System.DateTime(2000, 2, 5, 0, 0, 0, 0);
            this.dtpPkgEndDate.Name = "dtpPkgEndDate";
            this.dtpPkgEndDate.Size = new System.Drawing.Size(281, 30);
            this.dtpPkgEndDate.TabIndex = 50;
            this.dtpPkgEndDate.ValueChanged += new System.EventHandler(this.dtpPkgEndDate_ValueChanged);
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgEndDateLabel.Location = new System.Drawing.Point(385, 204);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(93, 25);
            pkgEndDateLabel.TabIndex = 64;
            pkgEndDateLabel.Text = "End Date";
            // 
            // dtpPkgStartDate
            // 
            this.dtpPkgStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.dtpPkgStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPkgStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPkgStartDate.Location = new System.Drawing.Point(385, 168);
            this.dtpPkgStartDate.MaxDate = new System.DateTime(2100, 12, 31, 0, 0, 0, 0);
            this.dtpPkgStartDate.MinDate = new System.DateTime(2000, 2, 5, 0, 0, 0, 0);
            this.dtpPkgStartDate.Name = "dtpPkgStartDate";
            this.dtpPkgStartDate.Size = new System.Drawing.Size(281, 30);
            this.dtpPkgStartDate.TabIndex = 49;
            this.dtpPkgStartDate.ValueChanged += new System.EventHandler(this.dtpPkgStartDate_ValueChanged);
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgStartDateLabel.Location = new System.Drawing.Point(385, 140);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(99, 25);
            pkgStartDateLabel.TabIndex = 66;
            pkgStartDateLabel.Text = "Start Date";
            // 
            // tbxPkgCommission
            // 
            this.tbxPkgCommission.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.tbxPkgCommission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgCommission.Location = new System.Drawing.Point(385, 107);
            this.tbxPkgCommission.Name = "tbxPkgCommission";
            this.tbxPkgCommission.Size = new System.Drawing.Size(281, 30);
            this.tbxPkgCommission.TabIndex = 48;
            this.tbxPkgCommission.Validating += new System.ComponentModel.CancelEventHandler(this.tbxPkgCommission_Validating);
            this.tbxPkgCommission.Validated += new System.EventHandler(this.tbxPkgCommission_Validated);
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(385, 79);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(120, 25);
            pkgAgencyCommissionLabel.TabIndex = 58;
            pkgAgencyCommissionLabel.Text = "Commission";
            // 
            // lblPackageName
            // 
            this.lblPackageName.AutoEllipsis = true;
            this.lblPackageName.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.lblPackageName, 2);
            this.lblPackageName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.lblPackageName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPackageName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblPackageName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPackageName.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblPackageName.Location = new System.Drawing.Point(384, 5);
            this.lblPackageName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPackageName.Name = "lblPackageName";
            this.lblPackageName.Size = new System.Drawing.Size(431, 40);
            this.lblPackageName.TabIndex = 63;
            this.lblPackageName.Text = "ProductName";
            this.lblPackageName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClearStartDate
            // 
            this.btnClearStartDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearStartDate.Location = new System.Drawing.Point(671, 167);
            this.btnClearStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearStartDate.Name = "btnClearStartDate";
            this.btnClearStartDate.Size = new System.Drawing.Size(95, 35);
            this.btnClearStartDate.TabIndex = 57;
            this.btnClearStartDate.TabStop = false;
            this.btnClearStartDate.Text = "Clear";
            this.btnClearStartDate.UseVisualStyleBackColor = true;
            this.btnClearStartDate.Click += new System.EventHandler(this.btnClearStartDate_Click);
            // 
            // btnClearEndDate
            // 
            this.btnClearEndDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClearEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEndDate.Location = new System.Drawing.Point(671, 231);
            this.btnClearEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearEndDate.Name = "btnClearEndDate";
            this.btnClearEndDate.Size = new System.Drawing.Size(95, 35);
            this.btnClearEndDate.TabIndex = 70;
            this.btnClearEndDate.TabStop = false;
            this.btnClearEndDate.Text = "Clear";
            this.btnClearEndDate.UseVisualStyleBackColor = true;
            this.btnClearEndDate.Click += new System.EventHandler(this.btnClearEndDate_Click);
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
            // frmPackageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 643);
            this.Controls.Add(this.pnlEntireForm);
            this.Name = "frmPackageManager";
            this.Text = "Package Manager";
            this.Load += new System.EventHandler(this.frmPackageManager_Load);
            this.VisibleChanged += new System.EventHandler(this.frmPackageManager_VisibleChanged);
            this.pnlEntireForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productExtendedBindingSource)).EndInit();
            this.gbxPackageDetails.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
 
        private System.Windows.Forms.Panel pnlEntireForm;
        private System.Windows.Forms.DataGridView dtgProducts;
  
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.GroupBox gbxPackageDetails;
        private System.Windows.Forms.ComboBox cmbPackageIds;
        private System.Windows.Forms.Button btnAddRemovePackage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tbxPkgName;
        private System.Windows.Forms.TextBox tbxPkgDesc;
        private System.Windows.Forms.TextBox tbxPkgPrice;
        private System.Windows.Forms.TextBox tbxPackageId;
        private System.Windows.Forms.ComboBox cmbProductList;
        private System.Windows.Forms.Button btnRemoveProduct;
        private System.Windows.Forms.ComboBox cmbSuppliers;
        private System.Windows.Forms.Label lblNameCharCount;
        private System.Windows.Forms.Label lblDescCharCount;
        private System.Windows.Forms.BindingSource productExtendedBindingSource;
        private System.Windows.Forms.TextBox tbxPkgCommission;
        private System.Windows.Forms.Label lblPackageName;
        private System.Windows.Forms.DateTimePicker dtpPkgStartDate;
        private System.Windows.Forms.DateTimePicker dtpPkgEndDate;
        private System.Windows.Forms.Button btnClearStartDate;
        private System.Windows.Forms.Button btnClearEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSupplierIdDataGridViewTextBoxColumn;
    }
}

