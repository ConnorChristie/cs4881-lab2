using System;

namespace Program
{
    public class ManhattanDistance : IHeuristic
    {
        public int Distance(Board board)
        {
            var total = 0;

            // Right now, this only checks the distance to the following final state:
            //   0 1 2
            //   3 4 5
            //   6 7 8
            for (var x = 0; x < board.Width; x++)
            {
                for (var y = 0; y < board.Height; y++)
                {
                    if (board[y, x] == 0) continue;

                    var idealX = board[y, x] % board.Width;
                    var idealY = (board[y, x] - x) / board.Width;

                    total += Math.Abs(x - idealX) + Math.Abs(y - idealY);
                }
            }

            return total;
        }
    }
}