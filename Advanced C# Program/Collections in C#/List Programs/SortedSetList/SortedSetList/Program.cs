//Sort List value using sort() method 
List<int> Numbers = new List<int>();

Numbers.Add(5);
Numbers.Add(2);
Numbers.Add(4);
Numbers.Add(3);
Numbers.Add(1);

Numbers.Sort();
Console.Write("using List Sort() method List is: ");
foreach (int number in Numbers)
    Console.Write(number + " ");

Console.WriteLine("\n\n");
//Sort List value without sort() method using sortedSet list 
var MyNumbersList = new SortedSet<int>();
MyNumbersList.Add(5);
MyNumbersList.Add(2);
MyNumbersList.Add(4);
MyNumbersList.Add(3);
MyNumbersList.Add(1);

Console.Write("using  SortedSet List Result is: ");
foreach (int number in MyNumbersList)
    Console.Write(number + " ");

Console.ReadKey();

//output:
//using List Sort() method List is: 1 2 3 4 5


//using SortedSet List Result is: 1 2 3 4 5