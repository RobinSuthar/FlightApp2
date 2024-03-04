using FlightApp.Models;

namespace FlightApp.Views;


[QueryProperty(nameof(FlightNumber),"Id")]

public partial class FlightFinderPage : ContentPage
{
    Flight flight;


    public FlightFinderPage()
    {
        InitializeComponent();

        List<Flight> flights = FlightsRepo.GetFlights();

        ListOfFlights.ItemsSource = flights;



    }

    private void Reutrn_home_From_finder_page_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
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

           
           ListOfFlights.IsVisible = !ListOfFlights.IsVisible;

    }
}