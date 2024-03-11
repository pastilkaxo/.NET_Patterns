namespace Lab03LibN
{
    static public partial class Lec03BLib
    {
        static public IFactory getL1()
        {
            return new Factory1();
        }
        static public IFactory getL2(float a)
        {
            return new Factory2(a);
        }

        static public IFactory getL3(float a, float b)
        {
            return new Factory3(a, b);
        }
    }
}
