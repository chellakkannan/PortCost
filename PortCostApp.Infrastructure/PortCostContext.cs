using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortCostApp.Core;

namespace PortCostApp.Infrastructure
{
    public class PortCostContext :DbContext
    {

        public PortCostContext()
            : base("name=PortCostAppConnectionString")
        {
        }
        public DbSet<PortCost> PortCosts { get; set; }        
    }
}
