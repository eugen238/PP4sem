using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    internal class Bonus_3 : IFactory
    {
        float a = 0;
        float b = 0;
        public Bonus_3(float a, float b)
        {
            this.a = a;
            this.b = b;
        }

        public IBonus getA(float coast1hour)
        {
            return new L3A(coast1hour, a, b);
        }

        public IBonus getB(float coast1hour, float x)
        {
            return new L3B(coast1hour, a, b, x);
        }

        public IBonus getC(float coast1hour, float x, float y)
        {
            return new L3C(coast1hour, a, b, x, y);
        }
    }
}
