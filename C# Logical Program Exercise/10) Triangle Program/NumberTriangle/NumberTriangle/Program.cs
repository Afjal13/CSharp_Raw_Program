//Print Number Triangle
//declare start or initial number
int rangeNumner = 1;
//index variable
int i, j, k, m;
//loop for new row define
for (i = 1; i <= 5; i++)
{
    //space define loop
    for (j = 5; j >= i; j--)
        Console.Write(" ");
    //right side number and also go after number using loop
    for (k = 1; k <= i; k++)
        Console.Write(rangeNumner++);
    //go before number 
    rangeNumner--;
    //left side number and go previous number using loop
    for (m = 1; m < i; m++)
        Console.Write(--rangeNumner);
    //jump to new row
    Console.Write("\n");
    //re-assign initial number 
    rangeNumner = 1;
}
//output:
 //    1
 //   121
 //  12321
 // 1234321
 //123454321
