
using Lab03LibN.Bonus_L3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03LibN
{
    public class Factory3 : IFactory
    {

        public float A { get; set; }
        public float B { get; set; }
        public IBonus getA(float cost1hour)
        {
            return new BonusA_L3(cost1hour, A, B);
        }

        public IBonus getB(float cost1hour, float x)
        {
            return new BonusB_L3(cost1hour, x, A, B);
        }

        public IBonus getC(float cost1hour, float x, float y)
        {
            return new BonusC_L3(cost1hour, x, y, A, B);
        }
        public Factory3(float a, float b)
        {
            A = a;
            B = b;
        }
    }
}
