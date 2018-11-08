using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SalesEVID;

namespace Main
{
    public partial class MainForm : Form
    {
        SQLSettings sqlSettings = new SQLSettings();
        LoginDetails Logins = new LoginDetails();
        public MainForm()
        {
            InitializeComponent();
            sqlSettings = SQLSettings.GetActiveSQLSettings();
            Logins = SQLSettings.getLoginInformation();
        }
        private void Dialog_Database_Load(object sender, EventArgs e)
        {
            txt_Server.Text = sqlSettings.Server;
            txt_Database.Text = sqlSettings.Database;
            txt_Username.Text = sqlSettings.Username;
            txt_Password.Text = sqlSettings.Password;
            try
            {
                textBoxPassword.Text = Logins.password;
                textBoxUsername.Text = Logins.username;
            }
            catch
            {
                
            }
        }
        private void SaveSqlSettings()
        {
            sqlSettings.Server = txt_Server.Text;
            sqlSettings.Database = txt_Database.Text;
            sqlSettings.Username = txt_Username.Text;
            sqlSettings.Password = txt_Password.Text;

            SQLSettings.setActiveSQLSettings(sqlSettings);
        }
        private void SaveLoginSettings()
        {
            Logins.username=(textBoxUsername.Text);
            Logins.password=(textBoxPassword.Text);

            SQLSettings.setLoginInformation(Logins);
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            SaveSqlSettings();
            SaveLoginSettings();
            //DialogResult = DialogResult.OK;
            if (txt_Database.Text == "")
            {
                
                MessageBox.Show("Please enter your database connection settings");
                return;
            }
            var users = DBHandler.getUsers();
            int counter=0;
            foreach (var item in users)
            {
                if (item.Username == textBoxUsername.Text)
                {
                    if (item.Password != textBoxPassword.Text)
                    {
                        MessageBox.Show("Error ! User does not exist. Please check your SQL Connection settings.");
                        return;
                    }
                }
                else counter++;
            }
            if (counter == users.Count)
            {
                MessageBox.Show("Error ! User does not exist. Please check your SQL Connection settings.");
                return;
            }
            string imeprezime = string.Empty;
            foreach (var item in users)
            {
                if (item.Username == textBoxUsername.Text)
                {
                    if (item.Password == textBoxPassword.Text)
                    {
                        imeprezime = item.FullName;
                    }
                }
            }
            CustomerList frm = new CustomerList(imeprezime);
            frm.ShowDialog();
            Close();
        }     
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btn_TestConnection_Click_1(object sender, EventArgs e)
        {

            SaveSqlSettings();

            Cursor.Current = Cursors.WaitCursor;
            bool rez = DBConnection.DBConnect();
            Cursor.Current = Cursors.Default;

            if (rez)
            {
                MessageBox.Show(this, "Connection OK", "Test Connection", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(this, "SQL Connection problem: " + Environment.NewLine + Environment.NewLine + DBConnection.Err, "Test Connection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}
