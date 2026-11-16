using System;
using Tyuiu.MishaginaKS.Sprint4.Task1.V14.Lib;
namespace Tyuiu.MishaginaKS.Sprint4.Task1.V14;
class Program

{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Задание #1 | Вариант 14";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнила: Мишагина К. С. | Группа АСОиУб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 13 элементов, заполненный        *");
        Console.WriteLine("* с клавиатуры в диапазоне от 1 до 8. Подсчитать сумму нечетных элементов.*");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int len = 13;
        int[] array = new int[len];

        for (int i = 0; i < len; i++)
        {
            Console.Write($"Введите значение {i} элемента массива: ");
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine();
        Console.WriteLine("Введенный массив:");
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
