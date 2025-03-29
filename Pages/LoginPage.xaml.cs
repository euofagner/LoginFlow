namespace LoginFlow.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();

        //bool result = Preferences.Get("ContinuarLogado", false);

        //if (result) 
        //    Shell.Current.GoToAsync($"//{nameof(MainPage)}");
	}

    private async void Button_Clicked(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
    }

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        //if (sender is CheckBox checkBox)
        //    Preferences.Set("ContinuarLogado", checkBox.IsChecked);
    }
}