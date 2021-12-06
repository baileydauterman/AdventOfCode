// See https://aka.ms/new-console-template for more information
using AdventOfCode;

Console.WriteLine("########### Day 1 ##############");
Console.WriteLine($"Increases (1.1):\t{Day1.SonarSweepPart1()}");
Console.WriteLine($"Increases (1.2):\t{Day1.SonarSweepPart2()}");
Console.WriteLine();


Console.WriteLine("########### Day 2 ##############");
var outp = Day2.DivePart1();
var answer = outp[0] * outp[1];
Console.WriteLine($"Increases (2.1):\t{answer}([ {outp[0]}, {outp[1]} ])");
outp = Day2.DivePart2();
answer = outp[0] * outp[1];
Console.WriteLine($"Increases (2.1):\t{answer}([ {outp[0]}, {outp[1]}, {outp[2]} ])");
Console.WriteLine();


Console.WriteLine("########### Day 3 ##############");
var day3 = Day3.BinaryDiagnosticPart1();
Console.WriteLine($"Increases (2.1): ([ {day3[0]}, {day3[1]} ])");
var day31 = Day3.BinaryDiagnosticPart2();
Console.WriteLine($"Increases (2.1): {day31[0] * day31[1]} ([ {day31[0]}, {day31[1]} ])");
Console.WriteLine();