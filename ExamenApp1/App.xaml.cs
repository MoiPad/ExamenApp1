using ExamenApp1.Views;

namespace ExamenApp1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage( new ExamenApp1MainPage());
        }
    }
}
