namespace ProductSupplierManager
{
    partial class frmProductSupplierManager
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
            this.ProductSupplierDataGrid = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblProductName = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productSupplierBindingSource = new System.Windows.Forms.BindingSource();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSupplierDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductSupplierDataGrid
            // 
            this.ProductSupplierDataGrid.AutoGenerateColumns = false;
            this.ProductSupplierDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductSupplierDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.ProductSupplierDataGrid.DataSource = this.productSupplierBindingSource;
            this.ProductSupplierDataGrid.Location = new System.Drawing.Point(32, 65);
            this.ProductSupplierDataGrid.Name = "ProductSupplierDataGrid";
            this.ProductSupplierDataGrid.RowHeadersWidth = 51;
            this.ProductSupplierDataGrid.RowTemplate.Height = 24;
            this.ProductSupplierDataGrid.Size = new System.Drawing.Size(796, 355);
            this.ProductSupplierDataGrid.TabIndex = 1;
            this.ProductSupplierDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductSupplierDataGrid_CellContentClick_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Controls.Add(this.ProductSupplierDataGrid);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 596);
            this.panel1.TabIndex = 2;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(29, 29);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(98, 17);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ProductSupplierID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ProductSupplierID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SupplierID";
            this.dataGridViewTextBoxColumn3.HeaderText = "SupplierID";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // productSupplierBindingSource
            // 
            this.productSupplierBindingSource.DataSource = typeof(DBConnector.ProductSupplier);
            // 
            // frmProductSupplierManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 596);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(925, 643);
            this.Name = "frmProductSupplierManager";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ProductSupplierDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productSupplierBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView ProductSupplierDataGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn productSupplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productSupplierBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblProductName;
    }
}

