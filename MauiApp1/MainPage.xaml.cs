namespace MauiApp1;

public partial class MainPage : ContentPage
{
	private readonly string masterPassword = "youllneverguessthis";

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnSubmit(object sender, EventArgs e)
	{
		string passwordSubmittedByUser = MasterPasswordInput.Text;

		if (passwordSubmittedByUser == masterPassword)
		{
			Shell.Current.GoToAsync("//VaultPage");
		}
		else
		{
			DisplayAlert("Error", "The password you entered is not correct.", "OK");
		}
	}
}

