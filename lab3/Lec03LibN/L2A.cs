using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class L2A : IBonus
    {
        public L2A(float coast1hour, float a)
        {
            this.coast1hour = coast1hour;
            this.a = a;
        }
        public float a = 0.0f;
        public float coast1hour { get; set; } = 0;

        public float calc(float number_hours)
        {
            return (float)((number_hours + Math.Pow(a, 5)) * coast1hour);
        }
    }
}
