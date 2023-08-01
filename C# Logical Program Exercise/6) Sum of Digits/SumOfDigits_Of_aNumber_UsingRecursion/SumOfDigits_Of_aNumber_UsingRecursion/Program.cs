//Finding the sum of digits of a number using Recursion method
//declare required field with initialize sum by 0
int readNumber, sum = 0, temp;
//take a number
Console.Write("\nEnter a Number: ");
readNumber=Convert.ToInt32(Console.ReadLine());
//store readnumber value to temp field
temp=readNumber;
//calculate sum of digits value and assign the value to sum field
sum = SumOfDigits(readNumber);
//display sum result
Console.Write($"\n\n\tEntered digits is: {temp}\n\n\tThe sum of digits is: {sum}");
//hold console window
Console.ReadKey();

//recursive mechanism
int SumOfDigits(int readNumber)
{
    if(readNumber ==0)
        return 0;
    else
        return (readNumber%10+SumOfDigits(readNumber/10));
}

//output:

//Enter a Number: 3647


//        Entered digits is: 3647

//        The sum of digits is: 20