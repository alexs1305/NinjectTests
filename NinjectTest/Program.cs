﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace NinjectTest
{
    class Program : NinjectSettings
    {
        static void Main(string[] args)
        {
            IKernel kernal = new StandardKernel();
            kernal.Bind<IPlayer>().To<Alex>();
            var competition = kernal.Get<PoolCompetition>();

            competition.StatePlayer();
        }
    }
}