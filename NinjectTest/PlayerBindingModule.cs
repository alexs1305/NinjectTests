using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace NinjectTest
{
    class PlayerBindingModule : Ninject.Modules.NinjectModule
    {
        public override void Load()
        {
            Bind<IPlayer>().To<Alex>();
            Bind<IPlayer>().To<NewPlayer>();
        }
    }
}
