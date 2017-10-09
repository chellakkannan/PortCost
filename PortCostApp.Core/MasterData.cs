using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;

namespace PortCostApp.Core
{
    public class PortCostCategory
    {
        public int PortCostCategoryID { get; set; }
        public string PortCostCategoryName { get; set; }
    }
    public class PortCostSubCategory
    {
        public int PortCostSubCategoryID { get; set; }
        public string PortCostSubCategoryName { get; set; }
    }
    public class Currency
    {        
        public string CurrencyCode { get; set; }        
    }    
}
