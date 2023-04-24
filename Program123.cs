using System;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create ⬇⬇⬇

            #region Arrays
            //TODO: Create an integer Array of size 50


            //TODO: Create a method to populate the number array with 50 random numbers that are between 0 and 50


            //TODO: Print the first number of the array

            //TODO: Print the last number of the array            

            Console.WriteLine("All Numbers Original");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");

            //TODO: Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*  1) First way, using a custom method => Hint: Array._____(); 
                2) Second way, Create a custom method (scroll to bottom of page to find ⬇⬇⬇)
            */

            Console.WriteLine("All Numbers Reversed:");

            Console.WriteLine("---------REVERSE CUSTOM------------");

            Console.WriteLine("-------------------");

            //TODO: Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");


            Console.WriteLine("-------------------");

            //TODO: Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");


            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //TODO: Create an integer List


            //TODO: Print the capacity of the list to the console


            //TODO: Populate the List with 50 random numbers between 0 and 50 you will need a method for this            


            //TODO: Print the new capacity


            Console.WriteLine("---------------------");

            //TODO: Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //UNCOMMENT this method to print out your numbers from arrays or lists
            //NumberPrinter();
            Console.WriteLine("-------------------");


            //TODO: Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Evens Only!!");

            Console.WriteLine("------------------");

            //TODO: Sort the list then print results
            Console.WriteLine("Sorted Evens!!");

            Console.WriteLine("------------------");

            //TODO: Convert the list to an array and store that into a variable


            //TODO: Clear the list


            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            List<int> myList = new List<int>(numbers);
            for (int i = myList.Count - 1; i >= 0; i--)
            {
                if (myList[i] % 3 == 0)
                {
                    myList.RemoveAt(i);
                }
            }
            numbers = myList.ToArray();
        }
        private static List<int> OddKiller(List<int> numberList)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int number in numberList)
            {
                if (number % 2 == 0)
                {
                    evenNumbers.Add(number);
                }
            }

            return evenNumbers;
        }

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            {
                if (numberList.Contains(searchNumber))
                {
                    Console.WriteLine($"The number {searchNumber} is in the list.");
                }
                else
                {
                    Console.WriteLine($"The number {searchNumber} is not in the list.");
                }
               
                
                bool numberFound = false;

                for (int i = 0; i < numberArray.Length; i++)
                {
                    if (numberArray[i] == searchNumber)
                    {
                        numberFound = true;
                        break;
                    }
                }

                if (numberFound)
                {
                    Console.WriteLine($"The number {searchNumber} is in the array.");
                }
                else
                {
                    Console.WriteLine($"The number {searchNumber} is not in the array.");
                }
            }
        }
        

        private static void Populator(List<int> numberList)
        {
            Random rng = new Random();
            for (int i = 0; i < numberList.Count; i++)
            {
                numberList[i] = rng.Next(1, 101);
            }
        }

        private static void Populator(int[] numbers)
        {
            Random rng = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rng.Next(1, 101);
            }
        }

        private static void ReverseArray(int[] array)
        {
            int i = 0;
            int j = array.Length - 1;

            while (i < j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
