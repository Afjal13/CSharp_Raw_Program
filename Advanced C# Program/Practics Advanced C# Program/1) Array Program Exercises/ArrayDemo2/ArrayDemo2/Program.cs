//Creating an Integer Array with size 3
int[] Numbers = new int[3];
//Accessing the Array Elements Before Initialization
Console.WriteLine("Accessing the Array Elements Before Initialization");
for (int i = 0; i <= Numbers.Length - 1; i++)
{
    Console.WriteLine($"Numbers[{i}] = {Numbers[i]}");
}
//Initializing the Array Elements using the Index Position
Numbers[0] = 10;
Numbers[1] = 20;
Numbers[2] = 30;
//Accessing the Array Elements After Initialization
Console.WriteLine("\nAccessing the Array Elements After Initialization");
for (int i = 0; i <= Numbers.Length - 1; i++)
{
    Console.WriteLine($"Numbers[{i}] = {Numbers[i]}");
}

Console.ReadKey();