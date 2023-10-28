namespace RecursiveDemo
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
           Program program = new Program();
            int[] y = { 1, 3, 2, 8 };
            program.function(y, 2);

            Console.ReadKey();  

        }
        int function(int[] x, int i)
        {
            int s = x[i];
            if (i > 0)
                s =s+ function(x, i - 1);
            Console.Write(s);
            return s;
        }
    }
}
output: 146
