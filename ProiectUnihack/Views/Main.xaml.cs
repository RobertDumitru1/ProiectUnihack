namespace ProiectUnihack.Views;

public partial class Main : ContentPage
{
	public Main()
	{
		InitializeComponent();
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Shop));
    }
}