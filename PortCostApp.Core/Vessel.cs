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
    public class Vessels
    {
        //   public List<SelectListItem> Vessels { get; set; }
        [Key]        
        public string VesselCode { get; set; }
        public string VesselName { get; set; }
    }
}
