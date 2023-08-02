//Binary to Decimal conversion using LinQ
//declare variable
int binaryNumber, decimalValue;
//Take a binary number
Console.Write("\nEnter a binary Number: ");
binaryNumber = int.Parse(Console.ReadLine());
//convert mechanism using linq formula
decimalValue = Convert.ToInt32(binaryNumber.ToString(), 2);
//display decimal result
Console.Write($"\n\n\tDecimal Value : {decimalValue} ");
//hold console window
Console.ReadKey();
//output:

//Enter a binary Number: 1010


//        Decimal Value : 10
