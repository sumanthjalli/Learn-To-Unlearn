using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCodeProblems.Test
{
    [TestClass]
    public class PalindromeTest
    {
        [TestMethod]
        public void Given_Number_Check_Palindrome()
        {
            //Given
            var number = 121;
            var problem = new Palindrome();
            var expectedResult = true;


            //When
            var actualResult = problem.IsPalendrome(number);

            //Then
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
