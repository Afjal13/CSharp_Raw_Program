//2D Array in C#
//Create Two-Dimensional Array
int[,] SalaryList = new int[3, 4];

//print 2D array result before initialize 
Console.WriteLine("\nBefore Initialize 2D Array is: ");
foreach(int Arr2D in SalaryList)
    Console.Write(Arr2D+" ");

//Initialize 2D array 
int temp = 0;
for(int i = 0; i <=SalaryList.GetLength(0)-1; i++)
{
    for(int j = 0; j <=SalaryList.GetLength(1)-1; j++)
    {
        temp += 500;
        SalaryList[i,j] = temp;
    }
}
Console.WriteLine();
//print 2D array result after initialize
Console.WriteLine("\nAfter Initialize 2D Array is: ");
foreach(int Arr2D in SalaryList)
    Console.Write(Arr2D+" ");

//hold console window
Console.ReadKey();

//output:

//Before Initialize 2D Array is:
//0 0 0 0 0 0 0 0 0 0 0 0

//After Initialize 2D Array is:
//500 1000 1500 2000 2500 3000 3500 4000 4500 5000 5500 6000
