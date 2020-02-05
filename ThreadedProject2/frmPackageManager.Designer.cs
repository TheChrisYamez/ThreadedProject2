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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtgProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnRemoveProduct = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbProductList = new System.Windows.Forms.ComboBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPackageIds = new System.Windows.Forms.ComboBox();
            this.btnAddRemovePackage = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            packageIdLabel1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgEndDateLabel.Location = new System.Drawing.Point(8, 201);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(81, 20);
            pkgEndDateLabel.TabIndex = 64;
            pkgEndDateLabel.Text = "End Date:";
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgStartDateLabel.Location = new System.Drawing.Point(8, 169);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(87, 20);
            pkgStartDateLabel.TabIndex = 66;
            pkgStartDateLabel.Text = "Start Date:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgNameLabel.Location = new System.Drawing.Point(8, 41);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(55, 20);
            pkgNameLabel.TabIndex = 68;
            pkgNameLabel.Text = "Name:";
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(8, 137);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(99, 20);
            pkgAgencyCommissionLabel.TabIndex = 58;
            pkgAgencyCommissionLabel.Text = "Commission:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgDescLabel.Location = new System.Drawing.Point(8, 73);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(93, 20);
            pkgDescLabel.TabIndex = 62;
            pkgDescLabel.Text = "Description:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pkgBasePriceLabel.Location = new System.Drawing.Point(8, 105);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(48, 20);
            pkgBasePriceLabel.TabIndex = 60;
            pkgBasePriceLabel.Text = "Price:";
            // 
            // packageIdLabel1
            // 
            packageIdLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            packageIdLabel1.AutoSize = true;
            packageIdLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            packageIdLabel1.Location = new System.Drawing.Point(7, 10);
            packageIdLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            packageIdLabel1.Name = "packageIdLabel1";
            packageIdLabel1.Size = new System.Drawing.Size(93, 20);
            packageIdLabel1.TabIndex = 70;
            packageIdLabel1.Text = "Package Id:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(816, 628);
            this.panel1.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox4.Controls.Add(this.dtgProducts);
            this.groupBox4.Controls.Add(this.btnRemoveProduct);
            this.groupBox4.Location = new System.Drawing.Point(393, 163);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox4.Size = new System.Drawing.Size(412, 452);
            this.groupBox4.TabIndex = 62;
            this.groupBox4.TabStop = false;
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
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dtgProducts.DataSource = this.productBindingSource;
            this.dtgProducts.Location = new System.Drawing.Point(9, 14);
            this.dtgProducts.Margin = new System.Windows.Forms.Padding(0);
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.ReadOnly = true;
            this.dtgProducts.RowHeadersWidth = 51;
            this.dtgProducts.RowTemplate.Height = 24;
            this.dtgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProducts.Size = new System.Drawing.Size(400, 395);
            this.dtgProducts.TabIndex = 58;
            this.dtgProducts.TabStop = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProdName";
            this.dataGridViewTextBoxColumn4.HeaderText = "ProdName";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DBConnector.Product);
            // 
            // btnRemoveProduct
            // 
            this.btnRemoveProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemoveProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveProduct.Location = new System.Drawing.Point(258, 410);
            this.btnRemoveProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemoveProduct.Name = "btnRemoveProduct";
            this.btnRemoveProduct.Size = new System.Drawing.Size(149, 38);
            this.btnRemoveProduct.TabIndex = 60;
            this.btnRemoveProduct.TabStop = false;
            this.btnRemoveProduct.Text = "Remove Selected";
            this.btnRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.cmbProductList);
            this.groupBox3.Controls.Add(this.btnAddProduct);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(392, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 150);
            this.groupBox3.TabIndex = 61;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Product";
            // 
            // cmbProductList
            // 
            this.cmbProductList.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbProductList.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbProductList.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.cmbProductList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProductList.FormattingEnabled = true;
            this.cmbProductList.Location = new System.Drawing.Point(10, 29);
            this.cmbProductList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbProductList.Name = "cmbProductList";
            this.cmbProductList.Size = new System.Drawing.Size(171, 28);
            this.cmbProductList.Sorted = true;
            this.cmbProductList.TabIndex = 61;
            this.cmbProductList.TabStop = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(191, 28);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(55, 24);
            this.btnAddProduct.TabIndex = 59;
            this.btnAddProduct.TabStop = false;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.tableLayoutPanel1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 91);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox2.Size = new System.Drawing.Size(374, 526);
            this.groupBox2.TabIndex = 60;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Package Details";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
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
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(5, 21);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(364, 500);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tbxPackageId
            // 
            this.tbxPackageId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.tbxPackageId.Enabled = false;
            this.tbxPackageId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPackageId.Location = new System.Drawing.Point(112, 7);
            this.tbxPackageId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbxPackageId.Name = "tbxPackageId";
            this.tbxPackageId.Size = new System.Drawing.Size(76, 26);
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
            this.tbxPkgCommission.Location = new System.Drawing.Point(113, 134);
            this.tbxPkgCommission.Name = "tbxPkgCommission";
            this.tbxPkgCommission.Size = new System.Drawing.Size(187, 26);
            this.tbxPkgCommission.TabIndex = 48;
            this.tbxPkgCommission.Leave += new System.EventHandler(this.tbxPkgCommission_Leave);
            // 
            // tbxPkgPrice
            // 
            this.tbxPkgPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.tbxPkgPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgPrice.Location = new System.Drawing.Point(113, 102);
            this.tbxPkgPrice.Name = "tbxPkgPrice";
            this.tbxPkgPrice.Size = new System.Drawing.Size(187, 26);
            this.tbxPkgPrice.TabIndex = 47;
            this.tbxPkgPrice.Leave += new System.EventHandler(this.tbxPkgPrice_Leave);
            // 
            // tbxPkgDesc
            // 
            this.tbxPkgDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.tbxPkgDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgDesc.Location = new System.Drawing.Point(113, 70);
            this.tbxPkgDesc.Name = "tbxPkgDesc";
            this.tbxPkgDesc.Size = new System.Drawing.Size(187, 26);
            this.tbxPkgDesc.TabIndex = 46;
            this.tbxPkgDesc.Leave += new System.EventHandler(this.tbxPkgDesc_Leave);
            // 
            // tbxPkgName
            // 
            this.tbxPkgName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.tbxPkgName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxPkgName.Location = new System.Drawing.Point(113, 38);
            this.tbxPkgName.Name = "tbxPkgName";
            this.tbxPkgName.Size = new System.Drawing.Size(187, 26);
            this.tbxPkgName.TabIndex = 45;
            this.tbxPkgName.Leave += new System.EventHandler(this.tbxPkgName_Leave);
            // 
            // dtpPkgStartDate
            // 
            this.dtpPkgStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.dtpPkgStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPkgStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPkgStartDate.Location = new System.Drawing.Point(113, 166);
            this.dtpPkgStartDate.Name = "dtpPkgStartDate";
            this.dtpPkgStartDate.Size = new System.Drawing.Size(134, 26);
            this.dtpPkgStartDate.TabIndex = 49;
            this.dtpPkgStartDate.ValueChanged += new System.EventHandler(this.dtpPkgStartDate_ValueChanged);
            // 
            // dtpPkgEndDate
            // 
            this.dtpPkgEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.dtpPkgEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpPkgEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpPkgEndDate.Location = new System.Drawing.Point(113, 198);
            this.dtpPkgEndDate.Name = "dtpPkgEndDate";
            this.dtpPkgEndDate.Size = new System.Drawing.Size(134, 26);
            this.dtpPkgEndDate.TabIndex = 50;
            this.dtpPkgEndDate.ValueChanged += new System.EventHandler(this.dtpPkgEndDate_ValueChanged);
            // 
            // btnClearStartDate
            // 
            this.btnClearStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearStartDate.Location = new System.Drawing.Point(305, 165);
            this.btnClearStartDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearStartDate.Name = "btnClearStartDate";
            this.btnClearStartDate.Size = new System.Drawing.Size(56, 27);
            this.btnClearStartDate.TabIndex = 57;
            this.btnClearStartDate.TabStop = false;
            this.btnClearStartDate.Text = "Clear";
            this.btnClearStartDate.UseVisualStyleBackColor = true;
            this.btnClearStartDate.Click += new System.EventHandler(this.btnClearStartDate_Click);
            // 
            // btnClearEndDate
            // 
            this.btnClearEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearEndDate.Location = new System.Drawing.Point(305, 197);
            this.btnClearEndDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClearEndDate.Name = "btnClearEndDate";
            this.btnClearEndDate.Size = new System.Drawing.Size(56, 27);
            this.btnClearEndDate.TabIndex = 70;
            this.btnClearEndDate.TabStop = false;
            this.btnClearEndDate.Text = "Clear";
            this.btnClearEndDate.UseVisualStyleBackColor = true;
            this.btnClearEndDate.Click += new System.EventHandler(this.btnClearEndDate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPackageIds);
            this.groupBox1.Controls.Add(this.btnAddRemovePackage);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 64);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lookup Package";
            // 
            // cmbPackageIds
            // 
            this.cmbPackageIds.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbPackageIds.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbPackageIds.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.cmbPackageIds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPackageIds.FormattingEnabled = true;
            this.cmbPackageIds.Location = new System.Drawing.Point(16, 25);
            this.cmbPackageIds.Name = "cmbPackageIds";
            this.cmbPackageIds.Size = new System.Drawing.Size(264, 28);
            this.cmbPackageIds.TabIndex = 42;
            this.cmbPackageIds.SelectedValueChanged += new System.EventHandler(this.cmbPackageIds_SelectedValueChanged);
            // 
            // btnAddRemovePackage
            // 
            this.btnAddRemovePackage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddRemovePackage.Location = new System.Drawing.Point(290, 24);
            this.btnAddRemovePackage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddRemovePackage.Name = "btnAddRemovePackage";
            this.btnAddRemovePackage.Size = new System.Drawing.Size(51, 24);
            this.btnAddRemovePackage.TabIndex = 55;
            this.btnAddRemovePackage.TabStop = false;
            this.btnAddRemovePackage.Text = "New";
            this.btnAddRemovePackage.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(10, 83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 28);
            this.comboBox1.TabIndex = 62;
            // 
            // frmPackageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 628);
            this.Controls.Add(this.panel1);
            this.Name = "frmPackageManager";
            this.Text = "Package Manager";
            this.Load += new System.EventHandler(this.frmPackageManager_Load);
            this.VisibleChanged += new System.EventHandler(this.frmPackageManager_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
 
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtgProducts;
  
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

