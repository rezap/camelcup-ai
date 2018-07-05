﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Delver.CamelCup.External
{
    public class BettingCard 
    {
        public CamelColor CamelColor { get; set; }

        public int Value { get; set; }

        public int Owner { get; set; }

        public bool IsFree => Owner == -1;
    }
}
