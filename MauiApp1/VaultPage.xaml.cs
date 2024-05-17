namespace MauiApp1;

public partial class VaultPage : ContentPage
{
    public VaultPage()
    {
        InitializeComponent();
    }

    private void OnLogOut(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("//MainPage");
    }
}

