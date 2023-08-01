/*Using Linq to find the sum of digits of a number in C#:
In the following program, first, we convert the integer into a string. 
As we know a string is an array of characters, so we use 
the Select operator to iterate over the array. For each character digit, first,
we parse it to a string and then we parse it to an int. Send the resulting 
enum to an int[] array. And then apply the Sum extension method to it to get 
the desired result.*/
//====================================****============================================
//declare required field with initialize sum by 0
int readNumber, sum = 0, temp;
//take a number
Console.Write("\nEnter a Number: ");
readNumber = int.Parse(Console.ReadLine());
//store readnumber value to temp field
temp = readNumber;
//calculate sum of digits value and assign the value to sum field using Linq
sum = readNumber.ToString().Select(digit => int.Parse(digit.ToString())).ToArray().Sum();

//display sum result
Console.WriteLine($"\n\n\tThe Sum of Digits is : {sum}");
Console.ReadKey();

//output:

//Enter a Number: 3647


//        The Sum of Digits is : 20
