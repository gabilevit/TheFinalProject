using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Simulators.Interfaces
{
    public interface IDepartureSimulator
    {
        Flight EmitDeparture();
    }
}
