using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode
{
    abstract class IDay
    {
        public abstract void Part1();

        public abstract void Part2();

        public abstract void TestCases();

        public abstract void Test(string input, string output);
        public abstract void Test(string input, bool expected);
    }
}
