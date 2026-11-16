using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MishaginaKS.Sprint4.Task2.V8.Lib;

namespace Tyuiu.MishaginaKS.Sprint4.Task2.V8.Test;

[TestClass]
public class DataServiceTest

{
    [TestMethod]
    public void ValidCalculate()

    {
        DataService ds = new DataService();

        int[] array = { 2, 3, 4, 5, 6, 7, 2, 3, 4, 5, 6 };

        int res = ds.Calculate(array);
        int wait = 23;

        Assert.AreEqual(wait, res);
    }
}

