using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class L1B : IBonus
    {
        public L1B() { }
        public L1B(float coast1hour, float x)
        {
            this.coast1hour = coast1hour;
            this.x = x;
        }
        public float x { get; set; } = 0;
        public float coast1hour { get; set; } = 0;

        public float calc(float number_hours)
        {
            return (float)(number_hours * coast1hour * Math.Pow(this.x, 2));
        }
    }
}
