using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        //Question1	Write a program to delete the duplicates from an array.
        static void RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0)
            {
                Console.WriteLine("Given array is empty.");
            }
            else
            {
                //Sorting array 
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            int temp;
                            temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;

                        }
                    }
                }
                //Removing Duplicates
                List<int> result = new List<int>();
                // Populating list without any duplication from array
                foreach (int i in nums)
                {
                    if (!result.Contains(i))
                    {
                        result.Add(i);
                    }
                }
                Console.Write("After removing duplicates: ");
                foreach (int k in result)
                {
                    Console.Write( k + " ");
                }
            
            }
        }

        //Question2	Write a program to find the largest and the second largest number in an array.
        static void LargestSecondLargest(int[] nums)
        {
            if (nums.Length == 0)
            {
                Console.WriteLine("Given array is empty.");
            }
            else
            {
                int counter = 0, largest = 0, secLargest = 0;
                while (counter < nums.Length)
                {
                    //check if anyy element of array nums is greater largest then update the secLargest and largest
                    if (nums[counter] > largest)
                    {
                        secLargest = largest;
                        largest = nums[counter];
                    }
                    // check if any element of nums array is not largest and greater than secLargest then update secLargest
                    else if (nums[counter] > secLargest && nums[counter] != largest)
                    {
                        secLargest = nums[counter];
                    }
                    counter++;
                }
                Console.WriteLine($"largest: {largest}, Second Largest: {secLargest}");
            }
        }

        //Question3 Write a program that places all the zeros in an array at the end of the list.
        static void ZeroesAtEnd(int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("Given array is empty.");
            }
            else
            {
                int counter = 0;
                // rotate all non-zero elements to left of the arr
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != 0)
                    {
                        arr[counter++] = arr[i];
                    }
                } 
                // lace zeroes at the end of the arr
                while (counter < arr.Length)
                {
                    arr[counter++] = 0;
                }
                // storing array in list
                List<int> numsList = new List<int>(arr);
                foreach(int num in numsList)
                {
                    Console.Write(num + " ..");
                }
            }
        }

        //Question4 Write a program to find the first non-repeating character in a string.   
        static void FirstNonRepeatingChar(string myString)
        {
            if (myString.Length == 0)
            {
                Console.WriteLine("Given array is empty.");
            }
            else
            {
                myString = myString.ToLower();
                bool isRepeating = false;
                for (int i = 0; i < myString.Length; i++)
                {
                    for (int j = 0; j < myString.Length; j++)
                    {
                        //check if myString is not comparing the same index and are equal then element is repeating
                        if (myString[i] == myString[j] && i != j)
                        {
                            isRepeating = true;
                            break;
                        }
                    } 
                    // isRepeating check never goes true if element is not repeating
                    if (isRepeating != true)
                    { 
                        Console.WriteLine($"First non-repeating character in string {myString} is {myString[i]}");
                        return;
                    }
                    isRepeating = false;
                }
            }
        }

        //Question5 Write a program to merge two sorted arrays into a single sorted array.
        static void MergeArrays(int[] arr1, int[] arr2)
        {
            if (arr1.Length == 0 || arr2.Length == 0)
            {
                Console.WriteLine("Any of the given or both arrays is/are empty.");
            }
            else
            {
                int size = arr1.Length + arr2.Length;
                int[] mergedArray = new int[size];
                //Storing array1 in new array for merging
                for (int i = 0; i < arr1.Length; i++)
                {
                    mergedArray[i] = arr1[i];
                }
                //Storing array2 in new array for merging
                for (int i = 0, j = arr1.Length; i < arr1.Length && j < size; i++, j++)
                {
                    mergedArray[j] = arr2[i];
                }
                //Sorting merged array
                for (int i = 0; i < size; i++)
                {
                    for (int j = i + 1; j < size; j++)
                    {
                        if (mergedArray[i] > mergedArray[j])
                        {
                            int temp;
                            temp = mergedArray[i];
                            mergedArray[i] = mergedArray[j];
                            mergedArray[j] = temp;

                        }
                    }
                }
                Console.WriteLine("Mergred Array is:");
                for (int i = 0; i < size; i++)
                {
                    Console.Write(mergedArray[i] + " ");
                }
            }
        }

        //Question6 Write a program to find the missing number in an array containing n distinct numbers taken from 0, 1, 2, ..., n. 
        static void MissingNum(int[] nums)
        {
            if (nums.Length == 0)
            {
                Console.WriteLine("Given array is empty.");
            }
            else
            {
                //Sorting array
                for (int i = 0; i < nums.Length; i++)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        if (nums[i] > nums[j])
                        {
                            int temp;
                            temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                        }
                    }
                }
                //if first number is missing
                if (nums[0] != 0)
                {
                    Console.WriteLine($"Missing number in given array is:  {0}");
                }
                //if last number is missing
                else if (nums[nums.Length - 1] != (nums.Length))
                {
                    Console.WriteLine($"Missing number in given array is:  {nums.Length}");
                }
                else
                {
                    int start = 0, end = nums.Length - 1;
                    int mid = 0;
                    // check for missing element
                    while (end - start > 1)
                    {
                        //getting middle/pivot element of nums 
                        mid = (start + end) / 2;
                        //if first half of the nums have missing element then update end to middle
                        if (nums[start] - start != nums[mid] - mid)
                        {
                            end = mid;
                        }
                        //if first half of the nums have no missing element then update start from middle
                        else if (nums[end] - end != nums[mid] - mid)
                        {
                            start = mid;
                        }
                    }
                    Console.WriteLine($"Missing number in given array is:  {nums[start] + 1}");
                }
            }
        }

        //Question7
        static void CheckArmstrong(int num)
        {
            if (num < 100 && num > 999)
            {
                Console.WriteLine("Given number is not a 3 digit number.");
            }
            else
            {
                int originalNum = num, temp = 0, digit;
                //take cube of each digit in a number and sum
                while (num != 0)
                {
                    digit = num % 10;
                    temp += (digit * digit * digit);
                    num /= 10;
                }
                if (temp == originalNum)
                {
                    Console.WriteLine($"{originalNum} is a Armstrong number.");
                }
                else
                {
                    Console.WriteLine($"{originalNum} is not a Armstrong number.");
                }
            }
        }

        //Question8 Write a program to find the longest common prefix in an array of strings.
        static void LongestCommonPrefix(string[] stringArray)
        {
            if (stringArray.Length == 0)
            {
                Console.WriteLine("Given array is empty.");
            }
            else
            {
                string prefix = "";
                for (int i = 0; i < stringArray[0].Length; i++)
                {
                    char compareChar = stringArray[0][i]; //ith character of first string in array
                    for (int j = 1; j < stringArray.Length; j++)
                    {
                        if (i >= stringArray[j].Length || stringArray[j][i] != compareChar)
                        {
                            Console.WriteLine($"Longest Common prefix in given string is: {prefix}");
                            return;
                        }
                    }
                    //appending matching character of string with prefix
                    prefix += compareChar;
                }
                Console.WriteLine($"Longest Common prefix in given string is: {prefix}");
            }
        }

        //Question9 Write a program that prints the Fibonacci sequence up to n terms (where n is user input).
        static void Fabonacci(int terms)
        {
            if (terms <= 0)
            {
                Console.WriteLine($"Invalid value entered for terms {terms}.");
            }
            else
            {
                int term1 = 0, term2 = 1;
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
        }

        //Question10 Write a program that reads N integers, determines how many positive and negative values have been read and computes the total and average of input values.
        static void CheckNumbers()
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine()); // n is number of integers user wants to enter
            if (n <= 0)
            {
                Console.WriteLine("Invalid value entered.");
            }
            else
            {
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
        }
            static void Main(string[] args)
            {
            /*int[] nums = { 2, 2, 5, 8, 5, 9, 3 };
            RemoveDuplicates(nums); */

            /*int[] arr = { 15, 9, 13, 16 };
            LargestSecondLargest(arr);*/

            /*int[] arr1 = {3,0,5,6,0,0,3,0,6 };
            ZeroesAtEnd(arr1);*/

            //FirstNonRepeatingChar("Swiss"); 

            /* int[] num1 = { 1, 3, 7, 9 };
             int[] num2 = { 2, 4, 5, 6, 8 };
             MergeArrays(num1, num2);*/


            /*int[] a1 = { 1, 5, 3, 0, 2 };
            MissingNum(a1);*/

            //CheckArmstrong(153); // only for 3 digit Armstrong number

            /* string[] str = { "liokiyn", "lion", "lion" };
            LongestCommonPrefix(str);*/

            //Fabonacci(5);

            //CheckNumbers();               
            }
    }
}