using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03LibN.Bonus_L1
{
    public class BonusC : IBonus
    {
        public float cost1hour { get; set; }
        public float x { get; set; }
        public float y { get; set; }


        public float calc(float number_hours)
        {
            return number_hours * cost1hour * x + y;
        }
        public BonusC(float cost1hour, float x, float y)
        {
            this.cost1hour = cost1hour;
            this.x = x;
            this.y = y;
        }
    }
}
