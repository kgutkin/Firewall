﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4.Network.Safety
{
    public abstract class FirewallCommand
    {
        public abstract NetworkPacket DoWithPacket(Firewall fw, NetworkPacket p);
    }
}
