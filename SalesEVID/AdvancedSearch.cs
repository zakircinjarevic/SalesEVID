using Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesEVID
{
    public partial class AdvancedSearch : Form
    {
        public AdvancedSearch()
        {
            InitializeComponent();
        }
        private void AdvancedSearch_Load(object sender, EventArgs e)
        {
            Populate();
        }
        void Populate()
        {
            var customers = DBHandler.getCustomers();
            var products = DBHandler.getProducts();

            customers = DBHandler.getCustomers();
            products = DBHandler.getProducts();
            DataGrid dg = new DataGrid();
            foreach (var item in products)
            {
                if (item.ProductName != "")
                    this.dataGridProducts.Rows.Add(item.CustomerID.CustomerName, item.CustomerID.WorkDescription, item.CustomerID.NumberOfEmployees, item.CustomerID.ContactPerson, item.CustomerID.PhoneNumber, item.CustomerID.Called, item.CustomerID.Waiting, item.CustomerID.Contract, item.CustomerID.Done, item.CustomerID.Notes, item.ProductName, item.SaleIncome, item.RentIncome, item.ContractDuration, item.DateOfContract);
            }
            HideAll();
        }
        void HideAll()
        {
            for (int i = 0; i < 15; i++)
            {
                dataGridProducts.Columns[i].Visible = false;
            }
            dataGridProducts.Columns[0].Visible = true;
            checkBoxCustomerName.Checked = true;
            dataGridProducts.Columns[1].Visible = true;
            checkBoxWorkDescription.Checked = true;
            dataGridProducts.Columns[11].Visible = true;
            checkBoxSale.Checked = true;
            dataGridProducts.Columns[12].Visible = true;
            checkBoxRent.Checked = true;
            dataGridProducts.Columns[14].Visible = true;
            checkBoxDateOfContract.Checked = true;
            checkBoxContractDuration.Checked = true;
            dataGridProducts.Columns[13].Visible = true;
            dataGridProducts.Columns[10].Visible = true;
            checkBoxProductName.Checked = true;
        }
        private void checkBoxProductName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxProductName.Checked)
            {
                dataGridProducts.Columns[10].Visible = true;
            }
            else
            {
                dataGridProducts.Columns[10].Visible = false;
            }
        }
        private void checkBoxWorkDescription_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxWorkDescription.Checked)
            {
                dataGridProducts.Columns[1].Visible = true;
            }
            else
            {
                dataGridProducts.Columns[1].Visible = false;
            }
        }
        private void checkBoxSale_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSale.Checked)
            {
                dataGridProducts.Columns[11].Visible = true;
            }
            else
            {
                dataGridProducts.Columns[11].Visible = false;
            }
        }
        private void checkBoxNumberOfEmployees_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNumberOfEmployees.Checked)
            {
                dataGridProducts.Columns[2].Visible = true;
            }
            else
            {
                dataGridProducts.Columns[2].Visible = false;
            }
        }
        private void checkBoxContactPerson_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxContactPerson.Checked)
            {
                dataGridProducts.Columns[3].Visible = true;
                dataGridProducts.Columns[4].Visible = true;
            }
            else
            {
                dataGridProducts.Columns[3].Visible = false;
                dataGridProducts.Columns[4].Visible = false;
            }
        }
        private void checkBoxstatuses_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxstatuses.Checked)
            {
                dataGridProducts.Columns[5].Visible = true;
                dataGridProducts.Columns[6].Visible = true;
                dataGridProducts.Columns[7].Visible = true;
                dataGridProducts.Columns[8].Visible = true;
            }
            else
            {
                dataGridProducts.Columns[5].Visible = false;
                dataGridProducts.Columns[6].Visible = false;
                dataGridProducts.Columns[7].Visible = false;
                dataGridProducts.Columns[8].Visible = false;
            }
        }
        private void checkBoxNotes_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNotes.Checked)
            {
                dataGridProducts.Columns[9].Visible = true;
            }
            else
            {
                dataGridProducts.Columns[9].Visible = false;
            }
        }
        private void checkBoxCustomerName_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCustomerName.Checked)
            {
                dataGridProducts.Columns[0].Visible = true;
            }
            else
            {
                dataGridProducts.Columns[0].Visible = false;
            }
        }
        private void checkBoxRent_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRent.Checked)
            {
                dataGridProducts.Columns[12].Visible = true;
            }
            else
            {
                dataGridProducts.Columns[12].Visible = false;
            }
        }
        private void checkBoxDateOfContract_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDateOfContract.Checked)
            {
                dataGridProducts.Columns[14].Visible = true;
            }
            else
            {
                dataGridProducts.Columns[14].Visible = false;
            }
        }
        private void checkBoxContractDuration_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxContractDuration.Checked)
            {
                dataGridProducts.Columns[13].Visible = true;
            }
            else
            {
                dataGridProducts.Columns[13].Visible = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var products = DBHandler.getProductsByDate(dateTimePickerFrom.Value, dateTimePickerTo.Value);
            dataGridProducts.Rows.Clear();
            DataGrid dg = new DataGrid();
            foreach (var item in products)
            {
                if (item.ProductName != "")
                    this.dataGridProducts.Rows.Add(item.CustomerID.CustomerName, item.CustomerID.WorkDescription, item.CustomerID.NumberOfEmployees, item.CustomerID.ContactPerson, item.CustomerID.PhoneNumber, item.CustomerID.Called, item.CustomerID.Waiting, item.CustomerID.Contract, item.CustomerID.Done, item.CustomerID.Notes, item.ProductName, item.SaleIncome, item.RentIncome, item.ContractDuration, item.DateOfContract);
            }
        }
        private void ShowProfitsOfCurrentProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                var allGridProducts = new List<Product>();
                float TotalRentIncome = 0;
                float TotalSaleIncome = 0;
                float MonthlyRentIncome = 0;
                for (int i = 0; i < dataGridProducts.Rows.Count; i++)
                {
                    Product p = new Product();
                    int.TryParse(Convert.ToString(dataGridProducts.Rows[i].Cells[0].Value), out p.ProductID);
                    p.ProductName = dataGridProducts.Rows[i].Cells[10].Value.ToString();

                    int.TryParse(Convert.ToString(dataGridProducts.Rows[i].Cells[13].Value), out p.ContractDuration);
                    int.TryParse(Convert.ToString(dataGridProducts.Rows[i].Cells[11].Value), out p.SaleIncome);
                    int.TryParse(Convert.ToString(dataGridProducts.Rows[i].Cells[12].Value), out p.RentIncome);

                    allGridProducts.Add(p);
                }
                foreach (var item in allGridProducts)
                {
                    if (item.SaleIncome > 0)
                    {
                        TotalSaleIncome += item.SaleIncome;
                    }
                }
                foreach (var item in allGridProducts)
                {
                    MonthlyRentIncome += item.RentIncome;
                }
                foreach (var item in allGridProducts)
                {
                    var temp = item.RentIncome * item.ContractDuration;
                    TotalRentIncome += temp;
                }
                MessageBox.Show("============ Product statistics ============" + Environment.NewLine +
                    "Total sale income of products from the list is  " + TotalSaleIncome + ",00 KM " + Environment.NewLine +
                    "Monthly rent income of products from the list is " + MonthlyRentIncome + ",00KM " + Environment.NewLine +
                    "Total income of renting the products from the list is " + TotalRentIncome + ",00KM");
            }      
        }
        private void dataGridProducts_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            contextMenuStrip1.Show(Cursor.Position);
        }
    }
}
