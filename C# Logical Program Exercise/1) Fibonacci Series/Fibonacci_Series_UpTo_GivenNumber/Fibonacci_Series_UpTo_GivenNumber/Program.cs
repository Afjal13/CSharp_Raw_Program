//How to Print the Fibonacci Series up to a given number in C#?
//declare required variable field
int firstNumber, secondNumber, nextNumber, inputNumber;
//take input number range
Console.Write("\nEnter the number upto which print the Fibonacci Series: ");
inputNumber = Convert.ToInt32(Console.ReadLine());
//initialize first & second value of fibonacci series
firstNumber = 0;
secondNumber = 1;
//define next number of series
nextNumber = firstNumber + secondNumber;
//upto fibonacci series mechanism
Console.Write("\nResults: ");
Console.Write($"{firstNumber} {secondNumber} ");
while(nextNumber < inputNumber)
{
    Console.Write(nextNumber+" ");
    firstNumber = secondNumber;
    secondNumber = nextNumber;
    nextNumber=firstNumber + secondNumber;
}
//hold the console window
Console.ReadKey();

//output:
//Enter the number upto which print the Fibonacci Series: 50

//Results: 0 1 1 2 3 5 8 13 21 34
