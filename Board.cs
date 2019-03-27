using System;
using System.Linq;
using System.Text;

namespace Program
{
    public class Board : ICloneable, IEquatable<Board>
    {
        private readonly int[,] _matrix;
        private (int X, int Y) _zeroPos;

        public int this[int x, int y]
        {
            get => _matrix[x, y];
            set => _matrix[x, y] = value;
        }

        public int Width => _matrix.GetLength(0);

        public int Height => _matrix.GetLength(1);

        public Board(int[,] matrix, (int, int) zeroPos)
        {
            _matrix = matrix;
            _zeroPos = zeroPos;
        }

        public Board Move(int x, int y)
        {
            var newX = _zeroPos.X + x;
            var newY = _zeroPos.Y + y;

            if (newX >= 0 && newX < Width && newY >= 0 && newY < Height)
            {
                var clone = Clone() as Board;
                var temp = clone[_zeroPos.Y, _zeroPos.X];

                // Swap the zero with the position it's being moved to
                clone[_zeroPos.Y, _zeroPos.X] = clone[newY, newX];
                clone[newY, newX] = temp;
                clone._zeroPos = (newX, newY);

                return clone;
            }

            return null;
        }

        public (int, int) IndexOfZero()
        {
            return _zeroPos;
        }

        public bool Equals(Board other)
        {
            return _matrix.Cast<int>().SequenceEqual(other._matrix.Cast<int>());
        }

        public object Clone()
        {
            var newMatrix = new int[Height, Width];

            for (var y = 0; y < Height; y++)
            {
                for (var x = 0; x < Width; x++)
                {
                    newMatrix[y, x] = _matrix[y, x];
                }
            }

            return new Board(newMatrix, _zeroPos);
        }

        public override string ToString()
        {
            var str = new StringBuilder();

            for (var y = 0; y < Height; y++)
            {
                for (var x = 0; x < Width; x++)
                {
                    str.Append(_matrix[y, x] + " ");
                }

                str.Append("\n");
            }

            return str.ToString();
        }
    }
}