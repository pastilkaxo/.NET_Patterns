using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03LibN.Bonus_L2
{
    public class BonusA_L2 : IBonus
    {
        public float cost1hour { get; set; }
        public float A { get; set; }

        public float calc(float number_hours)
        {
            return cost1hour * (number_hours+A);
        }

        public BonusA_L2(float cost1hour, float a)
        {
            this.cost1hour = cost1hour;
            A = a;
        }
    }
}
