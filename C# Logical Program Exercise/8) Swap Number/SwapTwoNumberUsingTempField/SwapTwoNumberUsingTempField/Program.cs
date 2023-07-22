//Swap Conversion between two number
//declare require variable field
int firstNumber, secondNumber, tempField;
//Title
Console.WriteLine("\n\t\tSwap Conversion Between Two Number!\n");
//Take two input number
Console.Write("\nEnter the First Number:__");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("\nEnter the Second Number:__");
secondNumber = Convert.ToInt32(Console.ReadLine());
//Before swap, display given two input number
Console.WriteLine($"\n\nBefore Swap:\nFirst Number is: {firstNumber}\nSecond Number is: {secondNumber}");
//swap between two number using 3rd variable tempField
tempField = firstNumber;       //first number keep into the variable tempField 
firstNumber = secondNumber;   //then second number keep into the variable firstNumber
secondNumber = tempField;    //then tempField number keep into the variable secondNumber
//After swap, display given two input number
Console.WriteLine($"\n\nAfter Swap:\nFirst Number is: {firstNumber}\nSecond Number is: {secondNumber}");
Console.ReadKey();


//output:

//Swap Conversion Between Two Number!


//Enter the First Number:__5

//Enter the Second Number:__10


//Before Swap:
//First Number is: 5
//Second Number is: 10


//After Swap:
//First Number is: 10
//Second Number is: 5
