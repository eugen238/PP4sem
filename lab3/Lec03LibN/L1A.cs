using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class L1A : IBonus
    {
        public L1A() { }
        public L1A(float coast1hour)
        {
            this.coast1hour = coast1hour;
        }
        public float coast1hour { get; set; } = 0;

        public float calc(float number_hours)
        {
            return (float)(number_hours * coast1hour);
        }
    }
}
