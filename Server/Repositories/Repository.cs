using Dal.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Repositories
{
    public class Repository : IRepository
    {
        private DataContext _data;

        public Repository(DataContext data)
        {
            _data = data;
        }

        public void InsertFlight(Flight flight)
        {
            _data.Flights.Add(flight);
            _data.SaveChanges();
        }
    }
}
