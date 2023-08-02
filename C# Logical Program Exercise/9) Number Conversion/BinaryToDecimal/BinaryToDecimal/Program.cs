//Binary to decimal
//declare variable
int readBinary, reminder,baseValue,decimalValue;
//take a binary number
Console.Write("\nEnter the binary number: ");
readBinary = Convert.ToInt32(Console.ReadLine());
//initialize by decimal value by 0 and base value by 1 
decimalValue = 0;
baseValue = 1;
//binary to decimal formula
while (readBinary > 0)
{
    reminder = readBinary % 10;
    decimalValue += reminder * baseValue;
    readBinary = readBinary / 10;
    baseValue = baseValue * 2;
}
//display decimal result
Console.Write($"\n\n\tDecimal Value : {decimalValue} ");
//hold console window
Console.ReadKey();

//output:

//Enter the binary number: 1010


//      Decimal Value: 10