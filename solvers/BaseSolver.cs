using System;
using System.Collections.Generic;
using Priority_Queue;

namespace Program
{
    public abstract class BaseSolver
    {
        private readonly Board _finalBoard;

        protected readonly IHeuristic _heuristic;

        protected readonly IList<Board> _explored = new List<Board>();

        public BaseSolver(Board finalBoard, IHeuristic heuristic)
        {
            _finalBoard = finalBoard;
            _heuristic = heuristic;
        }

        public int Solve(Board initialBoard)
        {
            var depth = 0;

            AddNode(new Node(initialBoard));

            while (HasNextNode())
            {
                var node = NextNode();

                // Console.WriteLine($"The best state to expand with a g(n) = {node.G} and h(n) = {node.H} is…");
                // Console.WriteLine(node.Board.ToString());

                if (node.Board.Equals(_finalBoard))
                {
                    return depth;
                }

                _explored.Add(node.Board);

                Expand(node);

                depth++;
            }

            return -1;
        }

        protected abstract bool HasNextNode();

        protected abstract Node NextNode();

        protected abstract void AddNode(Node node);

        protected abstract void Expand(Node node);
    }
}