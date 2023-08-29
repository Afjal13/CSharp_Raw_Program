List<int> Numbers = new List<int> ();

Numbers.Add (10);
Numbers.Add (11);
Numbers.Add (12);
Numbers.Add (13);
Numbers.Add (14);
Numbers.Add (15);

//Remove
bool isRemoved = Numbers.Remove(0);
Console.WriteLine($"Remove result is: {isRemoved}");
isRemoved = Numbers.Remove(13);
Console.WriteLine($"Remove result is: {isRemoved}");

//RemoveAt
List<int> NumbersList1 = new List<int>();

NumbersList1.Add(20);
NumbersList1.Add(30);
NumbersList1.Add(40);

NumbersList1.RemoveAt(1);
Console.Write($"After RemoveAt List result is: ");
foreach(var number in NumbersList1)
    Console.Write(number+" ");

//RemoveAll
List<int> NumbersList2 = new List<int>();

NumbersList2.Add(25);
NumbersList2.Add(35);
NumbersList2.Add(42);
NumbersList2.Add(43);

int totalRemovedItem =NumbersList2.RemoveAll(number=>number>35);
Console.WriteLine($"\nIn RemoveAll, Total removed item is: {totalRemovedItem}");

Console.ReadKey();

//output:
//Remove result is: False
//Remove result is: True
//After RemoveAt List result is: 20 40
//In RemoveAll, Total removed item is: 0
