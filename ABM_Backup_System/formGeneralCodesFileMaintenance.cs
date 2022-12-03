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
    public partial class formGeneralCodesFileMaintenance : Form
    {
        public formGeneralCodesFileMaintenance()
        {
            InitializeComponent();
        }

        private void listViewGeneralCodes_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                foreach (ListViewItem item in listViewGeneralCodes.SelectedItems)
                {
                    if (item.Text == "Range Codes")
                    {
                        formRangeCodes formRangeCodes = new formRangeCodes();
                        formRangeCodes.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Sysrem Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void formGeneralCodesFileMaintenance_Load(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewGeneralCodes.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.FromArgb(213, 238, 255) : Color.White;
            }
        }
    }
}
