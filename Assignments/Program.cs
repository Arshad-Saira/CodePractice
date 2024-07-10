using System;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        //Question2
        static void largestSecondLargest(int[] nums)
        {
            int counter = 0, largest = 0, secLargest = 0;
            while(counter < nums.Length)
            {
                if (nums[counter] > largest)
                {
                    largest = nums[counter];
                }
                if (nums[counter] > secLargest && secLargest < largest)
                {
                    Console.WriteLine("1");
                    secLargest = nums[counter];
                }
                counter++;
            }
            Console.WriteLine($"largest: {largest}, Second Largest: {secLargest}  , {nums.Length}");

        }

        //Question7
        static void CheckArmstrong(int num)
        {
            int originalNum = num, temp = 0, digit;

            while(num != 0)
            {
                digit = num % 10;
                temp += (digit * digit * digit);
                num /= 10;
            }
            Console.WriteLine(temp);
            if(temp == originalNum)
            {
                Console.WriteLine($"{originalNum} is a Armstrong number.");
            }
            else
            {
                Console.WriteLine($"{originalNum} is not a Armstrong number.");
            }
        }
        //Question9
        static void Fabonacci(int terms)
        {
            int term1 = 0 ,term2 = 1;
            Console.Write($"{term1} , {term2}");
            int nextTerm = term1 + term2;
            int counter = 2;
            while (counter < terms)
            {
                Console.Write($" , {nextTerm}");
                term1 = term2;
                term2 = nextTerm;
                nextTerm = term1 + term2;
                counter++;  
            }
        }

        //Question10
        static void CheckNumbers()
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine()); // n is number of integers user wants to enter
            int[] numbers = new int[n];
            int positiveCount = 0, negativeCount = 0;
            double sum = 0, average;
            Console.WriteLine($"Enter {n} values:");
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] >= 0)
                {
                    positiveCount++;
                }
                else
                {
                    negativeCount++;
                }
                sum += numbers[i];
            }
            average = sum / n;
            Console.WriteLine($"The number of positive numbers: {positiveCount} \nThe number of negative numbers: {negativeCount} " +
                $"\nTotal is: {sum} \nAverage is: {average}");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Fabonacci(5);
            //CheckNumbers();
            /*int[] arr = {5, 9, 3, 6};
            largestSecondLargest(arr);*/
            CheckArmstrong(93084); //  check 93084 case not handled
        }
    }
}