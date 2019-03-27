using System.Collections.Generic;
using Priority_Queue;

namespace Program
{
    public class HillClimbingSolver : BaseSolver
    {
        private Node _nextNode;

        public HillClimbingSolver(Board finalBoard, IHeuristic heuristic) : base(finalBoard, heuristic)
        {
        }

        protected override bool HasNextNode()
        {
            return _nextNode != null;
        }

        protected override Node NextNode()
        {
            return _nextNode;
        }

        protected override void Expand(Node node)
        {
            var best = new Node(null, int.MaxValue, 0);

            var node1 = AddNode(node, (-1, 0));
            var node2 = AddNode(node, (1, 0));
            var node3 = AddNode(node, (0, -1));
            var node4 = AddNode(node, (0, 1));

            if (node1 != null && node1.H < best.H) best = node1;
            if (node2 != null && node2.H < best.H) best = node2;
            if (node3 != null && node3.H < best.H) best = node3;
            if (node4 != null && node4.H < best.H) best = node4;

            if (best.Board != null)
            {
                _nextNode = best;
            }
            else
            {
                _nextNode = null;
            }
        }

        protected override void AddNode(Node node)
        {
            _nextNode = node;
        }

        private Node AddNode(Node originalNode, (int X, int Y) newPos)
        {
            var board = originalNode.Board.Move(newPos.X, newPos.Y);

            if (board != null && !_explored.Contains(board))
            {
                return new Node(board, _heuristic.Distance(board), originalNode.G + 1);
            }

            return null;
        }
    }
}