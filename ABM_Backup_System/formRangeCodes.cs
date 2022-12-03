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
    public partial class formRangeCodes : Form
    {
        public formRangeCodes()
        {
            InitializeComponent();
        }

        private void formRangeCodes_Load(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listViewRangeCodes.Items)
            {
                item.BackColor = item.Index % 2 == 0 ? Color.FromArgb(213, 238, 255) : Color.White;
            }
        }

        private void toolStripButton_Add_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.SubItems.Add(textBoxDescription.Text.Trim());
                listViewRangeCodes.Items.Add(new ListViewItem(textBoxRangeCode.Text.Trim(), listViewItem.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
