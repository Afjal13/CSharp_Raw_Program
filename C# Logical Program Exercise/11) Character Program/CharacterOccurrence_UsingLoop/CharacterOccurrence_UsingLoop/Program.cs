//Using Loop to Count the Character Occurrence in a String
//declare required field
string message;
int count, i;
//Read a string from console
Console.Write("\nEnter the String: ");
message =Console.ReadLine();
//convert to all string character into lower case
message =message.ToLower();
//Remove white space from read string
message = message.Replace(" ",string.Empty);
//character count mechanism
while (message.Length > 0) //check string length null or not
{
   Console.Write(message[0]+" : "); //get/print first letter of this string
    count = 0; //initialize count by 0 before check multiple letter
    for(i = 0; i < message.Length; i++) 
    {
        if(message[0]==message[i]) //check every letter into given string with first letter of this string
            count++; //count total number match character of this string 
    }
    Console.WriteLine(count); //print total matching count
    message=message.Replace(message[0].ToString(),string.Empty); //removed check letter from this string
}
//hold console window
Console.ReadKey();
//output

//Enter the String: Afjal Hossain
//a : 3
//f: 1
//j: 1
//l: 1
//h: 1
//o: 1
//s: 2
//i: 1
//n: 1
