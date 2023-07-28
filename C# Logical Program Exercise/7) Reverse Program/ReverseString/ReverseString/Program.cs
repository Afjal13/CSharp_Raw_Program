//How to reverse a string in C#?
//declare required variable fields
int i;
string inputStr, reverseStr;
//initialize by empty value
reverseStr = string.Empty;

//Take input String 
Console.Write("\nEnter a string: ");
inputStr = Console.ReadLine();
//String reverse mechanism 
for(i = inputStr.Length-1; i >=0 ; i--)
{
    reverseStr+=inputStr[i];
}
//Display results
Console.Write("\nReverse String: ");
Console.Write(reverseStr);
//hold console window
Console.ReadKey();
//output
//Enter a string: Afjal

//Reverse String: lajfA

