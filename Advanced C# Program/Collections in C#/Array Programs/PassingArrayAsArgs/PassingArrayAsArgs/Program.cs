//Create an array within some value
int[] Balance = { 1000, 2, 3, 17, 50 };
//declare required average field
double average;
//passing array as an method arguments and assign the average value
average = GetAverage(Balance);
//print the result
Console.WriteLine($"\nAverage value is: {average}");
//average mechanism method
static double GetAverage(int[] Balance) //received array as an arguments in method
{
    double average;
    int sum = 0;
    for (int i = 0; i <= Balance.Length - 1; i++)
        sum += Balance[i];
    average = (double)sum / Balance.Length;
    return average;
}
//hold console window
Console.ReadKey();
//output
//Average value is: 214.4