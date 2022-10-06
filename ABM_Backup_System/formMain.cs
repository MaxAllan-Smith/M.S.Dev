using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    }
}
