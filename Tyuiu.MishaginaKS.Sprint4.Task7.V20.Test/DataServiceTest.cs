using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.MishaginaKS.Sprint4.Task7.V20.Lib;

namespace Tyuiu.MishaginaKS.Sprint4.Task7.V20.Test;

[TestClass]
public class DataServiceTest

{
    [TestMethod]
    public void ValidCalculate()

    {
        DataService ds = new DataService();

        int rows = 5;
        int columns = 3;
        string str = "357951248632587";

        int res = ds.Calculate(rows, columns, str);
        int wait = 6144;

        Assert.AreEqual(wait, res);
    }
}

