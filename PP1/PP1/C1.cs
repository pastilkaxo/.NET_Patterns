using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1
{
    public class C1
    {
        // константы
         private const string University = "BSTU";
         public const string Faculty = "ISIT";
         protected const int Group = 2;

        // поля

        private int Age;
        public string Subject;
        protected bool Passed;

        // свойства
        private int _groupCount { get; set; }
        public string _studentName { get; set; }

        protected string _studentEmail { get; set; }


        public C1()
        {
            Age = 0;
            Subject = string.Empty;
            Passed = false;
            _studentName = string.Empty;
            _groupCount = 0;
            _studentEmail = string.Empty;

        }

        public C1(int age, string subject, bool passed, string name, int gCount, string sEmail)
        {
            Age = age;
            Subject = subject;
            Passed = passed;
            _studentName = name;
            _groupCount = gCount;
            _studentEmail = sEmail;

        }



        public C1(C1 c)
        {
            Age = c.Age;
            Subject = c.Subject;
            Passed = c.Passed;
            _studentName = c._studentName;
            _groupCount = c._groupCount;
            _studentEmail = c._studentEmail;

        }

        private int GetBirth()
        {
            int year = 2024 - this.Age;
            return year;
        }

        public void PrintStudent()
        {
            Console.WriteLine($"Name:{_studentName} Age:{Age} BirthYear:{GetBirth()} Subject: {Subject} Group:{Group} University: {University} Faculty:{Faculty}  Passed:{PassCheck()}");

        }

        protected string PassCheck()
        {
            if (Passed)
            {
                return $"Студент сдал все экзамены!";
            }
            else
            {
                return $"Студент не сдал все экзамены!";
            }
        }

    }
}
