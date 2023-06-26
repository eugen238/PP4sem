using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class L1C : IBonus
    {
        public L1C(float coast1hour, float x, float y)
        {
            this.coast1hour = coast1hour;
            this.x = x;
            this.y = y;
        }
        public float x { get; set; } = 0;
        public float y { get; set; } = 0;
        public float coast1hour { get; set; } = 0;

        public float calc(float number_hours)
        {
            return (float)(number_hours * coast1hour * x + Math.Pow(y, 2));
        }
    }
}
