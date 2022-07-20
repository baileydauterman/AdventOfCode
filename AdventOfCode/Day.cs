using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    interface IDay
    {
        void Part1();

        void Part2();

        void TestCases();

        void Test(string input, string output);
    }
}
