namespace FlightApp.Views;

public partial class SearchReservationPage : ContentPage
{
	public SearchReservationPage()
	{
		InitializeComponent();
	}

    private void Back_to_home_page_from_Search_registration_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");
    }
}