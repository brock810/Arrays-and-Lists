using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Globalization;
using System.Xml;

namespace Arrays
{
    class Program
    {
        //static void Main(string[] args)
        // {

        //var candyBag = new string[] { "snickers", "aero", "Candy-corn" };

        //var scores = new int[4] { 24, 35, 17, 2 };

        //var grades = new char[] { 'A', 'B', 'C', 'D' };

        // for (int i = 0; i < scores.Length; i++)
        //{
        //    Console.WriteLine(grades[i]);
        //}

        //var ages = new List<int>();
        // ages.Add(5);     //method
        //ages.Remove(15); //method
        // }
        //}
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            List<int> evens = new List<int>();
            List<int> odds = new List<int>();


            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    evens.Add(number);
                }
                else
                {
                    odds.Add(number);
                }
            }

            Console.WriteLine("Even numbers:");
            foreach (int even in evens)
            {
                Console.WriteLine(even);
            }

            Console.WriteLine("Odd numbers:");
            for (int i = 0; i < odds.Count; i++)
            {
                Console.WriteLine($"Odd number {i + 1}: {odds[i]}");
            }
        }
    }
}