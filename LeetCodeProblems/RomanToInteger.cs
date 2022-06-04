using System.Collections.Generic;

namespace LeetCodeProblems
{
    public class RomanToInteger
    {
        /// <summary>
        ///https://leetcode.com/problems/roman-to-integer/ 
        /// </summary>        
        public int ConvertRomanToInteger(string input)
        {
            Dictionary<string, int> romanDict = new Dictionary<string, int>();
            romanDict.Add("I", 1);
            romanDict.Add("V", 5);
            romanDict.Add("X", 10);
            romanDict.Add("L", 50);
            romanDict.Add("C", 100);
            romanDict.Add("D", 500);
            romanDict.Add("M", 1000);
            char[] chararry = input.ToCharArray();
            int baseValue = romanDict.GetValueOrDefault(chararry[chararry.Length - 1].ToString());
            for (int i = chararry.Length - 1; i >= 1; i--)
            {
                if (romanDict.GetValueOrDefault(chararry[i - 1].ToString()) >= romanDict.GetValueOrDefault(chararry[i].ToString()))
                    baseValue += romanDict.GetValueOrDefault(chararry[i - 1].ToString());
                else
                    baseValue -= romanDict.GetValueOrDefault(chararry[i - 1].ToString());

            }
            return baseValue;
        }
    }
}
