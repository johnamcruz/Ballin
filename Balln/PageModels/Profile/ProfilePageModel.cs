using FreshMvvm;
using Balln.Constants;
using Balln.ViewModels;

namespace Balln.PageModels.Profile
{
    public class ProfilePageModel : FreshBasePageModel
    {
        public ProfileViewModel Profile { get; set; }

        public ProfilePageModel()
        {
            Profile = new ProfileViewModel
            {
                ProfileImage = Images.ImageProfile,
                NickName = "johnamcruz",
                FullName = "John Abram Cruz",
                GameType = "Recreational",
                Gender = "Male",
                HomeCourt = "Salt Lake District Park",
                HoursPlayed = "20:00 Hours",
            };
        }
    }
}
