// See https://aka.ms/new-console-template for more information
using AdventOfCode;
using AdventOfCode.Day2;
using AdventOfCode.Day3;
using AdventOfCode.Day4;

Console.WriteLine("--- Day 1 ---");
Console.WriteLine(new Day1().Part1());
Console.WriteLine(new Day1().Part2());

Console.WriteLine("--- Day 2 ---");
var day2 = new Day2();
day2.TestCase();
day2.Part1();
Console.WriteLine(day2.TotalWrappingPaper);
Console.WriteLine(day2.TotalRibbonLength);

Console.WriteLine("--- Day 3 ---");
var day3 = new Day3();
day3.TestCases();
day3.Part1();
Console.WriteLine(day3.UniqueHouses);
day3.Part2();
Console.WriteLine(day3.UniqueHouses);

Console.WriteLine("--- Day 4 ---");
var day4 = new Day4();
day4.TestCases();

day4.Part1();
Console.WriteLine(day4.ValueStr);
day4.Part2();
Console.WriteLine(day4.ValueStr);