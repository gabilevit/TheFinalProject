using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dal.Simulators.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models;
using Server.Repositories;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AirportController : Controller
    {
        private IRepository _repository;
        private IArrivalSimulator _arrivalSimulator;

        public AirportController(IRepository repository, IArrivalSimulator arrivalSimulator)
        {
            _arrivalSimulator = arrivalSimulator;
            _repository = repository;
        }

        public Flight GetFlight([FromBody]Flight flight)
        {

            //_repository.InsertFlight(_arrivalSimulator.EmitArrival());
            return flight;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
