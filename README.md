Labirint-PCLP

Overview

Labirint-PCLP is a maze-solving project developed for the Procedural Programming course. It features maze generation and solving algorithms, allowing users to visualize the pathfinding process. The project is written in C and demonstrates fundamental programming concepts such as recursion, arrays, and backtracking.

Features

Maze Generation: Creates a randomized maze using algorithmic techniques.

Pathfinding Algorithms: Implements depth-first search (DFS) and breadth-first search (BFS) for maze solving.

Graphical Representation: Displays the maze structure in a user-friendly manner.

User Input Support: Allows customization of maze size and structure.

Getting Started

Prerequisites

Ensure you have the following installed:

GCC Compiler (for compiling C programs)

A terminal or command prompt to execute the program

Installation

Clone the repository:

git clone https://github.com/Radu-24/Labirint-PCLP.git
cd Labirint-PCLP

Compile the program using GCC:

gcc -o labirint main.c maze.c solver.c -Wall

Run the program:

./labirint

Usage

Generate a Maze: The program will prompt for the maze size and generate a random maze.

Solve the Maze: Select a solving algorithm (DFS/BFS) and observe the solution path.

Modify Maze: Input custom obstacles and re-run the solver.

Exit: Close the application or terminate via command line.

File Structure

Labirint-PCLP/
├── main.c          # Main program entry
├── maze.c          # Maze generation logic
├── maze.h          # Header file for maze functions
├── solver.c        # Maze solving algorithms
├── solver.h        # Header file for solver functions
├── README.md       # Project documentation
├── .gitignore      # Git ignore file
└── LICENSE         # License file

Contributing

Contributions are welcome! Please follow these steps:

Fork the repository.

Create a new branch for your feature or fix.

Commit your changes and push to your branch.

Submit a pull request for review.

License

This project is licensed under the MIT License - see the LICENSE file for details.

Acknowledgments

Procedural Programming Lab

Open-source programming resources
