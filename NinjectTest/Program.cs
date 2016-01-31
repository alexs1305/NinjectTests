using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace NinjectTest
{
    class Program : NinjectSettings
    {
        private static IPlayer[] Players;
        private static ICompetition Competition;

        static void Main(string[] args)
        {
            //Standard Dependency Injection
            var players = new IPlayer[2];
            players[0] = new Alex();
            players[1] = new NewPlayer();

            DependencyInjection(players);

            //Ninject
            Ninject();

        }

        public static void DependencyInjection(IPlayer[] players)
        {
            Players = players;
            Competition = new PoolCompetition(Players);
            Competition.Players.ToList().ForEach(p => Console.WriteLine($"Standard Dependency Injection adding {p.Name}"));
        }

        public static void Ninject()
        {
            IKernel kernal = new StandardKernel(new PlayerBindingModule());

            var competition = kernal.Get<PoolCompetition>();

            competition.StatePlayer();
        }
    }
}
