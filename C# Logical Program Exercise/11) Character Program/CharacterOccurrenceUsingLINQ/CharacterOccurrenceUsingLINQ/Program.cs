string message;
Console.Write("\nEnter the strng: ");
message = Console.ReadLine();

Dictionary<char,int> dict =message.Replace(" ",string.Empty)
    .GroupBy(c=>c).ToDictionary(gr=>gr.Key,gr=>gr.Count()); 

foreach(var item in dict.Keys)
{
    Console.WriteLine(item+" : "+dict[item]);
}

Console.ReadKey();