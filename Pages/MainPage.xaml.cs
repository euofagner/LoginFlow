namespace LoginFlow
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);

            bool result = Preferences.Get("ManterLogado", false); 

            Preferences.Set("ManterLogado", true);

            result = Preferences.Get("ManterLogado", false);
        }
    }

}
