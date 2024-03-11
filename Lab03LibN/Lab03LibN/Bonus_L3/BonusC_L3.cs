using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03LibN.Bonus_L3
{
    public class BonusC_L3 : IBonus
    {
        public float cost1hour { get; set; }
        public float x { get; set; }
        public float y { get; set; }
        public float A { get; set; }
        public float B { get; set; }


        public float calc(float number_hours)
        {
            return (number_hours + A) * (cost1hour+B) * x + y;
        }
        public BonusC_L3(float cost1hour, float x, float y,float a,float b)
        {
            this.cost1hour = cost1hour;
            this.x = x;
            this.y = y;
            this.A = a;
            this.B = b;
        }
    }
}
