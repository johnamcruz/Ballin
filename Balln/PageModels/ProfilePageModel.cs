using FreshMvvm;
using Balln.Constants;

namespace Balln.PageModels
{
    public class ProfilePageModel : FreshBasePageModel
    {
        public string ProfileImage { get; set; }
        public string NickName { get; set; }
        public string FullName { get; set; }
        public string GameType { get; set; }
        public string Gender { get; set; }
        public string HomeCourt { get; set; }
        public string HoursPlayed { get; set; }

        public ProfilePageModel()
        {
            ProfileImage = Images.ImageProfile;
            NickName = "johnamcruz";
            FullName = "John Abram Cruz";
            GameType = "Recreational";
            Gender = "Male";
            HomeCourt = "Salt Lake District Park";
            HoursPlayed = "20:00 Hours";
        }
    }
}
