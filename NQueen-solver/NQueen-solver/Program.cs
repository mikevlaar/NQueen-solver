using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NQueen_solver
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 9;
            bool[,] board = new bool[N, N];

            NQueenSolver solver = new NQueenSolver(N);

            solver.FindSolution(board, 0);
            solver.printNumberOfSolutions();

            Console.ReadLine();
        }
    }
}
