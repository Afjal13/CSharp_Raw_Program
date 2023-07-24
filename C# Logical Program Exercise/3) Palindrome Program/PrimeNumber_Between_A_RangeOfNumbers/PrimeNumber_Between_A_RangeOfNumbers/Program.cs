//How to display Prints the Prime Numbers between a range of numbers in C#?
//declare variable field
int startNumber, endNumber,count,i,j;
// take input start number of range
Console.Write("\nEnter the start Number: ");
startNumber = Convert.ToInt32(Console.ReadLine());
// take input end number of range
Console.Write("\nEnter the end Number: ");
endNumber = Convert.ToInt32(Console.ReadLine());
//display print all prime number of given range
Console.Write($"\n\nThe Prime Numbers between {startNumber} and {endNumber} are : ");
// prime mechanism 
for (i = startNumber; i <= endNumber; i++)
{
    count = 0;
    for(j = 2; j <= i/2; j++)
    {
        if (i % j == 0)
        {
            count++;
            break;
        }
    }
    if(count == 0 && i!=1)
        Console.Write("{0} ",i);
}
//hold console window
Console.ReadKey();

//output:

//Enter the start Number: 1

//Enter the end Number: 25


//The Prime Numbers between 1 and 25 are : 2 3 5 7 11 13 17 19 23



