// See https://aka.ms/new-console-template for more information
using AdventOfCode;

Console.WriteLine("########### Day 1 ##############");
Console.WriteLine("Increases (1.1): " + Day1.ParseDataPart1());
Console.WriteLine("Increases (1.2): " + Day1.ParseDataPart2());
Console.WriteLine();


Console.WriteLine("########### Day 2 ##############");
var outp = Day2.ParseDataPart1();
var answer = outp[0] * outp[1];
Console.WriteLine("Increases (2.1): " + answer + "( [" + outp[0] + ", " + outp[1] + "] )");
outp = Day2.ParseDataPart2();
answer = outp[0] * outp[1];
Console.WriteLine("Increases (1.2): " + answer + "( [" + outp[0] + ", " + outp[1] + ", " + outp[2] + "] )");
Console.WriteLine();