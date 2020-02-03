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
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label packageIdLabel;
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddRemovePackage = new System.Windows.Forms.Button();
            this.tbxPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.tbxPkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnClearEndDate = new System.Windows.Forms.Button();
            this.btnClearStartDate = new System.Windows.Forms.Button();
            this.tbxPkgCommission = new System.Windows.Forms.TextBox();
            this.tbxPkgPrice = new System.Windows.Forms.TextBox();
            this.tbxPkgDesc = new System.Windows.Forms.TextBox();
            this.tbxPkgName = new System.Windows.Forms.TextBox();
            this.cmbPackageIds = new System.Windows.Forms.ComboBox();
            this.dtgProducts = new System.Windows.Forms.DataGridView();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddRemoveProduct = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            packageIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(DBConnector.Package);
            this.packageBindingSource.CurrentChanged += new System.EventHandler(this.packageBindingSource_CurrentChanged);
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DBConnector.Product);
            this.productBindingSource.CurrentChanged += new System.EventHandler(this.productBindingSource_CurrentChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnAddRemovePackage, 0, 0);
            this.tableLayoutPanel1.Controls.Add(pkgEndDateLabel, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tbxPkgEndDate, 1, 7);
            this.tableLayoutPanel1.Controls.Add(pkgStartDateLabel, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbxPkgStartDate, 1, 6);
            this.tableLayoutPanel1.Controls.Add(pkgAgencyCommissionLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(pkgBasePriceLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(pkgDescLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(pkgNameLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(packageIdLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClearEndDate, 2, 7);
            this.tableLayoutPanel1.Controls.Add(this.btnClearStartDate, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.tbxPkgCommission, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbxPkgPrice, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tbxPkgDesc, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbxPkgName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cmbPackageIds, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtgProducts, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.btnAddRemoveProduct, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(820, 597);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnAddRemovePackage
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnAddRemovePackage, 2);
            this.btnAddRemovePackage.Location = new System.Drawing.Point(2, 2);
            this.btnAddRemovePackage.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRemovePackage.Name = "btnAddRemovePackage";
            this.btnAddRemovePackage.Size = new System.Drawing.Size(119, 19);
            this.btnAddRemovePackage.TabIndex = 36;
            this.btnAddRemovePackage.Text = "Add/Remove Package";
            this.btnAddRemovePackage.UseVisualStyleBackColor = true;
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(3, 186);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(55, 13);
            pkgEndDateLabel.TabIndex = 27;
            pkgEndDateLabel.Text = "End Date:";
            // 
            // tbxPkgEndDate
            // 
            this.tbxPkgEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.tbxPkgEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbxPkgEndDate.Location = new System.Drawing.Point(76, 183);
            this.tbxPkgEndDate.Name = "tbxPkgEndDate";
            this.tbxPkgEndDate.Size = new System.Drawing.Size(134, 20);
            this.tbxPkgEndDate.TabIndex = 28;
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(3, 160);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(58, 13);
            pkgStartDateLabel.TabIndex = 29;
            pkgStartDateLabel.Text = "Start Date:";
            // 
            // tbxPkgStartDate
            // 
            this.tbxPkgStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.tbxPkgStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tbxPkgStartDate.Location = new System.Drawing.Point(76, 157);
            this.tbxPkgStartDate.Name = "tbxPkgStartDate";
            this.tbxPkgStartDate.Size = new System.Drawing.Size(134, 20);
            this.tbxPkgStartDate.TabIndex = 30;
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(3, 134);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(65, 13);
            pkgAgencyCommissionLabel.TabIndex = 21;
            pkgAgencyCommissionLabel.Text = "Commission:";
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(3, 108);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(34, 13);
            pkgBasePriceLabel.TabIndex = 23;
            pkgBasePriceLabel.Text = "Price:";
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(3, 82);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(63, 13);
            pkgDescLabel.TabIndex = 25;
            pkgDescLabel.Text = "Description:";
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(3, 56);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(38, 13);
            pkgNameLabel.TabIndex = 34;
            pkgNameLabel.Text = "Name:";
            // 
            // packageIdLabel
            // 
            packageIdLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            packageIdLabel.AutoSize = true;
            packageIdLabel.Location = new System.Drawing.Point(3, 30);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(67, 13);
            packageIdLabel.TabIndex = 19;
            packageIdLabel.Text = "Package ID:";
            // 
            // btnClearEndDate
            // 
            this.btnClearEndDate.Location = new System.Drawing.Point(215, 182);
            this.btnClearEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearEndDate.Name = "btnClearEndDate";
            this.btnClearEndDate.Size = new System.Drawing.Size(56, 19);
            this.btnClearEndDate.TabIndex = 37;
            this.btnClearEndDate.Text = "Clear";
            this.btnClearEndDate.UseVisualStyleBackColor = true;
            // 
            // btnClearStartDate
            // 
            this.btnClearStartDate.Location = new System.Drawing.Point(215, 156);
            this.btnClearStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.btnClearStartDate.Name = "btnClearStartDate";
            this.btnClearStartDate.Size = new System.Drawing.Size(56, 19);
            this.btnClearStartDate.TabIndex = 1;
            this.btnClearStartDate.Text = "Clear";
            this.btnClearStartDate.UseVisualStyleBackColor = true;
            // 
            // tbxPkgCommission
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbxPkgCommission, 2);
            this.tbxPkgCommission.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.tbxPkgCommission.Location = new System.Drawing.Point(76, 131);
            this.tbxPkgCommission.Name = "tbxPkgCommission";
            this.tbxPkgCommission.Size = new System.Drawing.Size(200, 20);
            this.tbxPkgCommission.TabIndex = 22;
            // 
            // tbxPkgPrice
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbxPkgPrice, 2);
            this.tbxPkgPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.tbxPkgPrice.Location = new System.Drawing.Point(76, 105);
            this.tbxPkgPrice.Name = "tbxPkgPrice";
            this.tbxPkgPrice.Size = new System.Drawing.Size(200, 20);
            this.tbxPkgPrice.TabIndex = 24;
            // 
            // tbxPkgDesc
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbxPkgDesc, 2);
            this.tbxPkgDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.tbxPkgDesc.Location = new System.Drawing.Point(76, 79);
            this.tbxPkgDesc.Name = "tbxPkgDesc";
            this.tbxPkgDesc.Size = new System.Drawing.Size(200, 20);
            this.tbxPkgDesc.TabIndex = 26;
            // 
            // tbxPkgName
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.tbxPkgName, 2);
            this.tbxPkgName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.tbxPkgName.Location = new System.Drawing.Point(76, 53);
            this.tbxPkgName.Name = "tbxPkgName";
            this.tbxPkgName.Size = new System.Drawing.Size(200, 20);
            this.tbxPkgName.TabIndex = 35;
            // 
            // cmbPackageIds
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.cmbPackageIds, 2);
            this.cmbPackageIds.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.cmbPackageIds.FormattingEnabled = true;
            this.cmbPackageIds.Location = new System.Drawing.Point(76, 26);
            this.cmbPackageIds.Name = "cmbPackageIds";
            this.cmbPackageIds.Size = new System.Drawing.Size(200, 21);
            this.cmbPackageIds.TabIndex = 20;
            // 
            // dtgProducts
            // 
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
            this.tableLayoutPanel1.SetColumnSpan(this.dtgProducts, 4);
            this.dtgProducts.DataSource = this.productBindingSource;
            this.dtgProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgProducts.Location = new System.Drawing.Point(2, 231);
            this.dtgProducts.Margin = new System.Windows.Forms.Padding(2);
            this.dtgProducts.Name = "dtgProducts";
            this.dtgProducts.RowHeadersWidth = 51;
            this.dtgProducts.RowTemplate.Height = 24;
            this.dtgProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProducts.Size = new System.Drawing.Size(816, 364);
            this.dtgProducts.TabIndex = 31;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            // 
            // btnAddRemoveProduct
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.btnAddRemoveProduct, 2);
            this.btnAddRemoveProduct.Location = new System.Drawing.Point(2, 208);
            this.btnAddRemoveProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddRemoveProduct.Name = "btnAddRemoveProduct";
            this.btnAddRemoveProduct.Size = new System.Drawing.Size(119, 19);
            this.btnAddRemoveProduct.TabIndex = 38;
            this.btnAddRemoveProduct.Text = "Add/Remove Products";
            this.btnAddRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(215, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 19);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // frmPackageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 597);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmPackageManager";
            this.Text = "Package Manager";
            this.Load += new System.EventHandler(this.frmPackageManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnAddRemovePackage;
        private System.Windows.Forms.DateTimePicker tbxPkgEndDate;
        private System.Windows.Forms.DateTimePicker tbxPkgStartDate;
        private System.Windows.Forms.Button btnClearEndDate;
        private System.Windows.Forms.Button btnClearStartDate;
        private System.Windows.Forms.TextBox tbxPkgCommission;
        private System.Windows.Forms.TextBox tbxPkgPrice;
        private System.Windows.Forms.TextBox tbxPkgDesc;
        private System.Windows.Forms.TextBox tbxPkgName;
        private System.Windows.Forms.ComboBox cmbPackageIds;
        private System.Windows.Forms.DataGridView dtgProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddRemoveProduct;
        private System.Windows.Forms.Button btnSave;
    }
}

