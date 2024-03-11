using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP2
{
    public class Faculty : Organiztion
    {
        protected List<Department> departments;
        
        public Faculty() : base()
        {
            departments = new List<Department>();
        }
        public Faculty(Faculty fac)
        {
            departments = fac.departments;
            name = fac.name;
            shortName = fac.shortName;
            address = fac.address;
            timeStamp = fac.timeStamp;
        }
        public Faculty(string name ,string shortName , string address) : base(name, shortName, address)
        {

        }
        public int addDepartment(Department dep)
        {
            departments.Add(dep);
            return 0;
        }

        public bool delDepartment(int index)
        {
            if (verDepartment(index))
            {
                departments.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool updDepartment(Department dep)
        {
            departments[0] = dep;
            return true;
        }
        private bool verDepartment(int index)
        {
            if (departments[index] != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Department> getDepartments()
        {
            return departments; 
        }

    }
}
