using System;

namespace TupleMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var personInfo = GetPersonInfo("Afjal","Hossain",28,"Dhaka",3.75);

            Console.WriteLine($"Person Details:\nName: {personInfo.Item1}\nAge: {personInfo.Item2}\nAddress: {personInfo.Item3}\nPoint: {personInfo.Item5}\nGrade: {personInfo.Item4}");

            Console.ReadKey();
        }

        public static (string, int,string,char,double) GetPersonInfo(string firstName,string secondName, int age, string address, double point) // tuple return type
        {
            char grade;
            string fullNmae = firstName +" "+ secondName;
           
            if (point > 3)
                grade = 'A';
            else
                grade = 'B';

            return (fullNmae, age, address,grade,point); // tuple literal
        }
    }
}
//output
//Person Details:
//Name: Afjal Hossain
//Age: 28
//Address: Dhaka
//Point: 3.75
//Grade: A