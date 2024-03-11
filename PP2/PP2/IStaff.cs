using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP2
{
    interface IStaff
    {
        List<JobVacancy> getJobVacancies();
        List<Employee> getEmployees();
        List<JobTitle> getJobTitles();
        int addJobTitle(JobTitle jobTitle);
        string printJobVacancies();
        bool delJobTitle(int index);
        void openJobVacancy(JobVacancy jobVacancy);
        bool closeJobVacancy(int index);
        Employee recruit(JobVacancy vacancy,Person person);
        bool dismiss(int index,Reason reason);
    }
}
