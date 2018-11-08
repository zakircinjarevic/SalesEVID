using SalesEVID;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class AddEdit_Firmu : Form
    {
        public AddEdit_Firmu(Customer f)
        {
           // firma = f;
            InitializeComponent();
            textBoxID.Text = f.CustomerID.ToString();
            txt_customername.Text = f.CustomerName;
            txt_workdescription.Text = f.WorkDescription;
            txt_numberofemployees.Text = f.NumberOfEmployees.ToString();
            txt_contactperson.Text = f.ContactPerson;
            txt_phonenumber.Text = f.PhoneNumber;
            if (f.Called == true) checkBoxCalled.Checked = true; else checkBoxCalled.Checked = false;
            if (f.Waiting == true) checkBoxWaiting.Checked = true; else checkBoxCalled.Checked = false;
            if (f.Contract == true) checkBoxContract.Checked = true; else checkBoxContract.Checked = false;
            if (f.Done == true) checkBoxDone.Checked = true; else checkBoxDone.Checked = false;
            txt_notes.Text = f.Notes;
         
        }
        private void btn_OK_Click(object sender, EventArgs e)
        {
            if (txt_customername.Text == "")
            {
                MessageBox.Show("Please enter the Customer's name");
                return;
            }
            Customer firma = new Customer();
            firma.CustomerID = int.Parse(textBoxID.Text);
            firma.CustomerName = txt_customername.Text.Trim();
            firma.WorkDescription = txt_workdescription.Text.Trim();
            firma.NumberOfEmployees = int.Parse(txt_numberofemployees.Text);
            firma.ContactPerson = txt_contactperson.Text.Trim();
            firma.PhoneNumber = txt_phonenumber.Text.Trim();
            if (checkBoxCalled.Checked == true) firma.Called = true; else firma.Called = false;
            if (checkBoxWaiting.Checked == true) firma.Waiting = true; else firma.Waiting = false;
            if (checkBoxContract.Checked == true) firma.Contract = true; else firma.Contract = false;
            if (checkBoxDone.Checked == true) firma.Done = true; else firma.Done = false;
            firma.Notes = txt_notes.Text;
            txt_notes.Text = firma.Notes;

            DBHandler.setCustomer(firma);
            DialogResult = DialogResult.OK;
            Close();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddEdit_Firmu_Load(object sender, EventArgs e)
        {

        }
    }
}
