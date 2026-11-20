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

        int index = 0;
        Console.WriteLine("\nМассив:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{str[index]} \t");
                index++;
            }
            Console.WriteLine();
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int result = ds.Calculate(rows, columns, str);

        Console.WriteLine("Произведение четных элементов = " + result);

        Console.ReadKey();
    }
}
