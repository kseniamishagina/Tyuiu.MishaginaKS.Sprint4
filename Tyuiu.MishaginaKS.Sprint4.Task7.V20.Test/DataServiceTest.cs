using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MishaginaKS.Sprint4.Task7.V20.Lib;

namespace Tyuiu.MishaginaKS.Sprint4.Task7.V20.Test;

[TestClass]
public class DataServiceTest

{
    [TestMethod]
    public void ValidCalculate()

    {
        DataService ds = new DataService();

        int[,] matrix = new int[5, 3] {
            { 3, 5, 7 },
            { 9, 5, 1 },
            { 2, 4, 8 },
            { 6, 3, 2 },
            { 5, 8, 7 }
        };

        int[,] res = ds.Calculate(matrix);
        int[,] wait = new int[5, 3] {
            { 3, 5, 7 },
            { 9, 5, 1 },
            { 4, 8, 16 },
            { 12, 3, 4 },
            { 5, 16, 7 }
        };

        CollectionAssert.AreEqual(wait, res);
    }
}

