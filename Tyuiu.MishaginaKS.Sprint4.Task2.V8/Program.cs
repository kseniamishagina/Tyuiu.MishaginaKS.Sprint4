using System;
using Tyuiu.MishaginaKS.Sprint4.Task2.V8.Lib;
namespace Tyuiu.MishaginaKS.Sprint4.Task2.V8;

class Program

{
    static void Main(string[] args)

    {
        Random rnd = new Random();
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Задание #2 | Вариант 8";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнила: Мишагина К. С. | Группа АСОиУб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 11 элементов, заполненный        *");
        Console.WriteLine("* случайными числами от 2 до 7. Подсчитать сумму нечетных элементов.      *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int len = 11;
        int[] array = new int[len];

        for (int i = 0; i < len; i++)
        {
            array[i] = rnd.Next(2, 8);
        }

        Console.WriteLine("Массив из случайных чисел:");
        for (int i = 0; i < len; i++)
        {
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int result = ds.Calculate(array);

        Console.WriteLine("Сумма нечетных элементов массива = " + result);

        Console.ReadKey();
    }
}

