//Factorials of a number using Do while loop in C#
//declare required variable 
int readNumber, factNumber;
//Read a number from console
Console.Write("\nEnter a Number: ");
readNumber = int.Parse(Console.ReadLine());
//initialize by factorial start value 1
factNumber = 1;
//factorial mechanism using do while loop
do
{
    factNumber *= readNumber;
    readNumber--;
}
while (readNumber > 0);

//display factorial output
Console.Write($"\n\n\tFactorial is: {factNumber}");
//hold console window
Console.ReadLine();


//output:

//Enter a Number: 6


//        Factorial is: 720