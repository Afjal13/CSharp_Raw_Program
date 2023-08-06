//The simple way of Implementation to remove duplicate characters from a string
//read a string
Console.Write("\nEnter the string: ");
string readMessage = Console.ReadLine();
//declare empty string field
string resultString = string.Empty;
//remove duplicate character from string mechanism
for(int i = 0; i < readMessage.Length; i++)
{
    if (!resultString.Contains(readMessage[i]))
    {
        resultString +=readMessage[i];
    }
}
//display result
Console.WriteLine($"\nOriginal String is: {readMessage}\n\n\tAfter Removed duplicated Character, String is: {resultString}");
//hold console window
Console.ReadKey();

//output:

//Enter the string: afjal

//Original String is: afjal

//        After Removed duplicated Character, String is: afjl