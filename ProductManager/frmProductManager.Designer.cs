namespace ProductManager
{
    partial class frmProductManager
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
            System.Windows.Forms.Label prodNameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDataGridView = new System.Windows.Forms.DataGridView();
            this.prodNameComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.supplierDataGridView = new System.Windows.Forms.DataGridView();
            this.productSupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productDBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productSupplierBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnGoToEditSuppliersPage = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnRefreshSuppliers = new System.Windows.Forms.Button();
            this.btnRefreshProducts = new System.Windows.Forms.Button();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.supplierIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodNameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            prodNameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // prodNameLabel
            // 
            prodNameLabel.AutoSize = true;
            prodNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            prodNameLabel.Location = new System.Drawing.Point(75, 31);
            prodNameLabel.Name = "prodNameLabel";
            prodNameLabel.Size = new System.Drawing.Size(182, 29);
            prodNameLabel.TabIndex = 3;
            prodNameLabel.Text = "Product Name:";
            prodNameLabel.Click += new System.EventHandler(this.prodNameLabel_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(745, 112);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(263, 29);
            label1.TabIndex = 5;
            label1.Text = "Suppliers per Product:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(75, 112);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(171, 29);
            label2.TabIndex = 6;
            label2.Text = "Edit Products:";
            label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(745, 48);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(237, 29);
            label3.TabIndex = 8;
            label3.Text = "Add a New Product:";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(DBConnector.Product);
            this.productBindingSource.CurrentChanged += new System.EventHandler(this.productBindingSource_CurrentChanged);
            // 
            // productDataGridView
            // 
            this.productDataGridView.AutoGenerateColumns = false;
            this.productDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productIDDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn,
            this.Edit});
            this.productDataGridView.DataSource = this.productBindingSource;
            this.productDataGridView.Location = new System.Drawing.Point(79, 158);
            this.productDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.productDataGridView.Name = "productDataGridView";
            this.productDataGridView.RowHeadersWidth = 51;
            this.productDataGridView.RowTemplate.Height = 24;
            this.productDataGridView.Size = new System.Drawing.Size(569, 326);
            this.productDataGridView.TabIndex = 1;
            this.productDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productDataGridView_CellContentClick_1);
            // 
            // prodNameComboBox
            // 
            this.prodNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "ProdName", true));
            this.prodNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.supplierBindingSource, "ProductID", true));
            this.prodNameComboBox.DataSource = this.productBindingSource;
            this.prodNameComboBox.DisplayMember = "ProdName";
            this.prodNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodNameComboBox.FormattingEnabled = true;
            this.prodNameComboBox.Location = new System.Drawing.Point(79, 66);
            this.prodNameComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prodNameComboBox.Name = "prodNameComboBox";
            this.prodNameComboBox.Size = new System.Drawing.Size(217, 33);
            this.prodNameComboBox.TabIndex = 4;
            this.prodNameComboBox.ValueMember = "ProductID";
            this.prodNameComboBox.SelectedValueChanged += new System.EventHandler(this.prodNameComboBox_SelectedValueChanged);
            // 
            // supplierBindingSource
            // 
            this.supplierBindingSource.DataSource = typeof(DBConnector.Supplier);
            // 
            // supplierDataGridView
            // 
            this.supplierDataGridView.AutoGenerateColumns = false;
            this.supplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.supplierIDDataGridViewTextBoxColumn,
            this.supNameDataGridViewTextBoxColumn,
            this.prodNameDataGridViewTextBoxColumn1});
            this.supplierDataGridView.DataSource = this.supplierBindingSource;
            this.supplierDataGridView.Location = new System.Drawing.Point(671, 158);
            this.supplierDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.supplierDataGridView.Name = "supplierDataGridView";
            this.supplierDataGridView.ReadOnly = true;
            this.supplierDataGridView.RowHeadersWidth = 51;
            this.supplierDataGridView.RowTemplate.Height = 24;
            this.supplierDataGridView.Size = new System.Drawing.Size(577, 326);
            this.supplierDataGridView.TabIndex = 4;
            // 
            // productSupplierBindingSource
            // 
            this.productSupplierBindingSource.DataSource = typeof(DBConnector.ProductSupplier);
            // 
            // productDBBindingSource
            // 
            this.productDBBindingSource.DataSource = typeof(DBConnector.ProductDB);
            // 
            // productSupplierBindingSource1
            // 
            this.productSupplierBindingSource1.DataSource = this.productSupplierBindingSource;
            // 
            // btnGoToEditSuppliersPage
            // 
            this.btnGoToEditSuppliersPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoToEditSuppliersPage.Location = new System.Drawing.Point(1088, 95);
            this.btnGoToEditSuppliersPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGoToEditSuppliersPage.Name = "btnGoToEditSuppliersPage";
            this.btnGoToEditSuppliersPage.Size = new System.Drawing.Size(160, 46);
            this.btnGoToEditSuppliersPage.TabIndex = 7;
            this.btnGoToEditSuppliersPage.Text = "Edit Suppliers";
            this.btnGoToEditSuppliersPage.UseVisualStyleBackColor = true;
            this.btnGoToEditSuppliersPage.Click += new System.EventHandler(this.btnGoToEditSuppliersPage_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.Location = new System.Drawing.Point(1088, 31);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(160, 46);
            this.btnAddProduct.TabIndex = 9;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnRefreshSuppliers
            // 
            this.btnRefreshSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshSuppliers.Location = new System.Drawing.Point(1041, 500);
            this.btnRefreshSuppliers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshSuppliers.Name = "btnRefreshSuppliers";
            this.btnRefreshSuppliers.Size = new System.Drawing.Size(207, 46);
            this.btnRefreshSuppliers.TabIndex = 10;
            this.btnRefreshSuppliers.Text = "Refresh Suppliers";
            this.btnRefreshSuppliers.UseVisualStyleBackColor = true;
            this.btnRefreshSuppliers.Click += new System.EventHandler(this.btnRefreshSuppliers_Click);
            // 
            // btnRefreshProducts
            // 
            this.btnRefreshProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshProducts.Location = new System.Drawing.Point(80, 500);
            this.btnRefreshProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefreshProducts.Name = "btnRefreshProducts";
            this.btnRefreshProducts.Size = new System.Drawing.Size(201, 44);
            this.btnRefreshProducts.TabIndex = 11;
            this.btnRefreshProducts.Text = "Refresh Products";
            this.btnRefreshProducts.UseVisualStyleBackColor = true;
            this.btnRefreshProducts.Click += new System.EventHandler(this.btnRefreshProducts_Click);
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            this.productIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodNameDataGridViewTextBoxColumn
            // 
            this.prodNameDataGridViewTextBoxColumn.DataPropertyName = "ProdName";
            this.prodNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.prodNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.prodNameDataGridViewTextBoxColumn.Name = "prodNameDataGridViewTextBoxColumn";
            this.prodNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Edit.Text = "Edit";
            this.Edit.UseColumnTextForButtonValue = true;
            this.Edit.Width = 125;
            // 
            // supplierIDDataGridViewTextBoxColumn
            // 
            this.supplierIDDataGridViewTextBoxColumn.DataPropertyName = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.HeaderText = "SupplierID";
            this.supplierIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierIDDataGridViewTextBoxColumn.Name = "supplierIDDataGridViewTextBoxColumn";
            this.supplierIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.supplierIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // supNameDataGridViewTextBoxColumn
            // 
            this.supNameDataGridViewTextBoxColumn.DataPropertyName = "SupName";
            this.supNameDataGridViewTextBoxColumn.HeaderText = "Supplier Name";
            this.supNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supNameDataGridViewTextBoxColumn.Name = "supNameDataGridViewTextBoxColumn";
            this.supNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.supNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // prodNameDataGridViewTextBoxColumn1
            // 
            this.prodNameDataGridViewTextBoxColumn1.DataPropertyName = "ProdName";
            this.prodNameDataGridViewTextBoxColumn1.HeaderText = "Product Name";
            this.prodNameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.prodNameDataGridViewTextBoxColumn1.Name = "prodNameDataGridViewTextBoxColumn1";
            this.prodNameDataGridViewTextBoxColumn1.ReadOnly = true;
            this.prodNameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // frmProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 571);
            this.Controls.Add(this.btnRefreshProducts);
            this.Controls.Add(this.btnRefreshSuppliers);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(label3);
            this.Controls.Add(this.btnGoToEditSuppliersPage);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(this.supplierDataGridView);
            this.Controls.Add(prodNameLabel);
            this.Controls.Add(this.prodNameComboBox);
            this.Controls.Add(this.productDataGridView);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmProductManager";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmProductManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productDBBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.DataGridView productDataGridView;
        private System.Windows.Forms.BindingSource productDBBindingSource;
        private System.Windows.Forms.ComboBox prodNameComboBox;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.DataGridView supplierDataGridView;
        private System.Windows.Forms.BindingSource productSupplierBindingSource;
        private System.Windows.Forms.BindingSource productSupplierBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnGoToEditSuppliersPage;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnRefreshSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnRefreshProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prodNameDataGridViewTextBoxColumn1;
    }
}

