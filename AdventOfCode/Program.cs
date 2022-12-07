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


// -- Day 5 -- 
Assert.AreEqual(new Day5().CrateMover9000("../../../Day5/input.test", new Day5().test), "CMZ");
Assert.AreEqual(new Day5().CrateMover9000("../../../Day5/input.prod", new Day5().prod), "FWNSHLDNZ");

Assert.AreEqual(new Day5().CrateMover9001("../../../Day5/input.test", new Day5().test), "MCD");
Assert.AreEqual(new Day5().CrateMover9001("../../../Day5/input.prod", new Day5().prod), "RNRGDNFQG");

// -- Day 6 --
Assert.AreEqual(Day6.FindMarkerString("bvwbjplbgvbhsrlpgdmjqwftvncz"), 5);
Assert.AreEqual(Day6.FindMarkerString("nppdvjthqldpwncqszvftbrmjlhg"), 6);
Assert.AreEqual(Day6.FindMarkerString("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg"), 10);
Assert.AreEqual(Day6.FindMarkerString("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw"), 11);

Assert.AreEqual(Day6.FindMarker("../../../Day6/input.prod"), 1658);

Assert.AreEqual(Day6.FindMessageString("mjqjpqmgbljsphdztnvjfqwrcgsmlb"), 19);
Assert.AreEqual(Day6.FindMessageString("bvwbjplbgvbhsrlpgdmjqwftvncz"), 23);
Assert.AreEqual(Day6.FindMessageString("nppdvjthqldpwncqszvftbrmjlhg"), 23);
Assert.AreEqual(Day6.FindMessageString("nznrnfrfntjfmvfwmzdfjlvtqnbhcprsg"), 29);
Assert.AreEqual(Day6.FindMessageString("zcfzfwzzqfrljwzlrfnpqdbhtmscgvjw"), 26);
Assert.AreEqual(Day6.FindMessage("../../../Day6/input.prod"), 2260);