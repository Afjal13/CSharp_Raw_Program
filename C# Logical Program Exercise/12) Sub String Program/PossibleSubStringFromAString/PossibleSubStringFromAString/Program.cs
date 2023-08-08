//print possible all sub string from a string using a simple approach
//define required library package
using System.Text;
//declare inputString field
string inputString;
//take a string
Console.Write("\nEnter a String: ");
inputString = Console.ReadLine();   
//sub string mechanism
for(int i = 0; i < inputString.Length; ++i)     //outter loop for each letter
{
    StringBuilder subString = new StringBuilder();    //create new string object for each sub string
    for(int j = i; j < inputString.Length; ++j)     //inner loop for sub string on outter loop letter
    {
        subString.Append(inputString[j]);     //make sub string
        Console.Write(subString + " ");    //print sub string
    }
    
}
//hold console window
Console.ReadKey();

//output:

//Enter a String: xyz
//x xy xyz y yz z
