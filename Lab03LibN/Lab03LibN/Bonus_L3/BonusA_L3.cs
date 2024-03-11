using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03LibN.Bonus_L3
{
    public class BonusA_L3 : IBonus
    {
        public float cost1hour { get; set; }
        public float A { get; set; }
        public float B { get; set; }

        public float calc(float number_hours)
        {
            return (cost1hour+B) * (number_hours+A);
        }

        public BonusA_L3(float cost1hour, float a,float b)
        {
            this.cost1hour = cost1hour;
            A = a;
            B = b;
        }
    }
}
