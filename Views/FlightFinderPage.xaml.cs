using FlightApp.Models;
using System.Collections.ObjectModel;

namespace FlightApp.Views;


[QueryProperty(nameof(FlightNumber),"Id")]

public partial class FlightFinderPage : ContentPage
{
    Flight flight;

    Flight flight2;

    Flight flightarrival;

    Flight flightdayy;

    public string flightfrom;
    public string flightto;
    public string flightday;

    public FlightFinderPage()
    {
        InitializeComponent();

        List<Flight> flights = FlightsRepo.GetFlights();

        ListOfFlights.ItemsSource = flights;


        List<Flight> foundflights = FlightsRepo.GetFoundFlights();

        FoundListOfFlights.ItemsSource = foundflights;


    }

    private void Reutrn_home_From_finder_page_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(HomePage));
    }


    public string FlightNumber 
    {
        set
        {
            flight = FlightsRepo.GetFlightById(int.Parse(value));
            if(flight != null)
            {
                string flightnumberint = Convert.ToString(flight.flightNumber);
                string flightTimeint = Convert.ToString(flight.Time);
                string flightCostint = Convert.ToString(flight.Cost);
                FlightCode.Text = flightnumberint;
                FlightAirline.Text = flight.FlightName;
                FlightDay.Text = flight.Day;
                FlightTime.Text = flightTimeint;
                FlightCost.Text = flightCostint;
            }
        }
    }


    private void ListOfFlights_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Shell.Current.GoToAsync($"{nameof(FlightFinderPage)}" + $"?Id={((Flight)ListOfFlights.SelectedItem).flightNumber}");


    }


    private void Find_flights_btn_Clicked(object sender, EventArgs e)
    {

        //From_user_given.Text = flight.FlightName;
        //To_user_given.Text = flight.Day;
        //Day_user_given.Text = flight.ToString();
        ListOfFlights.IsVisible = !ListOfFlights.IsVisible;

        //USer 


        flightday = Day_user_given.Text;
        flightfrom = From_user_given.Text;
        flightto = To_user_given.Text;


        

        if (flightfrom == null)
        {
            DisplayAlert("ERROR", "INVALID INPUT", "OK");
        }
        else 
        {
            flight2 = FlightsRepo.GetFlightByDeparture(flightfrom);
            flightarrival = FlightsRepo.GetFlightByArrival(flightto);

            flightdayy = FlightsRepo.GetFlightByDay(flightday);

            if (flight2 == null || flightarrival == null || flightdayy == null)
            {
                DisplayAlert("NO FLIGHTS", "SORRY THERE ARE NOT FLIGHTS RIGHT NOW", "OK");
            }
            else
            {
                if ( flightto == flightarrival.Arrival && flightfrom == flight2.Departure && flightday == flightdayy.Day)
                { 

                    FlightCode.Text = flightarrival.Arrival;

                    FlightDay.Text = flight2.Departure;

                    new 
                }
                else
                {
                    DisplayAlert("NO FLIGHTS", "SEARCH SOEMTHING ELSE", "OK");
                }

            }

        }

        //List<Flight> flightsflitered= FlightsRepo.GetFlights();

        //List<Flight> fdsadas = FlightsRepo.SearchForFlights(flightfrom);

        //Console.WriteLine(fdsadas);
    }






}