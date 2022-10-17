using ABM_Backup_System_Library;
using System.Configuration;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Windows.Forms;

namespace ABM_Backup_System
{
    public partial class formWorkstationConfiguration : Form
    {
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

            try
            {
                AppSetting appSetting = new AppSetting();
                appSetting.SaveConnectionString("Default", conString);
                MessageBox.Show("Your connection has been successfully saved!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
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
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }
    }
}
