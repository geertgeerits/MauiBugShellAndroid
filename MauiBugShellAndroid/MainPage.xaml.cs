namespace MauiBugShellAndroid
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnImageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewPage1());
        }
    }
}
