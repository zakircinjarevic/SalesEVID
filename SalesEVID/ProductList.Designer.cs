namespace SalesEVID
{
    partial class ProductList
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
            this.dataGridProducts = new System.Windows.Forms.DataGridView();
            this.contextMenuProizvodi = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddAProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditTheProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RemoveTheProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RefreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowProfitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sale = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.rent = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contractduration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleincome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentincome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dateofcontract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.contextMenuProizvodi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridProizvodi
            // 
            this.dataGridProducts.AllowUserToAddRows = false;
            this.dataGridProducts.AllowUserToDeleteRows = false;
            this.dataGridProducts.AllowUserToOrderColumns = true;
            this.dataGridProducts.AllowUserToResizeColumns = false;
            this.dataGridProducts.AllowUserToResizeRows = false;
            this.dataGridProducts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.customer,
            this.productname,
            this.sale,
            this.rent,
            this.contractduration,
            this.saleincome,
            this.rentincome,
            this.Dateofcontract});
            this.dataGridProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridProducts.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridProducts.Location = new System.Drawing.Point(0, 0);
            this.dataGridProducts.MultiSelect = false;
            this.dataGridProducts.Name = "dataGridProizvodi";
            this.dataGridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProducts.Size = new System.Drawing.Size(878, 294);
            this.dataGridProducts.TabIndex = 0;
            this.dataGridProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProizvodi_CellClick);
            this.dataGridProducts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridProizvodi_MouseClick);
            // 
            // contextMenuProizvodi
            // 
            this.contextMenuProizvodi.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAProductToolStripMenuItem,
            this.EditTheProductToolStripMenuItem,
            this.RemoveTheProductToolStripMenuItem,
            this.RefreshToolStripMenuItem,
            this.ShowProfitsToolStripMenuItem});
            this.contextMenuProizvodi.Name = "contextMenuProizvodi";
            this.contextMenuProizvodi.Size = new System.Drawing.Size(183, 136);
            // 
            // AddAProductToolStripMenuItem
            // 
            this.AddAProductToolStripMenuItem.Name = "AddAProductToolStripMenuItem";
            this.AddAProductToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.AddAProductToolStripMenuItem.Text = "Add a product";
            this.AddAProductToolStripMenuItem.Click += new System.EventHandler(this.dodajProizvodToolStripMenuItem_Click);
            // 
            // EditTheProductToolStripMenuItem
            // 
            this.EditTheProductToolStripMenuItem.Name = "EditTheProductToolStripMenuItem";
            this.EditTheProductToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.EditTheProductToolStripMenuItem.Text = "Edit the product";
            this.EditTheProductToolStripMenuItem.Click += new System.EventHandler(this.izmjeniProizvodToolStripMenuItem_Click);
            // 
            // RemoveTheProductToolStripMenuItem
            // 
            this.RemoveTheProductToolStripMenuItem.Name = "RemoveTheProductToolStripMenuItem";
            this.RemoveTheProductToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.RemoveTheProductToolStripMenuItem.Text = "Remove the product";
            this.RemoveTheProductToolStripMenuItem.Click += new System.EventHandler(this.ukloniProizvodToolStripMenuItem_Click);
            // 
            // RefreshToolStripMenuItem
            // 
            this.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem";
            this.RefreshToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.RefreshToolStripMenuItem.Text = "Refresh";
            this.RefreshToolStripMenuItem.Click += new System.EventHandler(this.osvježiToolStripMenuItem_Click);
            // 
            // ShowProfitsToolStripMenuItem
            // 
            this.ShowProfitsToolStripMenuItem.Name = "ShowProfitsToolStripMenuItem";
            this.ShowProfitsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.ShowProfitsToolStripMenuItem.Text = "Show profits";
            this.ShowProfitsToolStripMenuItem.Click += new System.EventHandler(this.prikažiMjesečniProfitToolStripMenuItem_Click);
            // 
            // customerID
            // 
            this.customerID.HeaderText = "ProductID";
            this.customerID.Name = "customerID";
            this.customerID.Visible = false;
            // 
            // customer
            // 
            this.customer.HeaderText = "Customer";
            this.customer.Name = "customer";
            // 
            // productname
            // 
            this.productname.HeaderText = "Product name";
            this.productname.Name = "productname";
            // 
            // sale
            // 
            this.sale.HeaderText = "Sale";
            this.sale.Name = "sale";
            this.sale.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sale.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // rent
            // 
            this.rent.HeaderText = "Rent";
            this.rent.Name = "rent";
            // 
            // contractduration
            // 
            this.contractduration.HeaderText = "Contract duration";
            this.contractduration.Name = "contractduration";
            // 
            // saleincome
            // 
            this.saleincome.HeaderText = "Sale income";
            this.saleincome.Name = "saleincome";
            // 
            // rentincome
            // 
            this.rentincome.HeaderText = "Rent income";
            this.rentincome.Name = "rentincome";
            // 
            // Dateofcontract
            // 
            this.Dateofcontract.HeaderText = "Date of contract";
            this.Dateofcontract.Name = "Dateofcontract";
            this.Dateofcontract.Width = 150;
            // 
            // ProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 294);
            this.Controls.Add(this.dataGridProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product list";
            this.Load += new System.EventHandler(this.ProizvodList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            this.contextMenuProizvodi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.ContextMenuStrip contextMenuProizvodi;
        private System.Windows.Forms.ToolStripMenuItem AddAProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditTheProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RemoveTheProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RefreshToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowProfitsToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer;
        private System.Windows.Forms.DataGridViewTextBoxColumn productname;
        private System.Windows.Forms.DataGridViewCheckBoxColumn sale;
        private System.Windows.Forms.DataGridViewCheckBoxColumn rent;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractduration;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleincome;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentincome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dateofcontract;
    }
}