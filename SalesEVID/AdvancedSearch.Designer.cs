namespace SalesEVID
{
    partial class AdvancedSearch
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
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfEmployees = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Called = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Waiting = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Contract = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Done = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaleIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentIncome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContractDuration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfContract = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxProductName = new System.Windows.Forms.CheckBox();
            this.checkBoxSale = new System.Windows.Forms.CheckBox();
            this.checkBoxContractDuration = new System.Windows.Forms.CheckBox();
            this.checkBoxRent = new System.Windows.Forms.CheckBox();
            this.checkBoxWorkDescription = new System.Windows.Forms.CheckBox();
            this.checkBoxCustomerName = new System.Windows.Forms.CheckBox();
            this.checkBoxContactPerson = new System.Windows.Forms.CheckBox();
            this.checkBoxNumberOfEmployees = new System.Windows.Forms.CheckBox();
            this.checkBoxstatuses = new System.Windows.Forms.CheckBox();
            this.checkBoxNotes = new System.Windows.Forms.CheckBox();
            this.checkBoxDateOfContract = new System.Windows.Forms.CheckBox();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.prikažiProfiteTrenutnihProizvodaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridProducts
            // 
            this.dataGridProducts.AllowUserToAddRows = false;
            this.dataGridProducts.AllowUserToDeleteRows = false;
            this.dataGridProducts.AllowUserToOrderColumns = true;
            this.dataGridProducts.AllowUserToResizeRows = false;
            this.dataGridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridProducts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridProducts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CompanyName,
            this.WorkDescription,
            this.NumberOfEmployees,
            this.ContactPerson,
            this.PhoneNumber,
            this.Called,
            this.Waiting,
            this.Contract,
            this.Done,
            this.Notes,
            this.ProductName,
            this.SaleIncome,
            this.RentIncome,
            this.ContractDuration,
            this.DateOfContract});
            this.dataGridProducts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridProducts.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridProducts.Location = new System.Drawing.Point(12, 92);
            this.dataGridProducts.MultiSelect = false;
            this.dataGridProducts.Name = "dataGridProducts";
            this.dataGridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridProducts.Size = new System.Drawing.Size(1100, 584);
            this.dataGridProducts.TabIndex = 2;
            this.dataGridProducts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dataGridProducts_MouseClick);
            // 
            // CompanyName
            // 
            this.CompanyName.HeaderText = "Company name";
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Width = 105;
            // 
            // WorkDescription
            // 
            this.WorkDescription.HeaderText = "Work description";
            this.WorkDescription.Name = "WorkDescription";
            this.WorkDescription.Width = 112;
            // 
            // NumberOfEmployees
            // 
            this.NumberOfEmployees.HeaderText = "No. of employees";
            this.NumberOfEmployees.Name = "NumberOfEmployees";
            this.NumberOfEmployees.Width = 114;
            // 
            // ContactPerson
            // 
            this.ContactPerson.HeaderText = "Contact person";
            this.ContactPerson.Name = "ContactPerson";
            this.ContactPerson.Width = 104;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.HeaderText = "Phone number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.Width = 101;
            // 
            // Called
            // 
            this.Called.HeaderText = "Called";
            this.Called.Name = "Called";
            this.Called.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Called.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Called.Width = 61;
            // 
            // Waiting
            // 
            this.Waiting.HeaderText = "Waiting";
            this.Waiting.Name = "Waiting";
            this.Waiting.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Waiting.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Waiting.Width = 68;
            // 
            // Contract
            // 
            this.Contract.HeaderText = "Contract";
            this.Contract.Name = "Contract";
            this.Contract.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Contract.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Contract.Width = 72;
            // 
            // Done
            // 
            this.Done.HeaderText = "Done";
            this.Done.Name = "Done";
            this.Done.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Done.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Done.Width = 58;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            this.Notes.Width = 60;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product name";
            this.ProductName.Name = "ProductName";
            this.ProductName.Width = 98;
            // 
            // SaleIncome
            // 
            this.SaleIncome.HeaderText = "Sale income";
            this.SaleIncome.Name = "SaleIncome";
            this.SaleIncome.Width = 90;
            // 
            // RentIncome
            // 
            this.RentIncome.HeaderText = "Rent income";
            this.RentIncome.Name = "RentIncome";
            this.RentIncome.Width = 92;
            // 
            // ContractDuration
            // 
            this.ContractDuration.HeaderText = "Contract duration";
            this.ContractDuration.Name = "ContractDuration";
            this.ContractDuration.Width = 113;
            // 
            // DateOfContract
            // 
            this.DateOfContract.HeaderText = "Date of contract";
            this.DateOfContract.Name = "DateOfContract";
            this.DateOfContract.Width = 109;
            // 
            // checkBoxProductName
            // 
            this.checkBoxProductName.AutoSize = true;
            this.checkBoxProductName.Location = new System.Drawing.Point(120, 58);
            this.checkBoxProductName.Name = "checkBoxProductName";
            this.checkBoxProductName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxProductName.Size = new System.Drawing.Size(92, 17);
            this.checkBoxProductName.TabIndex = 3;
            this.checkBoxProductName.Text = "Product name";
            this.checkBoxProductName.UseVisualStyleBackColor = true;
            this.checkBoxProductName.CheckedChanged += new System.EventHandler(this.checkBoxProductName_CheckedChanged);
            // 
            // checkBoxSale
            // 
            this.checkBoxSale.AutoSize = true;
            this.checkBoxSale.Location = new System.Drawing.Point(12, 58);
            this.checkBoxSale.Name = "checkBoxSale";
            this.checkBoxSale.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxSale.Size = new System.Drawing.Size(47, 17);
            this.checkBoxSale.TabIndex = 4;
            this.checkBoxSale.Text = "Sale";
            this.checkBoxSale.UseVisualStyleBackColor = true;
            this.checkBoxSale.CheckedChanged += new System.EventHandler(this.checkBoxSale_CheckedChanged);
            // 
            // checkBoxContractDuration
            // 
            this.checkBoxContractDuration.AutoSize = true;
            this.checkBoxContractDuration.Location = new System.Drawing.Point(120, 35);
            this.checkBoxContractDuration.Name = "checkBoxContractDuration";
            this.checkBoxContractDuration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxContractDuration.Size = new System.Drawing.Size(107, 17);
            this.checkBoxContractDuration.TabIndex = 6;
            this.checkBoxContractDuration.Text = "Contract duration";
            this.checkBoxContractDuration.UseVisualStyleBackColor = true;
            this.checkBoxContractDuration.CheckedChanged += new System.EventHandler(this.checkBoxContractDuration_CheckedChanged);
            // 
            // checkBoxRent
            // 
            this.checkBoxRent.AutoSize = true;
            this.checkBoxRent.Location = new System.Drawing.Point(120, 12);
            this.checkBoxRent.Name = "checkBoxRent";
            this.checkBoxRent.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxRent.Size = new System.Drawing.Size(49, 17);
            this.checkBoxRent.TabIndex = 5;
            this.checkBoxRent.Text = "Rent";
            this.checkBoxRent.UseVisualStyleBackColor = true;
            this.checkBoxRent.CheckedChanged += new System.EventHandler(this.checkBoxRent_CheckedChanged);
            // 
            // checkBoxWorkDescription
            // 
            this.checkBoxWorkDescription.AutoSize = true;
            this.checkBoxWorkDescription.Location = new System.Drawing.Point(12, 35);
            this.checkBoxWorkDescription.Name = "checkBoxWorkDescription";
            this.checkBoxWorkDescription.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxWorkDescription.Size = new System.Drawing.Size(106, 17);
            this.checkBoxWorkDescription.TabIndex = 8;
            this.checkBoxWorkDescription.Text = "Work description";
            this.checkBoxWorkDescription.UseVisualStyleBackColor = true;
            this.checkBoxWorkDescription.CheckedChanged += new System.EventHandler(this.checkBoxWorkDescription_CheckedChanged);
            // 
            // checkBoxCustomerName
            // 
            this.checkBoxCustomerName.AutoSize = true;
            this.checkBoxCustomerName.Location = new System.Drawing.Point(12, 12);
            this.checkBoxCustomerName.Name = "checkBoxCustomerName";
            this.checkBoxCustomerName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxCustomerName.Size = new System.Drawing.Size(99, 17);
            this.checkBoxCustomerName.TabIndex = 7;
            this.checkBoxCustomerName.Text = "Customer name";
            this.checkBoxCustomerName.UseVisualStyleBackColor = true;
            this.checkBoxCustomerName.CheckedChanged += new System.EventHandler(this.checkBoxCustomerName_CheckedChanged);
            // 
            // checkBoxContactPerson
            // 
            this.checkBoxContactPerson.AutoSize = true;
            this.checkBoxContactPerson.Location = new System.Drawing.Point(228, 35);
            this.checkBoxContactPerson.Name = "checkBoxContactPerson";
            this.checkBoxContactPerson.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxContactPerson.Size = new System.Drawing.Size(98, 17);
            this.checkBoxContactPerson.TabIndex = 10;
            this.checkBoxContactPerson.Text = "Contact person";
            this.checkBoxContactPerson.UseVisualStyleBackColor = true;
            this.checkBoxContactPerson.CheckedChanged += new System.EventHandler(this.checkBoxContactPerson_CheckedChanged);
            // 
            // checkBoxNumberOfEmployees
            // 
            this.checkBoxNumberOfEmployees.AutoSize = true;
            this.checkBoxNumberOfEmployees.Location = new System.Drawing.Point(228, 58);
            this.checkBoxNumberOfEmployees.Name = "checkBoxNumberOfEmployees";
            this.checkBoxNumberOfEmployees.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxNumberOfEmployees.Size = new System.Drawing.Size(108, 17);
            this.checkBoxNumberOfEmployees.TabIndex = 9;
            this.checkBoxNumberOfEmployees.Text = "No. of employees";
            this.checkBoxNumberOfEmployees.UseVisualStyleBackColor = true;
            this.checkBoxNumberOfEmployees.CheckedChanged += new System.EventHandler(this.checkBoxNumberOfEmployees_CheckedChanged);
            // 
            // checkBoxstatuses
            // 
            this.checkBoxstatuses.AutoSize = true;
            this.checkBoxstatuses.Location = new System.Drawing.Point(228, 12);
            this.checkBoxstatuses.Name = "checkBoxstatuses";
            this.checkBoxstatuses.Size = new System.Drawing.Size(67, 17);
            this.checkBoxstatuses.TabIndex = 11;
            this.checkBoxstatuses.Text = "Statuses";
            this.checkBoxstatuses.UseVisualStyleBackColor = true;
            this.checkBoxstatuses.CheckedChanged += new System.EventHandler(this.checkBoxstatuses_CheckedChanged);
            // 
            // checkBoxNotes
            // 
            this.checkBoxNotes.AutoSize = true;
            this.checkBoxNotes.Location = new System.Drawing.Point(338, 12);
            this.checkBoxNotes.Name = "checkBoxNotes";
            this.checkBoxNotes.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxNotes.Size = new System.Drawing.Size(54, 17);
            this.checkBoxNotes.TabIndex = 12;
            this.checkBoxNotes.Text = "Notes";
            this.checkBoxNotes.UseVisualStyleBackColor = true;
            this.checkBoxNotes.CheckedChanged += new System.EventHandler(this.checkBoxNotes_CheckedChanged);
            // 
            // checkBoxDateOfContract
            // 
            this.checkBoxDateOfContract.AutoSize = true;
            this.checkBoxDateOfContract.Location = new System.Drawing.Point(338, 35);
            this.checkBoxDateOfContract.Name = "checkBoxDateOfContract";
            this.checkBoxDateOfContract.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkBoxDateOfContract.Size = new System.Drawing.Size(103, 17);
            this.checkBoxDateOfContract.TabIndex = 13;
            this.checkBoxDateOfContract.Text = "Date of contract";
            this.checkBoxDateOfContract.UseVisualStyleBackColor = true;
            this.checkBoxDateOfContract.CheckedChanged += new System.EventHandler(this.checkBoxDateOfContract_CheckedChanged);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(555, 6);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFrom.TabIndex = 14;
            this.dateTimePickerFrom.Value = new System.DateTime(2017, 2, 21, 10, 59, 0, 0);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(555, 32);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerTo.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "To";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.prikažiProfiteTrenutnihProizvodaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(254, 26);
            // 
            // prikažiProfiteTrenutnihProizvodaToolStripMenuItem
            // 
            this.prikažiProfiteTrenutnihProizvodaToolStripMenuItem.Name = "prikažiProfiteTrenutnihProizvodaToolStripMenuItem";
            this.prikažiProfiteTrenutnihProizvodaToolStripMenuItem.Size = new System.Drawing.Size(253, 22);
            this.prikažiProfiteTrenutnihProizvodaToolStripMenuItem.Text = "Prikaži profite trenutnih proizvoda";
            this.prikažiProfiteTrenutnihProizvodaToolStripMenuItem.Click += new System.EventHandler(this.ShowProfitsOfCurrentProductsToolStripMenuItem_Click);
            // 
            // AdvancedSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 694);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.checkBoxDateOfContract);
            this.Controls.Add(this.checkBoxNotes);
            this.Controls.Add(this.checkBoxstatuses);
            this.Controls.Add(this.checkBoxContactPerson);
            this.Controls.Add(this.checkBoxNumberOfEmployees);
            this.Controls.Add(this.checkBoxWorkDescription);
            this.Controls.Add(this.checkBoxCustomerName);
            this.Controls.Add(this.checkBoxContractDuration);
            this.Controls.Add(this.checkBoxRent);
            this.Controls.Add(this.checkBoxSale);
            this.Controls.Add(this.checkBoxProductName);
            this.Controls.Add(this.dataGridProducts);
            this.Name = "AdvancedSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Advanced search";
            this.Load += new System.EventHandler(this.AdvancedSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProducts)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridProducts;
        private System.Windows.Forms.CheckBox checkBoxProductName;
        private System.Windows.Forms.CheckBox checkBoxSale;
        private System.Windows.Forms.CheckBox checkBoxContractDuration;
        private System.Windows.Forms.CheckBox checkBoxRent;
        private System.Windows.Forms.CheckBox checkBoxWorkDescription;
        private System.Windows.Forms.CheckBox checkBoxCustomerName;
        private System.Windows.Forms.CheckBox checkBoxContactPerson;
        private System.Windows.Forms.CheckBox checkBoxNumberOfEmployees;
        private System.Windows.Forms.CheckBox checkBoxstatuses;
        private System.Windows.Forms.CheckBox checkBoxNotes;
        private System.Windows.Forms.CheckBox checkBoxDateOfContract;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem prikažiProfiteTrenutnihProizvodaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfEmployees;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Called;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Waiting;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Contract;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Done;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaleIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ContractDuration;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfContract;
    }
}