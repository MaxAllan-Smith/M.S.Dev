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
        private string db = "Default";
        public bool IsConnection
        {
            get
            {
                using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
                {
                    if (connection.State == ConnectionState.Closed)
                    {
                        connection.Open();
                    }
                }
                return true;
            }
        }

        public UserModel AddNewUser(UserModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@userName", model.UserName);
                p.Add("@passWord", model.PassWord);
                p.Add("@firstName", model.FirstName);
                p.Add("@lastName", model.LastName);
                p.Add("@emailAddress", model.EmailAddress);
                p.Add("@phoneNumber", model.PhoneNumber);

                connection.Execute("spUser_Insert", p, commandType: CommandType.StoredProcedure);

                MessageBox.Show("Successfully Added User To Database!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return model;
            }
        }

        public List<UserModel> GetUsers_ID(int id)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@id", id);

                var output = connection.Query<UserModel>("spGetUser_Id", p, commandType: CommandType.StoredProcedure).ToList();

                return output;
            }
        }

        public List<UserModel> GetUser_UsernamePassword(string username, string password)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
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
