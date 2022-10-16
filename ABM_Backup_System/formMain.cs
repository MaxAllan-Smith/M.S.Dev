using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABM_Backup_System
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void salesOrderCreditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                formSalesOrderr_Credit formSalesOrderr_Credit = new formSalesOrderr_Credit();
                formSalesOrderr_Credit.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                formLogin formLogin = new formLogin();
                formLogin.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void customerDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                formCustomerDatabase formCustomerDatabase = new formCustomerDatabase();
                formCustomerDatabase.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void configureWorkstationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                formWorkstationConfiguration formWorkstationConfiguration = new formWorkstationConfiguration();
                formWorkstationConfiguration.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void invoiceEnquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                formInvoiceEnquiry formInvoiceEnquiry = new formInvoiceEnquiry();
                formInvoiceEnquiry.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            try
            {
                formLogin formLogin = new formLogin();
                if (formLogin.ShowDialog() == DialogResult.OK)
                {
                    formLogin.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
