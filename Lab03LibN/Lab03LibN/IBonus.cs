using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03LibN
{
    public interface IBonus
    {
        float cost1hour { get; set; } 
        float calc(float number_hours); 
    }
}
