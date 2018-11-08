using SalesEVID;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Main
{
    public class DBConnection
    {
        public static String Err = "";
        public static String connectionStringMain = string.Empty;
        public static SqlConnection connectionMain;
        public static Boolean isConnected;
        public static Boolean userLogged;

        public static Boolean DBConnect()
        {
            if (isConnected)
                return true;
            SQLSettings sqlSettings = SQLSettings.GetActiveSQLSettings();
            
            if (!string.IsNullOrEmpty(sqlSettings.Server.Trim()) && !string.IsNullOrEmpty(sqlSettings.Database.Trim()) &&
                !string.IsNullOrEmpty(sqlSettings.Username.Trim()) && !string.IsNullOrEmpty(sqlSettings.Password.Trim()))
            {
                connectionStringMain = String.Format("Data Source={0};Network Library=DBMSSOCN;Initial Catalog={1};Persist Security Info=True; MultipleActiveResultSets=True;User ID={2};Password={3};Max Pool Size=4000",
                    sqlSettings.Server.Replace(":", ",").Replace(" ", ""), sqlSettings.Database, sqlSettings.Username, sqlSettings.Password);
            }
            else
            {
                Err = "Database connection parameters are not set!";
                return false;
            }

            try
            {
                if (connectionMain == null)
                    connectionMain = new SqlConnection();
                if (connectionMain.State == System.Data.ConnectionState.Open)
                {
                    connectionMain.Close();
                    connectionMain.Dispose();
                    SqlConnection.ClearPool(connectionMain);
                }
                SqlCommand com = new SqlCommand();
                connectionMain.ConnectionString = connectionStringMain;
                com.Connection = connectionMain;
                connectionMain.Open();
                isConnected = true;
                return true;
                
            }
            catch (Exception ex)
            {

                Err = ex.Message;
                return false;
            }
        }

        public static Boolean Disconnect()
        {
            try
            {
                connectionMain.Close();
                connectionMain.Dispose();
                SqlConnection.ClearPool(connectionMain);
            }
            catch { }
            isConnected = false;

            return true;
        }

        public static Boolean User_Connect()
        {
            //if (!isConnected)
            //    DBConnect();

            if (userLogged)
                return true;

            //using (Dialog_UserLogin dlg = new Dialog_UserLogin())
            //{
            //    dlg.BringToFront();
            //    dlg.ShowDialog();
            //    dlg.Close();
            //}

            return userLogged;
        }

        //public static Boolean UserDisConnect()
        //{
        //    userLogged = false;
        //    CurrentUser = new Operator();
        //    return true;
        //}

        public static Boolean initialConnection()
        {
            Boolean _retVal = false;

            //if (DBConnection.DBConnect())
            //{
            //    if (DBConnection.User_Connect())
            //        _retVal = true;
            //}


            if (DBConnection.User_Connect())
                _retVal = true;
            else
            {
                //Message_Connection msg = new Message_Connection(Err);
                //msg.ShowDialog();
                using (MainForm dlg = new MainForm())
                {
                    if (dlg.ShowDialog() == DialogResult.OK)
                        if (DBConnection.User_Connect())
                            _retVal = true;
                }
            }

            return _retVal;
        }

        public static void setUserPassword(string Username, string oldPassword, string newPassword)
        {
            SqlCommand com = new SqlCommand();
            SqlConnection conn = new SqlConnection { ConnectionString = connectionMain.ConnectionString };
            com.Connection = conn;
            conn.Open();

            try
            {
                //com.CommandText = String.Format("update [User] set [Password] = @Password where ([Username] = N'{0}' and ([Password] = N'{1}' or [Password] = N'{2}'))", Username, oldPassword, SecurePasswordHasher.Hash(oldPassword));

                SqlParameter paramPassword = new SqlParameter();
                paramPassword.ParameterName = "@Password";
                paramPassword.Value = newPassword;
                com.Parameters.Add(paramPassword);

                com.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Please log in to the system first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
            finally
            {
                com.Dispose();
                conn.Close();
                conn.Dispose();
                SqlConnection.ClearPool(connectionMain);
            }
        }



        //public static bool LoginUser(string username, string password, bool savePwd)
        //{
        //    bool retval = false;

        //    if (DBHandler.getTableRowCount("User") < 1)
        //    {
        //        if(DBHandler.getTableRowCount("Partner") < 1)
        //        {
        //            Partner p = new Partner();
        //            p.Active = true;
        //            p.PartnerName = "Initial";
        //            DBHandler.setPartner(p);
        //        }

        //        Operator o = new Operator();
        //        o.Username = "admin";
        //        o.FullName = "Administrator";
        //        o.MyRole.RoleID = 1;
        //        int.TryParse(DBHandler.getTableValue("Partner", "PartnerID", "PartnerName", "Initial"), out o.PartnerID);
        //        o.Password = "admin";
        //        DBHandler.setOperator(o, true);
        //    }
        //    String cmdText = "SELECT * FROM [User] WHERE Username = @Username AND Active = '1'";

        //    SqlCommand sqlCommand = null;
        //    SqlDataReader sqlDataReader = null;
        //    using (sqlCommand = new SqlCommand(cmdText, connectionMain))
        //    {
        //        try
        //        {
        //            SqlParameter paramUsername = new SqlParameter();
        //            paramUsername.ParameterName = "@Username";
        //            paramUsername.Value = username;
        //            sqlCommand.Parameters.Add(paramUsername);

        //            sqlDataReader = sqlCommand.ExecuteReader();

        //            if (sqlDataReader.Read())
        //            {
        //                String pwd = Convert.ToString(sqlDataReader["Password"]);
        //                if (SecurePasswordHasher.Verify(password, pwd) || pwd == password)
        //                {
        //                    retval = true;
        //                    int userID = -1;
        //                    int roleID = -1;
        //                    int.TryParse(Convert.ToString(sqlDataReader["UserID"]), out userID);
        //                    int.TryParse(Convert.ToString(sqlDataReader["RoleID"]), out roleID);
                            
        //                    CurrentUser = DBHandler.getOperatorByID(userID);
        //                    CurrentUser.MyRole = DBHandler.getRoleByID(roleID);

        //                    userLogged = true;
        //                }
        //                else
        //                {
        //                    CurrentUser = new Operator();
        //                    userLogged = false;
        //                    //MessageBox.Show("Korisnički račun ili šifra nisu valjani!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
        //                }
        //            }
        //            else
        //            {
        //                CurrentUser = new Operator();
        //                userLogged = false;
        //            }
        //        }
        //        catch
        //        { }
        //        finally
        //        {
        //            try
        //            {
        //                sqlCommand.Dispose();
        //                sqlDataReader.Close();
        //                sqlDataReader.Dispose();
        //            }
        //            catch { }
        //        }
        //    }

        //    return retval;
        //}
    }
}