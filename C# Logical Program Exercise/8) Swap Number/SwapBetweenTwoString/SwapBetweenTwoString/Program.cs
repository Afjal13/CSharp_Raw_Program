//Swap between two string without third variable
//declare variable
string firstName, secondName;
//Title
Console.WriteLine("\n\n\t\tString Swap Conversion!\n");
//take two input string
Console.Write("\nEnter the First Name: ");
firstName = Console.ReadLine();
Console.Write("\nEnter the Second Name: ");
secondName = Console.ReadLine();
//display before swap
Console.Write($"\n\nBefore Swap:\nFirst name is: {firstName}\nSecond name is: {secondName}");
//Swap mechanism
firstName = firstName+ secondName;
secondName = firstName.Substring(0, firstName.Length-secondName.Length);
firstName = firstName.Substring(secondName.Length);
//display after swap
Console.Write($"\n\nAfter Swap:\nFirst name is: {firstName}\nSecond name is: {secondName}");
//hold console window
Console.ReadKey();

//output:


//String Swap Conversion!


//Enter the First Name: Afjal

//Enter the Second Name: Hossain


//Before Swap:
//First name is: Afjal
//Second name is: Hossain

//After Swap:
//First name is: Hossain
//Second name is: Afjal
