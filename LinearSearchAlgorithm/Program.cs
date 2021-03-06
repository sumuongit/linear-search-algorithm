﻿using System;

namespace LinearSearchAlgorithm
{
    public class LinearSearch
    {
        int[] numbers = new int[10] { 10, 4, 20, 49, 65, 11, 66, 57, 9, 100 };
        bool isAvailable = false;

        public bool DoLinearSearch(int inputNumber)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (inputNumber == numbers[i])
                {
                    isAvailable = true;
                    // Make sure whenever the number is found in the given array let the control go beyond the loop.
                    return isAvailable;
                }
            }

            return isAvailable;
        }

        static void Main(string[] args)
        {
            LinearSearch ls = new LinearSearch();
            Console.WriteLine("INPUT: An array of numbers is as follows:");
            Console.WriteLine("=========================================");
            Console.WriteLine("10, 4, 20, 49, 65, 11, 66, 57, 9, 100");
            Console.WriteLine();

            Console.Write("Please enter a number and check whether it is available or not: ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            bool isAvailable = ls.DoLinearSearch(inputNumber);
            Console.WriteLine();

            if (isAvailable)
            {
                Console.WriteLine("OUTPUT: The number is avaiable");
            }
            else
            {
                Console.WriteLine("OUTPUT: The number is NOT avaiable");
            }

            Console.ReadLine();
        }
    }
}
