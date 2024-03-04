using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightApp.Models
{
    public static class FlightsRepo
    {

        static List<Flight> flights = new List<Flight>()
        {
            new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
            new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
            new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
            new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
            new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},

            new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
            new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
            new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
            new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
            new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
            new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
            new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
            new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
            new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},

            new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
            new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
            new Flight { flightNumber = 1367,FlightName = "Qatar  Airline", Departure = "GLC", Day = "Monday",Cost = 2533.23,Time= 11-08-2001 },
            new Flight { flightNumber = 5367,FlightName = "Indian Airline", Departure = "GLC", Day = "Monday",Cost = 6433.23,Time= 17-12-2021 }
        };


        public static List<Flight> GetFlights()
        {
            return flights;
        }


        public static Flight GetFlightById(int FlightID)
        {

            var flight =  flights.FirstOrDefault(x => x.flightNumber == FlightID);
            if (flight != null)
            {
                return new Flight
                {
                    flightNumber = flight.flightNumber,
                    FlightName = flight.FlightName,
                    Day = flight.Day,
                    Departure = flight.Departure,
                    Cost = flight.Cost,
                    Time = flight.Time,
                };
            }
            return null;

        }
    }
}
