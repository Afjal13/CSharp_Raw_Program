//How to reverse a string using Array.Reverse() method in C#

//declare required variable fields
string inputStr, reverseStr;

//Take input String 
Console.Write("\nEnter a String: ");
inputStr = Console.ReadLine();

//convert to character array of given string
char[] strArray = inputStr.ToCharArray();

//Reverse of character array
Array.Reverse(strArray);

//convert to string of reverse array
reverseStr = new string(strArray);

//display reverse string
Console.WriteLine($"\n\tThe Reverse string is: {reverseStr}");

//hold console window
Console.ReadKey();

//output:

//Enter a String: Afjal

//        The Reverse string is: lajfA