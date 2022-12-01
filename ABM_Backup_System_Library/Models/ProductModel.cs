using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Backup_System_Library.Models
{
    public  class ProductModel
    {
        public int ID { get; set; }
        public string PartNumber { get; set; }
        public string KnownAs { get; set; }
        public string Description { get; set; }
        public string BinLocation { get; set; }
        public int UOI { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public string DateSetup { get; set; }
        public string BarCode { get; set; }
        public float Width { get; set; }
        public float Depth { get; set; }
        public float Length { get; set; }
        public string ProdGroupPrefix { get; set; }
        public string RangeCode { get; set; }
        public int SupplierID { get; set; }
        public string BranchName { get; set; }
        public int CompanyID { get; set; }
        public int LastSoldID { get; set; }
        public string SupplierPartNumber { get; set; }
        public float RRP { get; set; }
        public float CostPrice { get; set; }
        public int StockQty { get; set; }
    }
}
