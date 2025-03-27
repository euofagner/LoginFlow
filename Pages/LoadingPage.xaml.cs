using LoginFlow.Services;

namespace LoginFlow.Pages;

public partial class LoadingPage : ContentPage
{
	private readonly AuthService _authService;

	public LoadingPage(AuthService authService)
	{
		InitializeComponent();
		_authService = authService;
	}

    protected async override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);

		if (await _authService.IsAuthenticadeAsync())
		{
			//User is logged in
			//redirect to main page

			await Shell.Current.GoToAsync($"//{nameof(MainPage)}");
		}
		else
		{
            //User is not logged in
            //Redirect to login page

            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}