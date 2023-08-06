//Using LINQ to Remove Duplicate Characters From a String
Console.Write("Enter a String : ");
string inputString = Console.ReadLine();
//remove duplicate using LINQ mechanism
var uniqueCharArray = inputString.ToCharArray().Distinct().ToArray();
//convert into string
var resultString = new string(uniqueCharArray);
//display
Console.WriteLine("After Removing Duplicates : " + resultString);
//hold console window
Console.ReadKey();
//output
//Enter a String : afjal
//After Removing Duplicates : afjl