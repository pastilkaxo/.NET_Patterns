using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP2
{
    public class Organiztion : IStaff
    {
        List<JobVacancy> vacancy = new List<JobVacancy>();
        List<Employee> employees = new List<Employee>();
        List<JobTitle> jobTitles = new List<JobTitle>();
        public int id { get; private set; }
        public string name { get; protected set; }
        public string shortName { get; protected set; }
        public string address { get; protected set; }
        public DateTime timeStamp { get; protected set; }

        public Organiztion()
        {
            id = 0;
            name = string.Empty;
            shortName = string.Empty;
            address = string.Empty; 
            timeStamp = DateTime.Now;
        }
        public Organiztion(Organiztion org)
        {
            id = org.id;
            name = org.name;
            shortName = org.shortName;
            address = org.address;
            timeStamp = org.timeStamp;
        }
        public Organiztion(int id, string name, string shortName, string address, DateTime timeStamp)
        {
            this.id = id;
            this.name = name;
            this.shortName = shortName;
            this.address = address;
            this.timeStamp = timeStamp;
        }

        public Organiztion(string name, string shortName, string address)
        {
            this.name = name;
            this.shortName = shortName;
            this.address = address;
        }

        public void printInfo()
        {
            Console.WriteLine($"------------->\n" +
                              $"ID:{id} Name:{name} ShortName:{shortName} Address:{address} Time:{timeStamp}\n" +
                              $"------------->\n");

        }

        public List<JobVacancy> getJobVacancies()
        {
            return vacancy;
        }

        public List<Employee> getEmployees()
        {
            return employees;
        }

        public List<JobTitle> getJobTitles()
        {
            return jobTitles;
        }

        public int addJobTitle(JobTitle jobTitle)
        {
            jobTitles.Add(jobTitle);
            return 0;
        }

        public string printJobVacancies()
        {
            if(vacancy.Count > 0){
                foreach (JobVacancy jobVacancy in vacancy)
                {
                    return $"{jobVacancy.vacansy}";
                }
            }
            else
            {
                return "nothing";
            }
            return "";
        }

        public bool delJobTitle(int index)
        {
            if (jobTitles[index] != null)
            {
                jobTitles.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void openJobVacancy(JobVacancy jobVacancy)
        {
            vacancy.Add(jobVacancy);
        }

        public bool closeJobVacancy(int index)
        {
            if (vacancy[index] != null)
            {
                vacancy.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        public Employee recruit(JobVacancy vacancy, Person person)
        {
            Employee emp = new Employee(person.PersonName,vacancy.vacansy);
            employees.Add(emp);
            return emp;
        }

        public bool dismiss(int index, Reason reason)
        {
           if(employees[index] != null)
            {
                Console.WriteLine($"Сотрудник {employees[index].empName} уволен по причине:{reason.Text}");
                employees.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
