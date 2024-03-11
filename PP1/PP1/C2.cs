using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP1
{
    public class C2 :  I1
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

        public List<C2> list = new List<C2>();
        public int AvgMark { get; set; }

        public event I1.MarkChecked OnMarkChecked;

        public int Mark { get; private set; }

        public C2 this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }

        private void HandleCheck(int avgMark, string message)
        {
            Console.WriteLine($"Средний балл: {avgMark}, Сообщение: {message}");
        }

        public void CheckMark()
        {
            list.Add(this);
            if(AvgMark != null)
            {
                OnMarkChecked?.Invoke(AvgMark, "Оценки сверены!");
            }
            
        }


        public C2 (int avgMark)
        {
            AvgMark = avgMark;
            OnMarkChecked += HandleCheck;

        }


        private int GetBirth()
        {
            int year = 2023 - this.Age;
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
