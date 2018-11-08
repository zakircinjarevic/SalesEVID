using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesEVID
{
    public class User
    {
        public int UserID;
        public string Username;
        public string Password;
        public string FullName;
        public User()
        {
            UserID = -1;
            Username = string.Empty;
            Password = string.Empty;
            FullName = string.Empty;
        }
        User(int userID = -1, string username = "", string password = "",string FullName="")
        {
            this.UserID = userID;
            this.Username = username;
            this.Password = password;
            this.FullName = FullName;
        }
    }
}
