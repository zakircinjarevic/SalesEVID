using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesEVID
{
    public class Product
    {
        public int ProductID;
        public string ProductName;
        public bool Sale;
        public bool Rent;
        public int SaleIncome;
        public int RentIncome;
        public int ContractDuration;
        public Customer CustomerID;
        public DateTime DateOfContract;

        public Product()
        {
            ProductID = -1;
            ProductName = string.Empty;
            Sale = false;
            Rent = false;
            SaleIncome = 0;
            RentIncome = 0;
            CustomerID = null;
        }
        public Product(int ProductID = -1,
            string ProductName = "",
          bool Sale = false,
          bool Rent = false,
          int SaleIncome = -1,
          int RentIncome = -1,
          Customer CustomerID = null
        )
        {
            this.Sale = Sale;
            this.Rent = Rent;
            this.ProductID = ProductID;
            this.SaleIncome = SaleIncome;
            this.RentIncome = RentIncome;
            this.ProductName = ProductName;
            this.CustomerID = CustomerID;
        }
    }
}
