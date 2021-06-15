using Dal.Simulators.Interfaces;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Simulators.Classes
{
    public class DepartureSimulator : IDepartureSimulator
    {
        public Flight EmitDeparture()
        {
            return GenerateRandomFlight();
        }

        private Flight GenerateRandomFlight()
        {
            return new Flight { FlightNum = 1, Contry = "Canada", IsArrival = false, IsDeparture = true };
        }
    }
}
