//Decimal to binary conversion using string field
//declare variable
int readNumber;
string binaryResult;
//Take a decimal number
Console.Write("\nEnter any decimal number: ");
readNumber=Convert.ToInt32(Console.ReadLine());
//initialize by empty string 
binaryResult = string.Empty;
//decimal to binary mechanism
for(int i = 0; readNumber > 0; i++)
{
    binaryResult = readNumber % 2 + binaryResult;
    readNumber = readNumber / 2;
}
//display result
Console.Write($"\n\nBinary Represenation of the given Number : {binaryResult}");
//hold console window
Console.ReadKey();

//output:

//Enter any decimal number: 10


//Binary Represenation of the given Number : 1010