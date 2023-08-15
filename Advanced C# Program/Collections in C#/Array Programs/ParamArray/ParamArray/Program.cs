//Create an array within some value
int[] Balance = { 1000, 2, 3, 17, 50 };
//declare required average field
double average;
double averageFromParamArr;
//passing array as an method arguments and assign the average value
average = GetAverage(Balance);
//print the result
Console.WriteLine($"\nAverage value is: {average}");
averageFromParamArr = GetAverage(1000, 2, 3, 17, 50); //param arguments value
Console.WriteLine($"\nFrom Param value, Average value is: {averageFromParamArr}");
//average mechanism method
static double GetAverage(params int[] arr) //received array as an arguments in method
{
    double average;
    int sum = 0;
    for (int i = 0; i <= arr.Length - 1; i++)
        sum += arr[i];
    average = (double)sum / arr.Length;
    return average;
}
//hold console window
Console.ReadKey();
//output:
//Average value is: 214.4
//From Param value, Average value is: 214.4