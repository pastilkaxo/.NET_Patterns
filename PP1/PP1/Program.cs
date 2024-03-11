
using PP1;

class Programm
{
    static void Main()
    {
        C1 c1 = new C1(19,"ПП",true,"Vlad",28,"vlad.lemeshok@gmail.com");
        c1.PrintStudent();
        C1 c2 = new C1(c1);
        c2.PrintStudent();
        C1 c3 = new C1();
        c3.PrintStudent();


        Console.WriteLine("------------------");

        C2 c21 = new C2(5);
        c21.CheckMark();
        c21.PrintStudent();

        C2 c22 = c21[0];
        c22.PrintStudent();

        Console.WriteLine("------------------");

        C4 c41 = new C4("Message From C4",1," Private from C3 #1",c21.AvgMark);
        c41.PrintMsg();
        c41.SelfFunc();
        Console.WriteLine("------------------");
        C3 c31 = new C4("Message From C3", 2 , " Private from C3 #2",c21.AvgMark);
        c31.PrintMsg();
        

    }
}