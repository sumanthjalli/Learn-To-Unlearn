using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Test
{
    [TestClass]
   public class RomanToIntegerTest
    {
        [TestMethod]
        public void Given_Roman_Number_Then_Integer()
        {
            //Given
            string input = "MCMXCIV";
            var problem = new RomanToInteger();
            var expectedResult = 1994;

            //When
            var actulaResult = problem.ConvertRomanToInteger(input);

            //Then
            Assert.AreEqual(actulaResult, expectedResult);
        }
    }
}
