using System;
using FreshMvvm;
using System.Collections.Generic;
using Balln.ViewModels;
using Balln.Constants;

namespace Balln.PageModels.Friends
{
    public class FriendsPageModel : FreshBasePageModel
    {
        public List<ProfileViewModel> Friends { get; set; }

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
    }
}
