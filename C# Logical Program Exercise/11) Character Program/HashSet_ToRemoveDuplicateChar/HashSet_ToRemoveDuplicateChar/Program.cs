//Using HashSet to Remove Duplicate Characters from string 
//Take a string 
Console.Write("Enter a String : ");
string inputString = Console.ReadLine();
//declare result string field with empty
string resultString = string.Empty;
//string convert into character HasSet object
var unique = new HashSet<char>(inputString);
//removed duplicate
foreach (char c in unique)
{
    resultString += c;
}
//display
Console.WriteLine("After Removing Duplicates : " + resultString);
//hold console window
Console.ReadKey();

//output
//Enter a String : afjal
//After Removing Duplicates : afjl