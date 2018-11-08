using SalesEVID;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class CustomerList : Form
    {
        public List<Customer> customers = new List<Customer>();
        public CustomerList()
        {
            InitializeComponent();
            PopulateCustomerList();
        }
        public CustomerList(string user)
        {
            InitializeComponent();
            PopulateCustomerList();
            labelUsername.Text = user;
        }
        private void CustomerList_Load(object sender, EventArgs e)
        {
            buttonQuerryMaker.Image = Image.FromFile(AppPaths.IcoPath + "\\MagnifyingGlass.png");
            buttonQuerryMaker.ImageAlign = ContentAlignment.MiddleRight;
            buttonReset.Image = Image.FromFile(AppPaths.IcoPath + "\\Reset.png");
            buttonReset.ImageAlign = ContentAlignment.TopCenter;
            buttonDone.Image = Image.FromFile(AppPaths.IcoPath + "\\Done.png");
            buttonDone.ImageAlign = ContentAlignment.TopCenter;
            buttonCalled.Image = Image.FromFile(AppPaths.IcoPath + "\\Called.png");
            buttonCalled.ImageAlign = ContentAlignment.TopCenter;
            buttonContract.Image = Image.FromFile(AppPaths.IcoPath + "\\Contract.png");
            buttonContract.ImageAlign = ContentAlignment.TopCenter;
            buttonWaiting.Image = Image.FromFile(AppPaths.IcoPath + "\\Waiting.png");
            buttonWaiting.ImageAlign = ContentAlignment.TopCenter;
            btnSoldProducts.Image = Image.FromFile(AppPaths.IcoPath + "\\SoldProducts.png");
            btnSoldProducts.ImageAlign = ContentAlignment.TopCenter;
            buttonAdvancedSearch.Image = Image.FromFile(AppPaths.IcoPath + "\\Advanced.png");
            buttonAdvancedSearch.ImageAlign = ContentAlignment.TopCenter;

        }
        private void PopulateCustomerList()
        {
            this.dataGridCustomers.Rows.Clear();

            customers = DBHandler.getCustomers();
            DataGrid dgv = new DataGrid();
            dgv.SuspendLayout();
            // Do update, change values
            
            foreach (var item in customers)
            {
                if (item.CustomerName != "")
                //maybe add the ones who are not done here, checkbox done
                this.dataGridCustomers.Rows.Add(item.CustomerID,item.CustomerName,item.WorkDescription,item.NumberOfEmployees,item.ContactPerson,item.PhoneNumber,item.Called,item.Waiting,item.Contract,item.Done,item.Notes);
            }
            dgv.ResumeLayout();
        }
        private void AddCustomer()
        {
            AddEdit_Firmu customers = new AddEdit_Firmu(new Customer());
            customers.ShowDialog();
            PopulateCustomerList();
        }
        private void EditCustomer()
        {
            if (dataGridCustomers.SelectedRows.Count == 0)
                return;


            Customer customer = new Customer();
            int.TryParse(Convert.ToString(dataGridCustomers.SelectedRows[0].Cells[0].Value), out customer.CustomerID);
            customer.CustomerName = dataGridCustomers.SelectedRows[0].Cells[1].Value.ToString(); //TODO
            customer.WorkDescription = dataGridCustomers.SelectedRows[0].Cells[2].Value.ToString();
            customer.NumberOfEmployees = int.Parse(dataGridCustomers.SelectedRows[0].Cells[3].Value.ToString());
            customer.ContactPerson = dataGridCustomers.SelectedRows[0].Cells[4].Value.ToString();
            customer.PhoneNumber = dataGridCustomers.SelectedRows[0].Cells[5].Value.ToString();
            customer.Called = bool.Parse(dataGridCustomers.SelectedRows[0].Cells[6].Value.ToString());
            customer.Waiting = bool.Parse(dataGridCustomers.SelectedRows[0].Cells[7].Value.ToString());
            customer.Contract = bool.Parse(dataGridCustomers.SelectedRows[0].Cells[8].Value.ToString());
            customer.Done = bool.Parse(dataGridCustomers.SelectedRows[0].Cells[9].Value.ToString());
            customer.Notes = dataGridCustomers.SelectedRows[0].Cells[10].Value.ToString();


            AddEdit_Firmu dlg = new AddEdit_Firmu(customer);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                PopulateCustomerList();
            }
        }
        private void DeleteCustomer()
        {
            if (dataGridCustomers.SelectedRows.Count == 0)
                return;
            Customer customer = new Customer();
            customer.CustomerID = int.Parse(dataGridCustomers.SelectedRows[0].Cells[0].Value.ToString());
            customer.CustomerName = dataGridCustomers.SelectedRows[0].Cells[1].Value.ToString();
            customer.WorkDescription = dataGridCustomers.SelectedRows[0].Cells[2].Value.ToString();
            customer.NumberOfEmployees = int.Parse(dataGridCustomers.SelectedRows[0].Cells[3].Value.ToString());
            customer.ContactPerson = dataGridCustomers.SelectedRows[0].Cells[4].Value.ToString();
            customer.PhoneNumber = dataGridCustomers.SelectedRows[0].Cells[5].Value.ToString();
            customer.Called = bool.Parse(dataGridCustomers.SelectedRows[0].Cells[6].Value.ToString());
            customer.Waiting = bool.Parse(dataGridCustomers.SelectedRows[0].Cells[7].Value.ToString());
            customer.Contract = bool.Parse(dataGridCustomers.SelectedRows[0].Cells[8].Value.ToString());
            customer.Done = bool.Parse(dataGridCustomers.SelectedRows[0].Cells[9].Value.ToString());
            customer.Notes = dataGridCustomers.SelectedRows[0].Cells[10].Value.ToString();
           
            if (MessageBox.Show(this, "Do you really want to delete the customer (" + customer.CustomerName + ") ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            DBHandler.delCustomer(customer.CustomerID);
            PopulateCustomerList();
        }     
        private void contextMenuStrip_Firme_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditCustomer();
        }
        private void ListView_Firme_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            contextMenuStrip_Firme.Show(Cursor.Position);
        }
        private void btn_AddNewCustomer_Click_1(object sender, EventArgs e)
        {
            AddCustomer();
        }
        private void btn_RemoveCustomer_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }
        private void btn_EditCustomer_Click(object sender, EventArgs e)
        {
            EditCustomer();
        }
        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                contextMenuStrip_Firme.Show(Cursor.Position.X, Cursor.Position.Y);
            }
        }
        private void btn_RefreshFirme_Click(object sender, EventArgs e)
        {
            PopulateCustomerList();
        }
        private void pogledajProizvodeToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Customer selected = new Customer();
            if (dataGridCustomers.SelectedRows.Count == 0)
                return;
            int customerid;
            int.TryParse(Convert.ToString(dataGridCustomers.SelectedRows[0].Cells[0].Value), out customerid);
            foreach (var item in customers)
            {
                if (item.CustomerID == customerid)
                {
                    selected = item;
                    break;
                }
            }
            ProductList frm = new ProductList(selected);
            frm.Text=dataGridCustomers.SelectedRows[0].Cells[1].Value.ToString();
            frm.ShowDialog();
        }    
        private void buttonReset_Click(object sender, EventArgs e)
        {
            PopulateCustomerList();
            buttonDone.Text = "Done";
            buttonContract.Text = "Contracts";
            buttonWaiting.Text = "Waiting";
            buttonCalled.Text = "Called";
        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            this.dataGridCustomers.Rows.Clear();

            if (buttonDone.Text == "Done")
            {
                customers = DBHandler.getCustomersByDone();
                DataGrid dg = new DataGrid();
                foreach (var item in customers)
                {
                    if (item.CustomerName != "")
                       
                        this.dataGridCustomers.Rows.Add(item.CustomerID, item.CustomerName, item.WorkDescription, item.NumberOfEmployees, item.ContactPerson, item.PhoneNumber, item.Called, item.Waiting, item.Contract, item.Done, item.Notes, "Pogledaj");
                }
                ChangeDone();
            }
            else
            {
                customers = DBHandler.getCustomersByActive();
                DataGrid dg = new DataGrid();
                foreach (var item in customers)
                {
                    if (item.CustomerName != "")
                       
                        this.dataGridCustomers.Rows.Add(item.CustomerID, item.CustomerName, item.WorkDescription, item.NumberOfEmployees, item.ContactPerson, item.PhoneNumber, item.Called, item.Waiting, item.Contract, item.Done, item.Notes, "Pogledaj");
                }
                ChangeDone();
            }

        }
        private void buttonCalled_Click(object sender, EventArgs e)
        {
            this.dataGridCustomers.Rows.Clear();

            if (buttonCalled.Text == "Called")
            {
                customers = DBHandler.getCustomersByCalled();
                DataGrid dg = new DataGrid();
                foreach (var item in customers)
                {
                    if (item.CustomerName != "")
                        
                        this.dataGridCustomers.Rows.Add(item.CustomerID, item.CustomerName, item.WorkDescription, item.NumberOfEmployees, item.ContactPerson, item.PhoneNumber, item.Called, item.Waiting, item.Contract, item.Done, item.Notes, "Pogledaj");
                }
                ChangeCalled();
            }
            else
            {
                customers = DBHandler.getCustomersByNotCalled();
                DataGrid dg = new DataGrid();
                foreach (var item in customers)
                {
                    if (item.CustomerName != "")
                        
                        this.dataGridCustomers.Rows.Add(item.CustomerID, item.CustomerName, item.WorkDescription, item.NumberOfEmployees, item.ContactPerson, item.PhoneNumber, item.Called, item.Waiting, item.Contract, item.Done, item.Notes, "Pogledaj");
                }
                ChangeCalled();
            }

        }
        private void buttonWaiting_Click(object sender, EventArgs e)
        {
            this.dataGridCustomers.Rows.Clear();

            if (buttonWaiting.Text == "Waiting")
            {
                customers = DBHandler.getCustomersByWaiting();
                DataGrid dg = new DataGrid();
                foreach (var item in customers)
                {
                    if (item.CustomerName != "")
                       
                        this.dataGridCustomers.Rows.Add(item.CustomerID, item.CustomerName, item.WorkDescription, item.NumberOfEmployees, item.ContactPerson, item.PhoneNumber, item.Called, item.Waiting, item.Contract, item.Done, item.Notes, "Pogledaj");
                }
                ChangeWaiting();
            }
            else
            {
                customers = DBHandler.getCustomersByOngoing();
                DataGrid dg = new DataGrid();
                foreach (var item in customers)
                {
                    if (item.CustomerName != "")
                       
                        this.dataGridCustomers.Rows.Add(item.CustomerID, item.CustomerName, item.WorkDescription, item.NumberOfEmployees, item.ContactPerson, item.PhoneNumber, item.Called, item.Waiting, item.Contract, item.Done, item.Notes, "Pogledaj");
                }
                ChangeWaiting();
            }
        }
        private void buttonContracts_Click(object sender, EventArgs e)
        {
            this.dataGridCustomers.Rows.Clear();

            if (buttonContract.Text == "Contracts")
            {
                customers = DBHandler.getCustomersByContract();
                DataGrid dg = new DataGrid();
                foreach (var item in customers)
                {
                    if (item.CustomerName != "")                       
                        this.dataGridCustomers.Rows.Add(item.CustomerID, item.CustomerName, item.WorkDescription, item.NumberOfEmployees, item.ContactPerson, item.PhoneNumber, item.Called, item.Waiting, item.Contract, item.Done, item.Notes, "Pogledaj");
                }
                PromjeniContract();
            }
            else
            {
                customers = DBHandler.getCustomersByNoContract();
                DataGrid dg = new DataGrid();
                foreach (var item in customers)
                {
                    if (item.CustomerName != "")
                        this.dataGridCustomers.Rows.Add(item.CustomerID, item.CustomerName, item.WorkDescription, item.NumberOfEmployees, item.ContactPerson, item.PhoneNumber, item.Called, item.Waiting, item.Contract, item.Done, item.Notes, "Pogledaj");
                }
                PromjeniContract();
            }
        }
        private void btnSoldProducts_Click(object sender, EventArgs e)
        {
            ProductList frm = new ProductList();
            frm.Text = "Sold products";
            frm.ShowDialog();
            PopulateCustomerList();
        }
        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            Close();
        }
        void ChangeCalled()
        {
            if (buttonCalled.Text == "Called")
                buttonCalled.Text = "Not called";
            else if (buttonCalled.Text == "Not called")
                buttonCalled.Text = "Called";
        }
        void ChangeWaiting()
        {
            if (buttonWaiting.Text == "Waiting")
                buttonWaiting.Text = "Ongoing";
            else if (buttonWaiting.Text == "Ongoing")
                buttonWaiting.Text = "Waiting";
        }
        void PromjeniContract()
        {
            if (buttonContract.Text == "Contracts")
                buttonContract.Text = "No contracts";
            else if (buttonContract.Text == "No contracts")
                buttonContract.Text = "Contracts";
        }
        void ChangeDone()
        {
            if (buttonDone.Text == "Done")
                buttonDone.Text = "Active";
            else if (buttonDone.Text == "Active")
                buttonDone.Text = "Done";
        }
        private void textBoxsearch_TextChanged(object sender, EventArgs e)
        {
            this.dataGridCustomers.Rows.Clear();

            customers = DBHandler.getCustomersByName(textBoxsearch.Text);
            DataGrid dg = new DataGrid();
            foreach (var item in customers)
            {
                if (item.CustomerName != "")
                    this.dataGridCustomers.Rows.Add(item.CustomerID, item.CustomerName, item.WorkDescription, item.NumberOfEmployees, item.ContactPerson, item.PhoneNumber, item.Called, item.Waiting, item.Contract, item.Done, item.Notes, "Check");
            }
        }

        private void buttonAdvancedSearch_Click(object sender, EventArgs e)
        {
            AdvancedSearch frm = new AdvancedSearch();
            frm.Show();
            PopulateCustomerList();
        }
    }
}
