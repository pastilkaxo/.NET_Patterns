using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03LibN.Bonus_L2
{
    public class BonusB_L2 : IBonus
    {
        public float cost1hour { get; set; }
        public float x { get; set; }

        public float A { get; set; }    


        public float calc(float number_hours)
        {
            return (number_hours + A) * cost1hour * x;
        }

        public BonusB_L2(float cost1hour, float x,float a)
        {
            this.cost1hour = cost1hour;
            this.x = x;
            this.A = a;
        }
    }
}
