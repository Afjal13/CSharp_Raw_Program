// Create a list of strings  
List<string> CountryList = new List<string>();
// Default Capacity  
Console.WriteLine($"Default Capacity: {CountryList.Capacity}");
CountryList.Add("Bangladesh");
CountryList.Add("India");
CountryList.Add("Rassia");
CountryList.Add("China");
// Original Capacity  
Console.WriteLine($"Original Capacity: {CountryList.Capacity}");
CountryList.Add("Iran");

// Current Capacity  
Console.WriteLine($"Current Capacity: {CountryList.Capacity}");

// Trim excess  
CountryList.TrimExcess();
Console.WriteLine($"Trimmed Capacity: {CountryList.Capacity}");

// Update Capacity  
CountryList.Capacity = 15;
Console.Write($"\n\t\tResize Capacity: { CountryList.Capacity}");
Console.WriteLine($"\n\nUpdated Capacity: {CountryList.Capacity}");
Console.ReadKey();

//output:
//Default Capacity: 0
//Original Capacity: 4
//Current Capacity: 8
//Trimmed Capacity: 5

//                Resize Capacity: 15

//Updated Capacity: 15
