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
Solved A* manhattan in 271 iterations.
Solved Hill Climbing manhattan in 312 iterations.
Solved A* misplaced tile in 484 iterations.
Solved Hill Climbing misplaced tile in -1 iterations.

Solved A* manhattan in 119 iterations.
Solved Hill Climbing manhattan in 152 iterations.
Solved A* misplaced tile in 5244 iterations.
Solved Hill Climbing misplaced tile in -1 iterations.

Solved A* manhattan in 2 iterations.
Solved Hill Climbing manhattan in 2 iterations.
Solved A* misplaced tile in 2 iterations.
Solved Hill Climbing misplaced tile in 2 iterations.
```