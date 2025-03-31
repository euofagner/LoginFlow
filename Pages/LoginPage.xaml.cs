using LoginFlow.Services;

namespace LoginFlow.Pages;

public partial class LoginPage : ContentPage
{
    private readonly AuthService _authService;

	public LoginPage(AuthService authService)
	{
		InitializeComponent();

        _authService = authService;

        //bool result = Preferences.Get("ContinuarLogado", false);

        //if (result) 
        //    Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        _authService.Login();
		await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }

    //private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    //{
    //    //if (sender is CheckBox checkBox)
    //    //    Preferences.Set("ContinuarLogado", checkBox.IsChecked);
    //}
}