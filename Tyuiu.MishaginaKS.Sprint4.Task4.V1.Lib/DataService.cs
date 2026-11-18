namespace Tyuiu.MishaginaKS.Sprint4.Task4.V1.Lib;

using tyuiu.cources.programming.interfaces.Sprint4;

public class DataService : ISprint4Task4V1
{
    public int Calculate(int[,] matrix)

    {
        int sum = 0;

        foreach (int x in matrix)
        {
            if (x % 2 == 0)
            {
                sum += x;
            }
        }

        return sum;
    }
}
