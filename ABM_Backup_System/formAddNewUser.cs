using ABM_Backup_System_Library;
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
    public partial class formAddNewUser : Form
    {
        public formAddNewUser()
        {
            InitializeComponent();
        }

        private void ClearForm()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Text = "";
            }

            textBox_Username.Focus();
        }

        private void toolStripButton_Add_Click(object sender, EventArgs e)
        {
            UserModel model = new UserModel();
            model.UserName = textBox_Username.Text;
            model.PassWord = textBox_Password.Text;
            model.FirstName = textBox_FirstName.Text;
            model.LastName = textBox_LastName.Text;
            model.EmailAddress = textBox_EmailAddress.Text;
            model.PhoneNumber = textBox_PhoneNumber.Text;

            SqlConnector sqlConnector = new SqlConnector();
            sqlConnector.AddNewUser(model);

            DialogResult = DialogResult.OK;

            ClearForm();
        }
    }
}
