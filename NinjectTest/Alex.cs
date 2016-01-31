using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    class Alex : IPlayer
    {
        private string name;
        private Func<string> winningquote;

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

        public Alex()
        {
            name = "Alex";
            winningquote = () => "I am the greatest";
        }
    }
}
