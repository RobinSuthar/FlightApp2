using FlightApp.Views;

namespace FlightApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(FlightFinderPage), typeof(FlightFinderPage));
            Routing.RegisterRoute(nameof(AboutUsPage), typeof(AboutUsPage));
            Routing.RegisterRoute(nameof(SearchReservationPage), typeof(SearchReservationPage));
            Routing.RegisterRoute(nameof(ResultOfFlights), typeof(ResultOfFlights));
        }
    }
}
