using ABM_Backup_System_Library;

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
            GlobalConfig.InitializeConnections(true);
            if (GlobalConfig.CnnString("Default").Length < 1)
            {
                formWorkstationConfiguration formWorkstationConfiguration = new formWorkstationConfiguration();
                if (formWorkstationConfiguration.ShowDialog() == DialogResult.OK)
                {
                    formWorkstationConfiguration.Close();
                    MessageBox.Show("Application Will Now Close!\n\nPlease Restart The Application!", "Application Closing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                    Environment.Exit(0);
                }
            }
            Application.Run(new formMain());
        }
    }
}