using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Backup_System_Library.Models
{
    public class CustomerModel
    {
        public int ID { get; set; }
        public string AccountNumber { get; set; }
        public string CompanyName { get; set; }
        public string SalesAddress1 { get; set; }
        public string SalesAddress2 { get; set; }
        public string SalesAddress3 { get; set; }
        public string SalesAddress4 { get; set; }
        public string SalesAddress5 { get; set; }
        public string PostCode { get; set; }
        public string SalesContact { get; set; }
        public string SalesPhoneNumber { get; set; }
        public string SalesFaxNumber { get; set; }
        public string SalesEmailAddress { get; set; }
        public string AccountsContact { get; set; }
        public string AccountsPhoneNumber { get; set; }
        public string AccountsFaxNumber { get; set; }
        public string AccountsEmailAddess { get; set; }
    }
}
