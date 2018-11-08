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
    public partial class ProductList : Form
    {
        bool specific = false;
        public List<Product> proizvodi = new List<Product>();
        public Customer selectedfirma = new Customer();
        public ProductList()
        {
            InitializeComponent();
            PopulateProizvodList(-1);
        }
        public ProductList(Customer f)
        {
            selectedfirma = f;
            InitializeComponent();
            specific = true;
            PopulateProizvodList(f.CustomerID);
        }
        private void PopulateProizvodList(int id)
        {
            this.dataGridProducts.Rows.Clear();
            proizvodi = id <= 0 ? DBHandler.getProducts() : DBHandler.getProducts().FindAll(i => i.CustomerID.CustomerID == id);
            DataGrid dg = new DataGrid();
            var firme = DBHandler.getCustomers();
            foreach (var item in proizvodi)
            {
                if (item.ProductName != "")
                {
                     dataGridProducts.Rows.Add(item.ProductID,item.CustomerID.CustomerName, item.ProductName, item.Sale, item.Rent, item.ContractDuration, item.SaleIncome, item.RentIncome,item.DateOfContract.ToShortDateString());
                }               
            }
            if (id == -1)
            {
                
            }
        }
        private void AddFirmu()
        {
            AddEdit_Product proizvodi = new AddEdit_Product(selectedfirma,new Product());
            proizvodi.ShowDialog();
            PopulateProizvodList(-1);
        }
        private void EditProizvod()
        {
            if (dataGridProducts.SelectedRows.Count == 0)
                return;
            Product p = new Product();
            p.CustomerID = selectedfirma;
            int.TryParse(Convert.ToString(dataGridProducts.SelectedRows[0].Cells[0].Value), out p.ProductID);
            p.ProductName = dataGridProducts.SelectedRows[0].Cells[2].Value.ToString();
            p.Sale = bool.Parse(dataGridProducts.SelectedRows[0].Cells[3].Value.ToString());
            p.Rent = bool.Parse(dataGridProducts.SelectedRows[0].Cells[4].Value.ToString());
            int.TryParse(Convert.ToString(dataGridProducts.SelectedRows[0].Cells[5].Value), out p.ContractDuration);
            int.TryParse(Convert.ToString(dataGridProducts.SelectedRows[0].Cells[6].Value), out p.SaleIncome);
            int.TryParse(Convert.ToString(dataGridProducts.SelectedRows[0].Cells[7].Value), out p.RentIncome);
            p.DateOfContract = Convert.ToDateTime(dataGridProducts.SelectedRows[0].Cells[8].Value);
            AddEdit_Product dlg = new AddEdit_Product(selectedfirma,p);
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (specific)
                    PopulateProizvodList(selectedfirma.CustomerID);
                else PopulateProizvodList(-1);
            }
        }
        private void osvježiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (specific)
                PopulateProizvodList(selectedfirma.CustomerID);
            else PopulateProizvodList(-1);
        }
        private void izmjeniProizvodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditProizvod();
            if (specific)
                PopulateProizvodList(selectedfirma.CustomerID);
            else PopulateProizvodList(-1);
        }
        private void dodajProizvodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEdit_Product frm = new AddEdit_Product(selectedfirma,new Product());
            frm.ShowDialog();
            if (specific)
                PopulateProizvodList(selectedfirma.CustomerID);
            else PopulateProizvodList(-1);
        }
        private void listView_Firme_MouseUp(object sender, MouseEventArgs e)
        {
            
        }
        private void ProizvodList_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridProizvodi_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridProizvodi_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            contextMenuProizvodi.Show(Cursor.Position);
        }
        void DeleteProizvod()
        {
            if (dataGridProducts.SelectedRows.Count == 0)
                return;

            Product p = new Product();
            p.CustomerID = selectedfirma;
            int.TryParse(Convert.ToString(dataGridProducts.SelectedRows[0].Cells[0].Value), out p.ProductID);
            p.ProductName = dataGridProducts.SelectedRows[0].Cells[2].Value.ToString();
            p.Sale = bool.Parse(dataGridProducts.SelectedRows[0].Cells[3].Value.ToString());
            p.Rent = bool.Parse(dataGridProducts.SelectedRows[0].Cells[4].Value.ToString());
            int.TryParse(Convert.ToString(dataGridProducts.SelectedRows[0].Cells[5].Value), out p.ContractDuration);
            int.TryParse(Convert.ToString(dataGridProducts.SelectedRows[0].Cells[6].Value), out p.SaleIncome);
            int.TryParse(Convert.ToString(dataGridProducts.SelectedRows[0].Cells[7].Value), out p.RentIncome);
            p.DateOfContract = Convert.ToDateTime(dataGridProducts.SelectedRows[0].Cells[8].Value);

            if (MessageBox.Show(this, "da li želite obrisati odabranu firmu (" + p.ProductName + ") ?", "Brisanje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;

            DBHandler.delProduct(p.ProductID);
            if (specific)
                PopulateProizvodList(selectedfirma.CustomerID);
            else PopulateProizvodList(-1);
        }
        private void ukloniProizvodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteProizvod();
        }

        private void prikažiMjesečniProfitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var allproductsinthegrid = new List<Product>();
            float TotalRentIncome = 0;
            float TotalSaleIncome = 0;
            float MonthlyRentIncome = 0;
            for (int i = 0; i < dataGridProducts.Rows.Count; i++)
            {
                Product p = new Product();
                p.CustomerID = selectedfirma;
                int.TryParse(Convert.ToString(dataGridProducts.Rows[i].Cells[0].Value), out p.ProductID);
                p.ProductName = dataGridProducts.Rows[i].Cells[2].Value.ToString();
                p.Sale = bool.Parse(dataGridProducts.Rows[i].Cells[3].Value.ToString());
                p.Rent = bool.Parse(dataGridProducts.Rows[i].Cells[4].Value.ToString());
                int.TryParse(Convert.ToString(dataGridProducts.Rows[i].Cells[5].Value), out p.ContractDuration);
                int.TryParse(Convert.ToString(dataGridProducts.Rows[i].Cells[6].Value), out p.SaleIncome);
                int.TryParse(Convert.ToString(dataGridProducts.Rows[i].Cells[7].Value), out p.RentIncome);
                p.DateOfContract = Convert.ToDateTime(dataGridProducts.SelectedRows[0].Cells[8].Value);
                allproductsinthegrid.Add(p);
            }
            foreach (var item in allproductsinthegrid)
            {
                if (item.SaleIncome > 0)
                {
                    TotalSaleIncome += item.SaleIncome;
                }
            }
            foreach (var item in allproductsinthegrid)
            {
                MonthlyRentIncome += item.RentIncome; 
            }
            foreach (var item in allproductsinthegrid)
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
}
