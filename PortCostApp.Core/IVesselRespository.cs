using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortCostApp.Core
{
    public interface IVesselRespository
    {
        IEnumerable<Vessels> GetVessels();
    }
}
