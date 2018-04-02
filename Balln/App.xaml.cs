using Balln.PageModels;
using Balln.Pages;
using Balln.Constants;
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
            tabbedNavigation.AddTab<CourtPageModel>("Courts", Images.CourtsTab);
            tabbedNavigation.AddTab<GamesPageModel>("Games", Images.GamesTab);
            tabbedNavigation.AddTab<FriendsPageModel>("Friends", Images.FriendsTab);
            tabbedNavigation.AddTab<ProfilePageModel>("Profile", Images.ProfileTab);
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
