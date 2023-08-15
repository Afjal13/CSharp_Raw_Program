//Check if an array object is equal to another array object in C#
// Creating and initializing new the String
String[] arr1 = new String[4] { "Sun", "Mon", "Tue", "Thu" };


// taking anotther array
String[] arr2 = new String[4] { "Sun", "Mon", "Tue", "Thu" };


// check if arr1 is
// equal to arr2 or not
Console.WriteLine(arr1.Equals(arr2));

// assigning arr1 reference to arr3
String[] arr3 = new String[4];
arr3 = arr1;

// check if arr2 is
// equal to arr3 or not
Console.WriteLine(arr2.Equals(arr3));

// check if arr1 is
// equal to arr3 or not
// it will return true as both
// array object refer to same
Console.WriteLine(arr1.Equals(arr3));
//hold console window
Console.ReadKey();
//output:
//False
//False
//True