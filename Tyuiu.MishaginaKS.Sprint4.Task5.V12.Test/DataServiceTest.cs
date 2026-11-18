using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MishaginaKS.Sprint4.Task5.V12.Lib;
namespace Tyuiu.MishaginaKS.Sprint4.Task5.V12.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidCalculate()

    {
        DataService ds = new DataService();

        int[,] matrix = new int[5, 5] {
            { -6,  2,  0, -1,  4 },
            { -3, -5,  1,  3, -2 },
            {  0,  4, -4, -6,  2 },
            {  1, -1, -2,  3,  0 },
            { -5,  2,  4, -3,  1 }
        };

        int res = ds.Calculate(matrix);
        int wait = 11;

        Assert.AreEqual(wait, res);
    }
}
