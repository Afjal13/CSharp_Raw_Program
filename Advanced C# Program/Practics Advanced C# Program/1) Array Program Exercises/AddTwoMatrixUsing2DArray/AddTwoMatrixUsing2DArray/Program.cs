//Program to Add 2 Matrices using C#
//declare two fields for matrix row & column
int rows, columns;
//take row quantity of matrix
Console.Write("Enter Matrix Rows: ");
rows = Convert.ToInt32(Console.ReadLine());
//take column quantity of matrix
Console.Write("Enter Matrix Columns: ");
columns = Convert.ToInt32(Console.ReadLine());
//declare 2D matrix array
int[,] MatrixOne = new int[rows, columns];
int[,] MatrixTwo = new int[rows, columns];
int[,] ResultMatrix = new int[rows, columns];
//initializing 1st matrix by user value
Console.WriteLine("\nEnter 1st Matrix Value: ");
for (int i = 0; i < rows; i++)
{
    Console.WriteLine($"\nColumn value of Row {i + 1}: ");
    for (int j = 0; j < columns; j++)
    {
        MatrixOne[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
//initializing 2nd matrix by user value
Console.WriteLine("\nEnter 2nd Matrix value: ");
for (int i = 0; i < rows; i++)
{
    Console.WriteLine($"\nColumn value of Row {i + 1}: ");
    for (int j = 0; j < columns; j++)
    {
        MatrixTwo[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}
//addition mechanism between two matrix
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        ResultMatrix[i, j] = MatrixOne[i, j] + MatrixTwo[i, j];
    }
}
//display result matrix
Console.WriteLine("\nAfter Added two Matrix result is: ");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(ResultMatrix[i, j] + " ");
    }
    Console.WriteLine();
}
//hold console window
Console.ReadKey();


//output:
//Enter Matrix Rows: 2
//Enter Matrix Columns: 3

//Enter 1st Matrix Value:

//Column value of Row 1:
//3
//2
//5

//Column value of Row 2:
//1
//4
//2

//Enter 2nd Matrix value:

//Column value of Row 1:
//4
//5
//2

//Column value of Row 2:
//7
//4
//6

//After Added two Matrix result is:
//7 7 7
//8 8 8
