using System;
namespace Balln.ViewModels
{
    public class GameViewModel
    {
        public string Name { get; set; }
        public string Date { get; set; }
        public string InvitedBy { get; set; }

        public string Address { get; set; }
        public string Description { get; set; }

        public int GoingCount { get; set; }
        public int MaybeCount { get; set; }
        public int InvitedCount { get; set; }
    }
}
