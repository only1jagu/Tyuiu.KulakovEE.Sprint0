﻿using System;

using Tyuiu.KulakovEE.Sprint0.Task5.V0.Lib;

namespace Tyuiu.KulakovEE.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Subtraction(15, 5));
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 5));

            Console.WriteLine("A / B = " + DataService.Division(9, 9));
            Console.ReadKey();
        }
    }
}
