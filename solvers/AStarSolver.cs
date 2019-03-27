using System.Collections.Generic;
using Priority_Queue;

namespace Program
{
    public class AStarSolver : BaseSolver
    {
        private readonly IPriorityQueue<Node, int> _nodes = new SimplePriorityQueue<Node, int>();

        public AStarSolver(Board finalBoard, IHeuristic heuristic) : base(finalBoard, heuristic)
        {
        }

        protected override bool HasNextNode()
        {
            return _nodes.Count > 0;
        }

        protected override Node NextNode()
        {
            return _nodes.Dequeue();
        }

        protected override void Expand(Node node)
        {
            AddNode(node, (-1, 0));
            AddNode(node, (1, 0));
            AddNode(node, (0, -1));
            AddNode(node, (0, 1));
        }

        protected override void AddNode(Node originalNode)
        {
            _nodes.Enqueue(originalNode, 0);
        }

        private void AddNode(Node originalNode, (int X, int Y) newPos)
        {
            var board = originalNode.Board.Move(newPos.X, newPos.Y);

            if (board != null && !_explored.Contains(board))
            {
                var newNode = new Node(board, _heuristic.Distance(board), originalNode.G + 1);
                _nodes.Enqueue(newNode, newNode.H + newNode.G);
            }
        }
    }
}