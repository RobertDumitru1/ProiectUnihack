namespace ProiectUnihack.Views;

public partial class Shop : ContentPage
{
	public Shop()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Can't afford", "You dont't have enough banuti", "ok");
    }

    private void ImageButton_Clicked_1(object sender, EventArgs e)
    {

    }
}