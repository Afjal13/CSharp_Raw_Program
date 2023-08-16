//List---> fixed type but dynamic size
//Create List and initialize
List<int> NumbersList = new List<int>();
NumbersList.Add(5);
NumbersList.Add(7);
NumbersList.Add(4);
NumbersList.Add(8);
NumbersList.Add(6);
//display ------>like array index
Console.WriteLine(NumbersList[2]);
//declare list and initialize with assign value
List<int> NumbersListTwo = new List<int>() { 5,8,9,2,4};
//display
Console.WriteLine(NumbersListTwo[2]);
//display full list value using for loop
Console.Write("\n2nd List Value: ");
for(int i = 0; i < NumbersListTwo.Count; i++)
{
    Console.Write(NumbersList[i]+" ");
}

//Real Life use
List<string> NamesList = new List<string>();
string isOk;
do
{
    Console.Write("\n\nEnter Name: ");
    string name = Console.ReadLine();
    NamesList.Add(name);
    Console.Write("Will you push name Then press Y or Press N: ");
    isOk = Console.ReadLine();

} while (isOk == "Y" || isOk=="y");

Console.Write("\n\nNames List: ");
foreach (string name in NamesList)
    Console.Write(name+" ");

//hold console window
Console.ReadKey();

//output:
//4
//9

//2nd List Value: 5 7 4 8 6

//Enter Name: Afjal
//Will you push name Then press Y or Press N: y


//Enter Name: Hussain
//Will you push name Then press Y or Press N: y


//Enter Name: Sazzad
//Will you push name Then press Y or Press N: y


//Enter Name: Sajeeb
//Will you push name Then press Y or Press N: y


//Enter Name: Rahat
//Will you push name Then press Y or Press N: n


//Names List: Afjal Hussain Sazzad Sajeeb Rahat