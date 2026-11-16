namespace Tyuiu.MishaginaKS.Sprint4.Task2.V8.Lib;
using tyuiu.cources.programming.interfaces.Sprint4;

public class DataService : ISprint4Task2V8

{
    public int Calculate(int[] array)

    {
        int sum = 0;

        foreach (int x in array)
        {
            if (x % 2 != 0)
            {
                sum += x;
            }
        }

        return sum;
    }
}
