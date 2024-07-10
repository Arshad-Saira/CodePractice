using System;
using System.Diagnostics.Metrics;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        //Question1
        static void RemoveDuplicates(int[] nums)
        {
            if(nums.Length == 0)
            {
                Console.WriteLine("Given array is empty.");
            }
            else
            {
                int[] newArray = new int[nums.Length];
                for (int i =0; i < nums.Length; i ++)
                {
                    for(int j = i+1; j < nums.Length; j++)
                    {
                        if(nums[i] > nums[j])
                        {
                            int temp;
                            temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;
                            
                        }
                    }
                }
                for(int i = 0 ; i < nums.Length; i++)
                {
                    Console.Write(nums[i]+" ");
                    
                }
                // duplicate removing code
                for(int i = 0 ; i < nums.Length-1; i++)
                {
                    if(i==0)
                    {
                        Console.WriteLine("\n1...");
                        newArray[i] = nums[i];
                    }
                    else if (nums[i] != nums[i + 1] && nums[i] != nums[i - 1])
                    {
                        Console.WriteLine("3...");
                        newArray[i] = nums[i];
                    }
                    else
                    {
                        Console.WriteLine("skipp");
                    }
                }
                if(nums[nums.Length - 2] != nums[nums.Length - 1])
                    {
                        Console.Write("\n2....");
                        newArray[nums.Length - 1] = nums[nums.Length - 1];
                    }
                Console.WriteLine("Array after removing duplicates is: ");
                for(int i = 0 ; i < newArray.Length; i++)
                {
                    Console.Write(newArray[i] + " ");
                }
            }
        }

        //Question2
        static void LargestSecondLargest(int[] nums)
        {
            if(nums.Length == 0)
            {
                Console.WriteLine("Given array is empty.");
            }
            else
            {
                int counter = 0, largest = 0, secLargest = 0;
            while(counter < nums.Length)
            {
                if (nums[counter] > largest)
                {
                    secLargest = largest;
                    largest = nums[counter];
                }
                else if (nums[counter] > secLargest && nums[counter] != largest)
                {
                    secLargest = nums[counter];
                }
                counter++;
            }
            Console.WriteLine($"largest: {largest}, Second Largest: {secLargest}");
            }  
        }

        //Question3 
        static void ZeroesAtEnd(int[] arr)
        {
            if(arr.Length == 0)
            {
                Console.WriteLine("Given array is empty.");
            }
            else
            {
                int counter = 0;
                for(int i=0; i<arr.Length; i++)
                {
                    if(arr[i] != 0)
                    {
                        arr[counter++] = arr[i];
                    }
                }
                while(counter < arr.Length)
                {
                    arr[counter++] = 0;
                }
                for(int i=0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }        
        }

        //Question4
        static void FirstNonRepeatingChar(string myString)
        {
            // bool isRepeating = false;
            // for(int i = 0; i < myString.Length; i++)
            // {
            //     for(int j = i+1; j < myString.Length; j++)
            //     {
            //         if(myString[i] == myString[j])
            //         {
            //             isRepeating = true;
            //             break;
            //         }
            //     }
            //     if( isRepeating == false)
            //     {
            //         Console.WriteLine($"First non-repeating character in string {myString} is {myString[i]}");
            //     }
            //     isRepeating = false;
            // }
            if(myString.Length == 0)
            {
                Console.WriteLine("Given array is empty.");
            }
            else
            {
                bool isRepeating = false;
                for(int i = 0; i < myString.Length; i++)
                {
                    for(int j = 0; j < myString.Length; j++)
                    {
                        Console.WriteLine( myString[i]);
                        Console.WriteLine( myString[j]);
                        if(myString[i] == myString[j] && i!=j)
                        {
                            Console.WriteLine(myString[i] + " " + myString[j] + " " + isRepeating + "1" + i , j);
                            isRepeating = true;
                            break;
                        }
                        Console.WriteLine(j);
                    }
                    Console.WriteLine(isRepeating + "..");
                    if( isRepeating == false)
                    {
                        Console.WriteLine($"First non-repeating character in string {myString} is {myString[i]}");
                    }
                    isRepeating = false;
                }
            }
        }

        //Question5
        static void MergeArrays(int[] arr1, int[] arr2)
        {
            if(arr1.Length ==0 || arr2.Length ==0)
            {
                Console.WriteLine("Any of the given or both arrays is/are empty.");
            }
            else
            {
                int size = arr1.Length + arr2.Length;
                int[] mergedArray = new int[size];
                for(int i = 0; i <  arr1.Length; i++)
                {
                    mergedArray[i] = arr1[i];
                }
                for(int i = 0, j = arr1.Length;i < arr1.Length && j < size; i++, j++)
                {
                    mergedArray[j] = arr2[i];
                }
                for (int i =0; i < size; i ++)
                {
                    for(int j = i+1; j < size; j++)
                    {
                        if(mergedArray[i] > mergedArray[j])
                        {
                            int temp;
                            temp = mergedArray[i];
                            mergedArray[i] = mergedArray[j];
                            mergedArray[j] = temp;
                            
                        }
                    }
                }
                Console.WriteLine("Mergred Array is:");
                for(int i = 0; i <  size; i++)
                {
                    Console.WriteLine(mergedArray[i]);
                }
            }
        }

        //Question6
        static void MissingNum(int[] nums)
        {
            if(nums.Length == 0)
            {
                Console.WriteLine("Given array is empty.");
            }
            else
            {
                for (int i =0; i < nums.Length; i ++)
                {
                    for(int j = i+1; j < nums.Length; j++)
                    {
                        if(nums[i] > nums[j])
                        {
                            int temp;
                            temp = nums[i];
                            nums[i] = nums[j];
                            nums[j] = temp;   
                        }
                    }
                }
                if (nums[0] != 0)
                {
                    Console.WriteLine($"Missing number in given array is:  {0}");
                }
                else if (nums[nums.Length - 1] != (nums.Length ))
                {
                    Console.WriteLine($"Missing number in given array is:  {nums.Length}");
                }
                int n1 = 0, n2 = nums.Length - 1;
                int mid = 0;
                while (n2 - n1 > 1) 
                {
                    mid = (n1 + n2) / 2;
                    if (nums[n1] - n1 != nums[mid] - mid)
                    {
                        n2 = mid;
                    }
                    else if (nums[n2] - n2 != nums[mid] - mid)
                    {
                        n1 = mid;
                    }
                }
                Console.WriteLine($"Missing number in given array is:  {nums[n1]+1}");
            }
        }

        //Question7
        static void CheckArmstrong(int num)
        {
            if(num < 100 && num > 999)
            {
                Console.WriteLine("Given number is not a 3 digit number.");
            }
            else
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
        }

        //Question8
        static void LongestCommonPrefix(string[] stringArray)
        {
            if(stringArray.Length == 0)
            {
                Console.WriteLine("Given array is empty.");
            }
            else
            {
                string prefix = "";
            bool isDone = false;
            for (int i = 0; i < stringArray[0].Length; i++) 
            {
                char compareChar = stringArray[0][i];
                for (int j = 1; j < stringArray.Length; j++) 
                {
                    if (i >= stringArray[j].Length || stringArray[j][i] != compareChar) 
                    {
                        Console.WriteLine($"Longest Common prefix in given string is: {prefix}");
                        return;
                    }
                }
                if(isDone !=true)
                    {
                        prefix += compareChar;
                    }
            }
            Console.WriteLine($"Longest Common prefix in given string is: {prefix}");
            }
        }

        //Question9
        static void Fabonacci(int terms)
        {
            if(terms <= 0)
            {
                Console.WriteLine($"Invalid value entered for terms {terms}.");
            }
            else
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
        }

        //Question10
        static void CheckNumbers()
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine()); // n is number of integers user wants to enter
            if(n <= 0)
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
            /* int[] nums = {2,2,5,8,5,9,3};
            RemoveDuplicates(nums);*/

            /*int[] arr = {5, 9, 3, 6};
            LargestSecondLargest(arr);*/

            /* int[] arr1 = {5, 0, 9, 0, 0, 3, 6, 0};
            ZeroesAtEnd(arr); */

            //FirstNonRepeatingChar("Swiss";) //checkit not working properly

            /* int[] num1 = {1,3,5,7};
            int[] num2 = {2,4,6,8};
            MergeArrays(num1, num2);
            */

            /* int[] a1 = {1,5,3,0,2};
            MissingNum(a1); */

            //CheckArmstrong(153); //  only for 3 digit number
            
            /*string[] str = {"lioni","lio", "liot"};
            LongestCommonPrefix(str);*/ 

            //Fabonacci(5);

            //CheckNumbers();                   
        }
    }
}