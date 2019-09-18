using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Airport.Models;
using Airport.Interface;

namespace Airport.Mocks
{
    public class MockAirstrip : IAirstrip
    {
        public IEnumerable<Airstrip> Airstrips
        {
            get
            {
                return new List<Airstrip>
                {
                    new Airstrip {Id = 1, IsFree = false},
                    new Airstrip {Id = 2, IsFree = true},
                };
            }
        }
    }
}
