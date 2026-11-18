namespace Tyuiu.MishaginaKS.Sprint4.Task5.V12.Lib;
using tyuiu.cources.programming.interfaces.Sprint4;
public class DataService : ISprint4Task5V12

{
    public int Calculate(int[,] matrix)

    {
        int count = 0;

        foreach (int x in matrix)
        {
            if (x < 0)
            {
                count++;
            }
        }

        return count;
    }
}

