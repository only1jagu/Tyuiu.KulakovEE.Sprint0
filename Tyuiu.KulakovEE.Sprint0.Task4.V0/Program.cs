﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KulakovEE.Sprint0.Task4.V0.Lib;

namespace Tyuiu.KulakovEE.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Пример линейной структуры программы
            //Вызов метода сложения Addition
            Console.WriteLine(DataService.Addition(1, 5));
            //Вызов метода сложения Subtraction
            Console.WriteLine(DataService.Subtraction(15, 5));
            //Вызов метода сложения Multiplication
            Console.WriteLine(DataService.Multiplication(10, 5));
            //Вызов метода сложения Division
            Console.WriteLine(DataService.Division(9, 3));

            Console.ReadKey();
        }
    }
}