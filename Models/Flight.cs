using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApp.Models
{
    public class Flight
    {
        public int flightNumber {  get; set; }
        public string FlightName { get; set; }
        public string Departure { get; set; }
        public string Day { get; set; }
        public int Time { get; set; }
        public double Cost { get; set; }

    }
}
