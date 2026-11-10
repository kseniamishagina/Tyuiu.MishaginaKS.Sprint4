using System;
using Tyuiu.MishaginaKS.Sprint4.Task0.V8.Lib;
namespace Tyuiu.MishaginaKS.Sprint4.Task0.V8;


class Program

{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Задание #0 | Вариант 8";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнила: Мишагина К. С. | Группа АСОиУб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Подсчитать произведение четных элементов массива.                       *");
        Console.WriteLine("* Массив: {1, 6, 3, 7, 5, 4, 2, 7, 8, 9}                                  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] array = { 1, 6, 3, 7, 5, 4, 2, 7, 8, 9 };

        Console.WriteLine("Исходный массив: ");
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "\t");
        }
        Console.WriteLine();

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int result = ds.GetMultEvenArrEl(array);

        Console.WriteLine("Произведение четных элементов массива = " + result);

        Console.ReadKey();
    }
}

