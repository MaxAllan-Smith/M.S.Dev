using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Backup_System_Library.Models
{
    public class StockModel
    {
        public int ID { get; set; }
        public int ProductID { get; set; }
        public int BranchID { get; set; }
        public int CompanyID { get; set; }
        public int SupplierID { get; set; }
        public int StockQty { get; set; }
        public string DateBookedIn { get; set; }
        public string TimeBookedIn { get; set; }
        public int BookedInType { get; set; }
        public float CostPrice { get; set; }

    }
}
