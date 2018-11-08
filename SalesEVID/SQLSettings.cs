using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using SalesEVID;


namespace Main
{
    public class SQLSettings
    {
        public string Server;
        public string Database;
        public string Username;
        public string Password;

        public SQLSettings()
        {
            Server = string.Empty;
            Database = string.Empty;
            Username = string.Empty;
            Password = string.Empty;
        }
        public static void setLoginInformation(LoginDetails informacije)
        {
            if (!Directory.Exists(AppPaths.LoginInfoPath))
                Directory.CreateDirectory(AppPaths.LoginInfoPath);

            var filename = Path.Combine(AppPaths.LoginInfoPath, "Logins.dat");

            using (var fs = File.Open(filename, FileMode.Create))
            {
                try
                {
                    var xmlser = new XmlSerializer(typeof(LoginDetails));
                    xmlser.Serialize(fs, informacije);
                }
                catch
                {
                }
                //fs.Close();
                //fs.Dispose();
            }
        }
        public static LoginDetails getLoginInformation()
        {
            var filename = Path.Combine(AppPaths.LoginInfoPath, "Logins.dat");
            if (!File.Exists(filename))
                setLoginInformation(new LoginDetails());

            try
            {
                using (var fs = File.Open(filename, FileMode.Open))
                {
                    var xmlser = new XmlSerializer(typeof(LoginDetails));
                    return (LoginDetails)xmlser.Deserialize(fs);
                }
            }
            catch
            {
                return new LoginDetails();
            }
        }
        public static void setActiveSQLSettings(SQLSettings aSettings)
        {
            if (!Directory.Exists(AppPaths.AppSettingsPath)) 
                Directory.CreateDirectory(AppPaths.AppSettingsPath);

            var filename = Path.Combine(AppPaths.AppSettingsPath, "AppData.dat");

            using (var fs = File.Open(filename, FileMode.Create))
            {                
                try
                {
                    var xmlser = new XmlSerializer(typeof(SQLSettings));
                    xmlser.Serialize(fs, aSettings);
                }
                catch
                {
                }
                //fs.Close();
                //fs.Dispose();
            }
        }
        public static SQLSettings GetActiveSQLSettings()
        {
            var filename = Path.Combine(AppPaths.AppSettingsPath, "AppData.dat");
            if(!File.Exists(filename))
                setActiveSQLSettings(new SQLSettings());
           
            try
            {
                using (var fs = File.Open(filename , FileMode.Open))
                {
                    var xmlser = new XmlSerializer(typeof(SQLSettings));
                    return (SQLSettings)xmlser.Deserialize(fs);
                }
            }
            catch
            {
                return new SQLSettings();
            }
        }
    }
}
