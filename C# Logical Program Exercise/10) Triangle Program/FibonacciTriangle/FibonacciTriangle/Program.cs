//Print fibonacci triangle
// declare required variable
int inputNumber,firstNumber, secondnumber, temp,i,j;
//take the fibonacci limit
Console.Write("Enter the fibonacci limit:__");
inputNumber=Convert.ToInt32(Console.ReadLine());
//initialize first and second value
firstNumber=0;
secondnumber=1;
//make fibonacci series
for (i = 1; i <= inputNumber; i++)
{
    firstNumber = 0;
    secondnumber = 1;
    Console.Write("\t");
    for(j = 1; j < i; j++)
    {
        temp = firstNumber + secondnumber;
        Console.Write(temp + "\t");
        firstNumber = secondnumber;
        secondnumber = temp;
    }
    Console.Write("\n");
}

//output:
//Enter the fibonacci limit:__9

//        1
//        1       2
//        1       2       3
//        1       2       3       5
//        1       2       3       5       8
//        1       2       3       5       8       13
//        1       2       3       5       8       13      21
//        1       2       3       5       8       13      21      34