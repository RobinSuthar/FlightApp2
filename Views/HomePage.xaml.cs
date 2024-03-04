namespace FlightApp.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private void find_flights_button_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync(nameof(FlightFinderPage));
    }

    private void reserve_flights_button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(SearchReservationPage));
    }

    private void about_us_Button_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(AboutUsPage));
    }

}