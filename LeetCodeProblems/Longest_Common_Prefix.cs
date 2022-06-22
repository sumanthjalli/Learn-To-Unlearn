using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems
{
    public  class Longest_Common_Prefix
    {
        public string LongestCommonPrefix(string[] inputString)
        {
            string prefix = inputString[0];
            for (int i = 1; i < inputString.Length; i++)
            {
                while (inputString[i].IndexOf(prefix) !=0)
                {
                    prefix = prefix.Substring(0,prefix.Length -1);
                    if (prefix =="")
                    {
                        return "";
                    }

                }
            }
            return prefix;
        }
    }
}
