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