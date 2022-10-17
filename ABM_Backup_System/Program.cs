using ABM_Backup_System_Library;
using ABM_Backup_System_Library.DataAccess;
using ABM_Backup_System_Library.Models;

namespace ABM_Backup_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            SqlConnector sqlConnector = new SqlConnector();

            GlobalConfig.InitializeConnections(true);
            
            if (GlobalConfig.CnnString("Default") == "")
            {
                formWorkstationConfiguration formWorkstationConfiguration = new formWorkstationConfiguration();
                if (formWorkstationConfiguration.ShowDialog() == DialogResult.OK)
                {
                    formWorkstationConfiguration.Close();
                }
            }
            else
            {
                List<UserModel> model = new List<UserModel>();
                model = sqlConnector.GetUsers_ID(1);
                if (model.Count == 0)
                {
                    formAddNewUser formAddNewUser = new formAddNewUser();
                    if (formAddNewUser.ShowDialog() == DialogResult.OK)
                    {
                        formAddNewUser.Close();
                    }
                }
            }

            Application.Run(new formMain());
        }
    }
}