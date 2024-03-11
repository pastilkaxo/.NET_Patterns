using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1
{
    public class C4 : C3
    {
        public int ID { get; set; }
        public C4(string msg ,int id , string pv,int avgMark) : base(msg,pv, avgMark)
        {
            ID = id;
            Console.WriteLine("C4 constr was used" + pv);
        }

        public void SelfFunc()
        {
            Console.WriteLine("C4 function");
        }

    }
}
