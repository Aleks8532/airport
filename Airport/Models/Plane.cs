using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Airport.Models
{
    public class Plane
    {
        public int Id { set; get; }
        public string Firm { set; get; }
        public int FuelSupply { set; get; } //запас топлива
        public int FuelConsumption { set; get; } //расход топлива
        public int Time { set; get; } //unixtimestamp 

    }
}
