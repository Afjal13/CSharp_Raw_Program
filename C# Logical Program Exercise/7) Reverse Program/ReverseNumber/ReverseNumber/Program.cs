//Create reverse of any number
//declare variable
int inputNumber, temp, count = 0,index = 0;
int[] reverseArray = new int[10];
//take a number of digits from user
Console.Write("\nEnter any Number(digits{0>or<=10}) for Reverse:__");
inputNumber = Convert.ToInt32(Console.ReadLine());
//create reverse 
while (inputNumber > 0)
{
    temp = inputNumber % 10;
    reverseArray[index] = temp;
    inputNumber = inputNumber / 10;
    count++;
    index++;
}
//display reverse results
Console.Write("\nReverse number is: ");
for (int i = 0; i < count; i++)
{
    Console.Write(reverseArray[i]);
}
//hold console window
Console.ReadKey();

//output:

//Enter any Number(digits{0>or<=10}) for Reverse:__625

//Reverse number is: 526


