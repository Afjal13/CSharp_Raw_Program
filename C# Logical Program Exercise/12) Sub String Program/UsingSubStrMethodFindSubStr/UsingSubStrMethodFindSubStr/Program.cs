string inputString;
int Len;
Console.Write("\nEnter The String: ");
inputString = Console.ReadLine();
Len = inputString.Length;

Console.WriteLine("\n\nAll Possible Sub String are: ");
for (int i = 0; i < Len; i++)
{
    for (int j = 0; j < Len - i; j++)
    {
        Console.Write(inputString.Substring(i, j + 1) + " ");
    }
}

Console.ReadKey();

//output:
//Enter The String: ABCD


//All Possible Sub String are:
//A AB ABC ABCD B BC BCD C CD D