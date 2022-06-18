namespace LeetCodeProblems
{
    public class Palindrome
    {
        /// <summary>
        /// https://leetcode.com/problems/palindrome-number/
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public bool IsPalendrome(int number)
        {
            if (number < 0)
                return false;

            int reverse = 0;
            while (number > reverse)
            {
                reverse = reverse * 10 + number % 10;
                number /= 10;
            }
            //'/' : returns the quotient and '%' will returns reminder 
            return number == reverse || number == reverse / 10;
        }
    }
}
