using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Specialized;
using System.Drawing;
using SalesEVID;

namespace Main
{
    public class DBHandler
    {
        public static List<Customer> getCustomers()
        {
            if (!DBConnection.isConnected)
                DBConnection.DBConnect();

            List<Customer> Customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    SqlDataReader MyDataReader = null;

                    try
                    {
                        conn.ConnectionString = DBConnection.connectionMain.ConnectionString;
                        com.Connection = conn;
                        conn.Open();

                        com.CommandText = " SELECT * FROM Customer";

                        MyDataReader = com.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            Customer customer = new Customer();
                            int.TryParse(Convert.ToString(MyDataReader["CustomerID"]), out customer.CustomerID);
                            customer.PhoneNumber = Convert.ToString(MyDataReader["PhoneNumber"]);
                            customer.NumberOfEmployees = Convert.ToInt32(MyDataReader["NumberOfEmployees"]);
                            customer.CustomerName = Convert.ToString(MyDataReader["CustomerName"]);
                            customer.WorkDescription = Convert.ToString(MyDataReader["WorkDescription"]);
                            customer.Called = Convert.ToBoolean(MyDataReader["Called"]);
                            customer.Waiting = Convert.ToBoolean(MyDataReader["Waiting"]);
                            customer.Contract = Convert.ToBoolean(MyDataReader["Contract"]);
                            customer.Done = Convert.ToBoolean(MyDataReader["Done"]);
                            customer.Notes = Convert.ToString(MyDataReader["Notes"]);
                            customer.ContactPerson = Convert.ToString(MyDataReader["ContactPerson"]);
                            Customers.Add(customer);

                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error(com.CommandText);
                        Log.Error(ex.Message);
                    }
                    finally
                    {
                        try
                        {
                            MyDataReader.Close();
                            conn.Close();
                            MyDataReader.Dispose();
                            conn.Dispose();
                            SqlConnection.ClearPool(conn);
                        }
                        catch (Exception ex)
                        {
                            Log.Error(com.CommandText);
                            Log.Error(ex.Message);
                        }
                    }
                }
            }
            return Customers;
        }
        public static List<User> getUsers()
        {
            if (!DBConnection.isConnected)
                DBConnection.DBConnect();

            List<User> Users = new List<User>();
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    SqlDataReader MyDataReader = null;

                    try
                    {
                        conn.ConnectionString = DBConnection.connectionMain.ConnectionString;
                        com.Connection = conn;
                        conn.Open();

                        com.CommandText = " SELECT * FROM Logins";

                        MyDataReader = com.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            User User = new User();
                            int.TryParse(Convert.ToString(MyDataReader["UserID"]), out User.UserID);
                            User.Password = Convert.ToString(MyDataReader["Password"]);
                            User.Username = Convert.ToString(MyDataReader["Username"]);
                            User.FullName = Convert.ToString(MyDataReader["FullName"]);
                            Users.Add(User);
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error(com.CommandText);
                        Log.Error(ex.Message);
                    }
                    finally
                    {
                        try
                        {
                            MyDataReader.Close();
                            conn.Close();
                            MyDataReader.Dispose();
                            conn.Dispose();
                            SqlConnection.ClearPool(conn);
                        }
                        catch (Exception ex)
                        {
                            Log.Error(com.CommandText);
                            Log.Error(ex.Message);
                        }
                    }
                }
            }
            return Users;
        }
        public static void setUser(User u)
        {
            if (!DBConnection.isConnected) DBConnection.DBConnect();

            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    string query = string.Empty;
                    if (u.UserID < 0)
                    {
                        query = string.Format("INSERT INTO [Logins] ([Username], [Password],[FullName] VALUES (N'{0}',N'{1}',N'{2}')", u.Username, u.Password, u.FullName);
                    }
                    else
                    {
                        query = string.Format("UPDATE [Logins] SET Username='{0}', Password='{1}', FullName'{2}' WHERE UserID = {3}", u.Username, u.Password, u.FullName, u.UserID);
                    }
                    try
                    {
                        conn.ConnectionString = DBConnection.connectionMain.ConnectionString;
                        com.Connection = conn;
                        conn.Open();
                        com.CommandText = query;
                        com.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Log.Error(com.CommandText);
                        Log.Error(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        conn.Dispose();
                        SqlConnection.ClearPool(conn);
                    }
                }
            }
        }
        public static List<Product> getProducts()
        {
            if (!DBConnection.isConnected)
                DBConnection.DBConnect();

            List<Product> products = new List<Product>();
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    SqlDataReader MyDataReader = null;

                    try
                    {
                        conn.ConnectionString = DBConnection.connectionMain.ConnectionString;
                        com.Connection = conn;
                        conn.Open();

                        com.CommandText = " SELECT Customer.CustomerID, CustomerName, WorkDescription, NumberOfEmployees, ContactPerson,PhoneNumber, Called, Waiting, Contract, Done, Notes, ProductID,ProductName,Sale,Rent,ContractDuration,DateOfContract,SaleIncome,RentIncome" +
                    " FROM Products inner join Customer on Customer.CustomerID = Products.CustomerID";

                        MyDataReader = com.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            Customer cstmr = new Customer();
                            int.TryParse(Convert.ToString(MyDataReader["CustomerID"]), out cstmr.CustomerID);
                            cstmr.PhoneNumber = Convert.ToString(MyDataReader["PhoneNumber"]);
                            cstmr.NumberOfEmployees = Convert.ToInt32(MyDataReader["NumberOfEmployees"]);
                            cstmr.CustomerName = Convert.ToString(MyDataReader["CustomerName"]);
                            cstmr.WorkDescription = Convert.ToString(MyDataReader["WorkDescription"]);
                            cstmr.Called = Convert.ToBoolean(MyDataReader["Called"]);
                            cstmr.Waiting = Convert.ToBoolean(MyDataReader["Waiting"]);
                            cstmr.Contract = Convert.ToBoolean(MyDataReader["Contract"]);
                            cstmr.Done = Convert.ToBoolean(MyDataReader["Done"]);
                            cstmr.Notes = Convert.ToString(MyDataReader["Notes"]);
                            cstmr.ContactPerson = Convert.ToString(MyDataReader["ContactPerson"]);

                            Product product = new Product();
                            int.TryParse(Convert.ToString(MyDataReader["ProductID"]), out product.ProductID);
                            product.ProductName = Convert.ToString(MyDataReader["ProductName"]);
                            product.Sale = Convert.ToBoolean(MyDataReader["Sale"]);
                            product.Rent = Convert.ToBoolean(MyDataReader["Rent"]);
                            int.TryParse(Convert.ToString(MyDataReader["ContractDuration"]), out product.ContractDuration);
                            int.TryParse(Convert.ToString(MyDataReader["RentIncome"]), out product.RentIncome);
                            int.TryParse(Convert.ToString(MyDataReader["SaleIncome"]), out product.SaleIncome);
                            product.DateOfContract = Convert.ToDateTime(MyDataReader["DateOfContract"]);
                            product.CustomerID = cstmr;
                            products.Add(product);
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error(com.CommandText);
                        Log.Error(ex.Message);
                    }
                    finally
                    {
                        try
                        {
                            MyDataReader.Close();
                            conn.Close();
                            MyDataReader.Dispose();
                            conn.Dispose();
                            SqlConnection.ClearPool(conn);
                        }
                        catch (Exception ex)
                        {
                            Log.Error(com.CommandText);
                            Log.Error(ex.Message);
                        }
                    }
                }
            }
            return products;
        }
        public static void setCustomer(Customer f)
        {
            if (!DBConnection.isConnected) DBConnection.DBConnect();

            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    string query = string.Empty;
                    if (f.CustomerID < 0)
                    {
                        query = string.Format("INSERT INTO [Customer] ([CustomerName], [WorkDescription], [NumberOfEmployees], [ContactPerson], [PhoneNumber], [Called], [Waiting], [Contract], [Done], [Notes]) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')",
                                                                     f.CustomerName, f.WorkDescription, f.NumberOfEmployees,f.ContactPerson ,f.PhoneNumber, f.Called, f.Waiting, f.Contract, f.Done, f.Notes);
                    }
                    else
                    {
                        query = string.Format("UPDATE [Customer] SET CustomerName='{0}', WorkDescription='{1}', NumberOfEmployees='{2}', ContactPerson='{3}', PhoneNumber='{4}', Called='{5}', Waiting='{6}', Contract='{7}', Done='{8}', Notes='{9}' WHERE CustomerID = {10}",
                                                                 f.CustomerName, f.WorkDescription, f.NumberOfEmployees, f.ContactPerson, f.PhoneNumber, f.Called, f.Waiting, f.Contract, f.Done,f.Notes, f.CustomerID);
                    }
                    try
                    {
                        conn.ConnectionString = DBConnection.connectionMain.ConnectionString;
                        com.Connection = conn;
                        conn.Open();
                        com.CommandText = query;
                        com.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Log.Error(com.CommandText);
                        Log.Error(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        conn.Dispose();
                        SqlConnection.ClearPool(conn);
                    }
                }
            }
        }
        public static void setProduct(Product p)
        {
            if (!DBConnection.isConnected) DBConnection.DBConnect();

            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    string query = string.Empty;
                    if (p.ProductID < 0)
                    {
                        query = string.Format("INSERT INTO [Products] ([ProductName], [Sale], [Rent],[ContractDuration], [SaleIncome],[RentIncome],[CustomerID],[DateOfContract]) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",
                                                                     p.ProductName, p.Sale, p.Rent, p.ContractDuration, p.SaleIncome, p.RentIncome, p.CustomerID.CustomerID, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
                    }
                    else
                    {
                        query = string.Format("UPDATE [Products] SET ProductName='{0}', Sale='{1}', Rent='{2}',ContractDuration='{3}', SaleIncome='{4}', RentIncome='{5}', DateOfContract='{8}', CustomerID='{6}' WHERE ProductID = {7}",
                                                                 p.ProductName, p.Sale, p.Rent,p.ContractDuration, p.SaleIncome, p.RentIncome, p.CustomerID.CustomerID, p.ProductID,p.DateOfContract.ToString("yyyy-MM-dd hh:mm:ss"));
                    }

                    try
                    {
                        conn.ConnectionString = DBConnection.connectionMain.ConnectionString;
                        com.Connection = conn;
                        conn.Open();
                        com.CommandText = query;
                        com.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Log.Error(com.CommandText);
                        Log.Error(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        conn.Dispose();
                        SqlConnection.ClearPool(conn);
                    }
                }
            }
        } // not sure
        public static void delProduct(int ProductID)
        {
            if (!DBConnection.isConnected) DBConnection.DBConnect();

            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    string query = string.Empty;
                    if (ProductID < 0) return;

                    query = "DELETE FROM Products WHERE ProductID = " + ProductID;

                    try
                    {
                        conn.ConnectionString = DBConnection.connectionMain.ConnectionString;
                        com.Connection = conn;
                        conn.Open();
                        com.CommandText = query;
                        com.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Log.Error(com.CommandText);
                        Log.Error(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        conn.Dispose();
                        SqlConnection.ClearPool(conn);
                    }
                }
            }
        }
        public static void delCustomer(int CustomerID)
        {
            if (!DBConnection.isConnected) DBConnection.DBConnect();

            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    string query = string.Empty;
                    if (CustomerID < 0) return;

                    query = "DELETE FROM Customer WHERE CustomerID = " + CustomerID;

                    try
                    {
                        conn.ConnectionString = DBConnection.connectionMain.ConnectionString;
                        com.Connection = conn;
                        conn.Open();
                        com.CommandText = query;
                        com.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Log.Error(com.CommandText);
                        Log.Error(ex.Message);
                    }
                    finally
                    {
                        conn.Close();
                        conn.Dispose();
                        SqlConnection.ClearPool(conn);
                    }
                }
            }
        }

        public static List<Product> getProductsByDate(DateTime start, DateTime end)
        {
            if (!DBConnection.isConnected)
                DBConnection.DBConnect();

            List<Product> Proizvodi = new List<Product>();
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    SqlDataReader MyDataReader = null;

                    try
                    {
                        conn.ConnectionString = DBConnection.connectionMain.ConnectionString;
                        com.Connection = conn;
                        conn.Open();

                        com.CommandText = " SELECT Customer.CustomerID, CustomerName, WorkDescription, NumberOfEmployees, ContactPerson,PhoneNumber, Called, Waiting, Contract, Done, Notes, ProductID,ProductName,Sale,Rent,ContractDuration,DateOfContract,SaleIncome,RentIncome" +
                    " FROM Products inner join Customer on Customer.CustomerID = Product.CustomerID WHERE DateOfContract between '" + start.ToString("yyyy-MM-dd hh:mm:ss") + "' and '" + end.ToString("yyyy-MM-dd hh:mm:ss")+"'";

                        MyDataReader = com.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            Customer cstmr = new Customer();
                            int.TryParse(Convert.ToString(MyDataReader["CustomerID"]), out cstmr.CustomerID);
                            cstmr.PhoneNumber = Convert.ToString(MyDataReader["PhoneNumber"]);
                            cstmr.NumberOfEmployees = Convert.ToInt32(MyDataReader["NumberOfEmployees"]);
                            cstmr.CustomerName = Convert.ToString(MyDataReader["CustomerName"]);
                            cstmr.WorkDescription = Convert.ToString(MyDataReader["WorkDescription"]);
                            cstmr.Called = Convert.ToBoolean(MyDataReader["Called"]);
                            cstmr.Waiting = Convert.ToBoolean(MyDataReader["Waiting"]);
                            cstmr.Contract = Convert.ToBoolean(MyDataReader["Contract"]);
                            cstmr.Done = Convert.ToBoolean(MyDataReader["Done"]);
                            cstmr.Notes = Convert.ToString(MyDataReader["Notes"]);
                            cstmr.ContactPerson = Convert.ToString(MyDataReader["ContactPerson"]);

                            Product product = new Product();
                            int.TryParse(Convert.ToString(MyDataReader["ProductID"]), out product.ProductID);
                            product.ProductName = Convert.ToString(MyDataReader["ProductName"]);
                            product.Sale = Convert.ToBoolean(MyDataReader["Sale"]);
                            product.Rent = Convert.ToBoolean(MyDataReader["Rent"]);
                            int.TryParse(Convert.ToString(MyDataReader["ContractDuration"]), out product.ContractDuration);
                            int.TryParse(Convert.ToString(MyDataReader["RentIncome"]), out product.RentIncome);
                            int.TryParse(Convert.ToString(MyDataReader["SaleIncome"]), out product.SaleIncome);
                            product.DateOfContract = Convert.ToDateTime(MyDataReader["DateOfContract"]);
                            product.CustomerID = cstmr;
                            Proizvodi.Add(product);
                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error(com.CommandText);
                        Log.Error(ex.Message);
                    }
                    finally
                    {
                        try
                        {
                            MyDataReader.Close();
                            conn.Close();
                            MyDataReader.Dispose();
                            conn.Dispose();
                            SqlConnection.ClearPool(conn);
                        }
                        catch (Exception ex)
                        {
                            Log.Error(com.CommandText);
                            Log.Error(ex.Message);
                        }
                    }
                }
            }
            return Proizvodi;
        }
        public static List<Customer> getCustomersByName(string name)
        {
            if (!DBConnection.isConnected)
                DBConnection.DBConnect();

            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    SqlDataReader MyDataReader = null;

                    try
                    {
                        conn.ConnectionString = DBConnection.connectionMain.ConnectionString;
                        com.Connection = conn;
                        conn.Open();

                        com.CommandText = " SELECT * FROM Customer WHERE CustomerName LIKE '%"+ name+"%'";

                        MyDataReader = com.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            Customer cstmr = new Customer();
                            int.TryParse(Convert.ToString(MyDataReader["CustomerID"]), out cstmr.CustomerID);
                            cstmr.PhoneNumber = Convert.ToString(MyDataReader["PhoneNumber"]);
                            cstmr.NumberOfEmployees = Convert.ToInt32(MyDataReader["NumberOfEmployees"]);
                            cstmr.CustomerName = Convert.ToString(MyDataReader["CustomerName"]);
                            cstmr.WorkDescription = Convert.ToString(MyDataReader["WorkDescription"]);
                            cstmr.Called = Convert.ToBoolean(MyDataReader["Called"]);
                            cstmr.Waiting = Convert.ToBoolean(MyDataReader["Waiting"]);
                            cstmr.Contract = Convert.ToBoolean(MyDataReader["Contract"]);
                            cstmr.Done = Convert.ToBoolean(MyDataReader["Done"]);
                            cstmr.Notes = Convert.ToString(MyDataReader["Notes"]);
                            cstmr.ContactPerson = Convert.ToString(MyDataReader["ContactPerson"]);
                            customers.Add(cstmr);

                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error(com.CommandText);
                        Log.Error(ex.Message);
                    }
                    finally
                    {
                        try
                        {
                            MyDataReader.Close();
                            conn.Close();
                            MyDataReader.Dispose();
                            conn.Dispose();
                            SqlConnection.ClearPool(conn);
                        }
                        catch (Exception ex)
                        {
                            Log.Error(com.CommandText);
                            Log.Error(ex.Message);
                        }
                    }
                }
            }
            return customers;
        }
        public static List<Customer> getCustomersByDone()
        {
            if (!DBConnection.isConnected)
                DBConnection.DBConnect();

            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    SqlDataReader MyDataReader = null;

                    try
                    {
                        conn.ConnectionString = DBConnection.connectionMain.ConnectionString;
                        com.Connection = conn;
                        conn.Open();

                        com.CommandText = " SELECT * FROM Customer WHERE Done = 1";

                        MyDataReader = com.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            Customer cstmr = new Customer();
                            int.TryParse(Convert.ToString(MyDataReader["CustomerID"]), out cstmr.CustomerID);
                            cstmr.PhoneNumber = Convert.ToString(MyDataReader["PhoneNumber"]);
                            cstmr.NumberOfEmployees = Convert.ToInt32(MyDataReader["NumberOfEmployees"]);
                            cstmr.CustomerName = Convert.ToString(MyDataReader["CustomerName"]);
                            cstmr.WorkDescription = Convert.ToString(MyDataReader["WorkDescription"]);
                            cstmr.Called = Convert.ToBoolean(MyDataReader["Called"]);
                            cstmr.Waiting = Convert.ToBoolean(MyDataReader["Waiting"]);
                            cstmr.Contract = Convert.ToBoolean(MyDataReader["Contract"]);
                            cstmr.Done = Convert.ToBoolean(MyDataReader["Done"]);
                            cstmr.Notes = Convert.ToString(MyDataReader["Notes"]);
                            cstmr.ContactPerson = Convert.ToString(MyDataReader["ContactPerson"]);
                            customers.Add(cstmr);

                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error(com.CommandText);
                        Log.Error(ex.Message);
                    }
                    finally
                    {
                        try
                        {
                            MyDataReader.Close();
                            conn.Close();
                            MyDataReader.Dispose();
                            conn.Dispose();
                            SqlConnection.ClearPool(conn);
                        }
                        catch (Exception ex)
                        {
                            Log.Error(com.CommandText);
                            Log.Error(ex.Message);
                        }
                    }
                }
            }
            return customers;
        }

        public static List<Customer> getCustomersByActive()
        {
            if (!DBConnection.isConnected)
                DBConnection.DBConnect();

            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    SqlDataReader MyDataReader = null;

                    try
                    {
                        conn.ConnectionString = DBConnection.connectionMain.ConnectionString;
                        com.Connection = conn;
                        conn.Open();

                        com.CommandText = " SELECT * FROM Customer WHERE Done = 0";

                        MyDataReader = com.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            Customer cstmr = new Customer();
                            int.TryParse(Convert.ToString(MyDataReader["CustomerID"]), out cstmr.CustomerID);
                            cstmr.PhoneNumber = Convert.ToString(MyDataReader["PhoneNumber"]);
                            cstmr.NumberOfEmployees = Convert.ToInt32(MyDataReader["NumberOfEmployees"]);
                            cstmr.CustomerName = Convert.ToString(MyDataReader["CustomerName"]);
                            cstmr.WorkDescription = Convert.ToString(MyDataReader["WorkDescription"]);
                            cstmr.Called = Convert.ToBoolean(MyDataReader["Called"]);
                            cstmr.Waiting = Convert.ToBoolean(MyDataReader["Waiting"]);
                            cstmr.Contract = Convert.ToBoolean(MyDataReader["Contract"]);
                            cstmr.Done = Convert.ToBoolean(MyDataReader["Done"]);
                            cstmr.Notes = Convert.ToString(MyDataReader["Notes"]);
                            cstmr.ContactPerson = Convert.ToString(MyDataReader["ContactPerson"]);
                            customers.Add(cstmr);

                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error(com.CommandText);
                        Log.Error(ex.Message);
                    }
                    finally
                    {
                        try
                        {
                            MyDataReader.Close();
                            conn.Close();
                            MyDataReader.Dispose();
                            conn.Dispose();
                            SqlConnection.ClearPool(conn);
                        }
                        catch (Exception ex)
                        {
                            Log.Error(com.CommandText);
                            Log.Error(ex.Message);
                        }
                    }
                }
            }
            return customers;
        }

        public static List<Customer> getCustomersByCalled()
        {
            if (!DBConnection.isConnected)
                DBConnection.DBConnect();

            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    SqlDataReader MyDataReader = null;

                    try
                    {
                        conn.ConnectionString = DBConnection.connectionMain.ConnectionString;
                        com.Connection = conn;
                        conn.Open();

                        com.CommandText = " SELECT * FROM Customer WHERE Called = 1";

                        MyDataReader = com.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            Customer cstmr = new Customer();
                            int.TryParse(Convert.ToString(MyDataReader["CustomerID"]), out cstmr.CustomerID);
                            cstmr.PhoneNumber = Convert.ToString(MyDataReader["PhoneNumber"]);
                            cstmr.NumberOfEmployees = Convert.ToInt32(MyDataReader["NumberOfEmployees"]);
                            cstmr.CustomerName = Convert.ToString(MyDataReader["CustomerName"]);
                            cstmr.WorkDescription = Convert.ToString(MyDataReader["WorkDescription"]);
                            cstmr.Called = Convert.ToBoolean(MyDataReader["Called"]);
                            cstmr.Waiting = Convert.ToBoolean(MyDataReader["Waiting"]);
                            cstmr.Contract = Convert.ToBoolean(MyDataReader["Contract"]);
                            cstmr.Done = Convert.ToBoolean(MyDataReader["Done"]);
                            cstmr.Notes = Convert.ToString(MyDataReader["Notes"]);
                            cstmr.ContactPerson = Convert.ToString(MyDataReader["ContactPerson"]);
                            customers.Add(cstmr);

                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error(com.CommandText);
                        Log.Error(ex.Message);
                    }
                    finally
                    {
                        try
                        {
                            MyDataReader.Close();
                            conn.Close();
                            MyDataReader.Dispose();
                            conn.Dispose();
                            SqlConnection.ClearPool(conn);
                        }
                        catch (Exception ex)
                        {
                            Log.Error(com.CommandText);
                            Log.Error(ex.Message);
                        }
                    }
                }
            }
            return customers;
        }
        public static List<Customer> getCustomersByNotCalled()
        {
            if (!DBConnection.isConnected)
                DBConnection.DBConnect();

            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    SqlDataReader MyDataReader = null;

                    try
                    {
                        conn.ConnectionString = DBConnection.connectionMain.ConnectionString;
                        com.Connection = conn;
                        conn.Open();

                        com.CommandText = " SELECT * FROM Customer WHERE Called = 0";

                        MyDataReader = com.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            Customer cstmr = new Customer();
                            int.TryParse(Convert.ToString(MyDataReader["CustomerID"]), out cstmr.CustomerID);
                            cstmr.PhoneNumber = Convert.ToString(MyDataReader["PhoneNumber"]);
                            cstmr.NumberOfEmployees = Convert.ToInt32(MyDataReader["NumberOfEmployees"]);
                            cstmr.CustomerName = Convert.ToString(MyDataReader["CustomerName"]);
                            cstmr.WorkDescription = Convert.ToString(MyDataReader["WorkDescription"]);
                            cstmr.Called = Convert.ToBoolean(MyDataReader["Called"]);
                            cstmr.Waiting = Convert.ToBoolean(MyDataReader["Waiting"]);
                            cstmr.Contract = Convert.ToBoolean(MyDataReader["Contract"]);
                            cstmr.Done = Convert.ToBoolean(MyDataReader["Done"]);
                            cstmr.Notes = Convert.ToString(MyDataReader["Notes"]);
                            cstmr.ContactPerson = Convert.ToString(MyDataReader["ContactPerson"]);
                            customers.Add(cstmr);

                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error(com.CommandText);
                        Log.Error(ex.Message);
                    }
                    finally
                    {
                        try
                        {
                            MyDataReader.Close();
                            conn.Close();
                            MyDataReader.Dispose();
                            conn.Dispose();
                            SqlConnection.ClearPool(conn);
                        }
                        catch (Exception ex)
                        {
                            Log.Error(com.CommandText);
                            Log.Error(ex.Message);
                        }
                    }
                }
            }
            return customers;
        }


        public static List<Customer> getCustomersByContract()
        {
            if (!DBConnection.isConnected)
                DBConnection.DBConnect();

            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    SqlDataReader MyDataReader = null;

                    try
                    {
                        conn.ConnectionString = DBConnection.connectionMain.ConnectionString;
                        com.Connection = conn;
                        conn.Open();

                        com.CommandText = " SELECT * FROM Customer WHERE Contract = 1";

                        MyDataReader = com.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            Customer cstmr = new Customer();
                            int.TryParse(Convert.ToString(MyDataReader["CustomerID"]), out cstmr.CustomerID);
                            cstmr.PhoneNumber = Convert.ToString(MyDataReader["PhoneNumber"]);
                            cstmr.NumberOfEmployees = Convert.ToInt32(MyDataReader["NumberOfEmployees"]);
                            cstmr.CustomerName = Convert.ToString(MyDataReader["CustomerName"]);
                            cstmr.WorkDescription = Convert.ToString(MyDataReader["WorkDescription"]);
                            cstmr.Called = Convert.ToBoolean(MyDataReader["Called"]);
                            cstmr.Waiting = Convert.ToBoolean(MyDataReader["Waiting"]);
                            cstmr.Contract = Convert.ToBoolean(MyDataReader["Contract"]);
                            cstmr.Done = Convert.ToBoolean(MyDataReader["Done"]);
                            cstmr.Notes = Convert.ToString(MyDataReader["Notes"]);
                            cstmr.ContactPerson = Convert.ToString(MyDataReader["ContactPerson"]);
                            customers.Add(cstmr);

                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error(com.CommandText);
                        Log.Error(ex.Message);
                    }
                    finally
                    {
                        try
                        {
                            MyDataReader.Close();
                            conn.Close();
                            MyDataReader.Dispose();
                            conn.Dispose();
                            SqlConnection.ClearPool(conn);
                        }
                        catch (Exception ex)
                        {
                            Log.Error(com.CommandText);
                            Log.Error(ex.Message);
                        }
                    }
                }
            }
            return customers;
        }
        public static List<Customer> getCustomersByNoContract()
        {
            if (!DBConnection.isConnected)
                DBConnection.DBConnect();

            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    SqlDataReader MyDataReader = null;

                    try
                    {
                        conn.ConnectionString = DBConnection.connectionMain.ConnectionString;
                        com.Connection = conn;
                        conn.Open();

                        com.CommandText = " SELECT * FROM Customer WHERE Contract = 0";

                        MyDataReader = com.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            Customer cstmr = new Customer();
                            int.TryParse(Convert.ToString(MyDataReader["CustomerID"]), out cstmr.CustomerID);
                            cstmr.PhoneNumber = Convert.ToString(MyDataReader["PhoneNumber"]);
                            cstmr.NumberOfEmployees = Convert.ToInt32(MyDataReader["NumberOfEmployees"]);
                            cstmr.CustomerName = Convert.ToString(MyDataReader["CustomerName"]);
                            cstmr.WorkDescription = Convert.ToString(MyDataReader["WorkDescription"]);
                            cstmr.Called = Convert.ToBoolean(MyDataReader["Called"]);
                            cstmr.Waiting = Convert.ToBoolean(MyDataReader["Waiting"]);
                            cstmr.Contract = Convert.ToBoolean(MyDataReader["Contract"]);
                            cstmr.Done = Convert.ToBoolean(MyDataReader["Done"]);
                            cstmr.Notes = Convert.ToString(MyDataReader["Notes"]);
                            cstmr.ContactPerson = Convert.ToString(MyDataReader["ContactPerson"]);
                            customers.Add(cstmr);

                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error(com.CommandText);
                        Log.Error(ex.Message);
                    }
                    finally
                    {
                        try
                        {
                            MyDataReader.Close();
                            conn.Close();
                            MyDataReader.Dispose();
                            conn.Dispose();
                            SqlConnection.ClearPool(conn);
                        }
                        catch (Exception ex)
                        {
                            Log.Error(com.CommandText);
                            Log.Error(ex.Message);
                        }
                    }
                }
            }
            return customers;
        }
        public static List<Customer> getCustomersByWaiting()
        {
            if (!DBConnection.isConnected)
                DBConnection.DBConnect();

            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    SqlDataReader MyDataReader = null;

                    try
                    {
                        conn.ConnectionString = DBConnection.connectionMain.ConnectionString;
                        com.Connection = conn;
                        conn.Open();

                        com.CommandText = " SELECT * FROM Customer WHERE Waiting = 1";

                        MyDataReader = com.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            Customer cstmr = new Customer();
                            int.TryParse(Convert.ToString(MyDataReader["CustomerID"]), out cstmr.CustomerID);
                            cstmr.PhoneNumber = Convert.ToString(MyDataReader["PhoneNumber"]);
                            cstmr.NumberOfEmployees = Convert.ToInt32(MyDataReader["NumberOfEmployees"]);
                            cstmr.CustomerName = Convert.ToString(MyDataReader["CustomerName"]);
                            cstmr.WorkDescription = Convert.ToString(MyDataReader["WorkDescription"]);
                            cstmr.Called = Convert.ToBoolean(MyDataReader["Called"]);
                            cstmr.Waiting = Convert.ToBoolean(MyDataReader["Waiting"]);
                            cstmr.Contract = Convert.ToBoolean(MyDataReader["Contract"]);
                            cstmr.Done = Convert.ToBoolean(MyDataReader["Done"]);
                            cstmr.Notes = Convert.ToString(MyDataReader["Notes"]);
                            cstmr.ContactPerson = Convert.ToString(MyDataReader["ContactPerson"]);
                            customers.Add(cstmr);

                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error(com.CommandText);
                        Log.Error(ex.Message);
                    }
                    finally
                    {
                        try
                        {
                            MyDataReader.Close();
                            conn.Close();
                            MyDataReader.Dispose();
                            conn.Dispose();
                            SqlConnection.ClearPool(conn);
                        }
                        catch (Exception ex)
                        {
                            Log.Error(com.CommandText);
                            Log.Error(ex.Message);
                        }
                    }
                }
            }
            return customers;
        }
        public static List<Customer> getCustomersByOngoing()
        {
            if (!DBConnection.isConnected)
                DBConnection.DBConnect();

            List<Customer> customers = new List<Customer>();
            using (SqlConnection conn = new SqlConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    SqlDataReader MyDataReader = null;

                    try
                    {
                        conn.ConnectionString = DBConnection.connectionMain.ConnectionString;
                        com.Connection = conn;
                        conn.Open();

                        com.CommandText = " SELECT * FROM Customer WHERE Waiting = 0";

                        MyDataReader = com.ExecuteReader();
                        while (MyDataReader.Read())
                        {
                            Customer cstmr = new Customer();
                            int.TryParse(Convert.ToString(MyDataReader["CustomerID"]), out cstmr.CustomerID);
                            cstmr.PhoneNumber = Convert.ToString(MyDataReader["PhoneNumber"]);
                            cstmr.NumberOfEmployees = Convert.ToInt32(MyDataReader["NumberOfEmployees"]);
                            cstmr.CustomerName = Convert.ToString(MyDataReader["CustomerName"]);
                            cstmr.WorkDescription = Convert.ToString(MyDataReader["WorkDescription"]);
                            cstmr.Called = Convert.ToBoolean(MyDataReader["Called"]);
                            cstmr.Waiting = Convert.ToBoolean(MyDataReader["Waiting"]);
                            cstmr.Contract = Convert.ToBoolean(MyDataReader["Contract"]);
                            cstmr.Done = Convert.ToBoolean(MyDataReader["Done"]);
                            cstmr.Notes = Convert.ToString(MyDataReader["Notes"]);
                            cstmr.ContactPerson = Convert.ToString(MyDataReader["ContactPerson"]);
                            customers.Add(cstmr);

                        }
                    }
                    catch (Exception ex)
                    {
                        Log.Error(com.CommandText);
                        Log.Error(ex.Message);
                    }
                    finally
                    {
                        try
                        {
                            MyDataReader.Close();
                            conn.Close();
                            MyDataReader.Dispose();
                            conn.Dispose();
                            SqlConnection.ClearPool(conn);
                        }
                        catch (Exception ex)
                        {
                            Log.Error(com.CommandText);
                            Log.Error(ex.Message);
                        }
                    }
                }
            }
            return customers;
        }//nezavrsene
    }
}