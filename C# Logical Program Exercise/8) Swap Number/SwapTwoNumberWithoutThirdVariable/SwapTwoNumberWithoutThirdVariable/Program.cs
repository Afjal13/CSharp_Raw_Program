//Swap between two number
//declare variable
int firstNumber, secondNumber;
//take two input number
Console.Write("\nEnter first number:__");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("\nEnter second number:__");
secondNumber = Convert.ToInt32(Console.ReadLine());
//display two number before swap
Console.WriteLine($"\nBefore Swap:\nFirst number : {firstNumber}\nSecond number: {secondNumber}");
//Swap number
firstNumber = firstNumber * secondNumber;
secondNumber = firstNumber / secondNumber;
firstNumber = firstNumber / secondNumber;
//display two number after swap
Console.WriteLine($"\nAfter Swap:\nFirst number : {firstNumber}\nSecond number: {secondNumber}\n\n");
//hold console window
Console.ReadKey();

//output:

//Enter first number:__5

//Enter second number:__10

//Before Swap:
//First number : 5
//Second number: 10

//After Swap:
//First number : 10
//Second number: 5
