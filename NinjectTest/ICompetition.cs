using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    interface ICompetition
    {
        string Title { get; }
        IPlayer[] Players { get; }

        void StatePlayer();

    }
}
