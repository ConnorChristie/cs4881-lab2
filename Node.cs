using System;

namespace Program
{
    public class Node : IEquatable<Node>
    {
        public Board Board { get; set; }

        public int H { get; set; }

        public int G { get; set; }

        public Node(Board board)
        {
            Board = board;
        }

        public Node(Board board, int h, int g) : this(board)
        {
            H = h;
            G = g;
        }

        public bool Equals(Node other)
        {
            return Board.Equals(other);
        }
    }
}