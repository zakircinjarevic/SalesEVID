using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesEVID
{
    public class Customer
    {
        public int CustomerID;
        public string CustomerName;
        public string WorkDescription;
        public int NumberOfEmployees;
        public string ContactPerson;
        public string PhoneNumber;
        public bool Called;
        public bool Waiting;
        public bool Contract;
        public bool Done;
        public string Notes;

        public Customer()
        {
            CustomerID=-1;
            CustomerName=string.Empty;
            WorkDescription=string.Empty;
            NumberOfEmployees=-1;
            Called=false;
            Waiting=false;
            Contract=false;
            Done=false;
            Notes=string.Empty;
            PhoneNumber=string.Empty;
            ContactPerson = string.Empty;
        }
        public Customer( int CompanyID = -1,
           string CustomerName = "",
           string WorkDescription = "",
           int NumberOfEmployees = -1,
           bool Called = false,
           bool Waiting = false,
           bool Contract = false,
           bool Done = false,
           string Notes = "",
            string ContactPerson = "",
           string PhoneNumber = "")
        {
            this.CustomerID= CompanyID;
            this.Notes = Notes;
            this.CustomerName = CustomerName;
            this.WorkDescription = WorkDescription;
            this.PhoneNumber = PhoneNumber;
            this.NumberOfEmployees = NumberOfEmployees;
            this.Called = Called;
            this.Waiting = Waiting;
            this.Contract = Contract;
            this.Done = Done;
            this.ContactPerson = ContactPerson;
        }
	}
}
