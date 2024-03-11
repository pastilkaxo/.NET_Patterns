using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab03LibN.Bonus_L1;

namespace Lab03LibN
{
    public class Factory1 : IFactory
    {
        public IBonus getA(float cost1hour)
        {
            return new BonusA(cost1hour);
        }

        public IBonus getB(float cost1hour, float x)
        {
          return new BonusB(cost1hour, x);
        }

        public IBonus getC(float cost1hour, float x, float y)
        {
            return new BonusC(cost1hour, x, y);
        }
    }
}
