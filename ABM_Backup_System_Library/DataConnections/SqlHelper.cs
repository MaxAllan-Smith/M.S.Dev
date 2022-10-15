using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Backup_System_Library.DataConnections
{
    public class SqlHelper
    {
        SqlConnection cn;

        public SqlHelper(string connString)
        {
            cn = new SqlConnection(connString);
        }

        public bool IsConnected
        {
            get
            {
                if (cn.State == System.Data.ConnectionState.Closed)
                {
                    cn.Open();
                }

                return true;
            }
        }
    }
}
