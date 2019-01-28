using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace PlantPlacesWebService
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            //fsdfdsf
            // Handle when your app starts
            Console.WriteLine("Hello");
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
            Console.WriteLine("Hello");
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
