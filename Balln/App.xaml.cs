using Balln.PageModels;
using Balln.Pages;
using FreshMvvm;
using Xamarin.Forms;

namespace Balln
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var tabbedNavigation = new FreshTabbedNavigationContainer();
            tabbedNavigation.AddTab<HomePageModel>("Courts", null);
            tabbedNavigation.AddTab<ProfilePageModel>("Profile", null);
            MainPage = tabbedNavigation;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
