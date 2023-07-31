//Factorials of a number using while loop in C#
//declare required variable 
int readNumber,factNumber;
//Read a number from console
Console.Write("\nEnter a Number: ");
readNumber = int.Parse(Console.ReadLine());
//initialize by factorial start value 1
factNumber = 1;
//factorial mechanism
while (readNumber != 1)
{
    factNumber *= readNumber;
    readNumber--;
}
//display factorial output
Console.Write($"\n\n\tFactorial is: {factNumber}");
//hold console window
Console.ReadLine();


//output:

//Enter a Number: 6


//        Factorial is: 720