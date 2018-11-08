namespace Main
{
    partial class CustomerList
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
            this.contextMenuStrip_Firme = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CheckProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_AddACustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_EditTheCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_DeleteTheCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_RefreshCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridCustomers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workdescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberofemployees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactperson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.called = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.waiting = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.contract = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.done = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonQuerryMaker = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxsearch = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDone = new System.Windows.Forms.Button();
            this.buttonWaiting = new System.Windows.Forms.Button();
            this.buttonContract = new System.Windows.Forms.Button();
            this.buttonCalled = new System.Windows.Forms.Button();
            this.btnSoldProducts = new System.Windows.Forms.Button();
            this.labelUsername = new System.Windows.Forms.Label();
            this.buttonOdjava = new System.Windows.Forms.Button();
            this.buttonAdvancedSearch = new System.Windows.Forms.Button();
            this.contextMenuStrip_Firme.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip_Firme
            // 
            this.contextMenuStrip_Firme.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckProducts,
            this.btn_AddACustomer,
            this.btn_EditTheCustomer,
            this.btn_DeleteTheCustomer,
            this.btn_RefreshCustomers});
            this.contextMenuStrip_Firme.Name = "contextMenuStrip_Devices";
            this.contextMenuStrip_Firme.Size = new System.Drawing.Size(181, 136);
            // 
            // CheckProducts
            // 
            this.CheckProducts.Name = "CheckProducts";
            this.CheckProducts.Size = new System.Drawing.Size(180, 22);
            this.CheckProducts.Text = "Check products";
            this.CheckProducts.Click += new System.EventHandler(this.pogledajProizvodeToolStripMenuItem_Click_1);
            // 
            // btn_AddACustomer
            // 
            this.btn_AddACustomer.Name = "btn_AddACustomer";
            this.btn_AddACustomer.Size = new System.Drawing.Size(180, 22);
            this.btn_AddACustomer.Text = "Add a customer";
            this.btn_AddACustomer.Click += new System.EventHandler(this.btn_AddNewCustomer_Click_1);
            // 
            // btn_EditTheCustomer
            // 
            this.btn_EditTheCustomer.Name = "btn_EditTheCustomer";
            this.btn_EditTheCustomer.Size = new System.Drawing.Size(180, 22);
            this.btn_EditTheCustomer.Text = "Edit a customer";
            this.btn_EditTheCustomer.Click += new System.EventHandler(this.btn_EditCustomer_Click);
            // 
            // btn_DeleteTheCustomer
            // 
            this.btn_DeleteTheCustomer.Name = "btn_DeleteTheCustomer";
            this.btn_DeleteTheCustomer.Size = new System.Drawing.Size(180, 22);
            this.btn_DeleteTheCustomer.Text = "Delete the customer";
            this.btn_DeleteTheCustomer.Click += new System.EventHandler(this.btn_RemoveCustomer_Click);
            // 
            // btn_RefreshCustomers
            // 
            this.btn_RefreshCustomers.Name = "btn_RefreshCustomers";
            this.btn_RefreshCustomers.Size = new System.Drawing.Size(180, 22);
            this.btn_RefreshCustomers.Text = "Refresh ";
            this.btn_RefreshCustomers.Click += new System.EventHandler(this.btn_RefreshFirme_Click);
            // 
            // dataGridCustomers
            // 
            this.dataGridCustomers.AllowUserToAddRows = false;
            this.dataGridCustomers.AllowUserToDeleteRows = false;
            this.dataGridCustomers.AllowUserToOrderColumns = true;
            this.dataGridCustomers.AllowUserToResizeRows = false;
            this.dataGridCustomers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridCustomers.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.CustomerName,
            this.workdescription,
            this.numberofemployees,
            this.contactperson,
            this.phonenumber,
            this.called,
            this.waiting,
            this.contract,
            this.done,
            this.notes});
            this.dataGridCustomers.ContextMenuStrip = this.contextMenuStrip_Firme;
            this.dataGridCustomers.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridCustomers.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridCustomers.Location = new System.Drawing.Point(6, 71);
            this.dataGridCustomers.MultiSelect = false;
            this.dataGridCustomers.Name = "dataGridCustomers";
            this.dataGridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridCustomers.Size = new System.Drawing.Size(1021, 584);
            this.dataGridCustomers.TabIndex = 1;
            this.dataGridCustomers.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer name";
            this.CustomerName.Name = "CustomerName";
            // 
            // workdescription
            // 
            this.workdescription.HeaderText = "Work description";
            this.workdescription.Name = "workdescription";
            // 
            // numberofemployees
            // 
            this.numberofemployees.HeaderText = "No. of employees";
            this.numberofemployees.Name = "numberofemployees";
            this.numberofemployees.Width = 80;
            // 
            // contactperson
            // 
            this.contactperson.HeaderText = "Contact person";
            this.contactperson.Name = "contactperson";
            // 
            // phonenumber
            // 
            this.phonenumber.HeaderText = "Phone number";
            this.phonenumber.Name = "phonenumber";
            // 
            // called
            // 
            this.called.HeaderText = "Called";
            this.called.Name = "called";
            this.called.Width = 70;
            // 
            // waiting
            // 
            this.waiting.HeaderText = "Waiting";
            this.waiting.Name = "waiting";
            this.waiting.Width = 55;
            // 
            // contract
            // 
            this.contract.HeaderText = "Contract";
            this.contract.Name = "contract";
            // 
            // done
            // 
            this.done.HeaderText = "Done";
            this.done.Name = "done";
            this.done.Width = 55;
            // 
            // notes
            // 
            this.notes.HeaderText = "Notes";
            this.notes.Name = "notes";
            this.notes.Width = 300;
            // 
            // buttonQuerryMaker
            // 
            this.buttonQuerryMaker.Location = new System.Drawing.Point(6, 6);
            this.buttonQuerryMaker.Name = "buttonQuerryMaker";
            this.buttonQuerryMaker.Size = new System.Drawing.Size(218, 59);
            this.buttonQuerryMaker.TabIndex = 2;
            this.buttonQuerryMaker.Text = "Search";
            this.buttonQuerryMaker.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonQuerryMaker.UseVisualStyleBackColor = true;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(681, 6);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(79, 59);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Reset filters";
            this.buttonReset.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // textBoxsearch
            // 
            this.textBoxsearch.Location = new System.Drawing.Point(102, 21);
            this.textBoxsearch.Name = "textBoxsearch";
            this.textBoxsearch.Size = new System.Drawing.Size(78, 20);
            this.textBoxsearch.TabIndex = 4;
            this.textBoxsearch.TextChanged += new System.EventHandler(this.textBoxsearch_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Company name";
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(512, 6);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(76, 59);
            this.buttonDone.TabIndex = 6;
            this.buttonDone.Text = "Done";
            this.buttonDone.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // buttonWaiting
            // 
            this.buttonWaiting.Location = new System.Drawing.Point(324, 6);
            this.buttonWaiting.Name = "buttonWaiting";
            this.buttonWaiting.Size = new System.Drawing.Size(77, 59);
            this.buttonWaiting.TabIndex = 7;
            this.buttonWaiting.Text = "Waiting";
            this.buttonWaiting.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonWaiting.UseVisualStyleBackColor = true;
            this.buttonWaiting.Click += new System.EventHandler(this.buttonWaiting_Click);
            // 
            // buttonContract
            // 
            this.buttonContract.Location = new System.Drawing.Point(407, 6);
            this.buttonContract.Name = "buttonContract";
            this.buttonContract.Size = new System.Drawing.Size(99, 59);
            this.buttonContract.TabIndex = 8;
            this.buttonContract.Text = "Contracts";
            this.buttonContract.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonContract.UseVisualStyleBackColor = true;
            this.buttonContract.Click += new System.EventHandler(this.buttonContracts_Click);
            // 
            // buttonCalled
            // 
            this.buttonCalled.Location = new System.Drawing.Point(230, 6);
            this.buttonCalled.Name = "buttonCalled";
            this.buttonCalled.Size = new System.Drawing.Size(88, 59);
            this.buttonCalled.TabIndex = 9;
            this.buttonCalled.Text = "Called";
            this.buttonCalled.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCalled.UseVisualStyleBackColor = true;
            this.buttonCalled.Click += new System.EventHandler(this.buttonCalled_Click);
            // 
            // btnSoldProducts
            // 
            this.btnSoldProducts.Location = new System.Drawing.Point(594, 6);
            this.btnSoldProducts.Name = "btnSoldProducts";
            this.btnSoldProducts.Size = new System.Drawing.Size(81, 59);
            this.btnSoldProducts.TabIndex = 10;
            this.btnSoldProducts.Text = "Sold products";
            this.btnSoldProducts.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSoldProducts.UseVisualStyleBackColor = true;
            this.btnSoldProducts.Click += new System.EventHandler(this.btnSoldProducts_Click);
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelUsername.Location = new System.Drawing.Point(894, 6);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(95, 24);
            this.labelUsername.TabIndex = 11;
            this.labelUsername.Text = "username";
            // 
            // buttonOdjava
            // 
            this.buttonOdjava.Location = new System.Drawing.Point(1089, 32);
            this.buttonOdjava.Name = "buttonOdjava";
            this.buttonOdjava.Size = new System.Drawing.Size(82, 34);
            this.buttonOdjava.TabIndex = 12;
            this.buttonOdjava.Text = "Odjava";
            this.buttonOdjava.UseVisualStyleBackColor = true;
            this.buttonOdjava.Click += new System.EventHandler(this.buttonSignOut_Click);
            // 
            // buttonAdvancedSearch
            // 
            this.buttonAdvancedSearch.Location = new System.Drawing.Point(766, 6);
            this.buttonAdvancedSearch.Name = "buttonAdvancedSearch";
            this.buttonAdvancedSearch.Size = new System.Drawing.Size(104, 59);
            this.buttonAdvancedSearch.TabIndex = 13;
            this.buttonAdvancedSearch.Text = "Advanced search";
            this.buttonAdvancedSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAdvancedSearch.UseVisualStyleBackColor = true;
            this.buttonAdvancedSearch.Click += new System.EventHandler(this.buttonAdvancedSearch_Click);
            // 
            // CustomerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 661);
            this.Controls.Add(this.buttonAdvancedSearch);
            this.Controls.Add(this.buttonOdjava);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.btnSoldProducts);
            this.Controls.Add(this.buttonCalled);
            this.Controls.Add(this.buttonContract);
            this.Controls.Add(this.buttonWaiting);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxsearch);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonQuerryMaker);
            this.Controls.Add(this.dataGridCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CustomerList";
            this.Padding = new System.Windows.Forms.Padding(3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesEVID ";
            this.Load += new System.EventHandler(this.CustomerList_Load);
            this.contextMenuStrip_Firme.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_Firme;
        private System.Windows.Forms.ToolStripMenuItem btn_AddACustomer;
        private System.Windows.Forms.ToolStripMenuItem btn_EditTheCustomer;
        private System.Windows.Forms.ToolStripMenuItem btn_DeleteTheCustomer;
        private System.Windows.Forms.ToolStripMenuItem btn_RefreshCustomers;
        private System.Windows.Forms.DataGridView dataGridCustomers;
        private System.Windows.Forms.ToolStripMenuItem CheckProducts;
        private System.Windows.Forms.Button buttonQuerryMaker;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxsearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Button buttonWaiting;
        private System.Windows.Forms.Button buttonContract;
        private System.Windows.Forms.Button buttonCalled;
        private System.Windows.Forms.Button btnSoldProducts;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Button buttonOdjava;
        private System.Windows.Forms.Button buttonAdvancedSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn workdescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberofemployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactperson;
        private System.Windows.Forms.DataGridViewTextBoxColumn phonenumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn called;
        private System.Windows.Forms.DataGridViewCheckBoxColumn waiting;
        private System.Windows.Forms.DataGridViewCheckBoxColumn contract;
        private System.Windows.Forms.DataGridViewCheckBoxColumn done;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes;
    }
}