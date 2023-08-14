//Creating and Initializing an Array of Integers
//Size of the Array is 10
int[] Numbers = { 17, 23, 4, 59, 27, 36, 96, 9, 1, 3 };
//Printing the Array Elements using a for Loop
Console.WriteLine("Original Array Elements :");
for (int i = 0; i < Numbers.Length; i++)
{
    Console.Write(Numbers[i] + " ");
}
Console.WriteLine();

//Sorting the Array Elements by using the Sort method of Array Class
Array.Sort(Numbers);  //Sort(<array>): Sorting the array elements
//Printing the Array Elements After Sorting using a foreach loop

Console.WriteLine("\nArray Elements After Sorting :");
foreach (int i in Numbers)
{
    Console.Write(i + " ");
}
Console.WriteLine();

//Reversing the array elements by using the Reverse method of Array Class
Array.Reverse(Numbers); //Reverse (<array>): Reversing the array elements
//Printing the Array Elements in Reverse Order
Console.WriteLine("\nArray Elements in the Reverse Order :");
foreach (int i in Numbers)
{
    Console.Write(i + " ");
}
Console.WriteLine();

//Creating a New Array
int[] NewNumbers = new int[10];
//Copying Some of the Elements from Old array to new array
//We declare the array with size 10 and we copy only 5 elements. 
//So the rest 5 elements will take the default value. In this array, it will take 0
Array.Copy(Numbers, NewNumbers, 5); //Copy (src, dest, n): Copying some of the elements or all elements from the old array to the new array

//Printing the Array Elements using for Each Loop
Console.WriteLine("\nNew Array Elements :");
foreach (int i in NewNumbers)
{
    Console.Write(i + " ");
}
Console.WriteLine();
Console.WriteLine($"\nNew Array Length using Length Property :{NewNumbers.Length}"); //GetLength(int): A 32-bit integer that represents the number of elements in the specified dimension.
Console.WriteLine($"New Array Length using GetLength Method :{NewNumbers.GetLength(0)}"); //Length: It Returns the total number of elements in all the dimensions of the Array; zero if there are no elements in the array. 
Array.Clear(Numbers, 0, NewNumbers.Length-5);
Console.WriteLine("\nAfter Clear New Array Elements :");
foreach (int i in Numbers)
{
    Console.Write(i + " ");
}
Console.WriteLine();
//GetValue vs SetValue in array...
//before setvalue
Console.WriteLine($"Before SetValue, Element at index 0 is: {Numbers.GetValue(0)}\n");
Numbers.SetValue(99, 0);
Console.WriteLine($"After SetValue, Element at index 0 is: {Numbers.GetValue(0)}\n");
// declaring an 2-D array
int[,] arr2d = new int[4, 2];

// declaring an 3-D array
int[,,] arr3d = new int[4, 2, 3];

// declaring an jagged array
int[][] jdarr = new int[2][];

// using Rank Property
Console.WriteLine("Dimension of arr2d array: "
                                + arr2d.Rank);

Console.WriteLine("Dimension of arr3d array: "
                                + arr3d.Rank);

// for the jagged array it 
// will always return 1
Console.WriteLine("Dimension of jdarr array: "
                                + jdarr.Rank);

Console.ReadKey();