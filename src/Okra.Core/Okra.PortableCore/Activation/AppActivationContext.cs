﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okra.Activation
{
    public abstract class AppActivationContext
    {
        public abstract IAppActivationRequest ActivationRequest { get; }
    }
}
