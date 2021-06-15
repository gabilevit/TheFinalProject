using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Flight
    {
        [Key]
        public int Id { get; set; }
        public int FlightNum { get; set; }
        public string Contry { get; set; }
        public bool IsDeparture { get; set; }
        public bool IsArrival { get; set; }
    }
}
