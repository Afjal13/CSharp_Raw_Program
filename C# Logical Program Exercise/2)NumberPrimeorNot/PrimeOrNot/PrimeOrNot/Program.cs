﻿using System;

namespace PrimeOrNot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            bool isPrime = true;
            Console.WriteLine("Enter a digit:__");
            n=Convert.ToInt32(Console.ReadLine());

            if (n == 0 || n==1)
            {
                isPrime = false;
            }
            else
            {
                for (i = 2; i <= n / 2; i++)
                {
                    if(n%i== 0)
                    {
                        isPrime=false;
                        break;
                    }
                }
            }
            if (isPrime)
                Console.WriteLine("Yes! "+ n + " is a Prime Number.");
            else
                Console.WriteLine("Sorry! "+ n + " is a not Prime Number!");
            Console.ReadKey();
        }
    }
}
