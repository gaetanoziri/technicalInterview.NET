using Microsoft.VisualStudio.TestTools.UnitTesting;
using technicalInterview.algorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace technicalInterview.algorithm.Tests
{
    [TestClass()]
    public class FizzBuzzTests
    {
        [TestMethod()]
        public void GenerateTest()
        {
            Assert.AreEqual(FizzBuzz.Generate(int.MinValue), "");
            Assert.AreEqual(FizzBuzz.Generate(0), "");
            Assert.AreEqual(FizzBuzz.Generate(1), "1");
            Assert.AreEqual(FizzBuzz.Generate(3), "1 2 Fizz");
            Assert.AreEqual(FizzBuzz.Generate(6), "1 2 Fizz 4 Buzz Fizz");
            Assert.AreEqual(FizzBuzz.Generate(15), "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 Fizz Buzz");
        }
    }
}