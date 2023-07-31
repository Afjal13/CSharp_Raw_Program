//Indentify Armstrong number
//declare required variable 
int InputNumber, i = 0, temp, count = 0, initialCache = 0, total = 0;
int[] arr = new int[10];
int[] sum = new int[10];
//take user input
Console.Write("Enter any Number(digits):__");
InputNumber=Convert.ToInt32(Console.ReadLine());
// hold input number
initialCache = InputNumber;
//convert separately a single digit of user input number
//and store into an array and also count total number of digits 
while (InputNumber > 0)
{
    temp = InputNumber % 10;
    arr[i] = temp;
    count++;
    InputNumber = InputNumber / 10;
    i++;
}
//store power value of digits into sum array
for (i = 1; i <= count; i++)
{
    sum[i - 1] = (int)Math.Pow(arr[count - i], count);
}
//calculate total sum value 
for (i = 0; i < count; i++)
{
    total += sum[i];
}
//check user number is armstrong or not
if (initialCache == total)
    Console.WriteLine($"\nYes! {initialCache} is Armstrong number.");
else
    Console.WriteLine($"\nSorry! {initialCache} is not Armstrong number.");
//hold the console window
Console.ReadKey();
//Output:
//Enter any Number(digits):__371

//Yes! 371 is Armstrong number.