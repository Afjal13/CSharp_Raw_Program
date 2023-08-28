List<int> Numbers = new List<int>();
Numbers.Add(1);
Numbers.Add(2);
Numbers.Add(3);
Numbers.Add(4);
Numbers.Add(5);

var isTrueAll = Numbers.All(number => number > 2);

Console.WriteLine($"Result is: {isTrueAll}");

var isCondtionTrue = Numbers.All(number => number > 0);
Console.WriteLine($"Result is: {isCondtionTrue}");

//Some process behind all for better understanding like that,
bool? isTrueAllByForeach=null;
foreach(var number in Numbers)
{
    if(number > 2)
    {
        isTrueAllByForeach = true;
    }
    else
    {
        isTrueAllByForeach = false;
        break;
    }
}
Console.WriteLine($"Using Foreach, Result is: {isTrueAllByForeach}");

bool? isTrueConditionByForeach = null;
foreach (var number in Numbers)
{
    if (number > 0)
    {
        isTrueConditionByForeach = true;
    }
    else
    {
        isTrueConditionByForeach = false;
        break;
    }
}
Console.WriteLine($"Using Foreach, Result is: {isTrueConditionByForeach}");

Console.ReadKey();

//output:
//Result is: False
//Result is: True
//Using Foreach, Result is: False
//Using Foreach, Result is: True