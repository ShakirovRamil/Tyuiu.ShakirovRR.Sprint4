using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.ShakirovRR.Sprint4.Task2.V8.Lib;

namespace Tyuiu.ShakirovRR.Sprint4.Task2.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random random = new Random();


            Console.Title = "Спринт #4 | Выполнил: Шакиров Р. Р. | ИСТНБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Базовые навки работы в C#                                         *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Шакиров Рамиль Русланович | ИСТНБ-23-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая выводит на экран результат                  *");
            Console.WriteLine("* данного нам задания                                                     *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.Write("Введите длину массива: ");
            int len = Convert.ToInt32(Console.ReadLine());

            int[] numsArray = new int[len];

            for (int i = 0; i < len; i++)
            {
                numsArray[i] = random.Next(3, 10);
            }

            Console.WriteLine();

            Console.Write("Массив: {");
            for (int i = 0; i < numsArray.Length; i++)
            {
                Console.Write(numsArray[i]);
                if (i != numsArray.Length - 1) { Console.Write(", "); }
            }
            Console.WriteLine("}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int res = ds.Calculate(numsArray);

            Console.WriteLine(res);

            Console.ReadLine();
        }
    }
}
