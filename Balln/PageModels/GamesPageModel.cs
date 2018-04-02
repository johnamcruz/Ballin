using System;
using System.Collections.Generic;
using Balln.ViewModels;
using FreshMvvm;

namespace Balln.PageModels
{
    public class GamesPageModel : FreshBasePageModel
    {
        public List<GameViewModel> Games { get; set; }

        public GamesPageModel()
        {
            Games = new List<GameViewModel> 
            {
                new GameViewModel
                {
                    Name = "McCully District Park",
                    Date = "Tues, 630pm",
                    InvitedBy = "johnamcruz"
                },
                new GameViewModel
                {
                    Name = "McCully District Park",
                    Date = "Tues, 630pm",
                    InvitedBy = "johnamcruz"
                },
                new GameViewModel
                {
                    Name = "McCully District Park",
                    Date = "Tues, 630pm",
                    InvitedBy = "johnamcruz"
                },
                new GameViewModel
                {
                    Name = "McCully District Park",
                    Date = "Tues, 630pm",
                    InvitedBy = "johnamcruz"
                },
            };
        }
    }
}
