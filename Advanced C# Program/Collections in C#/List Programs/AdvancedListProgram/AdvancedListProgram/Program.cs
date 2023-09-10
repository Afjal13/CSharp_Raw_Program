//=============================optimize code step-5=====================
Console.Write("\nResult: ");
new List<string> { "Afjal", "Hussain", "Tonmoy", "Raju", "Emran" }
.ForEach
    (name =>
        {
            if (name == "Raju")
            {
                Console.Write("Hello Raju!");
            }
        }
    );
Console.ReadLine();

Console.Write("\nList Result: ");
new List<string>() { "Imran", "Pranto", "Raihan" }
.ForEach(name => Console.Write(name + " "));
Console.ReadLine();
//=============================optimize code step-4=====================
//Console.Write("\nFirst list result: ");
//new List<string> { "Afjal", "Hussain", "Tonmoy", "Raju", "Emran" }
//.ForEach(name => Console.Write(name+" "));
//Console.ReadLine();

//Console.Write("\nSecond List Result: ");
//new List<string>() { "Imran", "Pranto", "Raihan" }
//.ForEach(name => Console.Write(name +" "));
//Console.ReadLine();

//=============================optimize code step-3=====================
//List<string> Names = new List<string> { "Afjal", "Hussain", "Tonmoy", "Raju", "Emran" };
//Console.Write("\nFirst list result: ");
//Display(Names);

//Console.ReadLine();

//List<string> NameList = new List<string>() { "Imran", "Pranto", "Raihan" };
//Console.Write("\nSecond List Result: ");
//Display(NameList);
//Console.ReadLine();

//static void Display(List<string> CurrentList)
//{
//    foreach (string CurrentName in CurrentList)
//        Console.Write(CurrentName + " ");
//}
//=============================optimize code step-2=====================

//List<string> Names = new List<string>{ "Afjal", "Hussain", "Tonmoy", "Raju", "Emran" };
//Console.Write("\nFirst list result: ");
//foreach (string name in Names)
//{
//    Display(name);
//}
//Console.ReadLine();
//List<string> NameList = new List<string>() { "Imran", "Pranto", "Raihan" };

//Console.Write("\nSecond List Result: ");
//foreach (string name in NameList)
//{
//    Display(name);
//}
//static void Display(string CurrentName)
//{
//    Console.Write(CurrentName+" ");
//}
//=============================optimize code step-1=====================

//List<string> Names = new List<string>() { "Afjal", "Hussain" , "Tonmoy" , "Raju" , "Emran" };

//Console.Write("\nFirst List Result: ");
//foreach (string name in Names)
//{
//    Console.Write(name+" ");
//}
//Console.ReadLine();
//List<string> NameList = new List<string>() { "Imran" , "Pranto" , "Raihan" };

//Console.Write("\nSecond List Result: ");
//foreach (string name in NameList)
//{
//    Console.Write(name+" ");
//}


//======================initial step=========================

//List<string> Names = new List<string>();
//Names.Add("Afjal");
//Names.Add("Hussain");
//Names.Add("Tonmoy");
//Names.Add("Raju");
//Names.Add("Emran");
//Console.Write("\nFirst List Result: ");
//for (int i = 0; i < Names.Count; i++)
//{
//    Console.Write(Names[i] + " ");
//}
//Console.WriteLine();
//List<string> NameList = new List<string>();
//NameList.Add("Imran");
//NameList.Add("Pranto");
//NameList.Add("Raihan");

//Console.Write("\nSecond List Result: ");
//for (int j = 0; j < NameList.Count; j++)
//{
//    Console.Write(NameList[j] + " ");
//}
