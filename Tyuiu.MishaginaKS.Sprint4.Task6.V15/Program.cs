using System;
using Tyuiu.MishaginaKS.Sprint4.Task6.V15.Lib;

namespace Tyuiu.MishaginaKS.Sprint4.Task6.V15;

class Program

{
    static void Main(string[] args)

    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Задание #6 | Вариант 15";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #15                                                             *");
        Console.WriteLine("* Выполнила: Мишагина К. С. | Группа АСОиУб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан строковый массив данных. Используя класс Array, подсчитать          *");
        Console.WriteLine("* количество элементов, длина которых меньше 7.                           *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string[] array = { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };

        Console.WriteLine("Исходный массив:");

        for (int i = 0; i < array.Length; i++)

        {
            Console.WriteLine(array[i]);
        }

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        int result = ds.Calculate(array);

        Console.WriteLine("Количество элементов с длиной меньше 7 = " + result);

        Console.ReadKey();
    }
}

