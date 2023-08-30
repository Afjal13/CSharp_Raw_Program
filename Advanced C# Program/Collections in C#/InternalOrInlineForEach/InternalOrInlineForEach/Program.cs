using static System.Console;

List<int> Numbers = new List<int>();
Numbers.Add(10);
Numbers.Add(15);
Numbers.Add(7);
Numbers.Add(3);
Numbers.Add(4);
Numbers.Add(5);

Write("Using Internal foreach loop, List is: ");
foreach (int number in Numbers)
    Write(number+" ");

WriteLine("\n\n");
//Inline ForEach loop
WriteLine("In Inline ForEach, Using method group list is: ");
Numbers.ForEach(WriteLine);

WriteLine("\n\n");
WriteLine("In Inline ForEach,without condition list is: ");
Numbers.ForEach(number => Write(number + " "));

WriteLine("\n\n");
WriteLine("In Inline ForEach,with condition list is: ");
Numbers.ForEach(
    number =>
    {
        if (number > 5)
            Write(number + " ");
    }
);

ReadKey();

//Output:
//Using Internal foreach loop, List is: 10 15 7 3 4 5


//In Inline ForEach, Using method group list is:
//10
//15
//7
//3
//4
//5



//In Inline ForEach, without condition list is:
//10 15 7 3 4 5


//In Inline ForEach, with condition list is:
//10 15 7

