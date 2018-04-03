using System;
using Balln.ViewModels;
using FreshMvvm;

namespace Balln.PageModels.Friends
{
    public class FriendProfilePageModel : FreshBasePageModel
    {
        public ProfileViewModel Profile { get; set; }

		public override void Init(object initData)
		{
            base.Init(initData);

            if (initData is ProfileViewModel profile)
            {
                Profile = profile;
            }
		}
	}
}
