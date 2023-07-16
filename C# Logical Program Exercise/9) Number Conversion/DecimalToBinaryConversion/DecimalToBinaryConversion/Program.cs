//Algorithm analysis
/*
Decimal to Binary Conversion Algorithm
Step 1: Divide the number by 2 through % (modulus operator) and store the remainder in array
Step 2: Divide the number by 2 through / (division operator)
Step 3: Repeat the step 2 until the number is greater than zero
*/
//declare variable
int inputNumber, i = 0;
int[] binaryArray = new int[10];
//take input decimal number
Console.Write("\nEnter any decimal number to convert:__");
inputNumber = Convert.ToInt32(Console.ReadLine());
//formula of decimal to binary
while (inputNumber > 0)
{
    binaryArray[i] = inputNumber % 2;
    inputNumber = inputNumber / 2;
    i++;
}
//display binary results
Console.Write($"\nAfter Conversion, Binary of the given number: ");
for (i = i - 1; i >= 0; i--)
{
    Console.Write(binaryArray[i]);
}
//hold console window
Console.ReadKey();

//output:

//Enter any decimal number to convert:__10

//After Conversion, Binary of the given number: 1010