using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Day2
{
    internal class Day2
    {
        public Day2()
        {

        }

        public class Present
        {
            public int Length { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }
        }

        public List<string> Data = File.ReadAllLines("../../../Day2/input.txt").ToList();
        public int TotalWrappingPaper = 0;
        public int TotalRibbonLength = 0;

        /// <summary>
        /// --- Day 2: I Was Told There Would Be No Math ---
        /// <para>
        /// The elves are running low on wrapping paper, and so they need to submit an order for more.They have a list of the dimensions(length l, width w, and height h) of each present, and only want to order exactly as much as they need.
        /// Fortunately, every present is a box (a perfect right rectangular prism), which makes calculating the required wrapping paper for each gift a little easier: find the surface area of the box, which is 2*l* w + 2*w* h + 2*h* l.The elves also need a little extra paper for each present: the area of the smallest side.
        /// </para>
        /// For example:
        /// 
        /// <para>A present with dimensions 2x3x4 requires 2*6 + 2*12 + 2*8 = 52 square feet of wrapping paper plus 6 square feet of slack, for a total of 58 square feet.</para>
        /// <para>A present with dimensions 1x1x10 requires 2*1 + 2*10 + 2*10 = 42 square feet of wrapping paper plus 1 square foot of slack, for a total of 43 square feet.</para>
        /// 
        /// All numbers in the elves' list are in feet. How many total square feet of wrapping paper should they order?
        /// </summary>
        /// <returns>Total square feet in list</returns>
        public void Part1()
        {
            TotalWrappingPaper = 0;
            TotalRibbonLength = 0;

            foreach (var s in Data)
            {
                var temp = s.Split('x');

                var p = new Present
                {
                    Length = int.Parse(temp[0]),
                    Width = int.Parse(temp[1]),
                    Height = int.Parse(temp[2])
                };

                CalculateSurfaceArea(p);
                CalculateRibbonLength(p);
            }
        }

        /// <summary>
        /// --- Part Two ---
        /// <para>The elves are also running low on ribbon. Ribbon is all the same width, so they only have to worry about the length they need to order, which they would again like to be exact.</para>
        /// <para>The ribbon required to wrap a present is the shortest distance around its sides, or the smallest perimeter of any one face. Each present also requires a bow made out of ribbon as well; 
        /// the feet of ribbon required for the perfect bow is equal to the cubic feet of volume of the present.Don't ask how they tie the bow, though; they'll never tell.</para>
        /// For example:
        /// <para>A present with dimensions 2x3x4 requires 2+2+3+3 = 10 feet of ribbon to wrap the present plus 2*3*4 = 24 feet of ribbon for the bow, for a total of 34 feet.</para>
        /// <para>A present with dimensions 1x1x10 requires 1+1+1+1 = 4 feet of ribbon to wrap the present plus 1*1*10 = 10 feet of ribbon for the bow, for a total of 14 feet.</para>
        /// <para>How many total feet of ribbon should they order?</para>
        /// </summary>
        /// <returns>Length of ribbon</returns>
        public int Part2()
        {
            throw new NotImplementedException();
        }

        public void TestCase()
        {
            TestMath(2, 3, 4, 58, 34);
            TestMath(1, 1, 10, 43, 14);
        }

        private void TestMath(int l, int w, int h, int expectedSA, int expectedRL)
        {
            TotalWrappingPaper = 0;
            TotalRibbonLength = 0;

            var p = new Present
            {
                Length = l,
                Width = w,
                Height = h,
            };

            CalculateSurfaceArea(p);
            CalculateRibbonLength(p);

            if (TotalWrappingPaper != expectedSA) throw new Exception($"Failed Test Case: \nGot {TotalWrappingPaper} \nExpected {expectedSA}");
            if (TotalRibbonLength != expectedRL) throw new Exception($"Failed Test Case: \nGot {TotalRibbonLength} \nExpected {expectedRL}");
        }

        private void CalculateSurfaceArea(Present p)
        {
            var one = p.Length * p.Width;
            var two = p.Length * p.Height;
            var three = p.Height * p.Width;

            TotalWrappingPaper += 2 * ( one + two + three) +
                   Minimum(one, two, three);
        }

        private void CalculateRibbonLength(Present p)
        {
            TotalRibbonLength += p.Length * p.Width * p.Height;

            var ints = new List<int>()
            {
                p.Length, p.Width, p.Height
            };

            ints.Sort();
            ints = ints.Take(2).ToList();

            TotalRibbonLength += 2*ints[0] + 2*ints[1];
        }

        private int Minimum(int one, int two, int three)
        {
            return Math.Min(one, Math.Min(two, three));
        }

        private Dictionary<int, int> Answers = new Dictionary<int, int>()
        {
            { 1, 1588178 },
            { 2, 3783758 }
        };
    }
}
