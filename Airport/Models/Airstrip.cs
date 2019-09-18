using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Models
{
    public class Airstrip
    {
        public int Id { set; get; }
        public bool IsFree { set; get; }
        public Plane Plane { set; get; } //is need?
    }
}
