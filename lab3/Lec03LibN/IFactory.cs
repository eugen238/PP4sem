using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec03LibN
{
    public interface IFactory
    {
        IBonus getA(float coast1hour);
        IBonus getB(float coast1hour,float x);
        IBonus getC(float coast1hour,float x,float y);
    }
}
