//Creating and Initializing an Array
//Here, the size will be decided based on the number of elements
//In this case size will be 5
int[] Numbers = { 10, 20, 30, 40, 50 };
//Accessing the Array Elements separately
Console.WriteLine("\nAccessing the Array Elements separately output is: ");
Console.WriteLine($"Numbers[0] = {Numbers[0]}");
Console.WriteLine($"Numbers[1] = {Numbers[1]}");
Console.WriteLine($"Numbers[2] = {Numbers[2]}");
Console.WriteLine($"Numbers[3] = {Numbers[3]}");
Console.WriteLine($"Numbers[4] = {Numbers[4]}");
//Accessing the Array Elements using for loop
Console.WriteLine("\nUsing For Loop output is: ");
for(int i = 0; i <= Numbers.Length-1; i++)
    Console.WriteLine($"Numbers[{i}] = {Numbers[i]}");
//Accessing the Array Elements using foreach loop
Console.WriteLine("\nUsing Foreach Loop output is: ");
int index = 0;
foreach(int number in Numbers)
    Console.WriteLine($"Numbers[{index++}] = {number}");
//hold console window
Console.ReadKey();

//output:

//Accessing the Array Elements separately output is:
//Numbers[0] = 10
//Numbers[1] = 20
//Numbers[2] = 30
//Numbers[3] = 40
//Numbers[4] = 50

//Using For Loop output is:
//Numbers[0] = 10
//Numbers[1] = 20
//Numbers[2] = 30
//Numbers[3] = 40
//Numbers[4] = 50

//Using Foreach Loop output is:
//Numbers[0] = 10
//Numbers[1] = 20
//Numbers[2] = 30
//Numbers[3] = 40
//Numbers[4] = 50