using Lab03LibN.Bonus_L2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03LibN
{
    public class Factory2 : IFactory
    {
        public float A { get; set; }    
        public IBonus getA(float cost1hour)
        {
            return new BonusA_L2(cost1hour, A);
        }

        public IBonus getB(float cost1hour, float x)
        {
            return new BonusB_L2(cost1hour, x, A);
        }

        public IBonus getC(float cost1hour, float x, float y)
        {
            return new BonusC_L2(cost1hour, x, y, A);
        }
        public Factory2(float a)
        {
            A = a;
        }   
    }
}
