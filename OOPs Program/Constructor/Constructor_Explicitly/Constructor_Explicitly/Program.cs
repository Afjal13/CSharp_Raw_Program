using System.Xml;

namespace Constructor_Explicitly
{
    internal class Program
    {
        static void Main(string[] args)
        {
            First f1 = new First();
            First f2 = new First();
            First f3 = new First();
            Console.WriteLine($"{f1.x}   {f2.x}   {f3.x}");
            Second s1 = new Second(100); //100 wll send to local variable x
            Second s2 = new Second(200); //200 wll send to local variable x
            Second s3 = new Second(300); //300 wll send to local variable x
            Console.WriteLine($"{s1.x}   {s2.x}   {s3.x}");
            Console.ReadKey();
        }
    }
    class First
    {
        public int x = 100;
    }

    class Second
    {
        public int x;
        //Parameterized Explicit Constructor
        public Second(int x)
        {
            this.x = x;
        }
    }
}

//Output:
//100   100   100
//100   200   300
