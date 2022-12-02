using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABM_Backup_System_Library.Models
{
    public class RangeCodeModel
    {
        public int ID { get; set; }
        public string RangeCode { get; set; }
        public string Description { get; set; }
        public string MfgCode { get; set; }

        public RangeCodeModel()
        {

        }

        public RangeCodeModel(string rangeCode)
        {
            RangeCode = rangeCode;
        }
    }
}
