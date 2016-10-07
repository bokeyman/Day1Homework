using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Collections;

namespace MyHomework
{
    [TestClass]
    public class UnitTest1
    {

        List<Product> ProductList = new List<Product>()
            {
                new Product { Id=1,Cost=1,Revenue=11,SellPrice=21},
                new Product { Id=2,Cost=2,Revenue=12,SellPrice=22},
                new Product { Id=3,Cost=3,Revenue=13,SellPrice=23},
                new Product { Id=4,Cost=4,Revenue=14,SellPrice=24},
                new Product { Id=5,Cost=5,Revenue=15,SellPrice=25},
                new Product { Id=6,Cost=6,Revenue=16,SellPrice=26},
                new Product { Id=1,Cost=7,Revenue=17,SellPrice=27},
                new Product { Id=2,Cost=8,Revenue=18,SellPrice=28},
                new Product { Id=3,Cost=9,Revenue=19,SellPrice=29},
                new Product { Id=4,Cost=10,Revenue=20,SellPrice=30},
                new Product { Id=5,Cost=11,Revenue=21,SellPrice=31}
            };


        [TestMethod]
        public void TestMethod1()
        {

            var Calculator = new Calculator();
            var actual =  Calculator.ItemMount(3, ProductList, "SellPrice");

            var expected = new ArrayList() { 66, 75, 84,  61};

            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void TestMethod2()
        {

            var Calculator = new Calculator();
            var actual = Calculator.ItemMount(4, ProductList, "Cost");

            var expected = new ArrayList() { 10, 26, 30 };

            CollectionAssert.AreEqual(expected, actual);
        }


    }

    internal class Product
    {
        public int Id { get; set; }
        public int Cost { get; set; }
        public int Revenue { get; set; }
        public int SellPrice { get; set; }
    }
}
