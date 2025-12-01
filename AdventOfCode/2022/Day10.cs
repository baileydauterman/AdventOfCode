using System;
using AdventOfCode.objects;

namespace AdventOfCode
{
	public class Day10
	{
		public int ParseFile(string path, Queue<int> priorityTicks)
		{
			var cpu = new EmulatedCpu
			{
				PriorityTicks = priorityTicks,
			};

			using (var stream = File.OpenRead(path))
			using (var reader = new StreamReader(stream))
			{
				while (!reader.EndOfStream)
				{
					var op = reader.ReadLine()?.Trim().Split(" ");

					if (op is null)
					{
						continue;
					}

					cpu.ProcessOperation(op);
				}
			}

			return cpu.Ticks.Sum();
		}
	}
}

