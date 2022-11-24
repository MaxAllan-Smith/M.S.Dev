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
        public bool IsConnection()
        {
            bool output;

            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                    output = true;
                }
                else
                {
                    output = false;
                }
            }

            return output;
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

        public List<UserModel> UserExist()
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var output = connection.Query<UserModel>("spUserExist", commandType: CommandType.StoredProcedure).ToList();

                return output;
            }
        }

        public CustomerModel AddNewCustomer(CustomerModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@accountNumber", model.AccountNumber);
                p.Add("@companyName", model.CompanyName);
                p.Add("@salesAddress1", model.SalesAddress1);
                p.Add("@salesAddress2", model.SalesAddress2);
                p.Add("@salesAddress3", model.SalesAddress3);
                p.Add("@salesAddress4", model.SalesAddress4);
                p.Add("@salesAddress5", model.SalesAddress5);
                p.Add("@postCode", model.PostCode);
                p.Add("@salesContact", model.SalesContact);
                p.Add("@salesPhoneNumber", model.SalesPhoneNumber);
                p.Add("@salesFaxNumber", model.SalesFaxNumber);
                p.Add("@salesEmailAddress", model.SalesEmailAddress);
                p.Add("@accountsContact", model.AccountsContact);
                p.Add("@accountsPhoneNumber", model.AccountsPhoneNumber);
                p.Add("@accountsFaxNumber", model.AccountsFaxNumber);
                p.Add("@accountsEmailAddress", model.AccountsEmailAddess);
                p.Add("@accountsMobileNumber", model.AccountsMobileNumber);
                p.Add("@country", model.Country);


                connection.Execute("spAddNewCustomer", p, commandType: CommandType.StoredProcedure);

                MessageBox.Show("New Customer Successfully Added To The Database!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return model;
            }
        }

        public CustomerModel GetNextCustomer(CustomerModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@id", model.ID);

                connection.Query<CustomerModel>("spGetNextCustomer", p, commandType: CommandType.StoredProcedure);

                return model;
            }
        }

        public CustomerModel GetIdByAccountNumber(CustomerModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@accountNumber", model.AccountNumber);

                connection.Execute("spGetIdByAccountNumber", p, commandType: CommandType.StoredProcedure);

                return model;
            }
        }

        public ProductModel GetAltProduct(ProductModel model)
        {
            using (IDbConnection connection = new SqlConnection(GlobalConfig.CnnString(db)))
            {
                var p = new DynamicParameters();

                p.Add("@partNumber", model.PartNumber);

                connection.Execute("TEST_spGetAltProduct", p, commandType: CommandType.StoredProcedure);

                return model;
            }
        }
    }
}
