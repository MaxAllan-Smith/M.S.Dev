using ABM_Backup_System_Library.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Backup_System_Library.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public List<UserModel> GetUser_UsernamePassword(string username, string password)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString("Default")))
            {
                var p = new DynamicParameters();
                p.Add("@userName", username);
                p.Add("@passWord", password);

                var output = connection.Query<UserModel>("spGetUser", p, commandType: CommandType.StoredProcedure).ToList();

                return output;
            }
        }
    }
}
