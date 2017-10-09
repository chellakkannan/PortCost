using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortCostApp.Core;

namespace PortCostApp.Infrastructure
{
    public class VesselContext : DbContext
    {

        public VesselContext()
            : base("name=PortCostAppConnectionString")
        {
        }        
        public DbSet<Vessels> Vessels { get; set; }

        public System.Data.Entity.DbSet<PortCostApp.Core.PortCost> PortCosts { get; set; }
    }
}
