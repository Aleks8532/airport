using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Models
{
    public class Dispatcher
    {
        public int Id { set; get; }
        public Plane Plane { set; get; }
        public Airstrip Airstrip {set; get;}

    }
}
