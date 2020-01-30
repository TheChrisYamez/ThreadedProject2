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
            System.Windows.Forms.Label packageIdLabel;
            System.Windows.Forms.Label pkgAgencyCommissionLabel;
            System.Windows.Forms.Label pkgBasePriceLabel;
            System.Windows.Forms.Label pkgDescLabel;
            System.Windows.Forms.Label pkgEndDateLabel;
            System.Windows.Forms.Label pkgNameLabel;
            System.Windows.Forms.Label pkgStartDateLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbPackageIds = new System.Windows.Forms.ComboBox();
            this.tbxPkgCommission = new System.Windows.Forms.TextBox();
            this.tbxPkgPrice = new System.Windows.Forms.TextBox();
            this.tbxPkgDesc = new System.Windows.Forms.TextBox();
            this.tbxPkgEndDate = new System.Windows.Forms.DateTimePicker();
            this.tbxPkgName = new System.Windows.Forms.TextBox();
            this.tbxPkgStartDate = new System.Windows.Forms.DateTimePicker();
            this.packageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            packageIdLabel = new System.Windows.Forms.Label();
            pkgAgencyCommissionLabel = new System.Windows.Forms.Label();
            pkgBasePriceLabel = new System.Windows.Forms.Label();
            pkgDescLabel = new System.Windows.Forms.Label();
            pkgEndDateLabel = new System.Windows.Forms.Label();
            pkgNameLabel = new System.Windows.Forms.Label();
            pkgStartDateLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(packageIdLabel);
            this.panel1.Controls.Add(this.cmbPackageIds);
            this.panel1.Controls.Add(pkgAgencyCommissionLabel);
            this.panel1.Controls.Add(this.tbxPkgCommission);
            this.panel1.Controls.Add(pkgBasePriceLabel);
            this.panel1.Controls.Add(this.tbxPkgPrice);
            this.panel1.Controls.Add(pkgDescLabel);
            this.panel1.Controls.Add(this.tbxPkgDesc);
            this.panel1.Controls.Add(pkgEndDateLabel);
            this.panel1.Controls.Add(this.tbxPkgEndDate);
            this.panel1.Controls.Add(pkgNameLabel);
            this.panel1.Controls.Add(this.tbxPkgName);
            this.panel1.Controls.Add(pkgStartDateLabel);
            this.panel1.Controls.Add(this.tbxPkgStartDate);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 692);
            this.panel1.TabIndex = 0;
            // 
            // packageIdLabel
            // 
            packageIdLabel.AutoSize = true;
            packageIdLabel.Location = new System.Drawing.Point(22, 53);
            packageIdLabel.Name = "packageIdLabel";
            packageIdLabel.Size = new System.Drawing.Size(65, 13);
            packageIdLabel.TabIndex = 0;
            packageIdLabel.Text = "Package Id:";
            // 
            // cmbPackageIds
            // 
            this.cmbPackageIds.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PackageId", true));
            this.cmbPackageIds.FormattingEnabled = true;
            this.cmbPackageIds.Location = new System.Drawing.Point(154, 50);
            this.cmbPackageIds.Name = "cmbPackageIds";
            this.cmbPackageIds.Size = new System.Drawing.Size(200, 21);
            this.cmbPackageIds.TabIndex = 1;
            this.cmbPackageIds.SelectedValueChanged += new System.EventHandler(this.cmbPackageIds_SelectedValueChanged);
            this.cmbPackageIds.Click += new System.EventHandler(this.cmbPackageIds_Click);
            // 
            // pkgAgencyCommissionLabel
            // 
            pkgAgencyCommissionLabel.AutoSize = true;
            pkgAgencyCommissionLabel.Location = new System.Drawing.Point(22, 80);
            pkgAgencyCommissionLabel.Name = "pkgAgencyCommissionLabel";
            pkgAgencyCommissionLabel.Size = new System.Drawing.Size(126, 13);
            pkgAgencyCommissionLabel.TabIndex = 2;
            pkgAgencyCommissionLabel.Text = "Pkg Agency Commission:";
            // 
            // tbxPkgCommission
            // 
            this.tbxPkgCommission.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgAgencyCommission", true));
            this.tbxPkgCommission.Location = new System.Drawing.Point(154, 77);
            this.tbxPkgCommission.Name = "tbxPkgCommission";
            this.tbxPkgCommission.Size = new System.Drawing.Size(200, 20);
            this.tbxPkgCommission.TabIndex = 3;
            // 
            // pkgBasePriceLabel
            // 
            pkgBasePriceLabel.AutoSize = true;
            pkgBasePriceLabel.Location = new System.Drawing.Point(22, 106);
            pkgBasePriceLabel.Name = "pkgBasePriceLabel";
            pkgBasePriceLabel.Size = new System.Drawing.Size(83, 13);
            pkgBasePriceLabel.TabIndex = 4;
            pkgBasePriceLabel.Text = "Pkg Base Price:";
            // 
            // tbxPkgPrice
            // 
            this.tbxPkgPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgBasePrice", true));
            this.tbxPkgPrice.Location = new System.Drawing.Point(154, 103);
            this.tbxPkgPrice.Name = "tbxPkgPrice";
            this.tbxPkgPrice.Size = new System.Drawing.Size(200, 20);
            this.tbxPkgPrice.TabIndex = 5;
            // 
            // pkgDescLabel
            // 
            pkgDescLabel.AutoSize = true;
            pkgDescLabel.Location = new System.Drawing.Point(22, 132);
            pkgDescLabel.Name = "pkgDescLabel";
            pkgDescLabel.Size = new System.Drawing.Size(57, 13);
            pkgDescLabel.TabIndex = 6;
            pkgDescLabel.Text = "Pkg Desc:";
            // 
            // tbxPkgDesc
            // 
            this.tbxPkgDesc.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgDesc", true));
            this.tbxPkgDesc.Location = new System.Drawing.Point(154, 129);
            this.tbxPkgDesc.Name = "tbxPkgDesc";
            this.tbxPkgDesc.Size = new System.Drawing.Size(200, 20);
            this.tbxPkgDesc.TabIndex = 7;
            // 
            // pkgEndDateLabel
            // 
            pkgEndDateLabel.AutoSize = true;
            pkgEndDateLabel.Location = new System.Drawing.Point(22, 159);
            pkgEndDateLabel.Name = "pkgEndDateLabel";
            pkgEndDateLabel.Size = new System.Drawing.Size(77, 13);
            pkgEndDateLabel.TabIndex = 8;
            pkgEndDateLabel.Text = "Pkg End Date:";
            // 
            // tbxPkgEndDate
            // 
            this.tbxPkgEndDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgEndDate", true));
            this.tbxPkgEndDate.Location = new System.Drawing.Point(154, 155);
            this.tbxPkgEndDate.Name = "tbxPkgEndDate";
            this.tbxPkgEndDate.Size = new System.Drawing.Size(200, 20);
            this.tbxPkgEndDate.TabIndex = 9;
            // 
            // pkgNameLabel
            // 
            pkgNameLabel.AutoSize = true;
            pkgNameLabel.Location = new System.Drawing.Point(22, 184);
            pkgNameLabel.Name = "pkgNameLabel";
            pkgNameLabel.Size = new System.Drawing.Size(60, 13);
            pkgNameLabel.TabIndex = 10;
            pkgNameLabel.Text = "Pkg Name:";
            // 
            // tbxPkgName
            // 
            this.tbxPkgName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.packageBindingSource, "PkgName", true));
            this.tbxPkgName.Location = new System.Drawing.Point(154, 181);
            this.tbxPkgName.Name = "tbxPkgName";
            this.tbxPkgName.Size = new System.Drawing.Size(200, 20);
            this.tbxPkgName.TabIndex = 11;
            // 
            // pkgStartDateLabel
            // 
            pkgStartDateLabel.AutoSize = true;
            pkgStartDateLabel.Location = new System.Drawing.Point(22, 211);
            pkgStartDateLabel.Name = "pkgStartDateLabel";
            pkgStartDateLabel.Size = new System.Drawing.Size(80, 13);
            pkgStartDateLabel.TabIndex = 12;
            pkgStartDateLabel.Text = "Pkg Start Date:";
            // 
            // tbxPkgStartDate
            // 
            this.tbxPkgStartDate.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.packageBindingSource, "PkgStartDate", true));
            this.tbxPkgStartDate.Location = new System.Drawing.Point(154, 207);
            this.tbxPkgStartDate.Name = "tbxPkgStartDate";
            this.tbxPkgStartDate.Size = new System.Drawing.Size(200, 20);
            this.tbxPkgStartDate.TabIndex = 13;
            // 
            // packageBindingSource
            // 
            this.packageBindingSource.DataSource = typeof(DBConnector.Package);
            // 
            // frmPackageManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 692);
            this.Controls.Add(this.panel1);
            this.Name = "frmPackageManager";
            this.Text = "Package Manager";
            this.Load += new System.EventHandler(this.frmPackageManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.packageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbPackageIds;
        private System.Windows.Forms.BindingSource packageBindingSource;
        private System.Windows.Forms.TextBox tbxPkgCommission;
        private System.Windows.Forms.TextBox tbxPkgPrice;
        private System.Windows.Forms.TextBox tbxPkgDesc;
        private System.Windows.Forms.DateTimePicker tbxPkgEndDate;
        private System.Windows.Forms.TextBox tbxPkgName;
        private System.Windows.Forms.DateTimePicker tbxPkgStartDate;
    }
}

