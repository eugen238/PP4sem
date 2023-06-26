using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class L2B : IBonus
    {
        public L2B(float coast1hour, float x, float a)
        {
            this.coast1hour = coast1hour;
            this.a = a;
            this.x = x;
        }
        public float a = 0.0f;
        public float x { get; set; } = 1;
        public float coast1hour { get; set; } = 0;

        public float calc(float number_hours)
        {
            return (float)((number_hours + a) * coast1hour * x);
        }
    }
}
