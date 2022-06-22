using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Test
{
    [TestClass]
    public class LongestCommonPrefixTest
    {
        [TestMethod]
        public void Logest_Common_Prefix_Reture()
        {
            //Given
            string[] givenStrArray = { "abcde", "abc", "abcd" };
            var problem = new Longest_Common_Prefix();
            string outPut = "abc";

            //When
            var actual = problem.LongestCommonPrefix(givenStrArray);

            //Then
            Assert.AreEqual(outPut,actual);
        }
    }
}
