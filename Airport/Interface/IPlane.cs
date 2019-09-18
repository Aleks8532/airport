using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Models;

namespace Interface
{
    interface IPlane
    {
        IEnumerable<Plane> Planes { get; }
    }
}
