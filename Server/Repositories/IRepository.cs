﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Server.Repositories
{
    public interface IRepository
    {
        void InsertFlight(Flight flight);
    }
}
