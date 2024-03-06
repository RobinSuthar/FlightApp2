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
       //   new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Arrival = "FRA" , Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
   //       new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Arrival = "FRA" , Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
       //   new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Arrival = "FRA" , Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
        //  new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Arrival = "FRA" , Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
       //   new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Arrival = "FRA" , Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
            
      //    new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Arrival = "FRA" , Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
       //   new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Arrival = "FRA", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
         // new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Arrival = "FRA", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
       //   new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Arrival = "FRA", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
       //  new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Arrival = "FRA", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
            new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Arrival = "FRA", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
     //     new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Arrival = "FRA", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
            new Flight { flightNumber  = 4367,FlightName = "huehue", Departure = "ABC", Arrival = "FRA", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
            new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Arrival = "FRA", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
//          SL-9060,Scare Airlines,DEL,YEG,Monday,20:00,255,848.00

            new Flight {flightNumber = 4200, FlightName ="Scare Airline ", Departure ="DEL",Arrival ="YEG",Day="Monay",Cost=848.00,Time=10-21-42 },
    //      new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Arrival = "FRA", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
      //    new Flight { flightNumber  = 4367,FlightName = "Birtish Airline", Departure = "GLC", Arrival = "FRA", Day = "Monday" , Cost = 3233.23,Time= 12-12-2001},
        //  new Flight { flightNumber = 1367,FlightName = "Qatar  Airline", Departure = "GLC", Arrival = "FRA" , Day = "Monday",Cost = 2533.23,Time= 11-08-2001 },
            new Flight { flightNumber = 5367,FlightName = "Indian Airline", Departure = "GLC", Arrival = "FRA" , Day = "Tuesday",Cost = 6433.23,Time= 17-12-2021 }
        };

        static List<Flight> foundFLights = new List<Flight>()
        {
            new Flight { FlightName = "sadasd", Arrival ="BHA", Departure ="BMB",Cost =212,Day = "adsad",Time = 21-21-31,flightNumber = 2112 }
        };

        static List<Flight> flightsdep = new List<Flight>()
        {
             new Flight {flightNumber = 4200, FlightName ="Scare Airline ", Departure ="DEL",Arrival ="YEG",Day="Monay",Cost=848.00,Time=10-21-42 },

        };





        public static List<Flight> GetFoundFlights()
        {
            return foundFLights;
        }



        public static List<Flight> GetFlights()
        {
            return flights;
        }



        public static Flight GetFlightByDeparture(string departure) 
        {

            var flight =flights.FirstOrDefault(x => x.Departure == departure);
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

        public static Flight GetFlightByArrival(string arrival)
        {
            var flight = flights.FirstOrDefault(x => x.Arrival == arrival);
            if (flight != null)
            {
                return new Flight 
                {

                    


                    flightNumber = flight.flightNumber,
                    FlightName = flight.FlightName,
                    Day = flight.Day,
                    Arrival = flight.Arrival,
                    Departure = flight.Departure,
                    Cost = flight.Cost,
                    Time = flight.Time,
                };
            }

            return null;

        }
        

        public static Flight GetFlightByDay(string day)
        {
            var flight = flights.FirstOrDefault(x => x.Day== day);
            if (flight != null)
            {
                return new Flight
                {
                    flightNumber = flight.flightNumber,
                    FlightName = flight.FlightName,
                    Day = flight.Day,
                    Arrival = flight.Arrival,
                    Departure = flight.Departure,
                    Cost = flight.Cost,
                    Time = flight.Time,
                };
            }

            return null;

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


        public static List<Flight> SearchForFlights(string filterText)
        {
            var flightsFound = flights.Where(x => x.Departure.StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();

            if ( flightsFound == null)
            {
                flights.Where(x => x.Arrival.
                StartsWith(filterText, StringComparison.OrdinalIgnoreCase))?.ToList();
            }else
            {
                return flightsFound;
            }
            return flightsFound;
        }
    }
}
