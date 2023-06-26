using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class Bonus_2 : IFactory
    {
        float a = 0;
        public Bonus_2(float a)
        {
            this.a = a;
        }
        public IBonus getA(float coast1hour)
        {
            return new L2A(coast1hour, a);
        }

        public IBonus getB(float coast1hour, float x)
        {
            return new L2B(coast1hour, a, x);
        }

        public IBonus getC(float coast1hour, float x, float y)
        {
            return new L2C(coast1hour, a, x, y);
        }
    }
}
