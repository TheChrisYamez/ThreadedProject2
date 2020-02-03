namespace View
{
    partial class MainView
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pnlForms = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSuppliers = new View.FlatButton();
            this.btnProducts = new View.FlatButton();
            this.btnPackages = new View.FlatButton();
            this.btnClose = new View.FlatButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pnlForms, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnClose, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 590);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel1_MouseUp);
            // 
            // pnlForms
            // 
            this.pnlForms.BackColor = System.Drawing.Color.Azure;
            this.pnlForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForms.Location = new System.Drawing.Point(3, 97);
            this.pnlForms.Name = "pnlForms";
            this.pnlForms.Padding = new System.Windows.Forms.Padding(5);
            this.pnlForms.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnlForms.Size = new System.Drawing.Size(794, 490);
            this.pnlForms.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.btnSuppliers, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnProducts, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPackages, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 38);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(794, 53);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.btnSuppliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuppliers.ForeColor = System.Drawing.Color.White;
            this.btnSuppliers.Location = new System.Drawing.Point(10, 0);
            this.btnSuppliers.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.btnSuppliers.Size = new System.Drawing.Size(246, 53);
            this.btnSuppliers.TabIndex = 2;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.UseVisualStyleBackColor = false;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.Location = new System.Drawing.Point(276, 0);
            this.btnProducts.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.btnProducts.Size = new System.Drawing.Size(244, 53);
            this.btnProducts.TabIndex = 1;
            this.btnProducts.Text = "Products";
            this.btnProducts.UseVisualStyleBackColor = false;
            this.btnProducts.Click += new System.EventHandler(this.btnProducts_Click);
            // 
            // btnPackages
            // 
            this.btnPackages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(68)))));
            this.btnPackages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPackages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPackages.FlatAppearance.BorderSize = 0;
            this.btnPackages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPackages.Font = new System.Drawing.Font("MS Reference Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPackages.ForeColor = System.Drawing.Color.White;
            this.btnPackages.Location = new System.Drawing.Point(540, 0);
            this.btnPackages.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.OnHoverBackColor = System.Drawing.Color.DarkOrchid;
            this.btnPackages.Size = new System.Drawing.Size(244, 53);
            this.btnPackages.TabIndex = 0;
            this.btnPackages.Text = "Packages";
            this.btnPackages.UseVisualStyleBackColor = false;
            this.btnPackages.Click += new System.EventHandler(this.btnPackages_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(762, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.OnHoverBackColor = System.Drawing.Color.Pink;
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(35, 21);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainView";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Travel Package System";
            this.TopMost = true;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel pnlForms;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private FlatButton btnSuppliers;
        private FlatButton btnProducts;
        private FlatButton btnPackages;
        private FlatButton btnClose;
    }
}

