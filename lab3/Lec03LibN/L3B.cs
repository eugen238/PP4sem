using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class L3B : IBonus
    {
        public L3B(float coast1hour, float x, float a, float b)
        {
            this.a = a;
            this.b = b;
            this.coast1hour = coast1hour;
            this.x = x;
        }
        float a = 0.0f;
        float b = 0.0f;
        public float x { get; set; } = 1;
        public float coast1hour { get; set; }

        public float calc(float number_hours)
        {
            return (float)((number_hours + a) * (coast1hour * Math.Pow(b, 6)) * x);
        }
    }
}
