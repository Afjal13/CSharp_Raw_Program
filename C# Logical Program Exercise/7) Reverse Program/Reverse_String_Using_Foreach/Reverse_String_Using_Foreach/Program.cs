//How to reverse a string using for each loop in C#

//declare required variable fields
string inputStr, reverseStr;

//Take input String 
Console.Write("\nEnter a String: ");
inputStr = Console.ReadLine();

//initialize by empty value
reverseStr = string.Empty;

//String reverse mechanism using foreach loop
foreach (char c in inputStr)
{
    reverseStr = c + reverseStr;
}

//Display reverse string 
Console.WriteLine($"\n\tReverse of given string is: {reverseStr}\n");

//hold console window
Console.ReadKey();

//output

//Enter a String: Afjal

//        Reverse of given string is: lajfA
