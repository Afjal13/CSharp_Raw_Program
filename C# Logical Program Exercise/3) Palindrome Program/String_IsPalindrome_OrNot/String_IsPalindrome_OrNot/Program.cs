//How to check if a given string is Palindrome or not in C#?
//declare required variable fields
int i;
string name;
string reverse = string.Empty;
//take aa input name and after capturing the name it is converted to lower case
Console.Write("Enter a string to Check Palindrome: ");
name = Console.ReadLine().ToLower(); 
//reverse name string
for (i = name.Length-1; i >=0; i--)
{
    reverse +=name[i];
}
//check palindrome of given name string
if (reverse == name)
    Console.WriteLine($"{name} is Palindrome!");
else
    Console.WriteLine($"{name} in not Palindrome!");
//hold console window
Console.ReadKey();

//output:
//Enter a string to Check Palindrome: Madam
//madam is Palindrome!
