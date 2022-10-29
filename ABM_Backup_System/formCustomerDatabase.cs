using ABM_Backup_System_Library.DataAccess;
using ABM_Backup_System_Library.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABM_Backup_System
{
    public partial class formCustomerDatabase : Form
    {
        public formCustomerDatabase()
        {
            InitializeComponent();
            textBox_AccountNumber.Focus();
        }

        private void ClearFormNew()
        {
            foreach (Control ctrl in this.tabPage_CustomerDetails.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = "";

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Text = "";
                }
            }

            foreach (Control ctrl in this.tabPage_FinancialInformation.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = "";

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Text = "";
                }
            }

            foreach (Control ctrl in this.tabPageAdditionalInformation.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = "";

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Text = "";
                }
            }

            foreach (Control ctrl in this.tabPage_Notes.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = "";

                if (ctrl is ComboBox)
                {
                    ((ComboBox)ctrl).Text = "";
                }
            }

            tabPage_CustomerDetails.Focus();
            textBox_AccountNumber.Focus();
        }

        private void toolStripButton_Exit_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void toolStripButton_Cancel_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFormNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void toolStripButton_OK_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerModel model = new CustomerModel();
                model.AccountNumber = textBox_AccountNumber.Text;
                model.CompanyName = textBox_AccountName.Text;
                model.SalesAddress1 = textBox_CAccountAddress1.Text;
                model.SalesAddress2 = textBox_CAccountAddress2.Text;
                model.SalesAddress3 = textBox_CAccountAddress3.Text;
                model.SalesAddress4 = textBox_CAccountAddress4.Text;
                model.SalesAddress5 = textBox_CAccountAddress5.Text;
                model.PostCode = textBox_AccountPostCode.Text;
                model.SalesContact = textBox_SalesContact.Text;
                model.SalesPhoneNumber = textBox_SalesPhoneNumber.Text;
                model.SalesFaxNumber = textBox_SalesFaxNumber.Text;
                model.SalesEmailAddress = textBox_SalesEmailAddress.Text;
                model.AccountsContact = textBox_AccountContact.Text;
                model.AccountsPhoneNumber = textBox_AccountPhoneNumber.Text;
                model.AccountsFaxNumber = textBox_AccountFaxNumber.Text;
                model.AccountsEmailAddess = textBox_AccountEmaillAddress.Text;

                SqlConnector sqlConnector = new SqlConnector();
                sqlConnector.AddNewCustomer(model);

                ClearFormNew();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void comboBox_Country_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage_CustomerDetails_Click(object sender, EventArgs e)
        {

        }

        private void formCustomerDatabase_Load(object sender, EventArgs e)
        {
            //Populates ComboBox with contries
            var list = CultureInfo.GetCultures(CultureTypes.SpecificCultures).Select(p => new RegionInfo(p.Name).EnglishName).Distinct().OrderBy(s => s).ToList();
            comboBox_Country.DataSource = list;
            comboBox_Country.Text = "United Kingdom";
        }
    }
}
