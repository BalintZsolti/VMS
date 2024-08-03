using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManufacturingSystem
{
    public interface IPerson
    {
        string Name { get; set; }
        void PerformDuties();
    }
}
