using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1
{
    public class C3 : C2
    {
        protected string Msg { get; set; }
        private string PrivateVariant; 
        public const string Define = "C3 - base";

        public C3(string msg, string privateVariant,int avgMark) : base(avgMark)
        {
            Msg = msg;
            PrivateVariant = privateVariant;
            Console.WriteLine("C3 constr was used");
        }


        public void PrintMsg()
        {
            Console.WriteLine(Msg + " Where " + Define);
        }

    }
}
