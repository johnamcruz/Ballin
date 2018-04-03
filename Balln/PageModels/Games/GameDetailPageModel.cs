using System;
using Balln.ViewModels;
using FreshMvvm;

namespace Balln.PageModels.Games
{
    public class GameDetailPageModel : FreshBasePageModel
    {
        public GameViewModel Game { get; set; }

		public override void Init(object initData)
		{
            base.Init(initData);

            if (initData is GameViewModel game)
            {
                Game = game;
            }
		}
	}
}
