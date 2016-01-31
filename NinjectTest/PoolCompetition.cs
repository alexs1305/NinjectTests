using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    class PoolCompetition : ICompetition
    {
        private string title = "Pool competition";
        private IPlayer[] players;

        public IPlayer[] Players
        {
            get
            {
                return players;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
        }

        public PoolCompetition(IPlayer[] newplayer)
        {
            players = newplayer;
        }

        public void StatePlayer()
        {
            
            Players.ToList().ForEach(p=>Console.WriteLine($"{p.Name} is in the tornement, their winning phrase will be '{p.WinningQuote()}' "));

        }
    }
}
