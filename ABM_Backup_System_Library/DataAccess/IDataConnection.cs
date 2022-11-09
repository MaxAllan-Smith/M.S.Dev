using ABM_Backup_System_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Backup_System_Library.DataAccess
{
    public interface IDataConnection
    {
        List<UserModel> GetUser_UsernamePassword(string username, string password);
        UserModel AddNewUser(UserModel model);
        List<UserModel> UserExist();
        CustomerModel AddNewCustomer(CustomerModel model);
        CustomerModel GetNextCustomer(CustomerModel model);
        CustomerModel GetIdByAccountNumber(CustomerModel model);
    }
}
