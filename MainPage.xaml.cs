namespace Module01Exercise01
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void SaveOrUpdateInfo(object sender, EventArgs e)
        {
            await DisplayAlert("User Registration Form", "Details successfully saved or updated!", "OK");
        }

        private void OnChangeBackgroundColor(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.DarkGreen;
        }
    }

}
