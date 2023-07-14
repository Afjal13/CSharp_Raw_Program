//identify factorial/bang/shriek of number
//Enter any Number: 6
//Factorial of 6 is: 720
//==============================================

//declare variable 
int userNumber, i, factNumber=1;
// take user input
Console.Write("Enter any Number(digit):__");
userNumber =Convert.ToInt32(Console.ReadLine());
//generate factorial value 
for (i = 1; i <= userNumber; i++)
{
    factNumber = factNumber * i;
}
// display factorial output
Console.Write($"Factorial of {userNumber} is: {factNumber}");
//hold the console window
Console.ReadKey();