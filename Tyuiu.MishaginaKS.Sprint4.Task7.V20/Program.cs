using System;
using Tyuiu.MishaginaKS.Sprint4.Task7.V20.Lib;

namespace Tyuiu.MishaginaKS.Sprint4.Task7.V20;


class Program

{
    static void Main(string[] args)

    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Задание #7 | Вариант 20";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #20                                                             *");
        Console.WriteLine("* Выполнила: Мишагина К. С. | Группа АСОиУб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана строка из одноразрядных цифр \"357951248632587\". Преобразуйте ее  *");
        Console.WriteLine("* в матрицу 5 на 3 и подсчитайте произведение четных чисел.               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int rows = 5;
        int columns = 3;
        string str = "357951248632587";
        int[,] matrix = new int[rows, columns];

        int index = 0;
        Console.WriteLine("\nИсходная матрица:");
        for (int i = 0; i < rows; i++)

        {
            for (int j = 0; j < columns; j++)

            {
                matrix[i, j] = int.Parse(str[index].ToString());
                Console.Write($"{matrix[i, j]} \t");
                index++;
            }
            Console.WriteLine();
        }

        int product = 1;
        for (int i = 0; i < rows; i++)

        {
            for (int j = 0; j < columns; j++)
            {
                if (matrix[i, j] % 2 == 0 && matrix[i, j] != 0)
                {
                    product *= matrix[i, j];
                }
            }
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int[,] resultMatrix = ds.Calculate(matrix);

        Console.WriteLine("Произведение четных элементов = " + product);

        Console.ReadKey();
    }
}

