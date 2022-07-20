using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace AdventOfCode.Day4
{
    internal class Day4 : IDay
    {
        public Day4()
        {
            Input = "ckczppom";
        }

        public string Hash { get; set; }
        public string Input { get; set; }

        public void ComputeHash()
        {
            using (MD5 md5 = MD5.Create() )
            {

            }
        }

        public void Day1()
        {
            throw new NotImplementedException();
        }

        public void Day2()
        {
            throw new NotImplementedException();
        }

        public void TestCases()
        {
            throw new NotImplementedException();
        }
    }
}
