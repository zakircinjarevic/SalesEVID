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
    public partial class AddEdit_Product : Form
    {
        Customer currentCustomer = new Customer();
        public AddEdit_Product(Customer f,Product p)
        {
            InitializeComponent();
            txtId.Visible = false;
            currentCustomer = f;
            p.CustomerID = f;
            if (p.ProductID == -1)
            {
                //adding
                txtContractDuration.Text = "";
                txtId.Text = "-1";
                txtSale.Text = "0";
                txtRent.Text = "0";
                txtProduct.Text = "";
                radioBtnRent.Checked = true;
            }
            else
            {
                //editing
                txtContractDuration.Text = p.ContractDuration.ToString();
                txtId.Text = p.ProductID.ToString();
                txtSale.Text = p.SaleIncome.ToString();
                txtRent.Text = p.RentIncome.ToString();
                txtProduct.Text = p.ProductName.ToString();
                if (p.Sale == true) radioBtnSale.Checked = true;
                else radioBtnSale.Checked = false;
                if (p.Rent == true) radioBtnRent.Checked = true;
                else radioBtnRent.Checked = false;
            }
              
        }
        private void btnSave_Click(object sender, EventArgs e)
        {        
            var p = new Product();
            p.ProductName = txtProduct.Text;
            if (radioBtnRent.Checked) p.Rent = true;
            else p.Sale = true;
            p.CustomerID = currentCustomer;
            int.TryParse(txtId.Text, out p.ProductID);
            int.TryParse(txtSale.Text, out p.SaleIncome);
            int.TryParse(txtRent.Text, out p.RentIncome);
            int.TryParse(txtContractDuration.Text, out p.ContractDuration);
            p.DateOfContract = DateTime.Now;
            DBHandler.setProduct(p);
            Close();
        }
        private void radioBtnSale_CheckedChanged(object sender, EventArgs e)
        {
            txtRent.Enabled = false;
            txtContractDuration.Enabled = false;
            txtSale.Enabled = true;
        }
        private void radioBtnRent_CheckedChanged(object sender, EventArgs e)
        {
            txtRent.Enabled = true;
            txtSale.Enabled = false;
            txtContractDuration.Enabled = true;
        }

        private void AddEdit_Product_Load(object sender, EventArgs e)
        {

        }
    }
}