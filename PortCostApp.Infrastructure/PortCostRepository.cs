using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortCostApp.Core;

namespace PortCostApp.Infrastructure
{
    public class PortCostRepository : IPortCostRespository
    {
        PortCostContext context = new PortCostContext();
        public void Add(PortCost pc)
        {
            context.PortCosts.Add(pc);
            context.SaveChanges();
        }

        public void Edit(PortCost pc)
        {
            context.Entry(pc).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public PortCost FindById(Int32 Id)
        {
            var result = (from r in context.PortCosts where r.ID == Id select r).FirstOrDefault();
            return result;
        }

        public IEnumerable<PortCost> GetPortCost()
        {
            return context.PortCosts;
            
        }

        public void Remove(Int32 Id)
        {
            PortCost pc = context.PortCosts.Find(Id);
            context.PortCosts.Remove(pc);
            context.SaveChanges();
        }
    }
}
