// See https://aka.ms/new-console-template for more information
using AdventOfCode;
using NUnit.Framework;

// -- Day 1 -- 
Assert.AreEqual(Day1.Max(), 69177);
Assert.AreEqual(Day1.Top3(), 207456);

// -- Day 2 -- 

Assert.AreEqual(Day2.ReadFile("../../../Day2/input.test").Select(f => f.Score).Sum(), 15);
Assert.AreEqual(Day2.ReadFile("../../../Day2/input.prod").Select(f => f.Score).Sum(), 13052);
Assert.AreEqual(Day2.ReadFileCorrectly("../../../Day2/input.prod").Select(f => f.Score).Sum(), 13693);

// -- Day 3 --

Assert.AreEqual(Day3.GetPriority("../../../Day3/input.test"), 157);
Assert.AreEqual(Day3.GetPriority("../../../Day3/input.prod"), 7817);

Assert.AreEqual(Day3.GetBadgeNum("../../../Day3/input.test2"), 70);
Assert.AreEqual(Day3.GetBadgeNum("../../../Day3/input.prod"), 2444);

// -- Day 4 --
Assert.AreEqual(Day4.CheckSections("../../../Day4/input.test"), 2);

Assert.AreEqual(Day4.CheckSections("../../../Day4/input.prod"), 431);
Assert.AreEqual(Day4.CheckSectionsAny("../../../Day4/input.prod"), 823);
