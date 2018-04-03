using System;
using System.Windows.Input;
using FreshMvvm;
using Xamarin.Forms;

namespace Balln.PageModels.Games
{
    public class AddNewGamePageModel : FreshBasePageModel
    {
        public ICommand CreateCommand => new Command(CreateGame);

        public ICommand CancelCommand => new Command(Cancel);

        public async void CreateGame(object sender)
        {
            await CoreMethods.PopPageModel(null, true);
        }

        public async void Cancel(object sender)
        {
            await CoreMethods.PopPageModel(null, true);
        }
    }
}
