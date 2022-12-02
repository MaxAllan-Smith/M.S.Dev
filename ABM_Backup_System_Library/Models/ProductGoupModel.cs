using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Backup_System_Library.Models
{
    public class ProductGoupModel
    {
        public int ID { get; set; }
        public string ProdGroupPrefix { get; set; }
        public string ProductGroupName { get; set; }
        public string OtherInformation { get; set; }

        public ProductGoupModel()
        {
            
        }

        public ProductGoupModel(string productGroupPrefix)
        {
            ProdGroupPrefix = productGroupPrefix;
        }

    }
}
