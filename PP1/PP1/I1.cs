using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1
{
    public interface I1
    {

        public int AvgMark { get; set; }

        public void CheckMark();

        public delegate void MarkChecked(int mark , string msg);
        public event MarkChecked? OnMarkChecked;

        public C2 this[int index]
        {
            get; set;
        }
        



    }
}
