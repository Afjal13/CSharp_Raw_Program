//Required variable initialization
int userInput, temp, divEndResult, sum = 0;
//take a user input
Console.Write("Enter a Number(digit):__");
userInput = Convert.ToInt32(Console.ReadLine());
//user input store to temp variable
temp = userInput;
//palindrome cookie
while (userInput > 0)
{
    divEndResult = userInput % 10;
    sum = (sum * 10) + divEndResult;
    userInput = userInput / 10;
}
//Check given user number palindrome or not
if (temp == sum)
    Console.WriteLine($"{temp} is Palindrome!");
else
    Console.WriteLine($"{temp} is not Palindrome!");
Console.ReadKey();
