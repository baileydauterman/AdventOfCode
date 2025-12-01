using System;
using AdventOfCode.objects;

namespace AdventOfCode
{
	public class Day9
	{
        public int ParseFile(string path)
        {
            var moves = new List<Move>();

            using (var stream = File.OpenRead(path))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine()?.Trim().Split(" ", 2);
                    var direction = GetDirection(line[0]);

                    moves.Add(new Move
                    {
                        Direction = GetDirection(line[0]),
                        Number = int.Parse(line[1])
                    });
                }
            }

            return RunGame(moves);
        }

        private int RunGame(List<Move> moves)
        {
            var head = new Coordinate();
            var tail = new Coordinate();
            var uniqueMoves = new HashSet<Coordinate>();

            foreach (var move in moves)
            {
                for (int i = 0; i < move.Number; i++)
                {
                    head.Move(move.Direction);
                    tail = head.CheckTouching(tail);

                    // WriteBoard(head, tail);

                    if (!tail.Equals(_startPosition))
                    {
                        uniqueMoves.Add(tail);
                    }
                }
            }

            return uniqueMoves.Count;
        }

        private void WriteBoard(Coordinate head, Coordinate tail)
        {
            Console.Clear();

            for (var row = 5; row > -1; row--)
            {
                for (var col = 0; col < 6; col++)
                {
                    if (head.Equals(row, col))
                    {
                        Console.Write(" H ");
                    }
                    else if (tail.Equals(row, col))
                    {
                        Console.Write(" T ");
                    }
                    else if (_startPosition.Equals(row, col))
                    {
                        Console.Write(" s ");
                    }
                    else
                    {
                        Console.Write(" . ");
                    }
                }
                Console.Write("\n");
            }
        }

        private Direction GetDirection(string dirStr)
        {
            switch (dirStr.ToLower())
            {
                case "u":
                    return Direction.Up;
                case "d":
                    return Direction.Down;
                case "r":
                    return Direction.Right;
                case "l":
                    return Direction.Left;
                default:
                    throw new ArgumentOutOfRangeException(nameof(dirStr));
            }
        }

        private readonly Coordinate _startPosition = new() { x = 0, y = 0 };
    }
}

