using System;
using NuGet.Frameworks;

namespace AdventOfCode.Tests._2025;

public class Day1
{
    [TestCase('R', 10, 50, 60)]
    [TestCase('L', 10, 50, 40)]
    [TestCase('R', 150, 50, 0)]
    public void DialPosition(char direction, int offset, int startingNumber, int expected)
    {
        var dial = new AdventOfCode._2025.Dial(startingNumber);

        dial.Turn(direction, offset);

        Assert.That(dial.Position, Is.EqualTo(expected));
    }

    [TestCase('R', 1000, 99, 10)]
    [TestCase('L', 100, 0, 1)]
    [TestCase('R', 150, 50, 2)]
    [TestCase('R', 99, 1, 1)]
    public void DialPassword2(char direction, int offset, int startingNumber, int expected)
    {
        var dial = new AdventOfCode._2025.Dial(startingNumber);

        dial.Turn(direction, offset);

        Assert.That(dial.Password2, Is.EqualTo(expected));
    }

    [Test]
    public void Part1()
    {
        using (var stream = File.OpenRead(Common.BuildPath(2025, 1, Common.DataType.Test))) 
        {
            var dial = AdventOfCode._2025.Day1.Part1(stream);
            Assert.That(dial.Password1, Is.EqualTo(3));
        }
        
        
        using (var stream = File.OpenRead(Common.BuildPath(2025, 1, Common.DataType.Prod)))
        {
            var dial = AdventOfCode._2025.Day1.Part1(stream);
            Assert.That(dial.Password1, Is.EqualTo(1180));
        }
    }

    [Test]
    public void Part2()
    {
        using (var stream = File.OpenRead(Common.BuildPath(2025, 1, Common.DataType.Test))) 
        {
            var dial = AdventOfCode._2025.Day1.Part1(stream);
            Assert.That(dial.Password2, Is.EqualTo(6));
        }
        
        
        using (var stream = File.OpenRead(Common.BuildPath(2025, 1, Common.DataType.Prod)))
        {
            var dial = AdventOfCode._2025.Day1.Part1(stream);
            Assert.That(dial.Password2, Is.EqualTo(6892));
        }
    }
}
