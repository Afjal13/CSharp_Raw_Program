List<int> Numbers = new List<int>();

var isAnyIsTrue = Numbers.Any();

Console.WriteLine($"In Empty List, Any result is: {isAnyIsTrue}");

Numbers.Add(1);
Numbers.Add(2);
Numbers.Add(3);
Numbers.Add(4);
Numbers.Add(5);

var isAnyTrue =Numbers.Any(number=>number<2);
Console.WriteLine($"In List, Any result is: {isAnyTrue}");

//For better understanding, look at behind process of the any property in list
bool? isAnyConditionIsTrue = null;
foreach(var number in Numbers)
{
    if (number < 2)
    {
        isAnyConditionIsTrue=true;
        break;
    }
    else
    {
        isAnyConditionIsTrue=false;
    }
}
Console.WriteLine($"In List using foreach loop, Any result is: {isAnyConditionIsTrue}");

Console.ReadKey();

//output:
//In Empty List, Any result is: False
//In List, Any result is: True
//In List using foreach loop, Any result is: True