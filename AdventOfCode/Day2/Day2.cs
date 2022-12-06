using static AdventOfCode.Day2;

namespace AdventOfCode
{
    internal class Day2
    {
        public enum Moves
        {
            None = 0,
            Rock = 1,
            Paper = 2, 
            Scissors = 3,
        }

        public enum Results
        {
            Lose = 0,
            Draw = 3,
            Win = 6
        }

        public class Round
        {
            public Moves FirstMove { get; set; }

            public Moves SecondMove { get; set; }

            public Results Results { get; set; }

            public int Score { get; set; }
        }

        public static List<Round> ReadFile(string path)
        {
            var game = new List<Round>();
            using (var stream = File.OpenRead(path))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    var roundMoves = reader.ReadLine().Split(" ").ToArray();

                    var round = new Round
                    {
                        FirstMove = GetMoves(roundMoves[0]),
                        SecondMove = GetMoves(roundMoves[1]),
                    };

                    round.Results = GetResults(round);
                    round.Score = (int)round.SecondMove + (int)round.Results;

                    game.Add(round);
                }
            }

            return game;
        }

        public static List<Round> ReadFileCorrectly(string path)
        {
            var game = new List<Round>();

            using (var stream = File.OpenRead(path))
            using (var reader = new StreamReader(stream))
            {
                while (!reader.EndOfStream)
                {
                    var roundMoves = reader.ReadLine().Split(" ").ToArray();

                    var round = new Round
                    {
                        FirstMove = GetMoves(roundMoves[0]),
                        Results = GetResult(roundMoves[1]),
                    };

                    round.SecondMove = GetResults(round, true);
                    round.Score = (int)round.SecondMove + (int)round.Results;

                    game.Add(round);
                }
            }

            return game;
        }

        private static Moves GetMoves(string move)
        {
            switch (move)
            {
                case "A":
                case "X":
                    return Moves.Rock;

                case "B":
                case "Y":
                    return Moves.Paper;

                case "C":
                case "Z":
                    return Moves.Scissors;

                default:
                    throw new ArgumentOutOfRangeException(nameof(move));
            }
        }

        private static Results GetResult(string outcome)
        {
            return outcome switch
            {
                "X" => Results.Lose,
                "Y" => Results.Draw,
                "Z" => Results.Win,
                _ => throw new ArgumentOutOfRangeException(nameof(outcome)),
            };
        }

        private static Moves GetResults(Round round, bool newFields = true)
        {
            switch (round.FirstMove)
            {
                case Moves.Rock:
                    return round.Results switch
                    {
                        Results.Lose => Moves.Scissors,
                        Results.Draw => Moves.Rock,
                        Results.Win => Moves.Paper,
                    };
                case Moves.Paper:
                    return round.Results switch
                    {
                        Results.Lose => Moves.Rock,
                        Results.Draw => Moves.Paper,
                        Results.Win => Moves.Scissors,
                    };
                case Moves.Scissors:
                    return round.Results switch
                    {
                        Results.Lose => Moves.Paper,
                        Results.Draw => Moves.Scissors,
                        Results.Win => Moves.Rock,
                    };
                default:
                    throw new ArgumentOutOfRangeException(nameof(round.FirstMove));
            }
        }

        private static Results GetResults(Round round)
        {
            switch (round.SecondMove)
            {
                case Moves.Rock:
                    return round.FirstMove switch
                    {
                        Moves.Scissors => Results.Win,
                        Moves.Rock => Results.Draw,
                        Moves.Paper => Results.Lose,
                    };

                case Moves.Paper:
                    return round.FirstMove switch
                    {
                        Moves.Rock => Results.Win,
                        Moves.Paper => Results.Draw,
                        Moves.Scissors => Results.Lose,
                    };

                case Moves.Scissors:
                    return round.FirstMove switch
                    {
                        Moves.Paper => Results.Win,
                        Moves.Scissors => Results.Draw,
                        Moves.Rock => Results.Lose,
                    };

                default:
                    throw new ArgumentOutOfRangeException(nameof(round.SecondMove));
            }
        }

        public static int Round1()
        {

            return 0;
        }
    }
}
