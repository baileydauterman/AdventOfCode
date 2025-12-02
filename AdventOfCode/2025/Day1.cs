using System;

namespace AdventOfCode._2025;

public class Day1
{
    public static Dial Part1(Stream stream)
    {
        var dial = new Dial(50);
        using var reader = new StreamReader(stream);

        var line = reader.ReadLine();
        while (line != null)
        {
            var firstChar = line[0];
            var distance = int.Parse(line[1..]);
            dial.Turn(firstChar, distance);

            line = reader.ReadLine();
        }

        return dial;
    }
}

public class Dial
{
    public Dial(int startingPosition, int maxPosition = 99, int minPosition = 0)
    {
        Position = startingPosition;
        this._maxPosition = maxPosition;
        this._minPosition = minPosition;
    }

    public int Position { get; private set; }

    public int Password1 { get; private set;}

    public int Password2 { get; private set;}

    public void Turn(char direction, int offset)
    {
        switch (direction)
        {
            case 'R':
                TurnRight(offset);
                break;

            case 'L':
                TurnLeft(offset);
                break;

            default:
                throw new ArgumentException("Invalid direction");
        }

        if (Position == 0)
        {
            Password1++;
        }
    }

    public void TurnRight(int distance)
    {
        while (distance-- > 0)
        {
            Position++;

            if (Position > _maxPosition)
            {
                Position = _minPosition;
            }

            if (Position == 0)
            {
                Password2++;
            }
        }
    }

    public void TurnLeft(int distance)
    {
        while (distance-- > 0)
        {
            Position--;

            if (Position < _minPosition)
            {
                Position = _maxPosition;
            }

            if (Position == 0)
            {
                Password2++;
            }
        }
    }

    private int _maxPosition { get;  set; }

    private int _minPosition { get;  set; }
}
