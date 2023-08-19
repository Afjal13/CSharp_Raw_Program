using System.Diagnostics;

List<int> List1 = new List<int>(1000); //Capacity 1000
List<int> List2 = new List<int>(); //Default Capacity 0

Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();

for (int i = 0; i < 10000; i++)
    List1.Add(i);

stopwatch.Stop();
Console.WriteLine($"Time Taken for List1: {stopwatch.ElapsedMilliseconds} ms.");


stopwatch.Restart();

for (int i = 0; i < 10000; i++)
    List2.Add(i);

stopwatch.Stop();
Console.WriteLine($"\nTime Taken for List2: {stopwatch.ElapsedMilliseconds} ms.");

Console.ReadKey();
//This code will add 10000 integers to both lists and measure the time taken to do so.
//The output will look something like this:

//Time Taken for List1: 3 ms.

//Time Taken for List2: 0 ms.

//Which had an initial capacity of 1000, was able to add all 10000 integers without having to
//resize its internal array.On the other hand, list2 had to resize its internal array
//multiple times during the process, which resulted in slower performance.

//This example shows that initializing a list with an appropriate capacity can improve
//performance by reducing the number of times the list needs to resize its internal array.

