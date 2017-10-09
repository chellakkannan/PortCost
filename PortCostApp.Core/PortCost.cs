using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortCostApp.Core
{
    public class PortCost
    {
        public Int32 ID { get; set; }
        public string VesselCode { get; set; }
        public string PortCode { get; set; }
        //[Required, Display(Name = "PortCostCategory #")]
        [Required] 
        [MaxLength(100)]
        public string PortCostCategory { get; set; }
        public string PortCostSubCategory { get; set; }
        [Required]
        public double Cost { get; set; }
        public string CurrencyCode { get; set; }
        public string ContractID { get; set; }
        public string ContractFilePath { get; set; }

    }
}
