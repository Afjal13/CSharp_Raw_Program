List<int> Numbers = new List<int> ();

int currentCapacity = Numbers.Capacity;
Console.WriteLine("\nResult 1:");
Console.WriteLine("Initial Size to " + currentCapacity);

for (int i = 0; i < 50; i++)
{
    Numbers.Add(i);
    if (currentCapacity != Numbers.Capacity)
    {
        Console.WriteLine("Resize to " + Numbers.Capacity);
        currentCapacity = Numbers.Capacity;
    }
}
Console.WriteLine("\n\nResult 2:");
//===========Explain more========================
List<int> myList = new List<int>();

foreach (var element in Enumerable.Range(0, 50))
{
    myList.Add(element);
    Console.WriteLine($"Items count: {myList.Count} - List capacity: {myList.Capacity}");
}
Console.ReadKey();

//Output:

//Result 1:
//Initial Size to 0
//Resize to 4
//Resize to 8
//Resize to 16
//Resize to 32
//Resize to 64


//Result 2:
//Items count: 1 - List capacity: 4
//Items count: 2 - List capacity: 4
//Items count: 3 - List capacity: 4
//Items count: 4 - List capacity: 4
//Items count: 5 - List capacity: 8
//Items count: 6 - List capacity: 8
//Items count: 7 - List capacity: 8
//Items count: 8 - List capacity: 8
//Items count: 9 - List capacity: 16
//Items count: 10 - List capacity: 16
//Items count: 11 - List capacity: 16
//Items count: 12 - List capacity: 16
//Items count: 13 - List capacity: 16
//Items count: 14 - List capacity: 16
//Items count: 15 - List capacity: 16
//Items count: 16 - List capacity: 16
//Items count: 17 - List capacity: 32
//Items count: 18 - List capacity: 32
//Items count: 19 - List capacity: 32
//Items count: 20 - List capacity: 32
//Items count: 21 - List capacity: 32
//Items count: 22 - List capacity: 32
//Items count: 23 - List capacity: 32
//Items count: 24 - List capacity: 32
//Items count: 25 - List capacity: 32
//Items count: 26 - List capacity: 32
//Items count: 27 - List capacity: 32
//Items count: 28 - List capacity: 32
//Items count: 29 - List capacity: 32
//Items count: 30 - List capacity: 32
//Items count: 31 - List capacity: 32
//Items count: 32 - List capacity: 32
//Items count: 33 - List capacity: 64
//Items count: 34 - List capacity: 64
//Items count: 35 - List capacity: 64
//Items count: 36 - List capacity: 64
//Items count: 37 - List capacity: 64
//Items count: 38 - List capacity: 64
//Items count: 39 - List capacity: 64
//Items count: 40 - List capacity: 64
//Items count: 41 - List capacity: 64
//Items count: 42 - List capacity: 64
//Items count: 43 - List capacity: 64
//Items count: 44 - List capacity: 64
//Items count: 45 - List capacity: 64
//Items count: 46 - List capacity: 64
//Items count: 47 - List capacity: 64
//Items count: 48 - List capacity: 64
//Items count: 49 - List capacity: 64
//Items count: 50 - List capacity: 64

