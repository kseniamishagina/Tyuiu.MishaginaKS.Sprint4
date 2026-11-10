namespace Tyuiu.MishaginaKS.Sprint4.Task0.V8.Lib;
using tyuiu.cources.programming.interfaces.Sprint4;

public class DataService : ISprint4Task0V8

{
    public int GetMultEvenArrEl(int[] array)

    {
        int product = 1;
        bool hasEven = false;

        foreach (int x in array)
        {
            if (x % 2 == 0 && x != 0)
            {
                product *= x;
                hasEven = true;
            }
        }

        return hasEven ? product : 0;
    }
}
    

