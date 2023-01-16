using System;
namespace AdventOfCode.objects
{
	public class EmulatedCpu
	{
		public Queue<int> PriorityTicks { get; set; } = new Queue<int>();

		public int Register = 1;

		public int Cycles = 0;

		public List<int> Ticks = new List<int>();

		public void ProcessOperation(string[] op)
		{
			var tickCheck = PriorityTicks.Any() ?
                PriorityTicks.Peek() : 0;

			switch (op[0])
			{
                // add tick and move on
                case "noop":
                    ProcessCycle(tickCheck);
                    break;
                // adds two ticks and changes the Register
                case "addx":
                    var endCycle = Cycles + 2;

                    while (Cycles < endCycle)
                    {
                        ProcessCycle(tickCheck);
                    }

                    Register += int.Parse(op[1]);
					break;
			}
		}

        private void ProcessCycle(int tickCheck)
        {
            Cycles++;

            if (Cycles == tickCheck)
            {
                Ticks.Add(Register * Cycles);
                PriorityTicks.Dequeue();
            }

        }
    }
}

