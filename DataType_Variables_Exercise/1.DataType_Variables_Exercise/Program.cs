﻿using System;

namespace _1.DataType_Variables_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int thirdNum = int.Parse(Console.ReadLine());
            int fourthNum = int.Parse(Console.ReadLine());

            long result = ((long)firstNum + secondNum) / thirdNum * fourthNum;
            Console.WriteLine(result);
        }
    }
}