namespace MauiApp0823
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();

            NavigatedTo += async (sender, e) =>
            {
                if (newPage != null)
                {
                    await DisplayAlert("Information", $"Clicked {(newPage.IsConfirm ? "Confirm" : "Cancel")} button!", "Confirm");
                    newPage = null;
                }
            };
        }

        NewPage1 newPage;

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        /// <summary>
        /// Open second page and get the return parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnOpenNewPage_Clicked(object sender, EventArgs e)
        {
            newPage = new();
            await Navigation.PushAsync(newPage);
        }
    }
}