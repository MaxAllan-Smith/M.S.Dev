using ABM_Backup_System_Library.DataConnections;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ABM_Backup_System
{
    public partial class formWorkstationConfiguration : Form
    {
        Configuration config;
        public formWorkstationConfiguration()
        {
            InitializeComponent();
        }

        public void ClearForm()
        {
            textBox_ServerPath.Clear();
            textBox_DatabaseName.Clear();
        }

        private void UpdateConfig()
        {
            var conString = string.Format("Server={0}; Database={1}; Trusted_Connection=True;", textBox_ServerPath.Text, textBox_DatabaseName.Text);

            SqlHelper helper = new SqlHelper(conString);

            if (helper.IsConnected)
            {
                appSettings settings = new appSettings();
                settings.SaveConnectionString("Default", conString);
                MessageBox.Show("Test Connection Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void toolStripButton_Sell_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateConfig();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
