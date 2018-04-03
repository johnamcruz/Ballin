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
                    NickName = "johnamcruz",
                    FullName = "John Cruz",
                    ProfileImage = Images.ImageProfile
                },
                new ProfileViewModel
                {
                    NickName = "johnamcruz",
                    FullName = "John Cruz",
                    ProfileImage = Images.ImageProfile
                },
                new ProfileViewModel
                {
                    NickName = "johnamcruz",
                    FullName = "John Cruz",
                    ProfileImage = Images.ImageProfile
                },
                new ProfileViewModel
                {
                    NickName = "johnamcruz",
                    FullName = "John Cruz",
                    ProfileImage = Images.ImageProfile
                },
                new ProfileViewModel
                {
                    NickName = "johnamcruz",
                    FullName = "John Cruz",
                    ProfileImage = Images.ImageProfile
                },
            };
        }

        public async void OpenDetail(object sender)
        {
            await CoreMethods.PushPageModel<FriendProfilePageModel>();
        }
    }
}
