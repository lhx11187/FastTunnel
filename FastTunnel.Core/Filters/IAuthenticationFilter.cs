﻿using FastTunnel.Core.Core;
using FastTunnel.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FastTunnel.Core.Filters
{
    public interface IAuthenticationFilter : IFastTunntlfilter
    {
        bool Authentication(FastTunnelServer server, LogInMassage requet);
    }
}