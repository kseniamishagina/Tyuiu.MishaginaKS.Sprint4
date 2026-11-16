using System;
using Tyuiu.MishaginaKS.Sprint4.Task3.V12.Lib;
namespace Tyuiu.MishaginaKS.Sprint4.Task3.V12;

class Program

{
    static void Main(string[] args)

    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Задание #3 | Вариант 12";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнила: Мишагина К. С. | Группа АСОиУб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* статическими значениями. Найдите минимальный элемент в третьем столбце. *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[,] array = new int[5, 5] {
            { 9, 7, 4, 9, 7 },
            { 5, 2, 5, 7, 6 },
            { 8, 3, 3, 5, 7 },
            { 8, 4, 2, 4, 5 },
            { 8, 8, 9, 5, 6 }
        };

        int rows = array.GetUpperBound(0) + 1;
        int columns = array.Length / rows;

        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{array[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int result = ds.Calculate(array);

        Console.WriteLine("Минимальный элемент в третьем столбце = " + result);

        Console.ReadKey();
    }
}
