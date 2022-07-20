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
            Input = string.Empty;
            Value = 0;
            Hash = string.Empty;
            ValueStr = string.Empty;
        }

        public string Hash { get; set; }
        public string Input { get; set; }
        public int Value { get; set; }
        public string ValueStr { get; set; }

        public override void Part1()
        {
            Start();

            Input = "ckczppom";
            while (!Hash.StartsWith("00000"))
            {
                ComputeHash();
                Value++;
            }
        }

        public override void Part2()
        {
            Start();

            Input = "ckczppom";
            while (!Hash.StartsWith("000000"))
            {
                ComputeHash();
                Value++;
            }
        }

        public override void TestCases()
        {
            Test("abcdef", "abcdef609043");
            Test("pqrstuv", "pqrstuv1048970");
        }

        public override void Test(string input, string output)
        {
            Start();

            Input = input;
            while (!Hash.StartsWith("00000"))
            {
                ComputeHash();
                Value++;
            }
            if (!output.Equals(ValueStr)) throw new Exception($"Test Case Failed: \n\tGot {ValueStr}\n\tExpected {output}");
        }

        private void ComputeHash()
        {
            ValueStr = Input + Value.ToString();

            using (MD5 md5 = MD5.Create())
            {
                byte[] hash = md5.ComputeHash(Encoding.ASCII.GetBytes(ValueStr));
                Hash = Convert.ToHexString(hash);
            }
        }

        private void Start()
        {
            Value = 0;
            Hash = string.Empty;
            ValueStr = string.Empty;
        }

        public override void Test(string input, bool expected)
        {
            throw new NotImplementedException();
        }

        private Dictionary<int, int> Answers = new Dictionary<int, int>()
        {
            { 1, 117946 },
            { 2, 3938038 },
        };
    }
}
