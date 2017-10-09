using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortCostApp.Core;

namespace PortCostApp.Infrastructure
{
    public class PortCostInitializeDB : DropCreateDatabaseIfModelChanges<PortCostContext>
    {
        protected override void Seed(PortCostContext context)
        {
            context.PortCosts.Add(new PortCost
                {
                VesselCode = "TEST",
                PortCode = "FIHKO",
                PortCostCategory ="CostCategory1",
                PortCostSubCategory ="Subcategory1",
                Cost = 100                
                 });
            context.PortCosts.Add(new PortCost
            {
                VesselCode = "VICH",
                PortCode = "RULED",
                PortCostCategory = "CostCategory2",
                PortCostSubCategory = "Subcategory2",
                Cost = 200
            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
