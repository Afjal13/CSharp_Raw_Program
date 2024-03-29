﻿namespace Copy_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(101, 30, "Hussain", "Dhaka", true);
            e1.Display();
            Console.WriteLine();

            Employee e2 = new Employee(e1);
            e2.Display();
            Console.ReadKey();
        }
    }
    class Employee
    {
        public int Id, Age;
        public string Address, Name;
        public bool IsPermanent;
        //Parameterized Constructor
        public Employee(int id, int age, string name, string address, bool isPermanent)
        {
            Id = id;
            Age = age;
            Address = address;
            Name = name;
            IsPermanent = isPermanent;
        }
        //Copy Constructor
        public Employee(Employee emp)
        {
            Id = emp.Id;
            Age = emp.Age;
            Address = emp.Address;
            Name = emp.Name;
            IsPermanent = emp.IsPermanent;
        }
        public void Display()
        {
            Console.WriteLine("Employee Id is:  " + Id);
            Console.WriteLine("Employee Name is:  " + Age);
            Console.WriteLine("Employee Address is:  " + Address);
            Console.WriteLine("Employee Name is:  " + Name);
            Console.WriteLine("Is Employee Permanent:  " + IsPermanent);
        }
    }

}