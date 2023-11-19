namespace ProiectUnihack.Views;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}

    private void SignUp(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("LogInPage");

		DisplayAlert("Account created successfuly", "Your account was created", "ok");
    }

}