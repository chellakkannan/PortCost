using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortCostApp.Core
{
    public interface IPortCostRespository
    {
        void Add(PortCost pc);
        void Edit(PortCost pc);
        void Remove(Int32 Id);
        IEnumerable<PortCost> GetPortCost();
        PortCost FindById(Int32 Id);
    }
}
