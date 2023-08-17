
using System.Collections;
//We know that
//Array is Fixed Type and Fixed Size Like
int[] Numbers = new int[5];   //here, value type fixed only integer allow and add maximum value 5

//Again
//List is Fixed Type But Dynamic size like
List<int> NumbersList = new List<int>(); //here, value type fixed only integer allow and add we can add unlimited value


//Now, we know that ArrayList.  it's make combination of Array & List Such as,
//ArrayList is dynamic Type and Dynamic size
//Create ArrayList
ArrayList PersonList = new ArrayList(); //there are no issue with type and limit
//Added difference type value to arraylist
PersonList.Add("Afjal Hossain");
PersonList.Add(28);
PersonList.Add(30000.00);
PersonList.Add(true);
//print specific arraylist index value
Console.WriteLine(PersonList[0]);
//==================================Example below====================================================
ArrayList PersonsList = new ArrayList();
//declare index variable for while loop
int index = 0;
while (index < 5)
{
    //take ArrayList value
    Console.Write($"Enter Person Info Index[{index+1}]: ");
    var PersonInfo = Console.ReadLine();
    PersonsList.Add(PersonInfo);
    index++;
}
//display
Console.WriteLine("Person Info: ");
for (int i = 0; i < PersonsList.Count; i++)
{
    Console.Write(PersonsList[i] + " ");
}

//hold console window
Console.ReadKey();

//Output:
//Afjal Hossain
//Enter Person Info Index[1]: Afjal Hossain
//Enter Person Info Index[2]: Dhaka,Bangladesh
//Enter Person Info Index[3]: 28
//Enter Person Info Index[4]: B +
//Enter Person Info Index[5]: True
//Person Info:
//Afjal Hossain Dhaka, Bangladesh 28 B+ True