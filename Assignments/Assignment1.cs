using System;

namespace MyApp
{
    internal class Program
    {
        //Question1  Write a program that takes two numbers as input and prints their sum.
        static void DisplaySum()
        {
            Console.WriteLine("Enter two numbers: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum of {num1} & {num2} is: {num1 + num2}");
        }

        //Question2  Write a program that prints all even numbers from 1 to 100.
        static void DisplayEvenNumbers()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        //Question3  Write a function that checks if a given year is a leap year or not.
        static void CheckLeapYear(int year)
        {
            bool isLeap = false;
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                isLeap = true;
            }
            if (isLeap == true)
            {
                Console.WriteLine($"{year} is a Leap Year");
            }
            else
            {
                Console.WriteLine($"{year} is not a Leap Year");
            }
        }

        //Question4  Write a program that converts kilometers per hours to miles per hour. Hint: 1km = 0.621371.
        static void KilometersToMilesPerHour(double kilometers)
        {
            double miles = kilometers * 0.621371;
            Console.WriteLine($"{kilometers}kilometers in miles per hour = {miles}");
        }

        //Question5  Write a pseudocode to check whether a number is a buzz number or not.

        static void CheckBuzzNumber(int num)
        {
            bool isBuzz = false;
            if(num % 10 == 7 || num % 7 == 0)
            {
                isBuzz = true;
            }
            if(isBuzz == true)
            {
                Console.WriteLine($"{num} is a buzz number");
            }
            else
            {
                Console.WriteLine($"{num} is not a buzz number");
            }
        }

        //Question6  Write a program that asks a user for number and prints the multiplication table of that number up to 10.
        static void TableOfNum()
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{num} * {i} = {num * i}");
            }
        }

        //Question7  Write a program that computes the factorial of a number (n!).
        static void Factorial(int num)
        {
            int fact = 1;
            if (num <= 0)
            {
                Console.WriteLine($"{num} has no factorial.");
            }
            else
            {
                for(int i = 1; i <= num; i++)
                {
                    fact *= i;
                }
                Console.WriteLine($"Factorial of {num} is {fact}");
            }
        }

        //Question8  Write a function that checks whether a number is prime or not.
        static void CheckPrime(int num)
        {
            bool isPrime = true;
            int i = 2;
            
            while(i <= num/2)
            {

                if (num % i == 0)
                {

                    isPrime = false;
                }
                i++;
            }

            if (isPrime == true)
            {

                Console.WriteLine($"{num} is Prime number.");
            }
            else
            {
                Console.WriteLine($"{num} is not Prime number.");
            }
        }

        //Question9  Write a program to check whether the triangle is equilateral, isosceles or scalene triangle.
        static void CheckTriangleType(int side1, int side2, int side3)
        {
            if (side1 == side2 && side1 == side3)
            {
                Console.WriteLine("Equilateral Triangle");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("Isosceles Traingle");
            }
            else
            {
                Console.WriteLine("Scalene Triangle");
            }
        }

        //Question10 Print this pattern(Half pyramid): (using multiple prints and then by loop).

        static void DisplayPattern()
        {
            //Using multiple prints
            Console.WriteLine("Using multiple prints");
            Console.WriteLine("*");
            Console.WriteLine("**");
            Console.WriteLine("***");
            Console.WriteLine("****");
            Console.WriteLine("*****");

            //Using loop
            Console.WriteLine("Using loop");
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        //BonusQuestion  Write a function that checks whether a number is a palindrome or not.
        static void CheckPalindrome(int num)
        {
            int reverse = 0;
            int result = 0;
            int temp = num;
            while(temp != 0)
            {
                result = temp % 10;
                reverse *= 10;
                reverse += result;
                temp /= 10;
            }
            if(num == reverse)
            {
                Console.WriteLine($"{num} is palindrome.");
            }
            else
            {
                Console.WriteLine($"{num} is not palindrome.");

            }
        }
        static void Main(string[] args)
        {
            DisplaySum();
            DisplayEvenNumbers();
            CheckLeapYear(2000);
            KilometersToMilesPerHour(200);
            CheckBuzzNumber(17);
            TableOfNum();
            Factorial(10);
            CheckPrime(9);
            CheckTriangleType(1, 2, 3);
            DisplayPattern();
            CheckPalindrome(212);
        }
        
    }
}