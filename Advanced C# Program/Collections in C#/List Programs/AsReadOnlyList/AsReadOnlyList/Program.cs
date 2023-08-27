List<int> Numbers = new List<int> { 1,2,3,4,5};

var ReadOnlyList = Numbers.AsReadOnly();

Console.Write("ReadOnly List is: ");
foreach (var element in ReadOnlyList)
    Console.Write(element +" ");
//ReadOnlyList.Add(10); //get error because this is only read not write in this list


Numbers.Add(6);
Numbers.Add(7);
Console.WriteLine("\n");
Console.Write("Numbers List is: ");
foreach (var element in ReadOnlyList)
    Console.Write(element + " ");



Console.ReadKey();

//output:
//ReadOnly List is: 1 2 3 4 5

//Numbers List is: 1 2 3 4 5 6 7