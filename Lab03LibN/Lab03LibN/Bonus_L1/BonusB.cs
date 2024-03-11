using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03LibN.Bonus_L1
{
    public class BonusB : IBonus
    {
        public float cost1hour { get; set; }
        public float x { get; set; }


        public float calc(float number_hours)
        {
            return cost1hour * number_hours * x;
        }

        public BonusB(float cost1hour, float x)
        {
            this.cost1hour = cost1hour;
            this.x = x;
        }
    }
}
