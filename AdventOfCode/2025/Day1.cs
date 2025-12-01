using System;

namespace AdventOfCode._2025;

public class Day1
{
    public static byte Part1()
    {
        
    }
}

public class Dial
{
    public Dial(byte maxPosition)
    {
        Position = 0;
        this._maxPosition = maxPosition;
    }

    public byte Position { get; private set; }

    public void TurnRight(byte distance)
    {
        Position = (byte)((Position + distance) % _maxPosition);
    }

    public void TurnLeft(byte distance)
    {
        Position = (byte)((Position - distance + _maxPosition) % _maxPosition);
    }

    private byte _maxPosition { get;  set; }
}
