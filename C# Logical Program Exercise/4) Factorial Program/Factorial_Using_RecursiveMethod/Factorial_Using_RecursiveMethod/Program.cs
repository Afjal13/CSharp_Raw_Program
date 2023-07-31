//Factorial of a number using Recursive Method 
//declare required variable
int readNumber;
long factorialNumber;
//Read a number from console
Console.Write("\nEnter a Number: ");
readNumber=Convert.ToInt32(Console.ReadLine());
// Recursive method
factorialNumber=RecursiveFactorialMethod(readNumber);
//display result
Console.Write($"\n\n\tFactorial is: {factorialNumber}");
//hold console window
Console.ReadKey();
//Recursive method mechanism
static long RecursiveFactorialMethod(int readNumber)
{
    if(readNumber==1)
        return 1;
    else
        return readNumber*RecursiveFactorialMethod(readNumber-1);
}

//output:

//Enter a Number: 6


//        Factorial is: 720