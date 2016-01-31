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
        private IPlayer player;

        public IPlayer Player
        {
            get
            {
                return player;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
        }

        public PoolCompetition(IPlayer newplayer)
        {
            player = newplayer;
        }

        public void StatePlayer()
        {
            IPlayer Player = player;
            Console.WriteLine($"{Player.Name} has won the trophy, saying '{Player.WinningQuote}' ");

        }
    }
}
