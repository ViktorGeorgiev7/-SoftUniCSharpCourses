﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> result = new List<int>();
            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int newElement = numbers[i] + numbers[numbers.Count - 1 - i];
                result.Add(newElement);

            }


            if (numbers.Count % 2 == 0)
            {
                Console.WriteLine(string.Join(" ", result));
            }
            else
            {
                result.Add(numbers[numbers.Count / 2]);
                Console.WriteLine(string.Join(" ", result));
            }

        }
    }
}