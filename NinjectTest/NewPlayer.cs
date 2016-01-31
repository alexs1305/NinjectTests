using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    class NewPlayer : IPlayer
    {
        private string name = "A New Player";
        private Func<string> winningquote = () => "I am a loser";

        public string Name
        {
            get
            {
                return name;
            }
        }

        public Func<string> WinningQuote
        {
            get
            {
                return winningquote;
            }
        }
    }
}
