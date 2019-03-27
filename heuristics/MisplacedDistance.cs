namespace Program
{
    public class MisplacedDistance : IHeuristic
    {
        public int Distance(Board board)
        {
            var total = 0;

            // Right now, this only checks the distance to the following final state:
            //   0 1 2
            //   3 4 5
            //   6 7 8
            for (var i = 0; i < board.Width * board.Height; i++)
            {
                var x = i % board.Width;
                var y = (i - x) / board.Width;

                if (board[y, x] != i) total++;
            }

            return total;
        }
    }
}