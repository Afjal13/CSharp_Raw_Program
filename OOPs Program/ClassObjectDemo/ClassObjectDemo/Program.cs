namespace ClassObjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();
            obj.num1 = 10;
            obj.num2 = 20;
            obj.Display();

            Console.ReadKey();
        }
    }

    public class Test
    {
        public int num1;
        public int num2;

        public void Display() {
            Console.WriteLine($"Sum is: {num1+num2}");
        }
    }
}