using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class Bonus_1 : IFactory
    {
        public IBonus getA(float coast1hour)
        {
            return new L1A(coast1hour);
        }

        public IBonus getB(float coast1hour, float x)
        {
            return new L1B(coast1hour, x);
        }

        public IBonus getC(float coast1hour, float x, float y)
        {
            return new L1C(coast1hour, x, y);
        }
    }
}
