namespace ProiectUnihack.Views;

public partial class LogInPage : ContentPage
{
	public LogInPage()
	{
		InitializeComponent();
	}

    public string UsernameEntry;

    public string PasswordEntry;

    private bool IsValidUser(string username, string password)
    {
        return username == "user1" && password == "password1";
    }
    private void LogIn(object sender, EventArgs e)
    {
        string username = entryUser.Text;
        string password = entryPassword.Text;
        if (IsValidUser(username, password))
        {
            DisplayAlert("Loging In", $"Welcome, {username}", "ok");
        }
        else DisplayAlert("Not Logging In", "Wrong credentials introducedced", "ok");
    }

}