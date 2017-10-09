using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PortCostApp.Core;

namespace PortCostApp.Infrastructure
{
    public class VesselRepository : IVesselRespository
    {
        VesselContext context = new VesselContext();

        public IEnumerable<Vessels> GetVessels()
        {
            return context.Vessels;

        }
    }
}
