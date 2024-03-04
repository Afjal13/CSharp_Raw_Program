namespace ConstractorChaning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine($"Person Name: {person.GetName()}");

            Person person1 = new Person("Afjal");
            Console.WriteLine($"Person1 Name: {person1.GetName()}");

            Person person2 = new Person("Afjal", "Hossain");
            Console.WriteLine($"Person2 Name: {person2.GetName()}");

            Person person3 = new Person("Afjal","Hossain","Monni");
            Console.WriteLine($"Person3 Name: {person3.GetName()}");



            Console.ReadKey();
        }
    }
}
