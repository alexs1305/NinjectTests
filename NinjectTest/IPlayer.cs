using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    interface IPlayer
    {
        string Name { get;}
        Func<string> WinningQuote { get; }

    }
}
