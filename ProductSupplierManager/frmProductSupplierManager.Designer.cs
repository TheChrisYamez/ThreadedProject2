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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ProductSupplierDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSupplierDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(60, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(192, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // ProductSupplierDataGrid
            // 
            this.ProductSupplierDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductSupplierDataGrid.Location = new System.Drawing.Point(60, 144);
            this.ProductSupplierDataGrid.Name = "ProductSupplierDataGrid";
            this.ProductSupplierDataGrid.RowHeadersWidth = 51;
            this.ProductSupplierDataGrid.RowTemplate.Height = 24;
            this.ProductSupplierDataGrid.Size = new System.Drawing.Size(796, 355);
            this.ProductSupplierDataGrid.TabIndex = 1;
            // 
            // frmProductSupplierManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 596);
            this.Controls.Add(this.ProductSupplierDataGrid);
            this.Controls.Add(this.comboBox1);
            this.Name = "frmProductSupplierManager";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ProductSupplierDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView ProductSupplierDataGrid;
    }
}

