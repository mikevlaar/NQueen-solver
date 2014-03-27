using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueen_solver
{
    class NQueenSolver
    {
        int N;
        int numberOfSolutions = 0;

        public NQueenSolver(int numberOfQueens)
        {
            N = numberOfQueens;
        }

        /**
         * Print the number of solutions found. 
         */
        public void printNumberOfSolutions()
        {
            Console.WriteLine(numberOfSolutions);
        }

        /**
        * Check if queen is allowed on position.
        * @param bool[,] board The current board to check a position on.
        * @param int x The current row to check if a queen can be placed.
        * @param int y The current column to check if a queen can be placed.
        */
        public bool Allowed(bool[,] board, int x, int y)
        {
            for (int i = 0; i <= x; i++)
            {
                if (board[i, y] || (i <= y && board[x - i, y - i]) || (y + i < N && board[x - i, y + i]))
                {
                    return false;
                }
            }
            return true;
        }

        /**
         * Finds a solution for the n-queen problem. 
         * Recursive method that prints all the solutions.
         * @param bool[,] board The current board to find a solution for.
         * @param int x The current row to check if a queen can be placed.
         */
        public void FindSolution(bool[,] board, int x)
        {
            if (x == N)
            {
                numberOfSolutions++;
                printSolution(board);
                return;
            }

            for (int y = 0; y < N; y++)
            {
                if (Allowed(board, x, y))
                {
                    board[x, y] = true;
                    FindSolution(board, x + 1);
                    board[x, y] = false;
                }
            }
        }

        /**
         * Method to print a solution.
         * @param bool[,] board the board that needs to be printed.
         */
        public void printSolution(bool[,] board)
        {
            Console.WriteLine("solution number: {0}", numberOfSolutions); 
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    Console.Write(board[i, j] ? "|Q" : "| ");
                }
                Console.WriteLine("|");
            }
            Console.WriteLine();
        }
    }
}
