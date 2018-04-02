using Balln.PageModels.Games;
using Balln.PageModels.Friends;
using Balln.PageModels.Profile;
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
            tabbedNavigation.AddTab<GamesPageModel>("Games", Images.CourtsTab);
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
