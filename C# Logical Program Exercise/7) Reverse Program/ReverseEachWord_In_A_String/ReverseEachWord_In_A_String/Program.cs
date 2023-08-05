//How to Reverse Each Word in a Given String in C#
//declare a string field
string inputMessage;
//take a string message from console
Console.Write("\nEnter the string: ");
inputMessage = Console.ReadLine ();
//break the given string message into sub string and also store into a string array
string[]  messageArray = inputMessage.Split (' ');
//declare reverse string field with initialize by empty 
string reverseMessage = string.Empty;
//take a temporary string field
string temp;
//all sub string reverse mechanism
for (int i = 0; i < messageArray.Length; i++) //take a sub string from array
{
    temp = messageArray [i];
    //reverse each sub string
    for (int j = temp.Length-1; j>=0 ; j--) 
    {
        reverseMessage +=temp [j];
    }
    //after reverse each sub string then added white space
    reverseMessage = reverseMessage + " ";
}
//display reverse string result
Console.Write ($"\n\n\tAfter Reverse string is: {reverseMessage}");
//hold console window
Console.ReadKey ();

//output:

//Enter the string: Committed! We will save our country in any situation


//        After Reverse string is: !dettimmoC eW lliw evas ruo yrtnuoc ni yna noitautis