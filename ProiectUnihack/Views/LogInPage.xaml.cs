namespace ProiectUnihack.Views;

public partial class LogInPage : ContentPage
{
	public LogInPage()
	{
		InitializeComponent();
	}

    public string UsernameEntry { get; private set; }
	public string PasswordEntry { get; private set; }

    private void LogIn(object sender, EventArgs e)
    {
        string username=UsernameEntry;
        string password = PasswordEntry;
        if (IsValidUser(username, password))
        {
            DisplayAlert("Loging In", $"Welcome, {username}", "ok");
        }
        else DisplayAlert("Not Logging In", "Wrong credentials introducedced", "ok");
    }
    private bool IsValidUser(string username, string password)
    {
        return username == "user1" && password == "password1";
    }
}