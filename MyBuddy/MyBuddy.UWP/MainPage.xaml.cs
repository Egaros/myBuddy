namespace MyBuddy.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadApplication(new MyBuddy.App());
        }
    }
}