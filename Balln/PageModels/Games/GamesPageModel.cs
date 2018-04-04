using System;
using System.Collections.Generic;
using System.Windows.Input;
using Balln.ViewModels;
using FreshMvvm;
using Xamarin.Forms;

namespace Balln.PageModels.Games
{
    public class GamesPageModel : FreshBasePageModel
    {
        public List<GameViewModel> Games { get; set; }

        public ICommand OpenDetailCommand => new Command(OpenDetail);

        public ICommand AddNewGameCommand => new Command(AddNewGame);

        public GamesPageModel()
        {
            Games = new List<GameViewModel> 
            {
                new GameViewModel
                {
                    Name = "McCully District Park",
                    Date = "Tues, 630pm",
                    InvitedBy = "johnamcruz",
                    Address = "1290 Aala St. Honolulu, HI 96817",
                    Description = "Time hoop...",
                    GoingCount = 10,
                    MaybeCount = 2,
                    InvitedCount = 20
                },
                new GameViewModel
                {
                    Name = "McCully District Park",
                    Date = "Tues, 630pm",
                    InvitedBy = "johnamcruz",
                    Address = "1290 Aala St. Honolulu, HI 96817",
                    Description = "Time hoop...",
                    GoingCount = 10,
                    MaybeCount = 2,
                    InvitedCount = 20
                },
                new GameViewModel
                {
                    Name = "McCully District Park",
                    Date = "Tues, 630pm",
                    InvitedBy = "johnamcruz",
                    Address = "1290 Aala St. Honolulu, HI 96817",
                    Description = "Time hoop...",
                    GoingCount = 10,
                    MaybeCount = 2,
                    InvitedCount = 20
                },
                new GameViewModel
                {
                    Name = "McCully District Park",
                    Date = "Tues, 630pm",
                    InvitedBy = "johnamcruz",
                    Address = "1290 Aala St. Honolulu, HI 96817",
                    Description = "Time hoop...",
                    GoingCount = 10,
                    MaybeCount = 2,
                    InvitedCount = 20
                },
            };
        }

        public async void OpenDetail(object sender)
        {
            await CoreMethods.PushPageModel<GameDetailPageModel>(sender);
        }

        public async void AddNewGame(object sender)
        {
            await CoreMethods.PushPageModel<AddNewGamePageModel>(null, true);
        }
    }
}
