
//Dynamically Initializing an Array in C#
int[] Numbers = new int[5];

//before initializing the array
Console.WriteLine("\nBefore initializing the Array: ");
int i = 0;
foreach(int number in Numbers)
    Console.WriteLine($"Numbers[{i++}] = {number}");

int value = 0;
for(int j = 0; j <= Numbers.Length - 1; j++)
{
    value += 10;
    Numbers[j] = value;
}
Console.WriteLine("\nAfter initializing the Array: ");
//after initializing the array
i = 0;
foreach (int number in Numbers)
    Console.WriteLine($"Numbers[{i++}] = {number}");

Console.ReadKey();