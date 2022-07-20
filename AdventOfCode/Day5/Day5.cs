using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Day5
{
    internal class Day5 : IDay
    {
        public Day5()
        {
            Data = File.ReadAllLines("../../../Day5/input.txt").ToList();
        }

        public List<string> Data { get; set; }
        public string CurrentString { get; set; } = string.Empty;
        public int ValidStrings { get; set; } = 0;
        public List<string> NaughtyStrings { get; set; } = new List<string>();
        public List<string> NiceStrings { get; set; } = new List<string>();
        public override void Part1()
        {
            foreach (var str in Data)
            {
                CurrentString = str;

                if (BadStrings() && DoubleLetter() && ContainsVowel())
                {
                    ValidStrings++;
                    NiceStrings.Add(CurrentString);
                }
                else
                {
                    NaughtyStrings.Add(CurrentString);
                }
            }
        }

        public override void Part2()
        {
            ValidStrings = 0;

            foreach (var str in Data)
            {
                CurrentString = str;
                if (DoubleLetterSplit() && PairSplit())
                {
                    ValidStrings++;
                    NiceStrings.Add(CurrentString);
                }
                else
                {
                    NaughtyStrings.Add(CurrentString);
                }
            }
        }

        public override void Test(string input, bool expected)
        {
            CurrentString = input;
            
            var result = BadStrings() && DoubleLetter() && ContainsVowel();

            if (result != expected) Console.Error.WriteLine($"{CurrentString} Test Case Failed: \n\tGot { result }\n\tExpected { expected }");
        }

        public void Test2(string input, bool expected)
        {
            CurrentString = input;

            var result = DoubleLetterSplit() && PairSplit();

            if (result != expected) Console.Error.WriteLine($"{CurrentString} Test Case Failed: \n\tGot { result }\n\tExpected { expected }");
        }


        public override void TestCases()
        {
            Test("ugknbfddgicrmopn", true);
            Test("aaa", true);
            Test("jchzalrnumimnmhp", false);
            Test("haegwjzuvuyypxyu", false);
            Test("dvszwmarrgswjxmb", false);

            Test2("qjhvhtzxzqqjkmpb", true);
            Test2("xxyxx", true);
            Test2("aaa", false);
            Test2("uurcxstgmygtbstg", false);
            Test2("ieodomkazucvgmuy", false);
        }

        private bool ContainsVowel()
        {
            var counter = 0;
            foreach (var v in Vowels)
            {
                counter += CurrentString.Where(x => (x == v)).ToList().Count();
            }

            return counter >= 3 ? true : false;
        }

        private bool DoubleLetter()
        {
            for (int i = 0; i < CurrentString.Length -1; i++)
            {
                if (CurrentString[i] == CurrentString[i + 1])
                {
                    return true;
                }
            }

            return false;
        }

        private bool BadStrings()
        {
            foreach (var str in BadString)
            {
                if(CurrentString.Contains(str))
                {
                    return false;
                }
            }

            return true;
        }

        private bool DoubleLetterSplit()
        {
            for (int i = 0; i < CurrentString.Length - 2; i++)
            {
                if (CurrentString[i] == CurrentString[i + 2])
                {
                    return true;
                }
            }

            return false;
        }

        private bool PairSplit()
        {
            for (int i = 0; i < CurrentString.Length - 2; i++)
            {
                var temp = CurrentString[i].ToString() + CurrentString[i+1].ToString();

                if (CurrentString.Substring(i+2, CurrentString.Length - (i+2)).Contains(temp))
                {
                    return true;
                }
            }

            return false;
        }

        public override void Test(string input, string output)
        {
            throw new NotImplementedException();
        }

        private List<string> BadString = new List<string>()
        {
            "ab",
            "cd",
            "pq",
            "xy"
        };

        private List<char> Vowels = new List<char>()
        {
            'a',
            'e',
            'i',
            'o',
            'u'
        };

        private Dictionary<int, int> Answer = new Dictionary<int, int>()
        {
            { 1, 258 },
            { 2, 53 },
        };
    }
}
