namespace ProiectUnihack.Views;

public partial class Main : ContentPage
{
    public string Banuti { get; set; }
	public Main()
	{
		InitializeComponent();

        BindingContext = this;

        Banuti = "150";
	}

    private void ImageButton_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(Shop));
    }
}