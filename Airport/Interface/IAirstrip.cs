using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Models;

namespace Airport.Interface
{
    interface IAirstrip
    {
        IEnumerable<Airstrip> Airstrips { get; }
    }
}
