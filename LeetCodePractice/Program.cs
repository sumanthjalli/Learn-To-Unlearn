using LeetCodeProblems;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodePractice
{
    class Program
    {
        static void Main(string[] args)
        {

            var dict = new HashSet<Tuple<int, int>>();
            dict.Add(new Tuple<int, int>(1, 2));
            dict.Add(new Tuple<int, int>(1, 2));
            dict.Add(new Tuple<int, int>(2, 1));
        }
    }
}
