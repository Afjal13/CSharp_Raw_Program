//Calculate Nth Fibonacci number 
// Using Iterative method
Console.WriteLine("\nIterative Formula:\n");
int inputNthFibonacciNumber, NthFibonacciNumber;
Console.Write("Enter Nth number of Fibonacci Series(digit):__");
inputNthFibonacciNumber = Convert.ToInt32(Console.ReadLine());
NthFibonacciNumber = inputNthFibonacciNumber - 1;
int[] FibonacciArray = new int[inputNthFibonacciNumber + 1];
FibonacciArray[0] = 0;
FibonacciArray[1] = 1;
for (int i = 2; i <= inputNthFibonacciNumber; i++)
{
    FibonacciArray[i] = FibonacciArray[i - 2] + FibonacciArray[i - 1];
}
Console.WriteLine($"\nIn Fibonacci Series, \n{inputNthFibonacciNumber}th Fìbonacci Number is: {FibonacciArray[NthFibonacciNumber]}");

//using Recursive method
Console.WriteLine("\nRecursion Formula:\n");
int RecInputNthFibonacciNumber, RecNthFibonacciNumber;
Console.Write("Enter Nth number of Fibonacci Series(digit):__");
RecInputNthFibonacciNumber = Convert.ToInt32(Console.ReadLine());
RecNthFibonacciNumber = GetNthFibonacci_Rec(RecInputNthFibonacciNumber-1);

static int GetNthFibonacci_Rec(int RecInputNthFibonacciNumber)
{
    if (RecInputNthFibonacciNumber == 0 || RecInputNthFibonacciNumber == 1)
        return RecInputNthFibonacciNumber;
    else
        return GetNthFibonacci_Rec(RecInputNthFibonacciNumber - 1) + GetNthFibonacci_Rec(RecInputNthFibonacciNumber - 2);
}
Console.WriteLine($"\nIn Fibonacci Series, \n{RecInputNthFibonacciNumber}th Fìbonacci Number is: {RecNthFibonacciNumber}");
Console.ReadKey();

//Output Screen...
//Enter Nth number of Fibonacci Series(digit):__10

//In Fibonacci Series,
//10th Fìbonacci Number is: 34
