# CS4881 (AI) - Lab 2

Generates a random 8x8 map and attempts to solve it using 4 different methods:
* Hill climbing using number of Misplaced Tiles heuristic
  * Doesn't always converge
* Hill climbing using Manhattan Distance heuristic
  * Doesn't always converge
* A* using number of Misplaced Tiles heuristic
* A* hill climbing using Manhattan Distance heuristic

## Sample Output

```
Solved Hill Climbing misplaced tile in -1 iterations.
Solved Hill Climbing manhattan in -1 iterations.
Solved A* misplaced tile in 6786 iterations.
Solved A* manhattan in 832 iterations.

Solved Hill Climbing misplaced tile in -1 iterations.
Solved Hill Climbing manhattan in 95 iterations.
Solved A* misplaced tile in 6365 iterations.
Solved A* manhattan in 364 iterations.

Solved Hill Climbing misplaced tile in -1 iterations.
Solved Hill Climbing manhattan in -1 iterations.
Solved A* misplaced tile in 16 iterations.
Solved A* manhattan in 10 iterations.

Solved Hill Climbing misplaced tile in -1 iterations.
Solved Hill Climbing manhattan in 293 iterations.
Solved A* misplaced tile in 2401 iterations.
Solved A* manhattan in 179 iterations.
```