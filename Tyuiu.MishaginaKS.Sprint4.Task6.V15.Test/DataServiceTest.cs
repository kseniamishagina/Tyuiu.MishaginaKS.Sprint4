using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MishaginaKS.Sprint4.Task6.V15.Lib;

namespace Tyuiu.MishaginaKS.Sprint4.Task6.V15.Test;

[TestClass]
public class DataServiceTest

{
    [TestMethod]
    public void ValidCalculate()

    {
        DataService ds = new DataService();

        string[] array = { "Чикаго", "Хьюстон", "Феникс", "Филадельфия", "Сан-Антонио", "Сан-Диего", "Даллас" };

        int res = ds.Calculate(array);
        int wait = 3;

        Assert.AreEqual(wait, res);
    }
}
