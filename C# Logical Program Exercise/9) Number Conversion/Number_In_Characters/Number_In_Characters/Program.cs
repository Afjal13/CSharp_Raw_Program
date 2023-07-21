//Conversion between Number In Character 
//declare required variable field
int inputNumber, temp, i = 0, j, k, MemoryValue, count = 0;
int[] numberArray = new int[10];
string[] stringArray = new string[10];
//take input number
Console.Write("\nEnter any Number(0=<digit<=9):__");
string userInput = Console.ReadLine();
//check console input is number in digit format or not
bool isNumber = int.TryParse(userInput, out inputNumber);

if (!isNumber)
{
    Console.WriteLine("\n\tWrong input!\n\n");
    return;
}
//storage console base input in MemoryValue
MemoryValue = inputNumber;
//if input number is less than 0
if (inputNumber < 0)
{
    Console.WriteLine("\n\tWrong input!\n\n");
    return;
}
//if entered input number is 0
else if (inputNumber == 0)
{
    stringArray[0] = "Zero";
    Console.Write($"\nEntered {MemoryValue} in Character pattern is:\t");
    Console.Write(stringArray[0]);
}
//if enterd input number is greater than 0
else
{
    //convert to single digits of given number
    while (inputNumber > 0)
    {
        temp = inputNumber % 10;
        numberArray[i] = temp;
        inputNumber = inputNumber / 10;
        count++;
        i++;
    }
    if (count <= 9)
    {
        //convert in character
        for (j = 1; j <= count; j++)
        {
            switch (numberArray[j-1])
            {
                case 0:
                    stringArray[j-1] = "Zero";
                    break;
                case 1:
                    stringArray[j-1] = "One";
                    break;
                case 2:
                    stringArray[j-1] = "Two";
                    break;
                case 3:
                    stringArray[j-1] = "Three";
                    break;
                case 4:
                    stringArray[j-1] = "Four";
                    break;
                case 5:
                    stringArray[j-1] = "Five";
                    break;
                case 6:
                    stringArray[j-1] = "Six";
                    break;
                case 7:
                    stringArray[j-1] = "Seven";
                    break;
                case 8:
                    stringArray[j-1] = "Eight";
                    break;
                case 9:
                    stringArray[j-1] = "Nine";
                    break;
                default:
                    stringArray[j-1] = "Invalid!";
                    break;
            }
        }
        //display output
        Console.Write($"\nEntered {MemoryValue} in Characters pattern is:\t");
        for (k = count-1; k >= 0; k--)
            Console.Write(stringArray[k] + " ");
    }
    //if total number of digit greter than 9 of given input number
    else
    {
        Console.WriteLine("\n\tGiven number out of range!\n\n");
        return;
    }
}
//for extra two row create
Console.WriteLine("\n\n");
//hold the console window
Console.ReadKey();

//output-1:

//Enter any Number(0=<digit<=9):__WithoutDigitsValue

//        Wrong input!

//output-2:

//Enter any Number(0=<digit<=9):__ - 1

//        Wrong input!

//output-3:

//Enter any Number(0=<digit<=9):__1234567895

//        Given number out of range!

//output-4:
//Enter any Number(0=<digit<=9):__0

//Entered 0 in Character pattern is:      Zero

//output-5:

//Enter any Number(0=<digit<=9):__2023

//Entered 2023 in Characters pattern is:  Two Zero Two Three
