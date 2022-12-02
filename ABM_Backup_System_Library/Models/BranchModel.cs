using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Backup_System_Library.Models
{
    public class BranchModel
    {
        public int ID { get; set; }
        public int BranchCode { get; set; }
        public string BranchName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Address3 { get; set; }
        public string Address4 { get; set; }
        public string Address5 { get; set; }
        public string PostCode { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }

        public BranchModel()
        {

        }

        public BranchModel(string branchName)
        {
            BranchName = branchName;
        }
    }
}
