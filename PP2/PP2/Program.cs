
using  PP2;

class Programm
{
    static void Main()
    {
        Organiztion org = new Organiztion(1,"Vladislav","Vlad" ,"Minsk",DateTime.Now);
        org.printInfo();
        University university = new University();
        Department department = new Department("ISIT");
        Department department2 = new Department("POIT");
        Faculty faculty = new Faculty();
        faculty.addDepartment(department);
        faculty.addDepartment(department2);
        university.addFaculty(faculty);
        for (int i = 0; i < university.GetFaculties().Count; i++)
        {
            Console.WriteLine("Факультетов: " + university.GetFaculties().Count);
        }
        Console.WriteLine("Специальностей:" + faculty.getDepartments().Count);
        JobVacancy vacancy = new JobVacancy("Ассистент");
        JobTitle jobTitle = new JobTitle("Помощник");
        Person person = new Person("Alex");
        org.openJobVacancy(vacancy);
        Console.WriteLine("Открытые вакансии:" + org.printJobVacancies());
        Console.WriteLine($"{faculty.recruit(vacancy, person).empName} назначен на роль {faculty.recruit(vacancy, person).empVac}");
        org.closeJobVacancy(0);
        Reason reason = new Reason("По С.Ж.");
        faculty.dismiss(0, reason);
    }
}