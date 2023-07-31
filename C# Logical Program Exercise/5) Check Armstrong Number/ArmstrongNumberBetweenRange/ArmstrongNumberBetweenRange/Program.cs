//Finding Armstrong number between ranges of numbers in C#
//declare required variable 
int startNumber, endNumber,i;
//Program Title
Console.WriteLine("\n\n\t\t==========Armstrong Program==========\n");
//Take start & end range for Armstrong number finding
Console.Write("\nEnter start number: ");
startNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("\nEnter end number: ");
endNumber = Convert.ToInt32(Console.ReadLine());
//output title
Console.WriteLine("\n\n\t\tArmstrong Number Finding...\n");
Console.Write("\n\nArmstrong Number List: ");
//check each number between range
//& display armstrong number
for (i = startNumber; i <= endNumber; i++)
{
    if (isNumberArmstrong(i))
        Console.Write(i + " ");
}
//armstrong number identify mechanism method
static bool isNumberArmstrong(int number)
{
    int j=0, k, m, total = 0, temp, remainder, count = 0;
    int[] digitArray = new int[number];
    int[] sumArray = new int[number];
    temp = number;
   
    while (number>0)
    {
        remainder = number % 10;
        digitArray[j] = remainder;
        count++;
        number = number / 10;
        j++;
    }

    for (k = 1; k <= count; k++)
    {
        sumArray[k - 1] = (int)Math.Pow(digitArray[k - 1], count);
    }
    for (m = 0; m < count; m++)
    {
        total += sumArray[m];
    }
    if (temp == total)
        return true;
    else
        return false;
}
//hold console window
Console.ReadKey();

//output


//                ========== Armstrong Program ==========


// Enter start number: 100

//Enter end number: 9000


//                Armstrong Number Finding...



//Armstrong Number List: 153 370 371 407 1634 8208
