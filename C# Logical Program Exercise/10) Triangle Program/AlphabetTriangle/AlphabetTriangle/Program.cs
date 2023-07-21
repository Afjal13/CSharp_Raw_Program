//Print Alphabet Triangle
//declare start or initial alphabet
char ch = 'A';
//index variable
int i, j, k, m;
//loop for new row define
for (i = 1; i <= 5; i++)
{
    //space define
    for (j = 5; j >= i; j--)
        Console.Write(" ");
    //right side alphabet and go after latter 
    for (k = 1; k <= i; k++)
        Console.Write(ch++);
    //go before latter 
    ch--;
    //left side alphabet and go previous latter 
    for (m = 1; m < i; m++)
        Console.Write(--ch);
    //jump to new row
    Console.Write("\n");
    //re-assign alphabet 
    ch = 'A';
}

//output:
 //    A
 //   ABA
 //  ABCBA
 // ABCDCBA
 //ABCDEDCBA


