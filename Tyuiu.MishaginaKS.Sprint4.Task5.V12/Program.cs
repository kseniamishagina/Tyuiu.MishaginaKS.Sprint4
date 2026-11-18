using System;
using Tyuiu.MishaginaKS.Sprint4.Task5.V12.Lib;

namespace Tyuiu.MishaginaKS.Sprint4.Task5.V12;

class Program

{
    static void Main(string[] args)

    {
        Random rnd = new Random();
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Задание #5 | Вариант 12";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнила: Мишагина К. С. | Группа АСОиУб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* случайными значениями в диапазоне от -6 до 4.                           *");
        Console.WriteLine("* Найти количество отрицательных элементов.                               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int rows = 5;
        int columns = 5;
        int[,] matrix = new int[rows, columns];

        for (int i = 0; i < rows; i++)

        {
            for (int j = 0; j < columns; j++)

            {
                matrix[i, j] = rnd.Next(-6, 5);
            }
        }

        Console.WriteLine("Массив из случайных чисел:");
        for (int i = 0; i < rows; i++)

        {
            for (int j = 0; j < columns; j++)

            {
                Console.Write($"{matrix[i, j]} \t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int result = ds.Calculate(matrix);

        Console.WriteLine("Количество отрицательных элементов = " + result);

        Console.ReadKey();
    }
}

