using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KulakovEE.Sprint0.Task7.V0.Lib;

namespace Tyuiu.KulakovEE.Sprint0.Task7.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Кулаков Е.Е. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #0                                                              *");
            Console.WriteLine("* Выполнил: Кулаков Егор Евгеньевич | АСОиУб-23-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Условие:                                                                *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значение двух    *");
            Console.WriteLine("* одинаковых массивов по длине                                            *");
            Console.WriteLine("* Спринт #0                                                               *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] ArrayNums1 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива №1");
            for (int i = 0; i < ArrayNums1.Length; i++)
            {
                Console.Write(ArrayNums1[i] + ", ");
            }
            Console.WriteLine();

            int[] ArrayNums2 = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Значение элементов массива №2");
            for (int i = 0; i < ArrayNums1.Length; i++)
            {
                Console.Write(ArrayNums2[i] + ", ");
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            if (ArrayNums1.Length == ArrayNums2.Length)
            {
                int[] resultArray = DataService.AdditionArrays(ArrayNums1, ArrayNums2);

                Console.WriteLine("Сумма эл-ов массива равна:");
                for (int i = 0; i < resultArray.Length; i++)
                {
                    Console.Write(resultArray[i] + ", ");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное кол-во эл-ов");
            }
            Console.ReadKey();
        }
       
    }
}
