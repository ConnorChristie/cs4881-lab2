namespace Program
{
    public class MisplacedDistance : IHeuristic
    {
        public int Distance(Board board)
        {
            var total = 0;

            for (var i = 0; i < (board.Width * board.Height) - 1; i++)
            {
                var x = i % board.Width;
                var y = (i - x) / board.Width;

                if (board[y, x] != i) total++;
            }

            return total;
        }
    }
}