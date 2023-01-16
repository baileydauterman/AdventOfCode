using System;

namespace AdventOfCode.objects
{
    public class Coordinate
    {
        public int x { get; set; } = 0;
        public int y { get; set; } = 0;
        public (int X, int Y) PreviousLocation { get; set; }

        public bool Equals(Coordinate comp)
        {
            return this.x == comp.x && this.y == comp.y;
        }

        public bool Equals(int x, int y)
        {
            return this.x == x && this.y == y;
        }

        public override int GetHashCode()
        {
            return 31 * x + 19 * y;
        }

        public override string ToString()
        {
            return $"{this.x}, {this.y}";
        }

        public void Move(Direction direction)
        {
            this.PreviousLocation = (this.x, this.y);

            switch (direction)
            {
                case Direction.Up:
                    this.x++;
                    break;
                case Direction.Down:
                    this.x--;
                    break;
                case Direction.Left:
                    this.y--;
                    break;
                case Direction.Right:
                    this.y++;
                    break;
            }
        }

        public Coordinate CheckTouching(Coordinate comp)
        {
            if (this.Equals(comp))
            {
                return comp;
            }

            // Check if tail is in any of the possible 8 surrounds locations.
            // If it isn't an exact match see if this is the closest position to
            // head
            var surrounding = this.GetSurrounding();
            if (surrounding.Where(val => val.Equals(comp)).Any())
            {
                return comp;
            }

            // If they aren't touching, return the last spot of the head
            return new Coordinate
            {
                x = this.PreviousLocation.X,
                y = this.PreviousLocation.Y,
            };
        }

        public List<Coordinate> GetSurrounding()
        {
            var surrounds = new List<Coordinate>
            {
                new Coordinate { x = this.x + 1, y = this.y },
                new Coordinate { x = this.x - 1, y = this.y },
                new Coordinate { x = this.x, y = this.y + 1 },
                new Coordinate { x = this.x, y = this.y - 1 },
                new Coordinate { x = this.x + 1, y = this.y - 1 },
                new Coordinate { x = this.x + 1, y = this.y + 1 },
                new Coordinate { x = this.x -1, y = this.y - 1 },
                new Coordinate { x = this.x - 1, y = this.y + 1},
            };

            return surrounds.Where(val => val.x > -1 && val.y > -1).ToList();
        }

        public int GetDistance(Coordinate comp)
        {
            return Math.Abs((comp.x - this.x) + (comp.y - this.y));
        }
    }
}

