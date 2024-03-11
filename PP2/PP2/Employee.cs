using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP2
{
    public class Employee
    {
        public string empName { get; set; }
        public string empVac { get; set; }

        public Employee(string empName, string empVac)
        {
            this.empName = empName;
            this.empVac = empVac;
        }
    }
}
