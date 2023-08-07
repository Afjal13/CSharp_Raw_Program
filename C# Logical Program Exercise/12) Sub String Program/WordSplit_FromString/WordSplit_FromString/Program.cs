//Split all word from a string
//define a string 
string str1 = "Hello! Bangladesh in the World.";
//split string
string[] str2 = str1.Split(' ');
//display all split word
for (int i = 0; i < str2.Length; i++)
{
    Console.WriteLine(str2[i]);
}
//hold console window
Console.ReadKey();
//output:
//Hello!
//Bangladesh
//in
//the
//World.
