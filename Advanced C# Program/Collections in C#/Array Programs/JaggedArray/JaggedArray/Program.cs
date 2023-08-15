//Jagged Array in C#
//Creating An jagged array with three Rows
int[][] JaggedArray = new int[3][];
//Initializing each row with different column size
//Uisng one dimensional array
JaggedArray[0] = new int[4];
JaggedArray[1] = new int[2];
JaggedArray[2] = new int[3];
//Printing the values of Jagged array using nested for loop
//It will print the default values as we are not assigning any
//values to the array
//GetLength(0): Returns the Size of the Rows (3)
Console.WriteLine("Printing the Default Values of Jagged Array:");
for (int i = 0; i <=JaggedArray.GetLength(0)-1; i++)
{
    //JaggedArray[i].Length: Returns the Length of Each Row
    for (int j = 0; j <=JaggedArray[i].Length-1; j++)
    {
        Console.Write(JaggedArray[i][j]+" ");
    }
    Console.WriteLine();
}
//Assigning values to the Jagged array by using nested for loop
for (int i = 0; i <=JaggedArray.GetLength(0)-1; i++)
{
    int value = 0;
    for ( int j = 0; j <=JaggedArray[i].Length-1; j++)
    {
        value++;
        JaggedArray[i][j] = value;
    }
}
//Printing the values of Jagged array by using foreach loop within for loop
Console.WriteLine("\n\nPrinting the Values of Jagged Array:");
for ( int i = 0; i <=JaggedArray.GetLength(0)-1; i++)
{
    foreach(int result in JaggedArray[i])
        Console.Write(result+" ");

    Console.WriteLine();
}
//[
//Note:
//You cannot simply use a foreach loop to Print the Values of a foreach loop
//foreach (var item in arr)
//{
//    Console.Write(item);
//}
//]

//hold console window
Console.ReadKey();

//output:
//Printing the Default Values of Jagged Array:
//0 0 0 0
//0 0
//0 0 0

//Printing the Values of Jagged Array:
//1 2 3 4
//1 2
//1 2 3
