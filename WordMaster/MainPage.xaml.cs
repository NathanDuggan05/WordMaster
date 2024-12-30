namespace WordMaster
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Standard_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GameStandard());
        }

        private void Versus_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GameVS());
        }

        private void Pressure_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GameTimed());
        }

        private void Stats_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Stats());
        }

        private void Instructions_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HowToPlay());
        }
    }
}
