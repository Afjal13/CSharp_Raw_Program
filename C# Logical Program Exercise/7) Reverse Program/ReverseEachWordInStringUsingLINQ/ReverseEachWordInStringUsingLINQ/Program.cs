//Using Linq to Reverse Each Word in C#
Console.Write("Enter a String : ");
string originalString = Console.ReadLine();

string reverseWordString = string.Join(" ", originalString
.Split(' ')
.Select(x => new String(x.Reverse().ToArray())));
Console.WriteLine($"Reverse Word String : {reverseWordString}");
Console.ReadKey();
//output:
///Enter a String : Welcome to CSharp
//Reverse Word String : emocleW ot prahSC