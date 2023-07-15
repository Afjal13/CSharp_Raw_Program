//calculate sum of total digit of input number
//declare variable;
int inputNumber = 0, cacheNumber, temp=0, count=0,sum = 0 ;
//take user input digits;
Console.Write("\nEnter any Number(digits):__");
inputNumber = Convert.ToInt32(Console.ReadLine());
cacheNumber = inputNumber;
//calculate of input digits
while (inputNumber > 0)
{
    temp = inputNumber % 10;
    sum += temp;
    inputNumber=inputNumber / 10;
    count++;
}
//display output results
Console.WriteLine($"\nHere, {cacheNumber} is entered number and total digits is {count} and sum of digits value is {sum}");
//hold console window
Console.ReadKey();