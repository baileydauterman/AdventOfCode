using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Day3
{
    internal class Day3
    {
        public Day3()
        {
            Santa = new Tracker();
            RoboSanta = new Tracker();
            Houses = new List<string>();
            Data = File.ReadAllText("../../../Day3/input.txt");
        }

        public class Tracker
        {
            public int Longitude { get; set; } = 0;
            public int Latitude { get; set; } = 0;

            public override string ToString()
            {
                return $"{Longitude}, {Latitude}";
            }
        }

        public List<string> Houses { get; set; }
        public string Data { get; set; }
        public Tracker Santa { get; set; }
        public Tracker RoboSanta { get; set; }
        public int UniqueHouses { get; set; }
        /// <summary>
        /// --- Day 3: Perfectly Spherical Houses in a Vacuum ---
        /// <para>Santa is delivering presents to an infinite two-dimensional grid of houses.
        /// He begins by delivering a present to the house at his starting location, and then an elf at the North Pole calls him via radio and tells him where to move next.Moves are always exactly one house to the north (^), 
        /// south(v), east(&gt;), or west(&lt;). After each move, he delivers another present to the house at his new location.
        /// However, the elf back at the north pole has had a little too much eggnog, and so his directions are a little off, and Santa ends up visiting some houses more than once.
        /// How many houses receive at least one present?</para>
        /// 
        /// For example:
        /// &gt; delivers presents to 2 houses: one at the starting location, and one to the east.
        /// ^&gt;v&lt; delivers presents to 4 houses in a square, including twice to the house at his starting/ending location.
        /// ^v^v^v^v^v delivers a bunch of presents to some very lucky children at only 2 houses.
        /// </summary>
        public void Part1()
        {
            Start();

            foreach (var m in Data)
            {
                MoveSanta(m);
            }

            GetUniqueHouses();
        }

        public void Part2()
        {
            Start();

            int counter = 1;

            foreach (var m in Data)
            {
                if (counter % 2 == 0)
                {
                    MoveSanta(m, true);
                }
                else
                {
                    MoveSanta(m);
                }

                counter++;
            }

            GetUniqueHouses();
        }

        public void TestCases()
        {
            Part1TestCase(">", 2);
            Part1TestCase("^>v<", 4);
            Part1TestCase("^v^v^v^v^v", 2);

            Part2TestCase("^v", 3);
            Part2TestCase("^>v<", 3);
            Part2TestCase("^v^v^v^v^v", 11);

            Part1();
            if (UniqueHouses != Answers[1]) throw new Exception($"Test Case Failed: \n\tGot {UniqueHouses}\n\tExpected {Answers[1]}");

            Part2();
            if (UniqueHouses != Answers[2]) throw new Exception($"Test Case Failed: \n\tGot {UniqueHouses}\n\tExpected {Answers[2]}");
        }

        public void Part1TestCase(string s, int expected)
        {
            Start();

            foreach (var m in s)
            {
                MoveSanta(m);
            }

            GetUniqueHouses();

            if (UniqueHouses != expected) throw new Exception($"Test Case Failed: \n\tGot {UniqueHouses}\n\tExpected {expected}");
        }

        public void Part2TestCase(string s, int expected)
        {
            Start();

            int counter = 1;

            foreach (var m in s)
            {
                if (counter % 2 == 0)
                {
                    MoveSanta(m, true);
                }
                else
                {
                    MoveSanta(m);
                }

                counter++;
            }

            GetUniqueHouses();

            if (UniqueHouses != expected) throw new Exception($"Test Case Failed: \n\tGot {UniqueHouses}\n\tExpected {expected}");
        }

        public void GetUniqueHouses()
        {
            UniqueHouses = Houses.Distinct().Count();
        }

        private void MoveSanta(char m, bool isRoboSanta=false)
        {
            var temp = isRoboSanta ? RoboSanta : Santa;
            switch (m)
            {
                case '^':
                    temp.Latitude += 1;
                    break;

                case 'v':
                    temp.Latitude -= 1;
                    break;

                case '>':
                    temp.Longitude += 1;
                    break;

                case '<':
                    temp.Longitude -= 1;
                    break;

                default:
                    throw new Exception($"Unknown character {m}");
            }

            Houses.Add(temp.ToString());
        }

        private void Start()
        {
            Santa = new Tracker();
            RoboSanta = new Tracker();
            Houses = new List<string>();
            Houses.Add(Santa.ToString());
        }

        private Dictionary<int, int> Answers = new Dictionary<int, int>()
        {
            { 1, 2081 },
            { 2, 2341 }
        };
    }
}
