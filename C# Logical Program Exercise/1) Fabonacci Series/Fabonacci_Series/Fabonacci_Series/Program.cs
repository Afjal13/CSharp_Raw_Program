//Fabonacci Series Solution
//Fabonacci Series without Recursive Method
Console.WriteLine("\nFabonacci Series without Recursive Solution:\n\n");
int firstNumber = 0, secondNumber = 1, temp,inputNumber;
Console.Write("Enter the number of elements:__");
inputNumber=Convert.ToInt32(Console.ReadLine());
Console.Write($"\nFebonacci Series:\n{firstNumber} {secondNumber} ");
for(int i = 2; i < inputNumber; i++)
{
    temp = firstNumber + secondNumber;
    Console.Write(temp+" ");
    firstNumber = secondNumber;
    secondNumber = temp;
}
Console.WriteLine("\n\nFabonacci Series Recursive Solution:\n");

int RecfirstNumber = 0, RecSecondNumber = 1, RecCounter = 1, RecInputNumber;
Console.Write("Enter the Recursion number of elements:__");
RecInputNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("\nFebonacci Series:\n");
RecursiveMethod(RecfirstNumber, RecSecondNumber, RecCounter, RecInputNumber);
//using recursive function
 static void RecursiveMethod(int RecfirstNumber, int RecSecondNumber, int RecursionCounter, int RecInputNumber)
{
    Console.Write(RecfirstNumber + " ");
    if (RecursionCounter < RecInputNumber)
    {
        RecursiveMethod(RecSecondNumber, RecfirstNumber+RecSecondNumber, RecursionCounter+1, RecInputNumber);
    }
}
Console.ReadKey();