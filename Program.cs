using System;
using System.Collections.Generic;

namespace Program
{
    class Program
    {
        private static readonly Board _finalBoard = new Board(new [,]
            {
                { 0, 1, 2 },
                { 3, 4, 5 },
                { 6, 7, 8 }
            },
            (0, 0)
        );

        static void Main(string[] args)
        {
            for (var i = 0; i < 10; i++)
            {
                var solverASMan = new AStarSolver(_finalBoard, new ManhattanDistance());
                var solverHCMan = new HillClimbingSolver(_finalBoard, new ManhattanDistance());
                var solverASMis = new AStarSolver(_finalBoard, new MisplacedDistance());
                var solverHCMis = new HillClimbingSolver(_finalBoard, new MisplacedDistance());

                var board = GenerateRandomBoard();

                var depthASMan = solverASMan.Solve(board);
                var depthHCMan = solverHCMan.Solve(board);
                var depthASMis = solverASMis.Solve(board);
                var depthHCMis = solverHCMis.Solve(board);

                Console.WriteLine($"Solved Hill Climbing misplaced tile in {depthHCMis} iterations.");
                Console.WriteLine($"Solved Hill Climbing manhattan in {depthHCMan} iterations.");
                Console.WriteLine($"Solved A* misplaced tile in {depthASMis} iterations.");
                Console.WriteLine($"Solved A* manhattan in {depthASMan} iterations.");
                Console.WriteLine();
            }
        }

        static Board GenerateRandomBoard()
        {
            var random = new Random();
            var iterations = random.Next(200);
            var board = _finalBoard;

            for (var i = 0; i < iterations; i++)
            {
                switch (random.Next(4))
                {
                    case 0:
                        board = board.Move(-1, 0) ?? board;
                        break;
                    case 1:
                        board = board.Move(1, 0) ?? board;
                        break;
                    case 2:
                        board = board.Move(0, -1) ?? board;
                        break;
                    case 3:
                        board = board.Move(0, 1) ?? board;
                        break;
                }
            }

            return board;
        }
    }
}
