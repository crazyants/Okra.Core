﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okra.Lifetime
{
    public abstract class AppLaunchContext
    {
        public abstract IAppLaunchRequest LaunchRequest { get; }
    }
}
