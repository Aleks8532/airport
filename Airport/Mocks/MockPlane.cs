using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Interface;
using Airport.Models;
using Interface;

namespace Airport.Mocks
{
    public class MockPlane : IPlane

    {
        public IEnumerable<Plane> Planes {
            get
            {
                return new List<Plane>
                {
                    new Plane {Id = 1, Firm = "Pobeda", FuelConsumption = 2, FuelSupply = 5000, Time = 600},
                    new Plane {Id = 2, Firm = "S7", FuelConsumption = 3, FuelSupply = 6000, Time = 500}
                };
            }
        }
    }
}
