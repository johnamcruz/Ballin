using System;
using FreshMvvm;
using System.Collections.Generic;
using Balln.ViewModels;
using Balln.Constants;
using System.Windows.Input;
using Xamarin.Forms;

namespace Balln.PageModels.Friends
{
    public class FriendsPageModel : FreshBasePageModel
    {
        public List<ProfileViewModel> Friends { get; set; }

        public ICommand OpenDetailCommand => new Command(OpenDetail);

        public FriendsPageModel()
        {
            Friends = new List<ProfileViewModel>
            {
                new ProfileViewModel
                {
                    ProfileImage = Images.ImageProfile,
                    NickName = "johnamcruz",
                    FullName = "John Abram Cruz",
                    GameType = "Recreational",
                    Gender = "Male",
                    HomeCourt = "Salt Lake District Park",
                    HoursPlayed = "20:00 Hours",
                },
                new ProfileViewModel
                {
                    ProfileImage = Images.ImageProfile,
                    NickName = "johnamcruz",
                    FullName = "John Abram Cruz",
                    GameType = "Recreational",
                    Gender = "Male",
                    HomeCourt = "Salt Lake District Park",
                    HoursPlayed = "20:00 Hours",
                },
                new ProfileViewModel
                {
                    ProfileImage = Images.ImageProfile,
                    NickName = "johnamcruz",
                    FullName = "John Abram Cruz",
                    GameType = "Recreational",
                    Gender = "Male",
                    HomeCourt = "Salt Lake District Park",
                    HoursPlayed = "20:00 Hours",
                }
            };
        }

        public async void OpenDetail(object sender)
        {
            await CoreMethods.PushPageModel<FriendProfilePageModel>(sender);
        }
    }
}
