List<int> Numbers = new List<int>();      //[] Count: 0  Capacity: 0
Console.WriteLine("\n\tInitial Step:");
Console.WriteLine($"\nTotal element is: {Numbers.Count}");
Console.WriteLine($"\nTotal Capacity is: {Numbers.Capacity}");

Console.WriteLine("\n\t1st Step:");
Numbers.Add(10);     //[10,null,null,null] Count: 1  Capacity: 4

Console.WriteLine($"\nTotal element is: {Numbers.Count}");
Console.WriteLine($"\nTotal Capacity is: {Numbers.Capacity}");

Console.WriteLine("\n\t2nd Step:");
Numbers.Add(15);    //[10,15,null,null] Count: 2  Capacity: 4
Numbers.Add(55);    //[10,15,55,null] Count: 3  Capacity: 4
Numbers.Add(5);     //[10,15,55,5] Count: 4  Capacity: 4

Console.WriteLine($"\nTotal element is: {Numbers.Count}");
Console.WriteLine($"\nTotal Capacity is: {Numbers.Capacity}");

Console.WriteLine("\n\t3rd Step:");
Numbers.Add(15);    //[10,15,55,5,15,null,null,null] Count: 5  Capacity: 8

Console.WriteLine($"\nTotal element is: {Numbers.Count}");
Console.WriteLine($"\nTotal Capacity is: {Numbers.Capacity}");

Console.WriteLine("\n\t4th Step:");
Numbers.Clear();    //[null,null,null,null,null,null,null,null] Count: 0  Capacity: 8

Console.WriteLine($"\nTotal element is: {Numbers.Count}");
Console.WriteLine($"\nTotal Capacity is: {Numbers.Capacity}");

Console.WriteLine("\n\t5th Step:");
Numbers.Add(35);    //[35,null,null,null,null,null,null,null] Count: 1  Capacity: 8

Console.WriteLine($"\nTotal element is: {Numbers.Count}");
Console.WriteLine($"\nTotal Capacity is: {Numbers.Capacity}");

Console.WriteLine("\n\t6th Step:");
Numbers.TrimExcess();   //[35] Count: 1  Capacity: 1

Console.WriteLine($"\nTotal element is: {Numbers.Count}");
Console.WriteLine($"\nTotal Capacity is: {Numbers.Capacity}");

Console.WriteLine("\n\t7th Step:");
Numbers.Clear();    //[null] Count: 0  Capacity: 1
Numbers.TrimExcess();   //[] Count: 0  Capacity: 0

Console.WriteLine($"\nTotal element is: {Numbers.Count}");
Console.WriteLine($"\nTotal Capacity is: {Numbers.Capacity}");

Console.WriteLine("\n\n========numbers start=======");
List<int> numbers = new List<int>();
numbers.Add(5);
numbers.Add(1);
numbers.Add(3);
numbers.Add(2);
numbers.Add(0);
Console.WriteLine(numbers.Capacity);
numbers.Clear();
Console.WriteLine(numbers.Capacity);
numbers.TrimExcess();
Console.WriteLine(numbers.Capacity);
Console.WriteLine("========numbers end=======\n\n");

//Contains, Exists, Find, FindAll, FindIndex, FindLast, FindLastIndex, LastIndexOf, IndexOf
List<int> MyNumbersList = new List<int> { 35, 39, 42, 88, 42, 99, 105, 120, 55 };

//search specific element is contain or not in the list
Console.WriteLine($"Contains Result is: {MyNumbersList.Contains(35)}");

//predicate condition in the list on given element
Console.WriteLine($"Exits Result is: {MyNumbersList.Exists(i => i >= 35)}");

//Binary search [most of the use for sorted list]
var binaryIndex = MyNumbersList.BinarySearch(88);
Console.WriteLine($"If the element is in List then Binary Result is: {binaryIndex}");
var binaryIndex1 = MyNumbersList.BinarySearch(250);
Console.WriteLine($"If the element is not in List then Binary Result is: {binaryIndex1}");

//IndexOf [Faster then binary search]
var binaryIndexOf = MyNumbersList.IndexOf(88);
Console.WriteLine($"If the element is in List then IndexOf Result is: {binaryIndexOf}");
var binaryIndexOf1 = MyNumbersList.IndexOf(250);
Console.WriteLine($"If the element is not in List then IndexOf Result is: {binaryIndexOf1}");

//Find nearest single element on specific condition on given element
Console.WriteLine($"Find Result is: {MyNumbersList.Find(i => i > 35)}");

//Find all element on specific condition on given element
Console.WriteLine($"FindAll Result is: ");
List<int> FindAllElements = MyNumbersList.FindAll(i => i > 42);
foreach (int element in FindAllElements)
    Console.WriteLine(element);

int findIndexElement = MyNumbersList.FindIndex(4, i => i > 55);
Console.WriteLine($"FindIndex Result is: {findIndexElement}");

Console.WriteLine($"FindLast Result is: {MyNumbersList.FindLast(i => i > 55)}");

var last = MyNumbersList.LastOrDefault();
Console.WriteLine($"LastOrDefault Result is: {last}");

var first = MyNumbersList.FirstOrDefault();
Console.WriteLine($"FirstOrDefault Result is: {first}");

//AddRange() method in list

int[] numbersArray = new int[] { 10, 20, 30 };

MyNumbersList.AddRange(numbersArray);
Console.WriteLine($"By AddRange Mehtod, after added an array List Result is: ");
foreach (int element in MyNumbersList)
    Console.WriteLine(element);

List<int> AnotherNumbersList = new List<int> { 40, 45, 50 };

var indexN = AnotherNumbersList.BinarySearch(45); //binary search on sorted list
Console.WriteLine($"binary is: {indexN}");

//AddRange
MyNumbersList.AddRange(AnotherNumbersList);

Console.WriteLine($"By AddRange method, after added an array List Result is: ");
foreach (int element in MyNumbersList)
    Console.WriteLine(element);

//hold console window
Console.ReadKey();

//output
//Initial Step:

//Total element is: 0

//Total Capacity is: 0

//        1st Step:

//Total element is: 1

//Total Capacity is: 4

//        2nd Step:

//Total element is: 4

//Total Capacity is: 4

//        3rd Step:

//Total element is: 5

//Total Capacity is: 8

//        4th Step:

//Total element is: 0

//Total Capacity is: 8

//        5th Step:

//Total element is: 1

//Total Capacity is: 8

//        6th Step:

//Total element is: 1

//Total Capacity is: 1

//        7th Step:

//Total element is: 0

//Total Capacity is: 1


//========numbers start=======
//8
//8
//0
//========numbers end=======


//Contains Result is: True
//Exits Result is: True
//If the element is in List then Binary Result is: -6
//If the element is not in List then Binary Result is: -10
//If the element is in List then IndexOf Result is: 3
//If the element is not in List then IndexOf Result is: -1
//Find Result is: 39
//FindAll Result is:
//88
//99
//105
//120
//55
//FindIndex Result is: 5
//FindLast Result is: 120
//LastOrDefault Result is: 55
//FirstOrDefault Result is: 35
//By AddRange Mehtod, after added an array List Result is:
//35
//39
//42
//88
//42
//99
//105
//120
//55
//10
//20
//30
//binary is: 1
//By AddRange method, after added an array List Result is:
//35
//39
//42
//88
//42
//99
//105
//120
//55
//10
//20
//30
//40
//45
//50
