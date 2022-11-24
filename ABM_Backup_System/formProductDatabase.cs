using ABM_Backup_System_Library.DataAccess;
using ABM_Backup_System_Library.Models;
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
    public partial class formProductDatabase : Form
    {
        public formProductDatabase()
        {
            InitializeComponent();
        }

        private void dataGridView_Alternatives_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView_Alternatives.Rows)
            {
                row.Cells["Column_Lno"].Value = row.Index + 1;
            }
        }

        private void formProductDatabase_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView_Alternatives_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                dataGridView_Alternatives.CurrentCell = dataGridView_Alternatives.Rows[0].Cells[0];
                dataGridView_Alternatives.BeginEdit(true);
            }
        }

        private void dataGridView_Alternatives_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView_Alternatives.CurrentCell.ColumnIndex.Equals(1))
            {
                if (e.Control is TextBox)
                {
                    ((TextBox)e.Control).CharacterCasing = CharacterCasing.Upper;
                }
            }
        }

        private void dataGridView_Alternatives_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView_Alternatives.CurrentCell = null;
        }
    }
}
